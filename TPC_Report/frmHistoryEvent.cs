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
    public partial class frmHistoryEvent : UserControl
    {
        TreeView _TreeView;
        ArrayList arrEventLevel;
        public frmHistoryEvent(TreeView treeView)
        {
            _TreeView = treeView;
            InitializeComponent();
        }

        private void frmHistoryEvent_Load(object sender, EventArgs e)
        {
            this.dateTimePicker2.MinDate = this.dateTimePicker1.Value;
            this.colorProgressBar1.Maximum = 10000;

            this.dataGridView1.ColumnCount = 7;
            this.dataGridView1.Columns[0].Name = "No";
            this.dataGridView1.Columns[1].Name = "警報等級";
            this.dataGridView1.Columns[2].Name = "日期";
            this.dataGridView1.Columns[3].Name = "時間";
            this.dataGridView1.Columns[4].Name = "識別位址";
            this.dataGridView1.Columns[5].Name = "計量值";
            this.dataGridView1.Columns[6].Name = "訊息";
            for (int ii = 0; ii < this.dataGridView1.ColumnCount; ii++)
            {
                this.dataGridView1.Columns[ii].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            var Level = new string[]
           {"ALL","重","中","輕"};
            ArrayList alData = new ArrayList();
            arrEventLevel = new ArrayList();
            for (int i = 0; i < Level.Length; i++)
            {
                this.cbxLevel.Items.Add("");
                alData.Add(new DictionaryEntry(Level[i], i));
            }

            arrEventLevel = new ArrayList();
            arrEventLevel = alData;

            this.cbxLevel.DisplayMember = "Key";
            this.cbxLevel.ValueMember = "Value";
            this.cbxLevel.DataSource = alData;
            arrEventLevel = alData;
        }

        private void btnClk_Click(object sender, EventArgs e)
        {
            StartRun_View();
            int type = (int)((dynamic)this.cbxLevel.SelectedItem).Value;
            DateTime SDate = Convert.ToDateTime(this.dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00");
            DateTime EDate = Convert.ToDateTime(this.dateTimePicker2.Value.AddDays(1).ToString("yyyy-MM-dd") + " 00:00:00");
            Task.Run(() =>
            {
                tAlarm mAlarm = new tAlarm(EditXml.strConnectionAlarms);
                var value = mAlarm.GetEvent(type, SDate, EDate);
                int AddBarValue = value.Length != 0 ? 9000 / value.Length : 9000;
                int no = 1;
                foreach (var item in value)
                {
                    string[] str = new string[] { no.ToString(),item.Level,item.DateTime.ToString("yyyy-MM-dd")
                        ,item.DateTime.ToString("hh:mm:ss"),item.name,item.values,item.message };
                    Invoke(new Action(() =>
                    {
                        dataGridView1.Rows.Add(str);
                        if (colorProgressBar1.Value < 9000)
                            colorProgressBar1.Value += AddBarValue;
                        else
                            colorProgressBar1.Value = 9800;
                    }));
                    Invoke(new Action(() =>
                    {
                        EndRun_View();
                    }));
                }
            });
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePicker2.MinDate = this.dateTimePicker1.Value;
            this.dateTimePicker2.Value = this.dateTimePicker1.Value;
        }
        private void StartRun_View()
        {
            _TreeView.Enabled = false;
            this.cbxLevel.Enabled = false;
            this.btnExcel.Enabled = false;
            this.btnPoint.Enabled = false;
            this.colorProgressBar1.Value = 0;
            this.dataGridView1.Rows.Clear();

        }
        private void EndRun_View()
        {
            _TreeView.Enabled = true;
            this.cbxLevel.Enabled = true;
            this.btnExcel.Enabled = true;
            this.btnPoint.Enabled = true;
            this.colorProgressBar1.Value = this.colorProgressBar1.Maximum;
        }
    }
}
