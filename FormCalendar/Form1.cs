using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 暂存数据到gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append("BEGIN:VEVENT").Append("\n");

            // 开始日期
            //String DTStart = dateTimePickerDTStart.Value.ToString("yyyyMMddTHHmmssZ");
            String DTStart = dateTimePickerDTStart.Value.ToString("yyyyMMdd");
            sb.Append("DTSTART:").Append(DTStart).Append("\n");
            // 开始日期
            //String DTEnd = dateTimePickerDTEnd.Value.ToString("yyyyMMddTHHmmssZ");
            String DTEnd = dateTimePickerDTEnd.Value.ToString("yyyyMMdd");
            sb.Append("DTEND:").Append(DTEnd).Append("\n");
            // 标题
            String Summary = textBoxSummary.Text;
            if (String.IsNullOrEmpty(Summary))
            {
                MessageBox.Show("【标题】不能为空");
                return;
            }
            sb.Append("SUMMARY:").Append(Summary).Append("\n");
            // 描述
            String Description = richTextBoxDescription.Text;
            if (!string.IsNullOrEmpty(Description))
            {
                sb.Append("DESCRIPTION:").Append(Description).Append("\n");
            }
            // uid
            String uid = System.Guid.NewGuid().ToString();
            sb.Append("UID:").Append(uid).Append("\n");

            sb.Append("END:VEVENT").Append("\n");


            int index = this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[index].Cells[0].Value = sb.ToString();


        }

        /// <summary>
        /// 生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string path = String.Empty;
            System.Windows.Forms.FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }

            // 如果未选择目录则不导出
            if (string.IsNullOrEmpty(path))
                return;

            StringBuilder sb = new StringBuilder("");
            sb.Append("BEGIN:VCALENDAR").Append("\n");
            sb.Append("PRODID:-//z-f.top//calendar 2.2//EN").Append("\n");
            sb.Append("VERSION:2.0").Append("\n");
            sb.Append("CALSCALE:GREGORIAN").Append("\n");

            int rows = this.dataGridView1.Rows.Count - 1;
            for (int i = 0; i < rows; i++)
            {
                sb.Append("").Append(this.dataGridView1.Rows[i].Cells[0].Value.ToString());
            }

            sb.Append("END:VCALENDAR").Append("\n");

            StreamWriter sw = new StreamWriter(path + "iCalendar.ics");
            sw.WriteLine(sb.ToString());
            sw.Close();
            MessageBox.Show("文件成功输出到【" + path + "iCalendar.ics】");
        }


        private int indexCon = 0;

        /// <summary>
        /// grid 部分窗体右键控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    this.dataGridView1.Rows[e.RowIndex].Selected = true;
                    indexCon = e.RowIndex;
                    this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[0];

                    this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                    this.contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ToolStripMenuItem t in contextMenuStrip1.Items)
            {
                if (t.Selected == true)
                {
                    if (t.Name == this.toolStripMenuItem1.Name)
                    {
                        // 删除
                        if (this.dataGridView1.Rows.Count - 1 == indexCon)
                        {
                            MessageBox.Show("未提交的行无法删除！");
                            return;
                        }
                        // 删除行
                        this.dataGridView1.Rows.RemoveAt(indexCon);
                    }
                    else if (t.Name == this.toolStripMenuItem2.Name)
                    {
                        // 隐藏邮件菜单
                        this.contextMenuStrip1.Hide();
                        // 导入
                        System.Windows.Forms.OpenFileDialog fbd = new OpenFileDialog();
                        if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            StreamReader sr = new StreamReader(fbd.FileName);
                            String strLine = String.Empty;
                            StringBuilder sb = new StringBuilder("");
                            List<String> resultList = new List<string>();
                            bool flag = false;

                            // 读取附件数据
                            strLine = sr.ReadLine();
                            while (strLine != null)
                            {
                                if (strLine.Equals("BEGIN:VEVENT") || flag)
                                {
                                    flag = true;
                                    sb.Append(strLine).Append("\n");
                                }
                                if (strLine.Equals("END:VEVENT"))
                                {
                                    flag = false;
                                    resultList.Add(sb.ToString());
                                    sb = new StringBuilder("");
                                }
                                strLine = sr.ReadLine();
                            }

                            // 清空grid
                            int rc = this.dataGridView1.RowCount - 1; // 下表从0开始，所以-1
                            for (int i = rc - 1; i >= 0; i--) // 最后一个不删除，所以-1
                            { 
                                // 删除行
                                this.dataGridView1.Rows.RemoveAt(i);
                            }
                            // 加入grid
                            foreach (String item in resultList)
                            {
                                int index = this.dataGridView1.Rows.Add();
                                this.dataGridView1.Rows[index].Cells[0].Value = item;
                            }
                        }
                    }
                }
            }

        }
    }
}
