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
    public partial class frmDayTransformer : UserControl
    {
        public frmDayTransformer()
        {
            InitializeComponent();
        }

        private void frmDayTransformer_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnCount = 13;
            this.dataGridView1.Columns[0].Name = "No";
            this.dataGridView1.Columns[1].Name = "日期";
            this.dataGridView1.Columns[2].Name = "時間";
            this.dataGridView1.Columns[3].Name = "名稱";
            this.dataGridView1.Columns[4].Name = "電流";
            this.dataGridView1.Columns[5].Name = "BUS1電壓";
            this.dataGridView1.Columns[6].Name = "BUS2電壓";
            this.dataGridView1.Columns[7].Name = "油溫(℃)";
            this.dataGridView1.Columns[8].Name = "TAP位置";
            this.dataGridView1.Columns[9].Name = "MWh";
            this.dataGridView1.Columns[10].Name = "MAVRh";
            this.dataGridView1.Columns[11].Name = "MAVh";
            this.dataGridView1.Columns[12].Name = "PF(%)";
           
            for (int ii = 0; ii < this.dataGridView1.ColumnCount; ii++)
            {
                this.dataGridView1.Columns[ii].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
