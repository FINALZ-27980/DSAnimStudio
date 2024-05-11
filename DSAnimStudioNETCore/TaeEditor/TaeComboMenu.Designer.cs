namespace DSAnimStudio.TaeEditor
{
    partial class TaeComboMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaeComboMenu));
            buttonPlayCombo = new System.Windows.Forms.Button();
            buttonCancelCombo = new System.Windows.Forms.Button();
            checkBoxLoop = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            textBoxComboSeq = new System.Windows.Forms.TextBox();
            checkBoxRecord = new System.Windows.Forms.CheckBox();
            checkBoxRecordHkxOnly = new System.Windows.Forms.CheckBox();
            checkBoxRecord60FPS = new System.Windows.Forms.CheckBox();
            textBox1 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // buttonPlayCombo
            // 
            buttonPlayCombo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonPlayCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonPlayCombo.ForeColor = System.Drawing.Color.White;
            buttonPlayCombo.Location = new System.Drawing.Point(412, 403);
            buttonPlayCombo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonPlayCombo.Name = "buttonPlayCombo";
            buttonPlayCombo.Size = new System.Drawing.Size(103, 46);
            buttonPlayCombo.TabIndex = 1;
            buttonPlayCombo.Text = "播放连招";
            buttonPlayCombo.UseVisualStyleBackColor = true;
            buttonPlayCombo.Click += buttonPlayCombo_Click;
            // 
            // buttonCancelCombo
            // 
            buttonCancelCombo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonCancelCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCancelCombo.ForeColor = System.Drawing.Color.White;
            buttonCancelCombo.Location = new System.Drawing.Point(299, 403);
            buttonCancelCombo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonCancelCombo.Name = "buttonCancelCombo";
            buttonCancelCombo.Size = new System.Drawing.Size(106, 46);
            buttonCancelCombo.TabIndex = 2;
            buttonCancelCombo.Text = "停止连招";
            buttonCancelCombo.UseVisualStyleBackColor = true;
            buttonCancelCombo.Click += buttonCancelCombo_Click;
            // 
            // checkBoxLoop
            // 
            checkBoxLoop.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            checkBoxLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            checkBoxLoop.ForeColor = System.Drawing.Color.White;
            checkBoxLoop.Location = new System.Drawing.Point(522, 429);
            checkBoxLoop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxLoop.Name = "checkBoxLoop";
            checkBoxLoop.Size = new System.Drawing.Size(70, 20);
            checkBoxLoop.TabIndex = 5;
            checkBoxLoop.Text = "循环";
            checkBoxLoop.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(576, 14);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 13);
            label2.TabIndex = 8;
            label2.Text = "可用指令";
            // 
            // textBoxComboSeq
            // 
            textBoxComboSeq.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxComboSeq.AutoCompleteCustomSource.AddRange(new string[] { "EnemyAtk", "EnemyComboAtk", "EnemyMove", "EnemyDodge", "PlayerRH", "PlayerMove", "PlayerLH", "PlayerGuard", "PlayerDodge", "PlayerEstus", "PlayerItem", "PlayerWeaponSwitch", "ThrowEscape" });
            textBoxComboSeq.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            textBoxComboSeq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBoxComboSeq.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxComboSeq.ForeColor = System.Drawing.Color.White;
            textBoxComboSeq.Location = new System.Drawing.Point(14, 14);
            textBoxComboSeq.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxComboSeq.Multiline = true;
            textBoxComboSeq.Name = "textBoxComboSeq";
            textBoxComboSeq.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxComboSeq.Size = new System.Drawing.Size(500, 382);
            textBoxComboSeq.TabIndex = 9;
            textBoxComboSeq.Text = "EnemyComboAtk 3000\r\nEnemyComboAtk 3001\r\nEnemyComboAtk 3002\r\n";
            // 
            // checkBoxRecord
            // 
            checkBoxRecord.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            checkBoxRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            checkBoxRecord.ForeColor = System.Drawing.Color.White;
            checkBoxRecord.Location = new System.Drawing.Point(14, 402);
            checkBoxRecord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxRecord.Name = "checkBoxRecord";
            checkBoxRecord.Size = new System.Drawing.Size(157, 20);
            checkBoxRecord.TabIndex = 10;
            checkBoxRecord.Text = "记录连招（实验性的）";
            checkBoxRecord.UseVisualStyleBackColor = true;
            // 
            // checkBoxRecordHkxOnly
            // 
            checkBoxRecordHkxOnly.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            checkBoxRecordHkxOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            checkBoxRecordHkxOnly.ForeColor = System.Drawing.Color.White;
            checkBoxRecordHkxOnly.Location = new System.Drawing.Point(14, 429);
            checkBoxRecordHkxOnly.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxRecordHkxOnly.Name = "checkBoxRecordHkxOnly";
            checkBoxRecordHkxOnly.Size = new System.Drawing.Size(135, 20);
            checkBoxRecordHkxOnly.TabIndex = 11;
            checkBoxRecordHkxOnly.Text = "仅记录HKX动画";
            checkBoxRecordHkxOnly.UseVisualStyleBackColor = true;
            // 
            // checkBoxRecord60FPS
            // 
            checkBoxRecord60FPS.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            checkBoxRecord60FPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            checkBoxRecord60FPS.ForeColor = System.Drawing.Color.White;
            checkBoxRecord60FPS.Location = new System.Drawing.Point(152, 429);
            checkBoxRecord60FPS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxRecord60FPS.Name = "checkBoxRecord60FPS";
            checkBoxRecord60FPS.Size = new System.Drawing.Size(131, 20);
            checkBoxRecord60FPS.TabIndex = 12;
            checkBoxRecord60FPS.Text = "用60帧记录";
            checkBoxRecord60FPS.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            textBox1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.ForeColor = System.Drawing.Color.White;
            textBox1.Location = new System.Drawing.Point(522, 33);
            textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBox1.Size = new System.Drawing.Size(167, 362);
            textBox1.TabIndex = 13;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // TaeComboMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            ClientSize = new System.Drawing.Size(705, 463);
            Controls.Add(textBox1);
            Controls.Add(checkBoxRecord60FPS);
            Controls.Add(checkBoxRecordHkxOnly);
            Controls.Add(checkBoxRecord);
            Controls.Add(textBoxComboSeq);
            Controls.Add(label2);
            Controls.Add(checkBoxLoop);
            Controls.Add(buttonCancelCombo);
            Controls.Add(buttonPlayCombo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(721, 225);
            Name = "TaeComboMenu";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "连招预览";
            FormClosing += TaeComboMenu_FormClosing;
            Load += TaeComboMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button buttonPlayCombo;
        private System.Windows.Forms.Button buttonCancelCombo;
        private System.Windows.Forms.CheckBox checkBoxLoop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxComboSeq;
        private System.Windows.Forms.CheckBox checkBoxRecord;
        private System.Windows.Forms.CheckBox checkBoxRecordHkxOnly;
        private System.Windows.Forms.CheckBox checkBoxRecord60FPS;
        private System.Windows.Forms.TextBox textBox1;
    }
}