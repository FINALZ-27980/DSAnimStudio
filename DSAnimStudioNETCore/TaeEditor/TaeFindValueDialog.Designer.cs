namespace DSAnimStudio.TaeEditor
{
    partial class TaeFindValueDialog
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
            textBoxSearchQuery = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            checkBox1 = new System.Windows.Forms.CheckBox();
            labelResults = new System.Windows.Forms.Label();
            listViewResults = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            buttonSearch = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            comboBoxSearchType = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // textBoxSearchQuery
            // 
            textBoxSearchQuery.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxSearchQuery.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            textBoxSearchQuery.ForeColor = System.Drawing.Color.White;
            textBoxSearchQuery.Location = new System.Drawing.Point(124, 14);
            textBoxSearchQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            textBoxSearchQuery.Name = "textBoxSearchQuery";
            textBoxSearchQuery.Size = new System.Drawing.Size(634, 23);
            textBoxSearchQuery.TabIndex = 0;
            textBoxSearchQuery.KeyPress += TextBoxSearchQuery_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(23, 19);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 13);
            label1.TabIndex = 1;
            label1.Text = "需要搜索的值";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(124, 44);
            checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(522, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "全词匹配（比如不勾选搜索“7”结果是所有数值中含有7的，勾选后只会显示值就是7的）";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelResults
            // 
            labelResults.AutoSize = true;
            labelResults.Location = new System.Drawing.Point(16, 75);
            labelResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelResults.Name = "labelResults";
            labelResults.Size = new System.Drawing.Size(33, 15);
            labelResults.TabIndex = 3;
            labelResults.Text = "结果";
            labelResults.Click += Label2_Click;
            // 
            // listViewResults
            // 
            listViewResults.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listViewResults.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            listViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewResults.ForeColor = System.Drawing.Color.White;
            listViewResults.FullRowSelect = true;
            listViewResults.GridLines = true;
            listViewResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewResults.Location = new System.Drawing.Point(18, 96);
            listViewResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            listViewResults.MultiSelect = false;
            listViewResults.Name = "listViewResults";
            listViewResults.Size = new System.Drawing.Size(901, 409);
            listViewResults.TabIndex = 4;
            listViewResults.UseCompatibleStateImageBehavior = false;
            listViewResults.View = System.Windows.Forms.View.Details;
            listViewResults.VirtualMode = true;
            listViewResults.ItemActivate += ListViewResults_ItemActivate;
            listViewResults.RetrieveVirtualItem += ListViewResults_RetrieveVirtualItem;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "TAE";
            columnHeader1.Width = 52;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "动作";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "词条类型";
            columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "词条内数值";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "匹配值";
            columnHeader5.Width = 100;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSearch.Location = new System.Drawing.Point(765, 11);
            buttonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(154, 28);
            buttonSearch.TabIndex = 5;
            buttonSearch.Text = "搜索";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += ButtonSearch_Click;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(677, 53);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 15);
            label2.TabIndex = 6;
            label2.Text = "搜索类型";
            // 
            // comboBoxSearchType
            // 
            comboBoxSearchType.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            comboBoxSearchType.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            comboBoxSearchType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBoxSearchType.ForeColor = System.Drawing.Color.White;
            comboBoxSearchType.FormattingEnabled = true;
            comboBoxSearchType.Items.AddRange(new object[] { "词条内数值", "参数名称", "词条名称", "词条类型ID" });
            comboBoxSearchType.Location = new System.Drawing.Point(765, 49);
            comboBoxSearchType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            comboBoxSearchType.Name = "comboBoxSearchType";
            comboBoxSearchType.Size = new System.Drawing.Size(153, 23);
            comboBoxSearchType.TabIndex = 7;
            // 
            // TaeFindValueDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(comboBoxSearchType);
            Controls.Add(label2);
            Controls.Add(buttonSearch);
            Controls.Add(listViewResults);
            Controls.Add(labelResults);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(textBoxSearchQuery);
            ForeColor = System.Drawing.Color.White;
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "TaeFindValueDialog";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "搜索框";
            Load += TaeFindValueDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearchQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSearchType;
    }
}