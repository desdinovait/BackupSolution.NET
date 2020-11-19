namespace BackupSolution.NET
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textSource = new System.Windows.Forms.TextBox();
            this.textDestination = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSource = new System.Windows.Forms.Button();
            this.buttonDestination = new System.Windows.Forms.Button();
            this.checkBIN = new System.Windows.Forms.CheckBox();
            this.checkOBJ = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textOtherExt = new System.Windows.Forms.TextBox();
            this.checkExclude = new System.Windows.Forms.CheckBox();
            this.labelExample = new System.Windows.Forms.Label();
            this.labelEx = new System.Windows.Forms.Label();
            this.buttonSuffixDate = new System.Windows.Forms.Button();
            this.buttonPrefixDate = new System.Windows.Forms.Button();
            this.labelPrefix = new System.Windows.Forms.Label();
            this.textPrefix = new System.Windows.Forms.TextBox();
            this.labelSuffix = new System.Windows.Forms.Label();
            this.textSuffix = new System.Windows.Forms.TextBox();
            this.checkName = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textOtherDir = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textSource
            // 
            this.textSource.Location = new System.Drawing.Point(78, 25);
            this.textSource.Name = "textSource";
            this.textSource.Size = new System.Drawing.Size(394, 20);
            this.textSource.TabIndex = 0;
            this.textSource.TextChanged += new System.EventHandler(this.textSource_TextChanged);
            // 
            // textDestination
            // 
            this.textDestination.Location = new System.Drawing.Point(78, 51);
            this.textDestination.Name = "textDestination";
            this.textDestination.Size = new System.Drawing.Size(394, 20);
            this.textDestination.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination :";
            // 
            // buttonSource
            // 
            this.buttonSource.Location = new System.Drawing.Point(478, 24);
            this.buttonSource.Name = "buttonSource";
            this.buttonSource.Size = new System.Drawing.Size(29, 20);
            this.buttonSource.TabIndex = 1;
            this.buttonSource.Text = "...";
            this.buttonSource.UseVisualStyleBackColor = true;
            this.buttonSource.Click += new System.EventHandler(this.buttonSource_Click);
            // 
            // buttonDestination
            // 
            this.buttonDestination.Location = new System.Drawing.Point(478, 50);
            this.buttonDestination.Name = "buttonDestination";
            this.buttonDestination.Size = new System.Drawing.Size(29, 20);
            this.buttonDestination.TabIndex = 3;
            this.buttonDestination.Text = "...";
            this.buttonDestination.UseVisualStyleBackColor = true;
            this.buttonDestination.Click += new System.EventHandler(this.buttonDestination_Click);
            // 
            // checkBIN
            // 
            this.checkBIN.AutoSize = true;
            this.checkBIN.Checked = true;
            this.checkBIN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBIN.Location = new System.Drawing.Point(9, 44);
            this.checkBIN.Name = "checkBIN";
            this.checkBIN.Size = new System.Drawing.Size(128, 17);
            this.checkBIN.TabIndex = 5;
            this.checkBIN.Text = "Exclude BIN directory";
            this.checkBIN.UseVisualStyleBackColor = true;
            this.checkBIN.CheckedChanged += new System.EventHandler(this.checkBIN_CheckedChanged);
            // 
            // checkOBJ
            // 
            this.checkOBJ.AutoSize = true;
            this.checkOBJ.Checked = true;
            this.checkOBJ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkOBJ.Location = new System.Drawing.Point(9, 21);
            this.checkOBJ.Name = "checkOBJ";
            this.checkOBJ.Size = new System.Drawing.Size(130, 17);
            this.checkOBJ.TabIndex = 4;
            this.checkOBJ.Text = "Exclude OBJ directory";
            this.checkOBJ.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textSource);
            this.groupBox1.Controls.Add(this.textDestination);
            this.groupBox1.Controls.Add(this.buttonDestination);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonSource);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 86);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Directory : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textOtherExt);
            this.groupBox2.Controls.Add(this.checkExclude);
            this.groupBox2.Controls.Add(this.labelExample);
            this.groupBox2.Controls.Add(this.labelEx);
            this.groupBox2.Controls.Add(this.buttonSuffixDate);
            this.groupBox2.Controls.Add(this.buttonPrefixDate);
            this.groupBox2.Controls.Add(this.labelPrefix);
            this.groupBox2.Controls.Add(this.textPrefix);
            this.groupBox2.Controls.Add(this.labelSuffix);
            this.groupBox2.Controls.Add(this.textSuffix);
            this.groupBox2.Controls.Add(this.checkName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textOtherDir);
            this.groupBox2.Controls.Add(this.checkBIN);
            this.groupBox2.Controls.Add(this.checkOBJ);
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 216);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options : ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(187, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 40);
            this.label4.TabIndex = 21;
            this.label4.Text = "Other extension exclusions : (separate with , or ; )";
            // 
            // textOtherExt
            // 
            this.textOtherExt.Location = new System.Drawing.Point(329, 75);
            this.textOtherExt.Name = "textOtherExt";
            this.textOtherExt.Size = new System.Drawing.Size(180, 20);
            this.textOtherExt.TabIndex = 8;
            // 
            // checkExclude
            // 
            this.checkExclude.AutoSize = true;
            this.checkExclude.Enabled = false;
            this.checkExclude.Location = new System.Drawing.Point(9, 77);
            this.checkExclude.Name = "checkExclude";
            this.checkExclude.Size = new System.Drawing.Size(162, 17);
            this.checkExclude.TabIndex = 7;
            this.checkExclude.Text = "Exclude .pdb and .vshost file";
            this.checkExclude.UseVisualStyleBackColor = true;
            // 
            // labelExample
            // 
            this.labelExample.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelExample.Location = new System.Drawing.Point(76, 184);
            this.labelExample.Name = "labelExample";
            this.labelExample.Size = new System.Drawing.Size(428, 20);
            this.labelExample.TabIndex = 16;
            this.labelExample.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEx
            // 
            this.labelEx.AutoSize = true;
            this.labelEx.Location = new System.Drawing.Point(22, 189);
            this.labelEx.Name = "labelEx";
            this.labelEx.Size = new System.Drawing.Size(53, 13);
            this.labelEx.TabIndex = 15;
            this.labelEx.Text = "Example :";
            // 
            // buttonSuffixDate
            // 
            this.buttonSuffixDate.Location = new System.Drawing.Point(244, 161);
            this.buttonSuffixDate.Name = "buttonSuffixDate";
            this.buttonSuffixDate.Size = new System.Drawing.Size(16, 20);
            this.buttonSuffixDate.TabIndex = 13;
            this.buttonSuffixDate.Text = "D";
            this.buttonSuffixDate.UseVisualStyleBackColor = true;
            this.buttonSuffixDate.Click += new System.EventHandler(this.buttonSuffixDate_Click);
            // 
            // buttonPrefixDate
            // 
            this.buttonPrefixDate.Location = new System.Drawing.Point(244, 138);
            this.buttonPrefixDate.Name = "buttonPrefixDate";
            this.buttonPrefixDate.Size = new System.Drawing.Size(16, 20);
            this.buttonPrefixDate.TabIndex = 11;
            this.buttonPrefixDate.Text = "D";
            this.buttonPrefixDate.UseVisualStyleBackColor = true;
            this.buttonPrefixDate.Click += new System.EventHandler(this.buttonPrefixDate_Click);
            // 
            // labelPrefix
            // 
            this.labelPrefix.AutoSize = true;
            this.labelPrefix.Location = new System.Drawing.Point(22, 141);
            this.labelPrefix.Name = "labelPrefix";
            this.labelPrefix.Size = new System.Drawing.Size(39, 13);
            this.labelPrefix.TabIndex = 12;
            this.labelPrefix.Text = "Prefix :";
            // 
            // textPrefix
            // 
            this.textPrefix.Location = new System.Drawing.Point(76, 138);
            this.textPrefix.Name = "textPrefix";
            this.textPrefix.Size = new System.Drawing.Size(162, 20);
            this.textPrefix.TabIndex = 10;
            this.textPrefix.TextChanged += new System.EventHandler(this.textPrefix_TextChanged);
            // 
            // labelSuffix
            // 
            this.labelSuffix.AutoSize = true;
            this.labelSuffix.Location = new System.Drawing.Point(22, 164);
            this.labelSuffix.Name = "labelSuffix";
            this.labelSuffix.Size = new System.Drawing.Size(39, 13);
            this.labelSuffix.TabIndex = 10;
            this.labelSuffix.Text = "Suffix :";
            // 
            // textSuffix
            // 
            this.textSuffix.Location = new System.Drawing.Point(76, 161);
            this.textSuffix.Name = "textSuffix";
            this.textSuffix.Size = new System.Drawing.Size(162, 20);
            this.textSuffix.TabIndex = 12;
            this.textSuffix.TextChanged += new System.EventHandler(this.textSuffix_TextChanged);
            // 
            // checkName
            // 
            this.checkName.AutoSize = true;
            this.checkName.Checked = true;
            this.checkName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkName.Location = new System.Drawing.Point(9, 113);
            this.checkName.Name = "checkName";
            this.checkName.Size = new System.Drawing.Size(152, 17);
            this.checkName.TabIndex = 9;
            this.checkName.Text = "Use source directory name";
            this.checkName.UseVisualStyleBackColor = true;
            this.checkName.CheckedChanged += new System.EventHandler(this.checkName_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(187, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Other directory exclusions : (separate with , or ; )";
            // 
            // textOtherDir
            // 
            this.textOtherDir.Location = new System.Drawing.Point(327, 18);
            this.textOtherDir.Name = "textOtherDir";
            this.textOtherDir.Size = new System.Drawing.Size(180, 20);
            this.textOtherDir.TabIndex = 6;
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(441, 329);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(86, 28);
            this.buttonStart.TabIndex = 15;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(349, 329);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(86, 28);
            this.buttonAbout.TabIndex = 14;
            this.buttonAbout.Text = "About...";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 368);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackupSolution.NET";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textSource;
        private System.Windows.Forms.TextBox textDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSource;
        private System.Windows.Forms.Button buttonDestination;
        private System.Windows.Forms.CheckBox checkBIN;
        private System.Windows.Forms.CheckBox checkOBJ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textOtherDir;
        private System.Windows.Forms.CheckBox checkName;
        private System.Windows.Forms.Label labelSuffix;
        private System.Windows.Forms.TextBox textSuffix;
        private System.Windows.Forms.Label labelPrefix;
        private System.Windows.Forms.TextBox textPrefix;
        private System.Windows.Forms.Button buttonPrefixDate;
        private System.Windows.Forms.Button buttonSuffixDate;
        private System.Windows.Forms.Label labelExample;
        private System.Windows.Forms.Label labelEx;
        private System.Windows.Forms.CheckBox checkExclude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textOtherExt;
    }
}

