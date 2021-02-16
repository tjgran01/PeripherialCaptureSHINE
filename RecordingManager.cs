using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;


namespace PeripherialCaptureSHINE
{
    class RecordingManager
    {
        string parID;
        RecordingDataValidator theValidator;
        List<string> _mRecordingStreams = new List<string>();
        Dictionary<string, string> recordingFPaths;

        StreamFactory streamFactory = new StreamFactory();
        Dictionary<string, SensorStream> _mStreams = new Dictionary<string, SensorStream>();

        public RecordingManager(List<string> recordingStrings, string parID, string rootFPath)
        {
            theValidator = new RecordingDataValidator(recordingStrings, parID, rootFPath);

            // Create Recording Folders and And Set File names.
            if (theValidator.CheckValidInputs()) // Once it checks --- it prunes invalid sensors.
            {
                SetParID(parID);
                SetRecordingStreams(recordingStrings); // So this check should always be up to date.
                var dirDict = CreateRecordingFolder(parID, rootFPath);
                SetRecordingFPaths(dirDict);
            }
        }

        #region Setters.        
        private void SetRecordingStreams(List<string> recordingStrings)
        {
            this._mRecordingStreams = theValidator.GetValidRecordingStrings();
        }


        private void SetParID(string id)
        {
            this.parID = id;
        }

        private void SetRecordingFPaths(Dictionary<string, string> dirDict)
        {
            Dictionary<string, string> fileDict = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> entry in dirDict)
            {
                Console.WriteLine(entry.Key);
                Console.WriteLine(entry.Value);

                fileDict[entry.Key] = entry.Value + "\\" + parID + "_" + entry.Key;
            }

            this.recordingFPaths = fileDict;
        }
        #endregion

        #region Getters
        private string GetSensorFPath(string key)
        {
            return this.recordingFPaths[key];
        }
        #endregion


        private Dictionary<string, string> CreateRecordingFolder(string parID, string rootFPath)
        {
            DateTime rightNow = DateTime.Now;
            string fpath = rootFPath + "\\" + parID + "\\" + (rightNow.ToString()).Replace('/', '-').Replace(' ', '_').Replace(":", "-") + "\\";
            Console.WriteLine(fpath);

            Dictionary<string, string> dirDict = new Dictionary<string, string>();
            foreach (string subdir in _mRecordingStreams)
            {
                Directory.CreateDirectory(@"" + fpath + "\\" + subdir);
                dirDict[subdir] = @"" + fpath + "\\" + subdir;
            }

            return dirDict;
        }

        public void StartStreams()
        {
            foreach (KeyValuePair<string, string> entry in recordingFPaths)
            {
                SensorStream mStream = streamFactory.GetStreamOfType(entry.Key);
                mStream.CreateFile(entry.Value);
                Thread sensorThread = new Thread(() => mStream.StartStream());
                sensorThread.IsBackground = true;
                sensorThread.Start();
                _mStreams.Add(entry.Key, mStream);
            }
        }
        
    }
}
