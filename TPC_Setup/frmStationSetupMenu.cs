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
    public partial class frmStationSetupMenu : Form
    {
        public frmStationSetupMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var frm = new frmFeederSetup();
                frm.ShowDialog();
            }
            else if (radioButton2.Checked)
            {
                var frm = new frmTranformSetup();
                frm.ShowDialog();
            }
            else if (radioButton3.Checked)
            {
                var frm = new frm161KVSetup();
                frm.ShowDialog();
            }
            else if (radioButton4.Checked)
            {
                var frm = new frmCBSetup();
                frm.ShowDialog();
            }
            else if (radioButton5.Checked)
            {
                var frm = new frmIEDSetup();
                frm.ShowDialog();
            }
        }
    }
}
