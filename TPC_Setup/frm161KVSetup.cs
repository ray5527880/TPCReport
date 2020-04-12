using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPC_Setup
{
    public partial class frm161KVSetup : Form
    {
        public frm161KVSetup()
        {
            InitializeComponent();
        }

        private void frm69KVSetup_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnCount = 4;
            this.dataGridView1.Columns[0].Name = "項次";
            this.dataGridView1.Columns[1].Name = "161KV編號";
            this.dataGridView1.Columns[2].Name = "161KV名稱";
            this.dataGridView1.Columns[3].Name = "161KV路徑";
            for (int ii = 0; ii < this.dataGridView1.ColumnCount - 1; ii++)
            {
                this.dataGridView1.Columns[ii].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            this.dataGridView1.Columns[3].Width = 150;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
