using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPCReport.Core.table;

namespace TPC_Report
{
    public partial class frmMonthFeeder : UserControl
    {

        tIED tFeederSetting;
        public frmMonthFeeder()
        {
            InitializeComponent();
        }

        private void frmMonthFeeder_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnCount = 9;
            this.dataGridView1.Columns[0].Name = "No";
            this.dataGridView1.Columns[1].Name = "日期";
            this.dataGridView1.Columns[2].Name = "時間";
            this.dataGridView1.Columns[3].Name = "名稱";
            this.dataGridView1.Columns[4].Name = "R相電流";
            this.dataGridView1.Columns[5].Name = "S相電流";
            this.dataGridView1.Columns[6].Name = "T相電流";
            this.dataGridView1.Columns[7].Name = "N相電流";
            this.dataGridView1.Columns[8].Name = "kWh";
            for (int ii = 0; ii < this.dataGridView1.ColumnCount; ii++)
            {
                this.dataGridView1.Columns[ii].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            this.dateTimePicker2.Value = this.dateTimePicker1.Value.AddMonths(1);
        }
    }
}
