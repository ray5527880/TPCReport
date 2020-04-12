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
    public partial class frmIEDSetup : Form
    {
        public frmIEDSetup()
        {
            InitializeComponent();
        }

        private void frmIEDSetup_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnCount = 7;
            this.dataGridView1.Columns[0].Name = "項次";
            this.dataGridView1.Columns[1].Name = "IED編號";
            this.dataGridView1.Columns[2].Name = "IED名稱";
            this.dataGridView1.Columns[3].Name = "IED路徑";
            this.dataGridView1.Columns[4].Name = "IED路徑";
            this.dataGridView1.Columns[5].Name = "保護類型";
            this.dataGridView1.Columns[6].Name = "保護編號";

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
