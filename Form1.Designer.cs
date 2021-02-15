namespace PeripherialCaptureSHINE
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.sensorStreamInstructions = new System.Windows.Forms.Label();
            this.beginRecordingButton = new System.Windows.Forms.Button();
            this.endRecordingButton = new System.Windows.Forms.Button();
            this.shimmerCheckLabel = new System.Windows.Forms.Label();
            this.tobiiCheckLabel = new System.Windows.Forms.Label();
            this.screenRecordingCheckLabel = new System.Windows.Forms.Label();
            this.audioOutputRecordingCheckLabel = new System.Windows.Forms.Label();
            this.shimmerCheckBox = new System.Windows.Forms.CheckBox();
            this.tobiiCheckBox = new System.Windows.Forms.CheckBox();
            this.screenRecordCheckBox = new System.Windows.Forms.CheckBox();
            this.audioRecordCheckbox = new System.Windows.Forms.CheckBox();
            this.subjectIdEntry = new System.Windows.Forms.TextBox();
            this.subjectIdLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.rootFolderLabel = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.fileBroswerButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.audioRecordCheckbox);
            this.panel1.Controls.Add(this.screenRecordCheckBox);
            this.panel1.Controls.Add(this.tobiiCheckBox);
            this.panel1.Controls.Add(this.shimmerCheckBox);
            this.panel1.Controls.Add(this.audioOutputRecordingCheckLabel);
            this.panel1.Controls.Add(this.screenRecordingCheckLabel);
            this.panel1.Controls.Add(this.tobiiCheckLabel);
            this.panel1.Controls.Add(this.shimmerCheckLabel);
            this.panel1.Controls.Add(this.sensorStreamInstructions);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 699);
            this.panel1.TabIndex = 0;
            // 
            // sensorStreamInstructions
            // 
            this.sensorStreamInstructions.AutoSize = true;
            this.sensorStreamInstructions.Location = new System.Drawing.Point(3, 9);
            this.sensorStreamInstructions.Name = "sensorStreamInstructions";
            this.sensorStreamInstructions.Size = new System.Drawing.Size(51, 20);
            this.sensorStreamInstructions.TabIndex = 0;
            this.sensorStreamInstructions.Text = "label1";
            this.sensorStreamInstructions.Click += new System.EventHandler(this.sensorStreamInstructions_Click);
            // 
            // beginRecordingButton
            // 
            this.beginRecordingButton.BackColor = System.Drawing.Color.SeaGreen;
            this.beginRecordingButton.Location = new System.Drawing.Point(1173, 523);
            this.beginRecordingButton.Name = "beginRecordingButton";
            this.beginRecordingButton.Size = new System.Drawing.Size(178, 71);
            this.beginRecordingButton.TabIndex = 0;
            this.beginRecordingButton.Text = "button1";
            this.beginRecordingButton.UseVisualStyleBackColor = false;
            this.beginRecordingButton.Click += new System.EventHandler(this.beginRecordingButton_Click);
            // 
            // endRecordingButton
            // 
            this.endRecordingButton.BackColor = System.Drawing.Color.IndianRed;
            this.endRecordingButton.Location = new System.Drawing.Point(1173, 631);
            this.endRecordingButton.Name = "endRecordingButton";
            this.endRecordingButton.Size = new System.Drawing.Size(178, 67);
            this.endRecordingButton.TabIndex = 1;
            this.endRecordingButton.Text = "button2";
            this.endRecordingButton.UseVisualStyleBackColor = false;
            this.endRecordingButton.Click += new System.EventHandler(this.endRecordingButton_Click);
            // 
            // shimmerCheckLabel
            // 
            this.shimmerCheckLabel.AutoSize = true;
            this.shimmerCheckLabel.Location = new System.Drawing.Point(3, 226);
            this.shimmerCheckLabel.Name = "shimmerCheckLabel";
            this.shimmerCheckLabel.Size = new System.Drawing.Size(51, 20);
            this.shimmerCheckLabel.TabIndex = 1;
            this.shimmerCheckLabel.Text = "label1";
            // 
            // tobiiCheckLabel
            // 
            this.tobiiCheckLabel.AutoSize = true;
            this.tobiiCheckLabel.Location = new System.Drawing.Point(3, 300);
            this.tobiiCheckLabel.Name = "tobiiCheckLabel";
            this.tobiiCheckLabel.Size = new System.Drawing.Size(51, 20);
            this.tobiiCheckLabel.TabIndex = 2;
            this.tobiiCheckLabel.Text = "label2";
            // 
            // screenRecordingCheckLabel
            // 
            this.screenRecordingCheckLabel.AutoSize = true;
            this.screenRecordingCheckLabel.Location = new System.Drawing.Point(3, 373);
            this.screenRecordingCheckLabel.Name = "screenRecordingCheckLabel";
            this.screenRecordingCheckLabel.Size = new System.Drawing.Size(51, 20);
            this.screenRecordingCheckLabel.TabIndex = 3;
            this.screenRecordingCheckLabel.Text = "label3";
            // 
            // audioOutputRecordingCheckLabel
            // 
            this.audioOutputRecordingCheckLabel.AutoSize = true;
            this.audioOutputRecordingCheckLabel.Location = new System.Drawing.Point(3, 444);
            this.audioOutputRecordingCheckLabel.Name = "audioOutputRecordingCheckLabel";
            this.audioOutputRecordingCheckLabel.Size = new System.Drawing.Size(51, 20);
            this.audioOutputRecordingCheckLabel.TabIndex = 4;
            this.audioOutputRecordingCheckLabel.Text = "label4";
            // 
            // shimmerCheckBox
            // 
            this.shimmerCheckBox.AutoSize = true;
            this.shimmerCheckBox.Location = new System.Drawing.Point(293, 226);
            this.shimmerCheckBox.Name = "shimmerCheckBox";
            this.shimmerCheckBox.Size = new System.Drawing.Size(106, 24);
            this.shimmerCheckBox.TabIndex = 5;
            this.shimmerCheckBox.Text = "checkBox1";
            this.shimmerCheckBox.UseVisualStyleBackColor = true;
            this.shimmerCheckBox.CheckedChanged += new System.EventHandler(this.shimmerCheckBox_CheckedChanged);
            // 
            // tobiiCheckBox
            // 
            this.tobiiCheckBox.AutoSize = true;
            this.tobiiCheckBox.Location = new System.Drawing.Point(293, 300);
            this.tobiiCheckBox.Name = "tobiiCheckBox";
            this.tobiiCheckBox.Size = new System.Drawing.Size(106, 24);
            this.tobiiCheckBox.TabIndex = 6;
            this.tobiiCheckBox.Text = "checkBox2";
            this.tobiiCheckBox.UseVisualStyleBackColor = true;
            this.tobiiCheckBox.CheckedChanged += new System.EventHandler(this.tobiiCheckBox_CheckedChanged);
            // 
            // screenRecordCheckBox
            // 
            this.screenRecordCheckBox.AutoSize = true;
            this.screenRecordCheckBox.Location = new System.Drawing.Point(293, 373);
            this.screenRecordCheckBox.Name = "screenRecordCheckBox";
            this.screenRecordCheckBox.Size = new System.Drawing.Size(106, 24);
            this.screenRecordCheckBox.TabIndex = 7;
            this.screenRecordCheckBox.Text = "checkBox3";
            this.screenRecordCheckBox.UseVisualStyleBackColor = true;
            this.screenRecordCheckBox.CheckedChanged += new System.EventHandler(this.screenRecordCheckBox_CheckedChanged);
            // 
            // audioRecordCheckbox
            // 
            this.audioRecordCheckbox.AutoSize = true;
            this.audioRecordCheckbox.Location = new System.Drawing.Point(293, 444);
            this.audioRecordCheckbox.Name = "audioRecordCheckbox";
            this.audioRecordCheckbox.Size = new System.Drawing.Size(106, 24);
            this.audioRecordCheckbox.TabIndex = 8;
            this.audioRecordCheckbox.Text = "checkBox4";
            this.audioRecordCheckbox.UseVisualStyleBackColor = true;
            this.audioRecordCheckbox.CheckedChanged += new System.EventHandler(this.audioRecordCheckbox_CheckedChanged);
            // 
            // subjectIdEntry
            // 
            this.subjectIdEntry.Location = new System.Drawing.Point(1045, 12);
            this.subjectIdEntry.Name = "subjectIdEntry";
            this.subjectIdEntry.Size = new System.Drawing.Size(101, 26);
            this.subjectIdEntry.TabIndex = 2;
            // 
            // subjectIdLabel
            // 
            this.subjectIdLabel.AutoSize = true;
            this.subjectIdLabel.Location = new System.Drawing.Point(540, 22);
            this.subjectIdLabel.Name = "subjectIdLabel";
            this.subjectIdLabel.Size = new System.Drawing.Size(51, 20);
            this.subjectIdLabel.TabIndex = 3;
            this.subjectIdLabel.Text = "label1";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // rootFolderLabel
            // 
            this.rootFolderLabel.AutoSize = true;
            this.rootFolderLabel.Location = new System.Drawing.Point(540, 114);
            this.rootFolderLabel.Name = "rootFolderLabel";
            this.rootFolderLabel.Size = new System.Drawing.Size(51, 20);
            this.rootFolderLabel.TabIndex = 4;
            this.rootFolderLabel.Text = "label1";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(820, 108);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(326, 26);
            this.pathTextBox.TabIndex = 5;
            // 
            // fileBroswerButton
            // 
            this.fileBroswerButton.Location = new System.Drawing.Point(1152, 98);
            this.fileBroswerButton.Name = "fileBroswerButton";
            this.fileBroswerButton.Size = new System.Drawing.Size(199, 53);
            this.fileBroswerButton.TabIndex = 6;
            this.fileBroswerButton.Text = "button1";
            this.fileBroswerButton.UseVisualStyleBackColor = true;
            this.fileBroswerButton.Click += new System.EventHandler(this.fileBroswerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 723);
            this.Controls.Add(this.fileBroswerButton);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.rootFolderLabel);
            this.Controls.Add(this.subjectIdLabel);
            this.Controls.Add(this.subjectIdEntry);
            this.Controls.Add(this.endRecordingButton);
            this.Controls.Add(this.beginRecordingButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button beginRecordingButton;
        private System.Windows.Forms.Button endRecordingButton;
        private System.Windows.Forms.Label sensorStreamInstructions;
        private System.Windows.Forms.CheckBox audioRecordCheckbox;
        private System.Windows.Forms.CheckBox screenRecordCheckBox;
        private System.Windows.Forms.CheckBox tobiiCheckBox;
        private System.Windows.Forms.CheckBox shimmerCheckBox;
        private System.Windows.Forms.Label audioOutputRecordingCheckLabel;
        private System.Windows.Forms.Label screenRecordingCheckLabel;
        private System.Windows.Forms.Label tobiiCheckLabel;
        private System.Windows.Forms.Label shimmerCheckLabel;
        private System.Windows.Forms.TextBox subjectIdEntry;
        private System.Windows.Forms.Label subjectIdLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label rootFolderLabel;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button fileBroswerButton;
    }
}

