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
    public partial class frmReportSetup : Form
    {
        public frmReportSetup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReportSetup_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var frm = new frmRPFeederSetup();
                frm.ShowDialog();
            }
            else if (radioButton2.Checked)
            {
                var frm = new frmRPTranformerSetup();
                frm.ShowDialog();
            }
            else if (radioButton3.Checked)
            {
                var frm = new frmRP161KVSetup();
                frm.ShowDialog();
            }
            else if (radioButton4.Checked)
            {
                var frm = new frmRPCBSetup();
                frm.ShowDialog();
            }
            else if (radioButton5.Checked)
            {
                var frm = new frmRPHistorySetup();
                frm.ShowDialog();
            }
            else if (radioButton6.Checked)
            {
                var frm = new frmRPEventSetup();
                frm.ShowDialog();
            }
        }
    }
}
