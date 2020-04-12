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
    public partial class frmCBSetup : Form
    {
        public frmCBSetup()
        {
            InitializeComponent();
        }

        private void frmCBSetup_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnCount = 4;
            this.dataGridView1.Columns[0].Name = "項次";
            this.dataGridView1.Columns[1].Name = "CB編號";
            this.dataGridView1.Columns[2].Name = "CB名稱";
            this.dataGridView1.Columns[3].Name = "CB路徑";
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
