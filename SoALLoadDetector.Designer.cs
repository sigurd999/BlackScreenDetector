﻿namespace SoALLoadDetector
{
	partial class SoALLoadDetector
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
			this.startButton = new System.Windows.Forms.Button();
			this.imageDisplay = new System.Windows.Forms.PictureBox();
			this.matchDisplayLabel = new System.Windows.Forms.Label();
			this.pausedDisplay = new System.Windows.Forms.Panel();
			this.gameTimeLabel = new System.Windows.Forms.Label();
			this.realTimeLabel = new System.Windows.Forms.Label();
			this.pausedTimeLabel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pauseSegmentList = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.recordCheck = new System.Windows.Forms.CheckBox();
			this.saveDiagnosticCheck = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.recordCurrentButton = new System.Windows.Forms.Button();
			this.resetButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.processListBox = new System.Windows.Forms.ListBox();
			this.label7 = new System.Windows.Forms.Label();
			this.previewPictureBox = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.croppedPreviewPictureBox = new System.Windows.Forms.PictureBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.scalingLabel = new System.Windows.Forms.Label();
			this.requiredMatchesUpDown = new System.Windows.Forms.NumericUpDown();
			this.button2 = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.blackLevelNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.pauseCountLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.croppedPreviewPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.requiredMatchesUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.blackLevelNumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(240, 864);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(43, 23);
			this.startButton.TabIndex = 0;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// imageDisplay
			// 
			this.imageDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.imageDisplay.Location = new System.Drawing.Point(16, 27);
			this.imageDisplay.Name = "imageDisplay";
			this.imageDisplay.Size = new System.Drawing.Size(200, 800);
			this.imageDisplay.TabIndex = 1;
			this.imageDisplay.TabStop = false;
			// 
			// matchDisplayLabel
			// 
			this.matchDisplayLabel.AutoSize = true;
			this.matchDisplayLabel.Location = new System.Drawing.Point(240, 701);
			this.matchDisplayLabel.Name = "matchDisplayLabel";
			this.matchDisplayLabel.Size = new System.Drawing.Size(13, 13);
			this.matchDisplayLabel.TabIndex = 2;
			this.matchDisplayLabel.Text = "0";
			// 
			// pausedDisplay
			// 
			this.pausedDisplay.Location = new System.Drawing.Point(354, 824);
			this.pausedDisplay.Name = "pausedDisplay";
			this.pausedDisplay.Size = new System.Drawing.Size(37, 35);
			this.pausedDisplay.TabIndex = 3;
			// 
			// gameTimeLabel
			// 
			this.gameTimeLabel.AutoSize = true;
			this.gameTimeLabel.Location = new System.Drawing.Point(240, 800);
			this.gameTimeLabel.Name = "gameTimeLabel";
			this.gameTimeLabel.Size = new System.Drawing.Size(43, 13);
			this.gameTimeLabel.TabIndex = 4;
			this.gameTimeLabel.Text = "0:00:00";
			// 
			// realTimeLabel
			// 
			this.realTimeLabel.AutoSize = true;
			this.realTimeLabel.Location = new System.Drawing.Point(240, 757);
			this.realTimeLabel.Name = "realTimeLabel";
			this.realTimeLabel.Size = new System.Drawing.Size(43, 13);
			this.realTimeLabel.TabIndex = 5;
			this.realTimeLabel.Text = "0:00:00";
			// 
			// pausedTimeLabel
			// 
			this.pausedTimeLabel.AutoSize = true;
			this.pausedTimeLabel.Location = new System.Drawing.Point(240, 845);
			this.pausedTimeLabel.Name = "pausedTimeLabel";
			this.pausedTimeLabel.Size = new System.Drawing.Size(43, 13);
			this.pausedTimeLabel.TabIndex = 6;
			this.pausedTimeLabel.Text = "0:00:00";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(236, 675);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(142, 22);
			this.label5.TabIndex = 7;
			this.label5.Text = "Current Matches";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(236, 735);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 22);
			this.label1.TabIndex = 8;
			this.label1.Text = "Real Time";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(236, 778);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 22);
			this.label2.TabIndex = 9;
			this.label2.Text = "Game Time";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(236, 824);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 22);
			this.label3.TabIndex = 10;
			this.label3.Text = "Paused Time";
			// 
			// pauseSegmentList
			// 
			this.pauseSegmentList.FormattingEnabled = true;
			this.pauseSegmentList.Location = new System.Drawing.Point(493, 766);
			this.pauseSegmentList.Name = "pauseSegmentList";
			this.pauseSegmentList.Size = new System.Drawing.Size(142, 121);
			this.pauseSegmentList.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(489, 736);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(146, 22);
			this.label4.TabIndex = 12;
			this.label4.Text = "Pause Segments";
			// 
			// recordCheck
			// 
			this.recordCheck.AutoSize = true;
			this.recordCheck.Location = new System.Drawing.Point(641, 766);
			this.recordCheck.Name = "recordCheck";
			this.recordCheck.Size = new System.Drawing.Size(105, 17);
			this.recordCheck.TabIndex = 13;
			this.recordCheck.Text = "Record Features";
			this.recordCheck.UseVisualStyleBackColor = true;
			this.recordCheck.CheckedChanged += new System.EventHandler(this.recordCheck_CheckedChanged);
			// 
			// saveDiagnosticCheck
			// 
			this.saveDiagnosticCheck.AutoSize = true;
			this.saveDiagnosticCheck.Checked = true;
			this.saveDiagnosticCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.saveDiagnosticCheck.Location = new System.Drawing.Point(641, 789);
			this.saveDiagnosticCheck.Name = "saveDiagnosticCheck";
			this.saveDiagnosticCheck.Size = new System.Drawing.Size(109, 17);
			this.saveDiagnosticCheck.TabIndex = 14;
			this.saveDiagnosticCheck.Text = "Save Diagnostics";
			this.saveDiagnosticCheck.UseVisualStyleBackColor = true;
			this.saveDiagnosticCheck.CheckedChanged += new System.EventHandler(this.saveDiagnosticCheck_CheckedChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(411, 675);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(153, 22);
			this.label6.TabIndex = 15;
			this.label6.Text = "Minimum Duration";
			// 
			// recordCurrentButton
			// 
			this.recordCurrentButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.recordCurrentButton.Location = new System.Drawing.Point(345, 864);
			this.recordCurrentButton.Name = "recordCurrentButton";
			this.recordCurrentButton.Size = new System.Drawing.Size(116, 23);
			this.recordCurrentButton.TabIndex = 17;
			this.recordCurrentButton.Text = "Record Current Feature";
			this.recordCurrentButton.UseVisualStyleBackColor = true;
			this.recordCurrentButton.Click += new System.EventHandler(this.recordCurrentButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(289, 864);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(50, 23);
			this.resetButton.TabIndex = 18;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(637, 836);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(113, 23);
			this.button1.TabIndex = 19;
			this.button1.Text = "Feature from File";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// processListBox
			// 
			this.processListBox.FormattingEnabled = true;
			this.processListBox.Location = new System.Drawing.Point(765, 766);
			this.processListBox.Name = "processListBox";
			this.processListBox.Size = new System.Drawing.Size(142, 121);
			this.processListBox.TabIndex = 20;
			this.processListBox.SelectedIndexChanged += new System.EventHandler(this.processListBox_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(761, 735);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(144, 22);
			this.label7.TabIndex = 21;
			this.label7.Text = "Process Capture";
			// 
			// previewPictureBox
			// 
			this.previewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.previewPictureBox.Location = new System.Drawing.Point(243, 122);
			this.previewPictureBox.Name = "previewPictureBox";
			this.previewPictureBox.Size = new System.Drawing.Size(448, 252);
			this.previewPictureBox.TabIndex = 22;
			this.previewPictureBox.TabStop = false;
			this.previewPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.previewPictureBox_MouseClick);
			this.previewPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.previewPictureBox_MouseDown);
			this.previewPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.previewPictureBox_MouseMove);
			this.previewPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.previewPictureBox_MouseUp);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(239, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(143, 22);
			this.label8.TabIndex = 23;
			this.label8.Text = "Capture Preview";
			// 
			// croppedPreviewPictureBox
			// 
			this.croppedPreviewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.croppedPreviewPictureBox.Location = new System.Drawing.Point(243, 410);
			this.croppedPreviewPictureBox.Name = "croppedPreviewPictureBox";
			this.croppedPreviewPictureBox.Size = new System.Drawing.Size(448, 252);
			this.croppedPreviewPictureBox.TabIndex = 24;
			this.croppedPreviewPictureBox.TabStop = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(239, 385);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(217, 22);
			this.label9.TabIndex = 25;
			this.label9.Text = "Cropped Capture Preview";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(12, 2);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(144, 22);
			this.label10.TabIndex = 26;
			this.label10.Text = "Matching Region";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(240, 106);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(349, 13);
			this.label11.TabIndex = 27;
			this.label11.Text = "Left Click sets top-left corner, right click sets bottom-right corner of region";
			// 
			// trackBar1
			// 
			this.trackBar1.LargeChange = 25;
			this.trackBar1.Location = new System.Drawing.Point(243, 58);
			this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
			this.trackBar1.Maximum = 201;
			this.trackBar1.Minimum = 100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(78, 45);
			this.trackBar1.SmallChange = 25;
			this.trackBar1.TabIndex = 28;
			this.trackBar1.TickFrequency = 25;
			this.trackBar1.Value = 100;
			this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
			// 
			// scalingLabel
			// 
			this.scalingLabel.AutoSize = true;
			this.scalingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scalingLabel.Location = new System.Drawing.Point(239, 35);
			this.scalingLabel.Name = "scalingLabel";
			this.scalingLabel.Size = new System.Drawing.Size(125, 22);
			this.scalingLabel.TabIndex = 29;
			this.scalingLabel.Text = "Scaling: 100%";
			// 
			// requiredMatchesUpDown
			// 
			this.requiredMatchesUpDown.DecimalPlaces = 4;
			this.requiredMatchesUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			this.requiredMatchesUpDown.Location = new System.Drawing.Point(415, 699);
			this.requiredMatchesUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.requiredMatchesUpDown.Name = "requiredMatchesUpDown";
			this.requiredMatchesUpDown.Size = new System.Drawing.Size(120, 20);
			this.requiredMatchesUpDown.TabIndex = 32;
			this.requiredMatchesUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            131072});
			this.requiredMatchesUpDown.ValueChanged += new System.EventHandler(this.requiredMatchesUpDown_ValueChanged);
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button2.Location = new System.Drawing.Point(637, 864);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(113, 23);
			this.button2.TabIndex = 33;
			this.button2.Text = "Features from Folder";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(570, 675);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(102, 22);
			this.label12.TabIndex = 34;
			this.label12.Text = "Black Level";
			// 
			// blackLevelNumericUpDown
			// 
			this.blackLevelNumericUpDown.DecimalPlaces = 4;
			this.blackLevelNumericUpDown.Location = new System.Drawing.Point(574, 701);
			this.blackLevelNumericUpDown.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
			this.blackLevelNumericUpDown.Name = "blackLevelNumericUpDown";
			this.blackLevelNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.blackLevelNumericUpDown.TabIndex = 35;
			this.blackLevelNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// pauseCountLabel
			// 
			this.pauseCountLabel.AutoSize = true;
			this.pauseCountLabel.Location = new System.Drawing.Point(351, 808);
			this.pauseCountLabel.Name = "pauseCountLabel";
			this.pauseCountLabel.Size = new System.Drawing.Size(13, 13);
			this.pauseCountLabel.TabIndex = 36;
			this.pauseCountLabel.Text = "0";
			// 
			// SoALLoadDetector
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1158, 913);
			this.Controls.Add(this.pauseCountLabel);
			this.Controls.Add(this.blackLevelNumericUpDown);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.requiredMatchesUpDown);
			this.Controls.Add(this.scalingLabel);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.croppedPreviewPictureBox);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.previewPictureBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.processListBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.recordCurrentButton);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.saveDiagnosticCheck);
			this.Controls.Add(this.recordCheck);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pauseSegmentList);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pausedTimeLabel);
			this.Controls.Add(this.realTimeLabel);
			this.Controls.Add(this.gameTimeLabel);
			this.Controls.Add(this.pausedDisplay);
			this.Controls.Add(this.matchDisplayLabel);
			this.Controls.Add(this.imageDisplay);
			this.Controls.Add(this.startButton);
			this.Name = "SoALLoadDetector";
			this.Text = "Skies of Arcadia Legends Load Detector";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SoALLoadDetector_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.croppedPreviewPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.requiredMatchesUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.blackLevelNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.PictureBox imageDisplay;
		private System.Windows.Forms.Label matchDisplayLabel;
		private System.Windows.Forms.Panel pausedDisplay;
		private System.Windows.Forms.Label gameTimeLabel;
		private System.Windows.Forms.Label realTimeLabel;
		private System.Windows.Forms.Label pausedTimeLabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox pauseSegmentList;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox recordCheck;
		private System.Windows.Forms.CheckBox saveDiagnosticCheck;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button recordCurrentButton;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox processListBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox previewPictureBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox croppedPreviewPictureBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label scalingLabel;
		private System.Windows.Forms.NumericUpDown requiredMatchesUpDown;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown blackLevelNumericUpDown;
		private System.Windows.Forms.Label pauseCountLabel;
	}
}

