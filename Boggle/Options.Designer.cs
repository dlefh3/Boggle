namespace Boggle
{
    partial class Options
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
            this.grpScoring = new System.Windows.Forms.GroupBox();
            this.radModeStandard = new System.Windows.Forms.RadioButton();
            this.radModeScrabble = new System.Windows.Forms.RadioButton();
            this.radModePointPer = new System.Windows.Forms.RadioButton();
            this.grpColors = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnColorSelected = new System.Windows.Forms.Button();
            this.btnColorValid = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.grpBounds = new System.Windows.Forms.GroupBox();
            this.radBoundPeriod = new System.Windows.Forms.RadioButton();
            this.radBoundStandard = new System.Windows.Forms.RadioButton();
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.radCustom = new System.Windows.Forms.RadioButton();
            this.radHard = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radEasy = new System.Windows.Forms.RadioButton();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.radSizeBig = new System.Windows.Forms.RadioButton();
            this.radSizeStandard = new System.Windows.Forms.RadioButton();
            this.grpLength = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.grpTime = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numTime = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCustomWords = new System.Windows.Forms.Button();
            this.btnCustomDice = new System.Windows.Forms.Button();
            this.of_WordList = new System.Windows.Forms.OpenFileDialog();
            this.of_DiceSets = new System.Windows.Forms.OpenFileDialog();
            this.grpScoring.SuspendLayout();
            this.grpColors.SuspendLayout();
            this.grpBounds.SuspendLayout();
            this.grpMode.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.grpLength.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            this.grpTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpScoring
            // 
            this.grpScoring.Controls.Add(this.radModeStandard);
            this.grpScoring.Controls.Add(this.radModeScrabble);
            this.grpScoring.Controls.Add(this.radModePointPer);
            this.grpScoring.Location = new System.Drawing.Point(4, 109);
            this.grpScoring.Name = "grpScoring";
            this.grpScoring.Size = new System.Drawing.Size(160, 100);
            this.grpScoring.TabIndex = 0;
            this.grpScoring.TabStop = false;
            this.grpScoring.Text = "Scoring Mode";
            // 
            // radModeStandard
            // 
            this.radModeStandard.AutoSize = true;
            this.radModeStandard.Checked = true;
            this.radModeStandard.Location = new System.Drawing.Point(21, 20);
            this.radModeStandard.Name = "radModeStandard";
            this.radModeStandard.Size = new System.Drawing.Size(68, 17);
            this.radModeStandard.TabIndex = 2;
            this.radModeStandard.TabStop = true;
            this.radModeStandard.Text = "Standard";
            this.radModeStandard.UseVisualStyleBackColor = true;
            this.radModeStandard.CheckedChanged += new System.EventHandler(this.radModeStandard_CheckedChanged);
            // 
            // radModeScrabble
            // 
            this.radModeScrabble.AutoSize = true;
            this.radModeScrabble.Location = new System.Drawing.Point(20, 72);
            this.radModeScrabble.Name = "radModeScrabble";
            this.radModeScrabble.Size = new System.Drawing.Size(132, 17);
            this.radModeScrabble.TabIndex = 1;
            this.radModeScrabble.Text = "Scrabble Letter Values";
            this.radModeScrabble.UseVisualStyleBackColor = true;
            this.radModeScrabble.CheckedChanged += new System.EventHandler(this.radModeScrabble_CheckedChanged);
            // 
            // radModePointPer
            // 
            this.radModePointPer.AutoSize = true;
            this.radModePointPer.Location = new System.Drawing.Point(20, 46);
            this.radModePointPer.Name = "radModePointPer";
            this.radModePointPer.Size = new System.Drawing.Size(107, 17);
            this.radModePointPer.TabIndex = 0;
            this.radModePointPer.Text = "1 Point Per Letter";
            this.radModePointPer.UseVisualStyleBackColor = true;
            this.radModePointPer.CheckedChanged += new System.EventHandler(this.radModePointPer_CheckedChanged);
            // 
            // grpColors
            // 
            this.grpColors.Controls.Add(this.label2);
            this.grpColors.Controls.Add(this.label1);
            this.grpColors.Controls.Add(this.btnColorSelected);
            this.grpColors.Controls.Add(this.btnColorValid);
            this.grpColors.Location = new System.Drawing.Point(16, 140);
            this.grpColors.Name = "grpColors";
            this.grpColors.Size = new System.Drawing.Size(91, 147);
            this.grpColors.TabIndex = 1;
            this.grpColors.TabStop = false;
            this.grpColors.Text = "Colors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected Letter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valid Moves";
            // 
            // btnColorSelected
            // 
            this.btnColorSelected.BackColor = System.Drawing.Color.Green;
            this.btnColorSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorSelected.Location = new System.Drawing.Point(20, 83);
            this.btnColorSelected.Name = "btnColorSelected";
            this.btnColorSelected.Size = new System.Drawing.Size(35, 35);
            this.btnColorSelected.TabIndex = 1;
            this.btnColorSelected.UseVisualStyleBackColor = false;
            this.btnColorSelected.Click += new System.EventHandler(this.btnColorSelected_Click);
            // 
            // btnColorValid
            // 
            this.btnColorValid.BackColor = System.Drawing.Color.Lime;
            this.btnColorValid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorValid.Location = new System.Drawing.Point(20, 19);
            this.btnColorValid.Name = "btnColorValid";
            this.btnColorValid.Size = new System.Drawing.Size(35, 35);
            this.btnColorValid.TabIndex = 0;
            this.btnColorValid.UseVisualStyleBackColor = false;
            this.btnColorValid.Click += new System.EventHandler(this.btnColorValid_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(16, 304);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // grpBounds
            // 
            this.grpBounds.Controls.Add(this.radBoundPeriod);
            this.grpBounds.Controls.Add(this.radBoundStandard);
            this.grpBounds.Location = new System.Drawing.Point(4, 215);
            this.grpBounds.Name = "grpBounds";
            this.grpBounds.Size = new System.Drawing.Size(160, 100);
            this.grpBounds.TabIndex = 3;
            this.grpBounds.TabStop = false;
            this.grpBounds.Text = "Boundary Conditions";
            // 
            // radBoundPeriod
            // 
            this.radBoundPeriod.AutoSize = true;
            this.radBoundPeriod.Location = new System.Drawing.Point(21, 55);
            this.radBoundPeriod.Name = "radBoundPeriod";
            this.radBoundPeriod.Size = new System.Drawing.Size(111, 17);
            this.radBoundPeriod.TabIndex = 1;
            this.radBoundPeriod.Text = "Periodic Boundary";
            this.radBoundPeriod.UseVisualStyleBackColor = true;
            this.radBoundPeriod.CheckedChanged += new System.EventHandler(this.radBoundPeriod_CheckedChanged);
            // 
            // radBoundStandard
            // 
            this.radBoundStandard.AutoSize = true;
            this.radBoundStandard.Checked = true;
            this.radBoundStandard.Location = new System.Drawing.Point(21, 31);
            this.radBoundStandard.Name = "radBoundStandard";
            this.radBoundStandard.Size = new System.Drawing.Size(116, 17);
            this.radBoundStandard.TabIndex = 0;
            this.radBoundStandard.TabStop = true;
            this.radBoundStandard.Text = "Standard Boundary\r\n";
            this.radBoundStandard.UseVisualStyleBackColor = true;
            this.radBoundStandard.CheckedChanged += new System.EventHandler(this.radBoundStandard_CheckedChanged);
            // 
            // grpMode
            // 
            this.grpMode.Controls.Add(this.radCustom);
            this.grpMode.Controls.Add(this.radHard);
            this.grpMode.Controls.Add(this.radMedium);
            this.grpMode.Controls.Add(this.radEasy);
            this.grpMode.Location = new System.Drawing.Point(16, 12);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(91, 122);
            this.grpMode.TabIndex = 4;
            this.grpMode.TabStop = false;
            this.grpMode.Text = "Difficulty";
            // 
            // radCustom
            // 
            this.radCustom.AutoSize = true;
            this.radCustom.Location = new System.Drawing.Point(20, 90);
            this.radCustom.Name = "radCustom";
            this.radCustom.Size = new System.Drawing.Size(60, 17);
            this.radCustom.TabIndex = 3;
            this.radCustom.Text = "Custom";
            this.radCustom.UseVisualStyleBackColor = true;
            this.radCustom.CheckedChanged += new System.EventHandler(this.radCustom_CheckedChanged);
            // 
            // radHard
            // 
            this.radHard.AutoSize = true;
            this.radHard.Location = new System.Drawing.Point(20, 66);
            this.radHard.Name = "radHard";
            this.radHard.Size = new System.Drawing.Size(48, 17);
            this.radHard.TabIndex = 2;
            this.radHard.Text = "Hard";
            this.radHard.UseVisualStyleBackColor = true;
            this.radHard.CheckedChanged += new System.EventHandler(this.radHard_CheckedChanged);
            // 
            // radMedium
            // 
            this.radMedium.AutoSize = true;
            this.radMedium.Checked = true;
            this.radMedium.Location = new System.Drawing.Point(20, 42);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(62, 17);
            this.radMedium.TabIndex = 1;
            this.radMedium.TabStop = true;
            this.radMedium.Text = "Medium";
            this.radMedium.UseVisualStyleBackColor = true;
            this.radMedium.CheckedChanged += new System.EventHandler(this.radMedium_CheckedChanged);
            // 
            // radEasy
            // 
            this.radEasy.AutoSize = true;
            this.radEasy.Location = new System.Drawing.Point(20, 21);
            this.radEasy.Name = "radEasy";
            this.radEasy.Size = new System.Drawing.Size(48, 17);
            this.radEasy.TabIndex = 0;
            this.radEasy.Text = "Easy";
            this.radEasy.UseVisualStyleBackColor = true;
            this.radEasy.CheckedChanged += new System.EventHandler(this.radEasy_CheckedChanged);
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.radSizeBig);
            this.grpSize.Controls.Add(this.radSizeStandard);
            this.grpSize.Location = new System.Drawing.Point(4, 3);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(161, 100);
            this.grpSize.TabIndex = 5;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Board Size";
            // 
            // radSizeBig
            // 
            this.radSizeBig.AutoSize = true;
            this.radSizeBig.Location = new System.Drawing.Point(20, 64);
            this.radSizeBig.Name = "radSizeBig";
            this.radSizeBig.Size = new System.Drawing.Size(68, 17);
            this.radSizeBig.TabIndex = 1;
            this.radSizeBig.Text = "Big (5X5)";
            this.radSizeBig.UseVisualStyleBackColor = true;
            this.radSizeBig.CheckedChanged += new System.EventHandler(this.radSizeBig_CheckedChanged);
            // 
            // radSizeStandard
            // 
            this.radSizeStandard.AutoSize = true;
            this.radSizeStandard.Checked = true;
            this.radSizeStandard.Location = new System.Drawing.Point(20, 38);
            this.radSizeStandard.Name = "radSizeStandard";
            this.radSizeStandard.Size = new System.Drawing.Size(96, 17);
            this.radSizeStandard.TabIndex = 0;
            this.radSizeStandard.TabStop = true;
            this.radSizeStandard.Text = "Standard (4X4)";
            this.radSizeStandard.UseVisualStyleBackColor = true;
            this.radSizeStandard.CheckedChanged += new System.EventHandler(this.radSizeStandard_CheckedChanged);
            // 
            // grpLength
            // 
            this.grpLength.Controls.Add(this.label4);
            this.grpLength.Controls.Add(this.numLength);
            this.grpLength.Location = new System.Drawing.Point(170, 3);
            this.grpLength.Name = "grpLength";
            this.grpLength.Size = new System.Drawing.Size(135, 100);
            this.grpLength.TabIndex = 6;
            this.grpLength.TabStop = false;
            this.grpLength.Text = "Minimum Word Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "letters";
            // 
            // numLength
            // 
            this.numLength.Location = new System.Drawing.Point(24, 38);
            this.numLength.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numLength.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(67, 20);
            this.numLength.TabIndex = 0;
            this.numLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numLength.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numLength.ValueChanged += new System.EventHandler(this.numLength_ValueChanged);
            // 
            // grpTime
            // 
            this.grpTime.Controls.Add(this.label3);
            this.grpTime.Controls.Add(this.numTime);
            this.grpTime.Location = new System.Drawing.Point(170, 109);
            this.grpTime.Name = "grpTime";
            this.grpTime.Size = new System.Drawing.Size(135, 100);
            this.grpTime.TabIndex = 7;
            this.grpTime.TabStop = false;
            this.grpTime.Text = "Time Limit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "minutes";
            // 
            // numTime
            // 
            this.numTime.Location = new System.Drawing.Point(24, 34);
            this.numTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTime.Name = "numTime";
            this.numTime.Size = new System.Drawing.Size(67, 20);
            this.numTime.TabIndex = 0;
            this.numTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTime.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numTime.ValueChanged += new System.EventHandler(this.numTime_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCustomWords);
            this.panel1.Controls.Add(this.btnCustomDice);
            this.panel1.Controls.Add(this.grpSize);
            this.panel1.Controls.Add(this.grpTime);
            this.panel1.Controls.Add(this.grpScoring);
            this.panel1.Controls.Add(this.grpLength);
            this.panel1.Controls.Add(this.grpBounds);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(139, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 322);
            this.panel1.TabIndex = 8;
            // 
            // btnCustomWords
            // 
            this.btnCustomWords.Location = new System.Drawing.Point(170, 270);
            this.btnCustomWords.Name = "btnCustomWords";
            this.btnCustomWords.Size = new System.Drawing.Size(135, 31);
            this.btnCustomWords.TabIndex = 9;
            this.btnCustomWords.Text = "Load Custom Word List";
            this.btnCustomWords.UseVisualStyleBackColor = true;
            this.btnCustomWords.Click += new System.EventHandler(this.btnCustomWords_Click);
            // 
            // btnCustomDice
            // 
            this.btnCustomDice.Location = new System.Drawing.Point(170, 231);
            this.btnCustomDice.Name = "btnCustomDice";
            this.btnCustomDice.Size = new System.Drawing.Size(135, 31);
            this.btnCustomDice.TabIndex = 8;
            this.btnCustomDice.Text = "Load Custom Dice Set";
            this.btnCustomDice.UseVisualStyleBackColor = true;
            this.btnCustomDice.Click += new System.EventHandler(this.btnCustomDice_Click);
            // 
            // of_WordList
            // 
            this.of_WordList.DefaultExt = "txt";
            this.of_WordList.Filter = "Word Lists| *.txt";
            this.of_WordList.Title = "Select Word List";
            // 
            // of_DiceSets
            // 
            this.of_DiceSets.DefaultExt = "txt";
            this.of_DiceSets.Filter = "Dice Set| *.txt";
            this.of_DiceSets.Title = "Select Dice Set";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 337);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpMode);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpColors);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Options";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Options_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Options_FormClosed);
            this.Load += new System.EventHandler(this.Options_Load);
            this.VisibleChanged += new System.EventHandler(this.Options_VisibleChanged);
            this.grpScoring.ResumeLayout(false);
            this.grpScoring.PerformLayout();
            this.grpColors.ResumeLayout(false);
            this.grpColors.PerformLayout();
            this.grpBounds.ResumeLayout(false);
            this.grpBounds.PerformLayout();
            this.grpMode.ResumeLayout(false);
            this.grpMode.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpLength.ResumeLayout(false);
            this.grpLength.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.grpTime.ResumeLayout(false);
            this.grpTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpScoring;
        private System.Windows.Forms.GroupBox grpColors;
        private System.Windows.Forms.RadioButton radModeStandard;
        private System.Windows.Forms.RadioButton radModeScrabble;
        private System.Windows.Forms.RadioButton radModePointPer;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnColorValid;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColorSelected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBounds;
        private System.Windows.Forms.RadioButton radBoundPeriod;
        private System.Windows.Forms.RadioButton radBoundStandard;
        private System.Windows.Forms.GroupBox grpMode;
        private System.Windows.Forms.RadioButton radCustom;
        private System.Windows.Forms.RadioButton radHard;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.RadioButton radEasy;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton radSizeBig;
        private System.Windows.Forms.RadioButton radSizeStandard;
        private System.Windows.Forms.GroupBox grpLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.GroupBox grpTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog of_WordList;
        private System.Windows.Forms.Button btnCustomWords;
        private System.Windows.Forms.Button btnCustomDice;
        private System.Windows.Forms.OpenFileDialog of_DiceSets;
    }
}