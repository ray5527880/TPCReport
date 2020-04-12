using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPC_Report
{
    public partial class frmMonthCB : UserControl
    {
        public frmMonthCB()
        {
            InitializeComponent();
        }

        private void frmMonthCB_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnCount = 10;
            this.dataGridView1.Columns[0].Name = "No";
            this.dataGridView1.Columns[1].Name = "日期";
            this.dataGridView1.Columns[2].Name = "時間";
            this.dataGridView1.Columns[3].Name = "名稱";
            this.dataGridView1.Columns[4].Name = "當時狀態";
            this.dataGridView1.Columns[5].Name = "對應資料點";
            this.dataGridView1.Columns[6].Name = "狀態敘述";
            this.dataGridView1.Columns[7].Name = "掛牌/卸牌";
            this.dataGridView1.Columns[8].Name = "控制條件運算式";
            this.dataGridView1.Columns[9].Name = "執行～結果確定的間隔時間";
            for (int ii = 0; ii < this.dataGridView1.ColumnCount; ii++)
            {
                this.dataGridView1.Columns[ii].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            this.dateTimePicker2.Value = this.dateTimePicker1.Value.AddMonths(1);
        }
    }
}
