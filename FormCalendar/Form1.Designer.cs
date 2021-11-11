namespace FormCalendar
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.source = new System.Windows.Forms.GroupBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.textBoxSummary = new System.Windows.Forms.TextBox();
            this.SUMMARYLabel = new System.Windows.Forms.Label();
            this.dateTimePickerDTEnd = new System.Windows.Forms.DateTimePicker();
            this.DTENDLabel = new System.Windows.Forms.Label();
            this.dateTimePickerDTStart = new System.Windows.Forms.DateTimePicker();
            this.DTSTARTLabel = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.source.SuspendLayout();
            this.grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // source
            // 
            this.source.Controls.Add(this.richTextBoxDescription);
            this.source.Controls.Add(this.DescriptionLabel);
            this.source.Controls.Add(this.textBoxSummary);
            this.source.Controls.Add(this.SUMMARYLabel);
            this.source.Controls.Add(this.dateTimePickerDTEnd);
            this.source.Controls.Add(this.DTENDLabel);
            this.source.Controls.Add(this.dateTimePickerDTStart);
            this.source.Controls.Add(this.DTSTARTLabel);
            this.source.Location = new System.Drawing.Point(12, 12);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(200, 403);
            this.source.TabIndex = 1;
            this.source.TabStop = false;
            this.source.Text = "Source";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(6, 279);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(188, 118);
            this.richTextBoxDescription.TabIndex = 7;
            this.richTextBoxDescription.Text = "";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(7, 248);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(29, 12);
            this.DescriptionLabel.TabIndex = 6;
            this.DescriptionLabel.Text = "描述";
            // 
            // textBoxSummary
            // 
            this.textBoxSummary.Location = new System.Drawing.Point(6, 207);
            this.textBoxSummary.Name = "textBoxSummary";
            this.textBoxSummary.Size = new System.Drawing.Size(188, 21);
            this.textBoxSummary.TabIndex = 5;
            // 
            // SUMMARYLabel
            // 
            this.SUMMARYLabel.AutoSize = true;
            this.SUMMARYLabel.Location = new System.Drawing.Point(7, 183);
            this.SUMMARYLabel.Name = "SUMMARYLabel";
            this.SUMMARYLabel.Size = new System.Drawing.Size(29, 12);
            this.SUMMARYLabel.TabIndex = 4;
            this.SUMMARYLabel.Text = "标题";
            // 
            // dateTimePickerDTEnd
            // 
            this.dateTimePickerDTEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerDTEnd.Location = new System.Drawing.Point(6, 138);
            this.dateTimePickerDTEnd.Name = "dateTimePickerDTEnd";
            this.dateTimePickerDTEnd.Size = new System.Drawing.Size(188, 21);
            this.dateTimePickerDTEnd.TabIndex = 3;
            // 
            // DTENDLabel
            // 
            this.DTENDLabel.AutoSize = true;
            this.DTENDLabel.Location = new System.Drawing.Point(7, 107);
            this.DTENDLabel.Name = "DTENDLabel";
            this.DTENDLabel.Size = new System.Drawing.Size(53, 12);
            this.DTENDLabel.TabIndex = 2;
            this.DTENDLabel.Text = "结束日期";
            // 
            // dateTimePickerDTStart
            // 
            this.dateTimePickerDTStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerDTStart.Location = new System.Drawing.Point(6, 65);
            this.dateTimePickerDTStart.Name = "dateTimePickerDTStart";
            this.dateTimePickerDTStart.Size = new System.Drawing.Size(188, 21);
            this.dateTimePickerDTStart.TabIndex = 1;
            // 
            // DTSTARTLabel
            // 
            this.DTSTARTLabel.AutoSize = true;
            this.DTSTARTLabel.Location = new System.Drawing.Point(7, 38);
            this.DTSTARTLabel.Name = "DTSTARTLabel";
            this.DTSTARTLabel.Size = new System.Drawing.Size(53, 12);
            this.DTSTARTLabel.TabIndex = 0;
            this.DTSTARTLabel.Text = "开始日期";
            // 
            // grid
            // 
            this.grid.Controls.Add(this.dataGridView1);
            this.grid.Location = new System.Drawing.Point(218, 12);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(401, 403);
            this.grid.TabIndex = 2;
            this.grid.TabStop = false;
            this.grid.Text = "Grid";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(395, 383);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "原始数据";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "暂存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(385, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "生成";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            this.contextMenuStrip1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip1_MouseClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "删除行";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "导入（会覆盖）";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.source);
            this.Name = "Form1";
            this.Text = "日历制作.ics";
            this.source.ResumeLayout(false);
            this.source.PerformLayout();
            this.grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox source;
        private System.Windows.Forms.DateTimePicker dateTimePickerDTStart;
        private System.Windows.Forms.Label DTSTARTLabel;
        private System.Windows.Forms.GroupBox grid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label DTENDLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox textBoxSummary;
        private System.Windows.Forms.Label SUMMARYLabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerDTEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

