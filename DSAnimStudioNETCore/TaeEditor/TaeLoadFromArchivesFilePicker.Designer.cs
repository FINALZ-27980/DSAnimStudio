namespace DSAnimStudio.TaeEditor
{
    partial class TaeLoadFromArchivesFilePicker
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
            listBoxFiles = new System.Windows.Forms.ListBox();
            buttonOK = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // listBoxFiles
            // 
            listBoxFiles.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listBoxFiles.FormattingEnabled = true;
            listBoxFiles.IntegralHeight = false;
            listBoxFiles.ItemHeight = 15;
            listBoxFiles.Location = new System.Drawing.Point(12, 12);
            listBoxFiles.Name = "listBoxFiles";
            listBoxFiles.ScrollAlwaysVisible = true;
            listBoxFiles.Size = new System.Drawing.Size(480, 251);
            listBoxFiles.TabIndex = 0;
            // 
            // buttonOK
            // 
            buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonOK.Location = new System.Drawing.Point(417, 269);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new System.Drawing.Size(75, 23);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 273);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(297, 15);
            label4.TabIndex = 17;
            label4.Text = "提示： 按Enter键快速选择突出显示的项目并继续。";
            // 
            // TaeLoadFromArchivesFilePicker
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(504, 304);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(buttonOK);
            Controls.Add(listBoxFiles);
            MinimumSize = new System.Drawing.Size(520, 240);
            Name = "TaeLoadFromArchivesFilePicker";
            Text = "从已成文件中选择文件";
            Load += TaeLoadFromArchivesFilePicker_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label4;
    }
}