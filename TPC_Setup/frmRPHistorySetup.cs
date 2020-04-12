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
    public partial class frmRPHistorySetup : Form
    {
        public frmRPHistorySetup()
        {
            InitializeComponent();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRPHistorySetup_Load(object sender, EventArgs e)
        {

        }
    }
}
