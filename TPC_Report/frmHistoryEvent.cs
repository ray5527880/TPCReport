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
    public partial class frmHistoryEvent : UserControl
    {
        public frmHistoryEvent()
        {
            InitializeComponent();
        }

        private void frmHistoryEvent_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnCount = 9;
            this.dataGridView1.Columns[0].Name = "No";
            this.dataGridView1.Columns[1].Name = "事件等級";
            this.dataGridView1.Columns[2].Name = "日期";
            this.dataGridView1.Columns[3].Name = "時間";
            this.dataGridView1.Columns[4].Name = "名稱";
            this.dataGridView1.Columns[5].Name = "識別位址";
            this.dataGridView1.Columns[6].Name = "狀態敘述";
            this.dataGridView1.Columns[7].Name = "計量值";
            this.dataGridView1.Columns[8].Name = "訊息";
            for (int ii = 0; ii < this.dataGridView1.ColumnCount; ii++)
            {
                this.dataGridView1.Columns[ii].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
