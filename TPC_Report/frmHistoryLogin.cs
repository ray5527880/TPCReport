using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using TPCReport.Core.table;

namespace TPC_Report
{
    public partial class frmHistoryLogin : UserControl
    {
        ArrayList arrUserLevel;
        TreeView _TreeView;
        public frmHistoryLogin(TreeView treeView)
        {
            _TreeView = treeView;
            InitializeComponent();
        }

        private void frmHistoryLogin_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnCount = 6;
            this.dataGridView1.Columns[0].Name = "No";
            this.dataGridView1.Columns[1].Name = "日期";
            this.dataGridView1.Columns[2].Name = "時間";
            this.dataGridView1.Columns[3].Name = "用戶名稱";
            this.dataGridView1.Columns[4].Name = "用戶等級";
            this.dataGridView1.Columns[5].Name = "訊息";
            for (int ii = 0; ii < this.dataGridView1.ColumnCount; ii++)
            {
                this.dataGridView1.Columns[ii].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            var Level = new string[]
           {"ALL","高","中","低"};
            ArrayList alData = new ArrayList();
            arrUserLevel = new ArrayList();
            for (int i = 0; i < Level.Length; i++)
            {
                this.cbxLevel.Items.Add("");
                alData.Add(new DictionaryEntry(Level[i], i));
            }

            arrUserLevel = new ArrayList();
            arrUserLevel = alData;

            this.cbxLevel.DisplayMember = "Key";
            this.cbxLevel.ValueMember = "Value";
            this.cbxLevel.DataSource = alData;
            arrUserLevel = alData;
        }

        private void btnClk_Click(object sender, EventArgs e)
        {

        }
    }
}
