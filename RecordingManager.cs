using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace PeripherialCaptureSHINE
{
    class RecordingManager
    {
        List<string> validSensorsStrams = new List<string>() { "Tobii", "SHIMMER", "Screen Capture", "Audio Output" };
        List<string> sensorsToRemove = new List<string>();
        List<string> _mRecordingStreams = new List<string>();

        public RecordingManager(List<string> recordingStrings)
        {
            var setSuccess = SetRecordingStreams(recordingStrings);
            if (setSuccess)
            {
                CreateRecordingFolder();
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

        private void CreateRecordingFolder()
        {
            DateTime rightNow = DateTime.Now;
        }
    }
}
