namespace DSAnimStudio.TaeEditor
{
    partial class TaeLoadFromArchivesWizard
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
            components = new System.ComponentModel.Container();
            label1 = new System.Windows.Forms.Label();
            textBoxPathInterroot = new System.Windows.Forms.TextBox();
            buttonPathInterroot = new System.Windows.Forms.Button();
            buttonPathAnibnd = new System.Windows.Forms.Button();
            textBoxPathAnibnd = new System.Windows.Forms.TextBox();
            buttonPathChrbnd = new System.Windows.Forms.Button();
            textBoxPathChrbnd = new System.Windows.Forms.TextBox();
            buttonPathSaveLoose = new System.Windows.Forms.Button();
            textBoxPathSaveLoose = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            buttonHelpSaveLoose = new System.Windows.Forms.Button();
            buttonHelpChrbnd = new System.Windows.Forms.Button();
            buttonHelpAnibnd = new System.Windows.Forms.Button();
            buttonHelpGameEXE = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            buttonCreateProject = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            labelLoadingText = new System.Windows.Forms.Label();
            progressBarLoading = new System.Windows.Forms.ProgressBar();
            checkBoxLoadLooseParams = new System.Windows.Forms.CheckBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            buttonClearModEngineDir = new System.Windows.Forms.Button();
            buttonHelpCfgLoadUnpackedGameFiles = new System.Windows.Forms.Button();
            checkBoxCfgLoadUnpackedGameFiles = new System.Windows.Forms.CheckBox();
            buttonHelpCfgLoadLooseGameParam = new System.Windows.Forms.Button();
            buttonHelpCfgModEngineDir = new System.Windows.Forms.Button();
            buttonBrowseModEngineDir = new System.Windows.Forms.Button();
            textBoxPathModEngineDir = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "1.选择游戏路径";
            // 
            // textBoxPathInterroot
            // 
            textBoxPathInterroot.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxPathInterroot.Location = new System.Drawing.Point(207, 5);
            textBoxPathInterroot.Name = "textBoxPathInterroot";
            textBoxPathInterroot.Size = new System.Drawing.Size(312, 23);
            textBoxPathInterroot.TabIndex = 1;
            textBoxPathInterroot.Leave += textBoxPathInterroot_Leave;
            textBoxPathInterroot.Validating += textBoxPathInterroot_Validating;
            textBoxPathInterroot.Validated += textBoxPathInterroot_Validated;
            // 
            // buttonPathInterroot
            // 
            buttonPathInterroot.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonPathInterroot.Location = new System.Drawing.Point(539, 5);
            buttonPathInterroot.Name = "buttonPathInterroot";
            buttonPathInterroot.Size = new System.Drawing.Size(33, 23);
            buttonPathInterroot.TabIndex = 2;
            buttonPathInterroot.Text = "...";
            buttonPathInterroot.UseVisualStyleBackColor = true;
            buttonPathInterroot.Click += buttonPathInterroot_Click;
            // 
            // buttonPathAnibnd
            // 
            buttonPathAnibnd.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonPathAnibnd.Enabled = false;
            buttonPathAnibnd.Location = new System.Drawing.Point(539, 34);
            buttonPathAnibnd.Name = "buttonPathAnibnd";
            buttonPathAnibnd.Size = new System.Drawing.Size(33, 23);
            buttonPathAnibnd.TabIndex = 4;
            buttonPathAnibnd.Text = "...";
            buttonPathAnibnd.UseVisualStyleBackColor = true;
            buttonPathAnibnd.Click += buttonPathAnibnd_Click;
            // 
            // textBoxPathAnibnd
            // 
            textBoxPathAnibnd.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxPathAnibnd.Location = new System.Drawing.Point(207, 34);
            textBoxPathAnibnd.Name = "textBoxPathAnibnd";
            textBoxPathAnibnd.ReadOnly = true;
            textBoxPathAnibnd.Size = new System.Drawing.Size(312, 23);
            textBoxPathAnibnd.TabIndex = 3;
            textBoxPathAnibnd.Leave += textBoxPathAnibnd_Leave;
            // 
            // buttonPathChrbnd
            // 
            buttonPathChrbnd.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonPathChrbnd.Enabled = false;
            buttonPathChrbnd.Location = new System.Drawing.Point(539, 63);
            buttonPathChrbnd.Name = "buttonPathChrbnd";
            buttonPathChrbnd.Size = new System.Drawing.Size(33, 23);
            buttonPathChrbnd.TabIndex = 6;
            buttonPathChrbnd.Text = "...";
            buttonPathChrbnd.UseVisualStyleBackColor = true;
            buttonPathChrbnd.Click += buttonPathChrbnd_Click;
            // 
            // textBoxPathChrbnd
            // 
            textBoxPathChrbnd.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxPathChrbnd.Location = new System.Drawing.Point(207, 63);
            textBoxPathChrbnd.Name = "textBoxPathChrbnd";
            textBoxPathChrbnd.ReadOnly = true;
            textBoxPathChrbnd.Size = new System.Drawing.Size(312, 23);
            textBoxPathChrbnd.TabIndex = 5;
            textBoxPathChrbnd.Leave += textBoxPathChrbnd_Leave;
            // 
            // buttonPathSaveLoose
            // 
            buttonPathSaveLoose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonPathSaveLoose.Enabled = false;
            buttonPathSaveLoose.Location = new System.Drawing.Point(539, 92);
            buttonPathSaveLoose.Name = "buttonPathSaveLoose";
            buttonPathSaveLoose.Size = new System.Drawing.Size(33, 23);
            buttonPathSaveLoose.TabIndex = 8;
            buttonPathSaveLoose.Text = "...";
            buttonPathSaveLoose.UseVisualStyleBackColor = true;
            buttonPathSaveLoose.Click += buttonPathSaveLoose_Click;
            // 
            // textBoxPathSaveLoose
            // 
            textBoxPathSaveLoose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxPathSaveLoose.Location = new System.Drawing.Point(207, 92);
            textBoxPathSaveLoose.Name = "textBoxPathSaveLoose";
            textBoxPathSaveLoose.ReadOnly = true;
            textBoxPathSaveLoose.Size = new System.Drawing.Size(312, 23);
            textBoxPathSaveLoose.TabIndex = 7;
            textBoxPathSaveLoose.Leave += textBoxPathSaveLoose_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 39);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(89, 15);
            label2.TabIndex = 9;
            label2.Text = "2. 选择ANIBND";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 68);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(90, 15);
            label3.TabIndex = 10;
            label3.Text = "3.选择CHRBND";
            // 
            // buttonHelpSaveLoose
            // 
            buttonHelpSaveLoose.Location = new System.Drawing.Point(178, 92);
            buttonHelpSaveLoose.Name = "buttonHelpSaveLoose";
            buttonHelpSaveLoose.Size = new System.Drawing.Size(23, 23);
            buttonHelpSaveLoose.TabIndex = 14;
            buttonHelpSaveLoose.Text = "?";
            buttonHelpSaveLoose.UseVisualStyleBackColor = true;
            buttonHelpSaveLoose.Click += buttonHelpSaveLoose_Click;
            // 
            // buttonHelpChrbnd
            // 
            buttonHelpChrbnd.Location = new System.Drawing.Point(178, 63);
            buttonHelpChrbnd.Name = "buttonHelpChrbnd";
            buttonHelpChrbnd.Size = new System.Drawing.Size(23, 23);
            buttonHelpChrbnd.TabIndex = 13;
            buttonHelpChrbnd.Text = "?";
            buttonHelpChrbnd.UseVisualStyleBackColor = true;
            buttonHelpChrbnd.Click += buttonHelpChrbnd_Click;
            // 
            // buttonHelpAnibnd
            // 
            buttonHelpAnibnd.Location = new System.Drawing.Point(178, 34);
            buttonHelpAnibnd.Name = "buttonHelpAnibnd";
            buttonHelpAnibnd.Size = new System.Drawing.Size(23, 23);
            buttonHelpAnibnd.TabIndex = 12;
            buttonHelpAnibnd.Text = "?";
            buttonHelpAnibnd.UseVisualStyleBackColor = true;
            buttonHelpAnibnd.Click += buttonHelpAnibnd_Click;
            // 
            // buttonHelpGameEXE
            // 
            buttonHelpGameEXE.Location = new System.Drawing.Point(178, 5);
            buttonHelpGameEXE.Name = "buttonHelpGameEXE";
            buttonHelpGameEXE.Size = new System.Drawing.Size(23, 23);
            buttonHelpGameEXE.TabIndex = 11;
            buttonHelpGameEXE.Text = "?";
            buttonHelpGameEXE.UseVisualStyleBackColor = true;
            buttonHelpGameEXE.Click += buttonHelpGameEXE_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 96);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(136, 15);
            label4.TabIndex = 15;
            label4.Text = "4. 选择保存项目文件夹";
            // 
            // buttonCreateProject
            // 
            buttonCreateProject.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonCreateProject.Enabled = false;
            buttonCreateProject.Location = new System.Drawing.Point(453, 226);
            buttonCreateProject.Name = "buttonCreateProject";
            buttonCreateProject.Size = new System.Drawing.Size(119, 23);
            buttonCreateProject.TabIndex = 16;
            buttonCreateProject.Text = "创建项目";
            buttonCreateProject.UseVisualStyleBackColor = true;
            buttonCreateProject.Click += buttonCreateProject_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // labelLoadingText
            // 
            labelLoadingText.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            labelLoadingText.Location = new System.Drawing.Point(12, 226);
            labelLoadingText.Name = "labelLoadingText";
            labelLoadingText.Size = new System.Drawing.Size(223, 23);
            labelLoadingText.TabIndex = 17;
            labelLoadingText.Text = "正在解密param，请稍候...";
            labelLoadingText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBarLoading
            // 
            progressBarLoading.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            progressBarLoading.Location = new System.Drawing.Point(241, 226);
            progressBarLoading.MarqueeAnimationSpeed = 10;
            progressBarLoading.Maximum = 1;
            progressBarLoading.Name = "progressBarLoading";
            progressBarLoading.Size = new System.Drawing.Size(116, 23);
            progressBarLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            progressBarLoading.TabIndex = 18;
            progressBarLoading.Value = 1;
            // 
            // checkBoxLoadLooseParams
            // 
            checkBoxLoadLooseParams.AutoSize = true;
            checkBoxLoadLooseParams.Location = new System.Drawing.Point(6, 46);
            checkBoxLoadLooseParams.Name = "checkBoxLoadLooseParams";
            checkBoxLoadLooseParams.Size = new System.Drawing.Size(195, 19);
            checkBoxLoadLooseParams.TabIndex = 19;
            checkBoxLoadLooseParams.Text = "加载解密后且解包的散装参数";
            checkBoxLoadLooseParams.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.Controls.Add(buttonClearModEngineDir);
            groupBox1.Controls.Add(buttonHelpCfgLoadUnpackedGameFiles);
            groupBox1.Controls.Add(checkBoxCfgLoadUnpackedGameFiles);
            groupBox1.Controls.Add(buttonHelpCfgLoadLooseGameParam);
            groupBox1.Controls.Add(buttonHelpCfgModEngineDir);
            groupBox1.Controls.Add(buttonBrowseModEngineDir);
            groupBox1.Controls.Add(textBoxPathModEngineDir);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(checkBoxLoadLooseParams);
            groupBox1.Location = new System.Drawing.Point(7, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(565, 99);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "设置";
            // 
            // buttonClearModEngineDir
            // 
            buttonClearModEngineDir.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonClearModEngineDir.Location = new System.Drawing.Point(501, 15);
            buttonClearModEngineDir.Name = "buttonClearModEngineDir";
            buttonClearModEngineDir.Size = new System.Drawing.Size(23, 23);
            buttonClearModEngineDir.TabIndex = 27;
            buttonClearModEngineDir.Text = "X";
            buttonClearModEngineDir.UseVisualStyleBackColor = true;
            buttonClearModEngineDir.Click += buttonClearModEngineDir_Click;
            // 
            // buttonHelpCfgLoadUnpackedGameFiles
            // 
            buttonHelpCfgLoadUnpackedGameFiles.Location = new System.Drawing.Point(229, 68);
            buttonHelpCfgLoadUnpackedGameFiles.Name = "buttonHelpCfgLoadUnpackedGameFiles";
            buttonHelpCfgLoadUnpackedGameFiles.Size = new System.Drawing.Size(23, 23);
            buttonHelpCfgLoadUnpackedGameFiles.TabIndex = 26;
            buttonHelpCfgLoadUnpackedGameFiles.Text = "?";
            buttonHelpCfgLoadUnpackedGameFiles.UseVisualStyleBackColor = true;
            buttonHelpCfgLoadUnpackedGameFiles.Click += buttonHelpCfgLoadUnpackedGameFiles_Click;
            // 
            // checkBoxCfgLoadUnpackedGameFiles
            // 
            checkBoxCfgLoadUnpackedGameFiles.AutoSize = true;
            checkBoxCfgLoadUnpackedGameFiles.Location = new System.Drawing.Point(5, 71);
            checkBoxCfgLoadUnpackedGameFiles.Name = "checkBoxCfgLoadUnpackedGameFiles";
            checkBoxCfgLoadUnpackedGameFiles.Size = new System.Drawing.Size(130, 19);
            checkBoxCfgLoadUnpackedGameFiles.TabIndex = 25;
            checkBoxCfgLoadUnpackedGameFiles.Text = "加载解包后的文件";
            checkBoxCfgLoadUnpackedGameFiles.UseVisualStyleBackColor = true;
            // 
            // buttonHelpCfgLoadLooseGameParam
            // 
            buttonHelpCfgLoadLooseGameParam.Location = new System.Drawing.Point(229, 42);
            buttonHelpCfgLoadLooseGameParam.Name = "buttonHelpCfgLoadLooseGameParam";
            buttonHelpCfgLoadLooseGameParam.Size = new System.Drawing.Size(23, 23);
            buttonHelpCfgLoadLooseGameParam.TabIndex = 24;
            buttonHelpCfgLoadLooseGameParam.Text = "?";
            buttonHelpCfgLoadLooseGameParam.UseVisualStyleBackColor = true;
            buttonHelpCfgLoadLooseGameParam.Click += buttonHelpCfgLoadLooseGameParam_Click;
            // 
            // buttonHelpCfgModEngineDir
            // 
            buttonHelpCfgModEngineDir.Location = new System.Drawing.Point(229, 15);
            buttonHelpCfgModEngineDir.Name = "buttonHelpCfgModEngineDir";
            buttonHelpCfgModEngineDir.Size = new System.Drawing.Size(23, 23);
            buttonHelpCfgModEngineDir.TabIndex = 23;
            buttonHelpCfgModEngineDir.Text = "?";
            buttonHelpCfgModEngineDir.UseVisualStyleBackColor = true;
            buttonHelpCfgModEngineDir.Click += buttonHelpCfgModEngineDir_Click;
            // 
            // buttonBrowseModEngineDir
            // 
            buttonBrowseModEngineDir.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonBrowseModEngineDir.Location = new System.Drawing.Point(526, 15);
            buttonBrowseModEngineDir.Name = "buttonBrowseModEngineDir";
            buttonBrowseModEngineDir.Size = new System.Drawing.Size(33, 23);
            buttonBrowseModEngineDir.TabIndex = 22;
            buttonBrowseModEngineDir.Text = "...";
            buttonBrowseModEngineDir.UseVisualStyleBackColor = true;
            buttonBrowseModEngineDir.Click += buttonBrowseModEngineDir_Click;
            // 
            // textBoxPathModEngineDir
            // 
            textBoxPathModEngineDir.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxPathModEngineDir.Location = new System.Drawing.Point(257, 15);
            textBoxPathModEngineDir.Name = "textBoxPathModEngineDir";
            textBoxPathModEngineDir.Size = new System.Drawing.Size(240, 23);
            textBoxPathModEngineDir.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 18);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(97, 15);
            label5.TabIndex = 20;
            label5.Text = "Mod文件夹位置";
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonCancel.Enabled = false;
            buttonCancel.Location = new System.Drawing.Point(363, 226);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(84, 23);
            buttonCancel.TabIndex = 21;
            buttonCancel.Text = "取消";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // TaeLoadFromArchivesWizard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(584, 261);
            Controls.Add(buttonCancel);
            Controls.Add(groupBox1);
            Controls.Add(progressBarLoading);
            Controls.Add(labelLoadingText);
            Controls.Add(buttonCreateProject);
            Controls.Add(label4);
            Controls.Add(buttonHelpSaveLoose);
            Controls.Add(buttonHelpChrbnd);
            Controls.Add(buttonHelpAnibnd);
            Controls.Add(buttonHelpGameEXE);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonPathSaveLoose);
            Controls.Add(textBoxPathSaveLoose);
            Controls.Add(buttonPathChrbnd);
            Controls.Add(textBoxPathChrbnd);
            Controls.Add(buttonPathAnibnd);
            Controls.Add(textBoxPathAnibnd);
            Controls.Add(buttonPathInterroot);
            Controls.Add(textBoxPathInterroot);
            Controls.Add(label1);
            MinimumSize = new System.Drawing.Size(600, 300);
            Name = "TaeLoadFromArchivesWizard";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "从打包的游戏数据创建项目";
            FormClosing += TaeLoadFromArchivesWizard_FormClosing;
            Load += TaeLoadFromArchivesWizard_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPathInterroot;
        private System.Windows.Forms.Button buttonPathInterroot;
        private System.Windows.Forms.Button buttonPathAnibnd;
        private System.Windows.Forms.TextBox textBoxPathAnibnd;
        private System.Windows.Forms.Button buttonPathChrbnd;
        private System.Windows.Forms.TextBox textBoxPathChrbnd;
        private System.Windows.Forms.Button buttonPathSaveLoose;
        private System.Windows.Forms.TextBox textBoxPathSaveLoose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonHelpSaveLoose;
        private System.Windows.Forms.Button buttonHelpChrbnd;
        private System.Windows.Forms.Button buttonHelpAnibnd;
        private System.Windows.Forms.Button buttonHelpGameEXE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCreateProject;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelLoadingText;
        private System.Windows.Forms.ProgressBar progressBarLoading;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPathModEngineDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxLoadLooseParams;
        private System.Windows.Forms.Button buttonBrowseModEngineDir;
        private System.Windows.Forms.Button buttonHelpCfgLoadLooseGameParam;
        private System.Windows.Forms.Button buttonHelpCfgModEngineDir;
        private System.Windows.Forms.Button buttonHelpCfgLoadUnpackedGameFiles;
        private System.Windows.Forms.CheckBox checkBoxCfgLoadUnpackedGameFiles;
        private System.Windows.Forms.Button buttonClearModEngineDir;
        private System.Windows.Forms.Button buttonCancel;
    }
}