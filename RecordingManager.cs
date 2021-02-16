using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;


namespace PeripherialCaptureSHINE
{
    class RecordingManager
    {
        List<string> validSensorsStrams = new List<string>() { "Tobii", "SHIMMER", "Screen Capture", "Audio Output" };
        List<string> sensorsToRemove = new List<string>();
        List<string> _mRecordingStreams = new List<string>();

        public RecordingManager(List<string> recordingStrings, string parID, string rootFPath)
        {
            var setSuccess = SetRecordingStreams(recordingStrings);
            if (setSuccess)
            {
                CreateRecordingFolder(parID, rootFPath);
            }
        }

        private bool SetRecordingStreams(List<string> recordingStrings)
        {
            foreach (string s in recordingStrings)
            {
                if (!validSensorsStrams.Contains(s))
                {
                    Console.WriteLine("UNKNOWN SENSOR BEING PASSED TO RECORDING MANAGER: " + s);
                    var msgResponse = MessageBox.Show("INVALID SENSOR STREAM : " + s + " is being sent to recording manager. This stream will be removed before recording!!!", "STREAM ERROR.", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (msgResponse.ToString() == "Cancel")
                    {
                        return false;
                    }
                    sensorsToRemove.Add(s);
                }
            }

            if (sensorsToRemove.Count() > 0)
            {
                foreach (string s in sensorsToRemove)
                {
                    recordingStrings.Remove(s);
                }
            }

            this._mRecordingStreams = recordingStrings;
            return true;
        }

        private void CreateRecordingFolder(string parID, string rootFPath)
        {
            bool idValid = ValidateParameter("ID", parID);
            bool pathValid = ValidateParameter("root", rootFPath);

            if (idValid && pathValid)
            {
                if (_mRecordingStreams.Count > 0)
                {
                    DateTime rightNow = DateTime.Now;
                    string fpath =  rootFPath + "\\" + parID + "\\" +(rightNow.ToString()).Replace('/', '-').Replace(' ', '_').Replace(":", "-") + "\\";
                    Console.WriteLine(fpath);

                    foreach (string subdir in _mRecordingStreams)
                    {
                        Directory.CreateDirectory(@"" + fpath + "\\" + subdir);
                    }
                }
                else
                {
                    MessageBox.Show("Uhm... You haven't selected any valid streams to record, mon ami.", "No Streams Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private bool ValidateParameter(string parameterString, string parameter)
        {
            if (parameterString == "ID")
            {
                if (parameter != "0000")
                {
                    Console.WriteLine("All Good --- Participant ID " + parameter +  " is valid.");
                    return true;
                }
                else
                {
                    MessageBox.Show("Please enter a participant ID!", "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (parameterString == "root")
            {
                if (Directory.Exists(parameter))
                {
                    Console.WriteLine("All Good --- Directory: " + parameter + " Exists.");
                    return true;
                }
                else
                {
                    MessageBox.Show("Please enter a Valid Root Directory!", "Root Directory Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return false;
            }
           
        }
    }
}
