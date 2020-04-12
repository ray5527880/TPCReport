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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var frm = new frmStationSetupMenu();
                frm.ShowDialog();
            }
            else if(radioButton2.Checked)
            {
                var frm = new frmReportSetup();
                frm.ShowDialog();
            }
            else if (radioButton3.Checked)
            {
                var frm = new frmPointSetup();
                frm.ShowDialog();
            }
        }
    }
}
