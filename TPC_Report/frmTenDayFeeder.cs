using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;
using System.Data.SqlClient;
using System.Threading.Tasks;

using TPCReport.Core.table;


namespace TPC_Report
{
    public partial class frmTenDayFeeder : UserControl
    {
        tIED mtIED;
        tDemandSub1by1Hour mtDemandSub1By1Hour;
        ArrayList arrFeederList;
        TreeView _treeView;
        public frmTenDayFeeder(TreeView treeView)
        {
            InitializeComponent();
            _treeView = treeView;
        }

        private void frmTenDayFeeder_Load(object sender, EventArgs e)
        {
            this.colorProgressBar1.Maximum = 10000;
            this.colorProgressBar1.Minimum = 0;

            this.dateTimePicker1.CustomFormat = "yyyy-MM";
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //this.dateTimePicker1.ShowUpDown = true;

            this.dataGridView1.ColumnCount = 8;
            this.dataGridView1.Columns[0].Name = "No";
            this.dataGridView1.Columns[1].Name = "日期";
            this.dataGridView1.Columns[2].Name = "名稱";
            this.dataGridView1.Columns[3].Name = "R相電流";
            this.dataGridView1.Columns[4].Name = "S相電流";
            this.dataGridView1.Columns[5].Name = "T相電流";
            this.dataGridView1.Columns[6].Name = "N相電流";
            this.dataGridView1.Columns[7].Name = "kWh";
            for (int ii = 0; ii < this.dataGridView1.ColumnCount; ii++)
            {
                this.dataGridView1.Columns[ii].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            setFeederCombox();

        }
        private void setFeederCombox()
        {
            ArrayList alData = new ArrayList();
            arrFeederList = new ArrayList();
            mtIED = new tIED(EditXml.strConnectionSetting);

            foreach (var item in mtIED.GetData(1))
            {
                this.cbxFeeder.Items.Add("");
                alData.Add(new DictionaryEntry(item.IEDName, item.IEDID));
            }

            arrFeederList = new ArrayList();
            arrFeederList = alData;

            this.cbxFeeder.DisplayMember = "Key";
            this.cbxFeeder.ValueMember = "Value";
            this.cbxFeeder.DataSource = alData;
            arrFeederList = alData;

            this.cbxFeeder.Visible = true;
        }

        private void btnClk_Click(object sender, EventArgs e)
        {
            if (this.btnClk.Text == "查詢")
            {
                DateTime startTime, EndTime;
                var selectedMeter = (dynamic)this.cbxFeeder.SelectedItem;
                if (rdo1st.Checked)
                {
                    startTime = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM") + "-01 00:00:00");
                    EndTime = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM") + "-11 00:00:00");
                }
                else if (rdo2sd.Checked)
                {
                    startTime = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM") + "-11 00:00:00");
                    EndTime = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM") + "-21 00:00:00");
                }
                else if (rdo3th.Checked)
                {
                    startTime = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM") + "-21 00:00:00");
                    EndTime = Convert.ToDateTime(dateTimePicker1.Value.AddMonths(1).ToString("yyyy-MM") + "-01 00:00:00");
                }
                else
                {
                    return;
                }
                _treeView.Enabled = false;
                colorProgressBar1.Value = 0;


                this.btnClk.Text = "停止";
                Task.Run(() =>
                {
                    mtDemandSub1By1Hour = new tDemandSub1by1Hour(EditXml.strConnectionHistory);
                    for (int i = 0; i < (EndTime - startTime).Days; i++)
                    {
                        DateTime _startTime = Convert.ToDateTime(startTime.AddDays(i).ToString("yyyy-MM-dd") + " 00:00:00");
                        DateTime _EndTime = _startTime.AddDays(1);
                        var value = mtDemandSub1By1Hour.GetDataByDay((int)selectedMeter.Value, _startTime, _EndTime);
                        string[] strRow = new string[]
                       {
                            (i+1).ToString(),value.datetime.ToString("yyyy-MM-dd"),selectedMeter.Key.ToString(),value.Ipr.ToString(),
                            value.Ips.ToString(),value.Ipt.ToString(),value.Ipn.ToString(),value.kWh.ToString()
                       };
                        this.Invoke(new Action(() => { dataGridView1.Rows.Add(strRow); }));
                    }
                });
                _treeView.Enabled = true;
            }
            else
            {
                this.btnClk.Text = "查詢";
            }
        }
        private void TheadData()
        {
            DateTime startTime, EndTime;
            var selectedMeter = (dynamic)this.cbxFeeder.SelectedItem;
            if (rdo1st.Checked)
            {
                startTime = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM") + "-01 00:00:00");
                EndTime = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM") + "-11 00:00:00");
            }
            else if (rdo2sd.Checked)
            {
                startTime = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM") + "-11 00:00:00");
                EndTime = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM") + "-21 00:00:00");
            }
            else if (rdo3th.Checked)
            {
                startTime = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM") + "-21 00:00:00");
                EndTime = Convert.ToDateTime(dateTimePicker1.Value.AddMonths(1).ToString("yyyy-MM") + "-01 00:00:00");
            }
            else
            {
                return;
            }

            mtDemandSub1By1Hour = new tDemandSub1by1Hour(EditXml.strConnectionHistory);
            var value = mtDemandSub1By1Hour.GetData(selectedMeter, startTime, EndTime);
            int no = 0;
            foreach (var item in value)
            {
                string[] strRow = new string[]
                {
                    no.ToString(),item.datetime.ToString("yyyy-MM-dd"),selectedMeter,item.Ipr.ToString(),
                    item.Ips.ToString(),item.Ipt.ToString(),item.Ipn.ToString(),item.kWh.ToString()
                };
                this.Invoke(new Action(() => { dataGridView1.Rows.Add(strRow); }));

            }

        }
        private void UpdataView()
        {

        }
    }
}
