using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using TPCReport.Core.table;
//using BF_Report_TPC.table;

namespace TPC_Report
{
    public partial class frmDayFeeder : UserControl
    {
        private CancellationTokenSource tokenSource;
        private TreeView _treeView;

        private ArrayList arrFeederList;
        private tIED mtIED;


        public frmDayFeeder(TreeView treeView)
        {
            _treeView = treeView;
            InitializeComponent();
        }

        private void frmDayFeeder_Load(object sender, EventArgs e)
        {
            this.colorProgressBar1.Maximum = 10000;
            this.dataGridView1.ColumnCount = 9;
            this.dataGridView1.Columns[0].Name = "No";
            this.dataGridView1.Columns[1].Name = "日期";
            this.dataGridView1.Columns[2].Name = "時間";
            this.dataGridView1.Columns[3].Name = "名稱";
            this.dataGridView1.Columns[4].Name = "R相電流";
            this.dataGridView1.Columns[5].Name = "S相電流";
            this.dataGridView1.Columns[6].Name = "T相電流";
            this.dataGridView1.Columns[7].Name = "N相電流";
            this.dataGridView1.Columns[8].Name = "kWh";
            for (int ii = 0; ii < this.dataGridView1.ColumnCount; ii++)
            {
                this.dataGridView1.Columns[ii].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            setIEDCombox();
        }

        private void setIEDCombox()
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


        private void btnClick_Click(object sender, EventArgs e)
        {
            if (btnClick.Text == "查詢")
            {
                StarttRun_View();
                this.btnClick.Text = "停止";
                DateTime startTime = Convert.ToDateTime(this.dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00");
                DateTime endTime = Convert.ToDateTime(this.dateTimePicker1.Value.AddDays(1).ToString("yyyy-MM-dd") + " 00:00:00");
                var _IED = (dynamic)this.cbxFeeder.SelectedItem;
                Task.Run(() =>
                {
                    tDemandSub1by1Hour mDemand = new tDemandSub1by1Hour(EditXml.strConnectionHistory);
                    var data = mDemand.GetDataByHour((int)_IED.Value, startTime, endTime);
                    for (int i = 0; i < 24; i++)
                    {
                        string[] str = new string[]
                        {
                            (i + 1).ToString(), startTime.ToString("yyyy-MM-dd"), string.Format(" {0:00}:00:00", i),(string)_IED.Key
                            , data[i].Ipr.ToString(), data[i].Ips.ToString(), data[i].Ipt.ToString(), data[i].Ipn.ToString(), data[i].kWh.ToString()
                        };
                        Invoke(new Action(() =>
                        {
                            dataGridView1.Rows.Add(str);
                        }));
                    }
                });
                EndRun_View();
            }
            else
            {
                this.btnClick.Text = "查詢";
                EndRun_View();
            }
        }
       
        private void ThreadData()
        {

        }
        private void StarttRun_View()
        {
            _treeView.Enabled = false;
            this.btn_Pie.Enabled = false;
            this.btn_Line.Enabled = false;
            this.btn_Bar.Enabled = false;
            this.btn_Excel.Enabled = false;
            this.btn_Point.Enabled = false;

            this.colorProgressBar1.Value = 0;

            this.dataGridView1.Rows.Clear();
            

        }
        private void EndRun_View()
        {
            _treeView.Enabled = true;
            this.btn_Pie.Enabled = true;
            this.btn_Line.Enabled = true;
            this.btn_Bar.Enabled = true;
            this.btn_Excel.Enabled = true;
            this.btn_Point.Enabled = true;



            this.colorProgressBar1.Value = this.colorProgressBar1.Maximum;

        }
        private void ThreadExcel()
        {

        }
    }
}
