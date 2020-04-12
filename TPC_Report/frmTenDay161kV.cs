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
    public partial class frmTenDay161kV : UserControl
    {
        public frmTenDay161kV()
        {
            InitializeComponent();
        }

        private void frmTenDay69kV_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.CustomFormat = "yyyy/MM";
            this.dataGridView1.ColumnCount = 18;
            this.dataGridView1.Columns[0].Name = "No";
            this.dataGridView1.Columns[1].Name = "日期";
            this.dataGridView1.Columns[2].Name = "時間";
            this.dataGridView1.Columns[3].Name = "名稱";
            this.dataGridView1.Columns[4].Name = "Va";
            this.dataGridView1.Columns[5].Name = "Vb";
            this.dataGridView1.Columns[6].Name = "Vc";
            this.dataGridView1.Columns[7].Name = "Ia";
            this.dataGridView1.Columns[8].Name = "Ib";
            this.dataGridView1.Columns[9].Name = "Ic";
            this.dataGridView1.Columns[10].Name = "Hz";
            this.dataGridView1.Columns[11].Name = "kW";
            this.dataGridView1.Columns[12].Name = "kVar";
            this.dataGridView1.Columns[13].Name = "+kWh";
            this.dataGridView1.Columns[14].Name = "-kWh";
            this.dataGridView1.Columns[15].Name = "+kVarh";
            this.dataGridView1.Columns[16].Name = "-kVarh";
            this.dataGridView1.Columns[17].Name = "℃";
            for (int ii = 0; ii < this.dataGridView1.ColumnCount; ii++)
            {
                this.dataGridView1.Columns[ii].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
