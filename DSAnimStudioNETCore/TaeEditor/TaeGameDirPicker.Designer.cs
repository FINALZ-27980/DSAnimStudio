﻿namespace DSAnimStudio.TaeEditor
{
    partial class TaeGameDirPicker
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBoxGameDir = new System.Windows.Forms.TextBox();
            textBoxModDir = new System.Windows.Forms.TextBox();
            buttonBrowseGameDir = new System.Windows.Forms.Button();
            buttonBrowseModDir = new System.Windows.Forms.Button();
            buttonSave = new System.Windows.Forms.Button();
            buttonClearModDir = new System.Windows.Forms.Button();
            checkBoxLoadLooseParams = new System.Windows.Forms.CheckBox();
            checkBoxLoadUnpackedGameFiles = new System.Windows.Forms.CheckBox();
            label3 = new System.Windows.Forms.Label();
            textBoxProjectDirectory = new System.Windows.Forms.TextBox();
            buttonHelpLoadLooseParams = new System.Windows.Forms.Button();
            buttonHelpLoadUxmFiles = new System.Windows.Forms.Button();
            noPaddingButtonHelpModEngindDir = new NoPaddingButton();
            buttonABORT = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 53);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(233, 15);
            label1.TabIndex = 0;
            label1.Text = "游戏根目录文件夹，即exe文件所在路径";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 97);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(296, 15);
            label2.TabIndex = 1;
            label2.Text = "mod引擎加载路径，一般为根目录下的mods文件夹";
            // 
            // textBoxGameDir
            // 
            textBoxGameDir.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxGameDir.Location = new System.Drawing.Point(12, 71);
            textBoxGameDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxGameDir.Name = "textBoxGameDir";
            textBoxGameDir.Size = new System.Drawing.Size(531, 23);
            textBoxGameDir.TabIndex = 2;
            // 
            // textBoxModDir
            // 
            textBoxModDir.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxModDir.Location = new System.Drawing.Point(12, 115);
            textBoxModDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxModDir.Name = "textBoxModDir";
            textBoxModDir.Size = new System.Drawing.Size(450, 23);
            textBoxModDir.TabIndex = 3;
            // 
            // buttonBrowseGameDir
            // 
            buttonBrowseGameDir.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonBrowseGameDir.Location = new System.Drawing.Point(550, 71);
            buttonBrowseGameDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonBrowseGameDir.Name = "buttonBrowseGameDir";
            buttonBrowseGameDir.Size = new System.Drawing.Size(75, 23);
            buttonBrowseGameDir.TabIndex = 4;
            buttonBrowseGameDir.Text = "搜索";
            buttonBrowseGameDir.UseVisualStyleBackColor = true;
            buttonBrowseGameDir.Click += buttonBrowseGameDir_Click;
            // 
            // buttonBrowseModDir
            // 
            buttonBrowseModDir.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonBrowseModDir.Location = new System.Drawing.Point(550, 114);
            buttonBrowseModDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonBrowseModDir.Name = "buttonBrowseModDir";
            buttonBrowseModDir.Size = new System.Drawing.Size(75, 23);
            buttonBrowseModDir.TabIndex = 5;
            buttonBrowseModDir.Text = "搜索";
            buttonBrowseModDir.UseVisualStyleBackColor = true;
            buttonBrowseModDir.Click += buttonBrowseModDir_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonSave.Location = new System.Drawing.Point(524, 166);
            buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(100, 23);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "添加";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonClearModDir
            // 
            buttonClearModDir.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonClearModDir.Location = new System.Drawing.Point(468, 114);
            buttonClearModDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonClearModDir.Name = "buttonClearModDir";
            buttonClearModDir.Size = new System.Drawing.Size(75, 23);
            buttonClearModDir.TabIndex = 7;
            buttonClearModDir.Text = "清除";
            buttonClearModDir.UseVisualStyleBackColor = true;
            buttonClearModDir.Click += buttonClearModDir_Click;
            // 
            // checkBoxLoadLooseParams
            // 
            checkBoxLoadLooseParams.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            checkBoxLoadLooseParams.AutoSize = true;
            checkBoxLoadLooseParams.Location = new System.Drawing.Point(12, 145);
            checkBoxLoadLooseParams.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxLoadLooseParams.Name = "checkBoxLoadLooseParams";
            checkBoxLoadLooseParams.Size = new System.Drawing.Size(286, 19);
            checkBoxLoadLooseParams.TabIndex = 8;
            checkBoxLoadLooseParams.Text = "加载解密后且解包的散装参数（只狼用不上）";
            checkBoxLoadLooseParams.UseVisualStyleBackColor = true;
            // 
            // checkBoxLoadUnpackedGameFiles
            // 
            checkBoxLoadUnpackedGameFiles.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            checkBoxLoadUnpackedGameFiles.AutoSize = true;
            checkBoxLoadUnpackedGameFiles.Location = new System.Drawing.Point(12, 170);
            checkBoxLoadUnpackedGameFiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxLoadUnpackedGameFiles.Name = "checkBoxLoadUnpackedGameFiles";
            checkBoxLoadUnpackedGameFiles.Size = new System.Drawing.Size(312, 19);
            checkBoxLoadUnpackedGameFiles.TabIndex = 9;
            checkBoxLoadUnpackedGameFiles.Text = "加载UXM解包后的文件，有完整解包文件建议使用";
            checkBoxLoadUnpackedGameFiles.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 9);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(386, 15);
            label3.TabIndex = 10;
            label3.Text = "修改后的anibnd.dcx文件保存路径，一般设置成mods下的chr文件夹";
            // 
            // textBoxProjectDirectory
            // 
            textBoxProjectDirectory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxProjectDirectory.Location = new System.Drawing.Point(12, 27);
            textBoxProjectDirectory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxProjectDirectory.Name = "textBoxProjectDirectory";
            textBoxProjectDirectory.ReadOnly = true;
            textBoxProjectDirectory.Size = new System.Drawing.Size(612, 23);
            textBoxProjectDirectory.TabIndex = 11;
            // 
            // buttonHelpLoadLooseParams
            // 
            buttonHelpLoadLooseParams.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            buttonHelpLoadLooseParams.Location = new System.Drawing.Point(386, 141);
            buttonHelpLoadLooseParams.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonHelpLoadLooseParams.Name = "buttonHelpLoadLooseParams";
            buttonHelpLoadLooseParams.Size = new System.Drawing.Size(23, 23);
            buttonHelpLoadLooseParams.TabIndex = 12;
            buttonHelpLoadLooseParams.Text = "?";
            buttonHelpLoadLooseParams.UseVisualStyleBackColor = true;
            buttonHelpLoadLooseParams.Click += buttonHelpLoadLooseParams_Click;
            // 
            // buttonHelpLoadUxmFiles
            // 
            buttonHelpLoadUxmFiles.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            buttonHelpLoadUxmFiles.Location = new System.Drawing.Point(386, 166);
            buttonHelpLoadUxmFiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonHelpLoadUxmFiles.Name = "buttonHelpLoadUxmFiles";
            buttonHelpLoadUxmFiles.Size = new System.Drawing.Size(23, 23);
            buttonHelpLoadUxmFiles.TabIndex = 13;
            buttonHelpLoadUxmFiles.Text = "?";
            buttonHelpLoadUxmFiles.UseVisualStyleBackColor = true;
            buttonHelpLoadUxmFiles.Click += buttonHelpLoadUxmFiles_Click;
            // 
            // noPaddingButtonHelpModEngindDir
            // 
            noPaddingButtonHelpModEngindDir.Location = new System.Drawing.Point(387, 94);
            noPaddingButtonHelpModEngindDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            noPaddingButtonHelpModEngindDir.Name = "noPaddingButtonHelpModEngindDir";
            noPaddingButtonHelpModEngindDir.OwnerDrawText = null;
            noPaddingButtonHelpModEngindDir.Size = new System.Drawing.Size(20, 21);
            noPaddingButtonHelpModEngindDir.TabIndex = 14;
            noPaddingButtonHelpModEngindDir.Text = "?";
            noPaddingButtonHelpModEngindDir.UseVisualStyleBackColor = true;
            noPaddingButtonHelpModEngindDir.Click += noPaddingButtonHelpModEngindDir_Click;
            // 
            // buttonABORT
            // 
            buttonABORT.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonABORT.Location = new System.Drawing.Point(444, 166);
            buttonABORT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonABORT.Name = "buttonABORT";
            buttonABORT.Size = new System.Drawing.Size(74, 23);
            buttonABORT.TabIndex = 15;
            buttonABORT.Text = "取消";
            buttonABORT.UseVisualStyleBackColor = true;
            buttonABORT.Click += buttonABORT_Click;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 200);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(242, 15);
            label4.TabIndex = 16;
            label4.Text = "提示：按Enter键快速接受当前值并继续。";
            // 
            // TaeGameDirPicker
            // 
            AcceptButton = buttonSave;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = buttonABORT;
            ClientSize = new System.Drawing.Size(636, 224);
            Controls.Add(label4);
            Controls.Add(buttonABORT);
            Controls.Add(noPaddingButtonHelpModEngindDir);
            Controls.Add(buttonHelpLoadUxmFiles);
            Controls.Add(buttonHelpLoadLooseParams);
            Controls.Add(textBoxProjectDirectory);
            Controls.Add(label3);
            Controls.Add(checkBoxLoadUnpackedGameFiles);
            Controls.Add(checkBoxLoadLooseParams);
            Controls.Add(buttonClearModDir);
            Controls.Add(buttonSave);
            Controls.Add(buttonBrowseModDir);
            Controls.Add(buttonBrowseGameDir);
            Controls.Add(textBoxModDir);
            Controls.Add(textBoxGameDir);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(600, 263);
            Name = "TaeGameDirPicker";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "各项设置含义";
            FormClosing += TaeGameDirPicker_FormClosing;
            Load += TaeGameDirPicker_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGameDir;
        private System.Windows.Forms.TextBox textBoxModDir;
        private System.Windows.Forms.Button buttonBrowseGameDir;
        private System.Windows.Forms.Button buttonBrowseModDir;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClearModDir;
        private System.Windows.Forms.CheckBox checkBoxLoadLooseParams;
        private System.Windows.Forms.CheckBox checkBoxLoadUnpackedGameFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProjectDirectory;
        private System.Windows.Forms.Button buttonHelpLoadLooseParams;
        private System.Windows.Forms.Button buttonHelpLoadUxmFiles;
        private NoPaddingButton noPaddingButtonHelpModEngindDir;
        private System.Windows.Forms.Button buttonABORT;
        private System.Windows.Forms.Label label4;
    }
}