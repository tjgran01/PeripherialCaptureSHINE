using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace PeripherialCaptureSHINE
{
    class RecordingDataValidator
    {
        List<string> recordingStrings;
        string parID;
        string rootFPath;

        List<string> validSensorsStrams = new List<string>() { "Tobii", "SHIMMER", "Screen Capture", "Audio Output" };
        List<string> sensorsToRemove = new List<string>();


        public RecordingDataValidator(List<string> recordingStrings, string parID, string rootFPath)
        {
            this.recordingStrings = recordingStrings;
            this.parID = parID;
            this.rootFPath = rootFPath;
        }


        public void RemoveDataReferences()
        {
            this.recordingStrings = null;
            this.parID = null;
            this.rootFPath = null;
        }


        public List<string> GetValidRecordingStrings()
        {
            return this.recordingStrings;
        }


        public bool CheckValidInputs()
        {
            bool streamRes = CheckValidStreams();
            bool idRes = ValidateParameter("ID", this.parID);
            bool dirRes = ValidateParameter("root", this.rootFPath);

            if (streamRes && idRes && dirRes) return true; else return false;
        }


        private bool CheckValidStreams()
        {
            Console.WriteLine("RECORDING STRINGS: " + recordingStrings);
            foreach (string s in recordingStrings)
            {
                Console.WriteLine(s);
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
                if (recordingStrings.Count() <= 0)
                {
                    MessageBox.Show("Uhm... You haven't selected any valid streams to record, mon ami.", "No Streams Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private bool ValidateParameter(string parameterString, string parameter)
        {
            if (parameterString == "ID")
            {
                if (parameter != "0000")
                {
                    Console.WriteLine("All Good --- Participant ID " + parameter + " is valid.");
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
