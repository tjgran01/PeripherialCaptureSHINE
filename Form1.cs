using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PeripherialCaptureSHINE
{
    public partial class Form1 : Form
    {
        string formName = "Shine Sensor Capture Application";
        string button1Text = "Begin Recording";
        string button2Text = "End Recording";
        string checkBoxInstrText = "Please select the streams you wish to to capture from the list below. \n Once you are satisfied with your selections, \n press the \"Begin Recording.\" button to start recording.";

        string shimmerCheckLabelText = "SHIMMER GSR";
        string tobiiCheckLabelText = "Tobii 4C Eyetracker";
        string screenCaptureLabelText = "Screen Recording";
        string audioOutLabelText = "Audio Output Recording";

        bool isShimmer;
        bool isTobii;
        bool isScreenRecording;
        bool isAudioOutRecording;

        string defaultID = "0000";
        string idLabelText = "Please Enter The Participant's ID Number: ";

        string rootFolderLabelText = "Select a Root Folder";
        string rootFolderButtonText = "Select Root Folder";


        List<string> recordingList = new List<string>();
        RecordingManager _mRecordingMan;

        public Form1()
        {
            InitializeComponent();
            SetFormDefaults();
        }

        private void SetFormDefaults()
        {
            this.Text = this.formName;
            this.beginRecordingButton.Text = button1Text;
            this.endRecordingButton.Text = button2Text;
            this.sensorStreamInstructions.Text = checkBoxInstrText;

            // Set checkbox Text: ""

            this.shimmerCheckBox.Text = "";
            this.tobiiCheckBox.Text = "";
            this.screenRecordCheckBox.Text = "";
            this.audioRecordCheckbox.Text = "";

            this.shimmerCheckLabel.Text = shimmerCheckLabelText;
            this.tobiiCheckLabel.Text = tobiiCheckLabelText;
            this.screenRecordingCheckLabel.Text = screenCaptureLabelText;
            this.audioOutputRecordingCheckLabel.Text = audioOutLabelText;

            // Subject ID

            this.subjectIdEntry.Text = defaultID;
            this.subjectIdLabel.Text = idLabelText;

            // Folder Stuff

            this.rootFolderLabel.Text = rootFolderLabelText;
            this.fileBroswerButton.Text = rootFolderButtonText;
            this.pathTextBox.Text = @"C:";
        }

        private void beginRecordingButton_Click(object sender, EventArgs e)
        {
            _mRecordingMan = new RecordingManager(recordingList, subjectIdEntry.Text, pathTextBox.Text);
            _mRecordingMan.StartStreams();
        }

        private void endRecordingButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void UpdateRecordingList(bool sensorVal, string sensor)
        {
            if (sensorVal)
            {
                recordingList.Add(sensor);
            }
            else
            {
                recordingList.Remove(sensor);
            }
        }


        // These don't matter.

        private void sensorStreamInstructions_Click(object sender, EventArgs e)
        {

        }

        private void shimmerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.isShimmer = this.shimmerCheckBox.Checked;
            UpdateRecordingList(isShimmer, "SHIMMER");
        }

        private void tobiiCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.isTobii = this.tobiiCheckBox.Checked;
            UpdateRecordingList(isTobii, "Tobii");
        }

        private void screenRecordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.isScreenRecording = this.screenRecordCheckBox.Checked;
            UpdateRecordingList(isScreenRecording, "Screen Capture");
        }

        private void audioRecordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.isAudioOutRecording = this.audioRecordCheckbox.Checked;
            UpdateRecordingList(isAudioOutRecording, "Audio Output");
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            string folderpath = folderBrowserDialog1.RootFolder.ToString();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dr = fbd.ShowDialog();
        }

        private void fileBroswerButton_Click(object sender, EventArgs e)
        {
            string folderpath = folderBrowserDialog1.RootFolder.ToString();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dr = fbd.ShowDialog();
            if (dr.ToString() == "OK")
            {
                this.pathTextBox.Text = fbd.SelectedPath;
            }
        }
    }
}
