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
    public partial class frmMonth161kV : UserControl
    {
        public frmMonth161kV()
        {
            InitializeComponent();
        }
        //各種類比值之顯示，如電壓、電流、頻率、乏、瓦、溫度、分接頭位置……。
        //顯示各類比點的相關資料，包括流水號、點名稱敘述、目前計量、低限值、高限值、警報狀態、計算點的運算式、IED 資料點識別號碼。
        //顯示各累計點的相關資料，包括流水號、點名稱敘述、目前累計值、高限值、警報狀態、IED 資料點識別號碼。
        private void frmMonth69kV_Load(object sender, EventArgs e)
        {
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
            this.dateTimePicker2.Value = this.dateTimePicker1.Value.AddMonths(1);

        }
    }
}
