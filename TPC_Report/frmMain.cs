using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPC_Report
{
    public partial class frmMain : Form
    {
        private string PowerNodeName = "電力監控報表";
        private string AlarmNodeName = "分析維護報表";
        private string[] strReport = new string[] { "饋線", "變壓器"};
        private string[] strType = new string[] { "日報表", "旬報表", "月報表", "報表" };
        private string[] strAReport = new string[] { "CB", "歷史警報", "歷史事件","歷史登入" };
        private int itemCount = 0;
        private List<string> m_strReportName;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            TreeNode PowerNode = new TreeNode();
            PowerNode.Text = PowerNodeName;
            treeView1.Nodes.Add(PowerNode);
            TreeNode AlarmNode = new TreeNode();
            AlarmNode.Text = AlarmNodeName;
            treeView1.Nodes.Add(AlarmNode);

            PowerNode.NodeFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            AlarmNode.NodeFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            m_strReportName = new List<string>();

            TreeNode[] pNode = new TreeNode[strReport.Length + strAReport.Length];
            TreeNode[,] prNode = new TreeNode[5, 3];
            for (int ii = 0; ii < strReport.Length+strAReport.Length; ii++)
            {
                if (ii < strReport.Length)
                {
                    pNode[ii] = new TreeNode();
                    pNode[ii].Text = strReport[ii];
                    pNode[ii].NodeFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                    PowerNode.Nodes.Add(pNode[ii]);
                    for (int jj = 0; jj < 3; jj++)
                    {
                        prNode[ii, jj] = new TreeNode();
                        prNode[ii, jj].Text = strReport[ii] + strType[jj];
                        prNode[ii, jj].NodeFont = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                        pNode[ii].Nodes.Add(prNode[ii, jj]);
                        prNode[ii, jj].ImageIndex = 2;
                        prNode[ii, jj].SelectedImageIndex = 2;

                        m_strReportName.Add(strReport[ii] + strType[jj]);

                        itemCount++;
                    }
                }
                else
                {
                   
                    if (ii == strReport.Length)
                    {
                        pNode[ii] = new TreeNode();
                        pNode[ii].Text = strAReport[ii - strReport.Length];
                        pNode[ii].NodeFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                        AlarmNode.Nodes.Add(pNode[ii]);
                        for (int jj = 0; jj < 3; jj++)
                        {
                            prNode[ii, jj] = new TreeNode();
                            prNode[ii, jj].Text = strAReport[ii - strReport.Length] + strType[jj];
                            prNode[ii, jj].NodeFont = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                            pNode[ii].Nodes.Add(prNode[ii, jj]);
                            prNode[ii, jj].ImageIndex = 2;
                            prNode[ii, jj].SelectedImageIndex = 2;

                            m_strReportName.Add(strAReport[ii - strReport.Length] + strType[jj]);

                            itemCount++;
                        }
                    }
                    else
                    {
                        pNode[ii] = new TreeNode();
                        pNode[ii].Text = strAReport[ii - strReport.Length] + strType[3];
                        pNode[ii].NodeFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                        AlarmNode.Nodes.Add(pNode[ii]);
                        m_strReportName.Add(strAReport[ii - strReport.Length] + strType[3]);
                        itemCount++;
                    }                    
                }
            }
            PowerNode.Expand();
            EditXml editXml = new EditXml();
            editXml.GetDB();

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            for (int i = 0; i < m_strReportName.Count(); i++)
            {
                if (e.Node.Text == m_strReportName[i])
                {
                    if (mainPanel.Controls.Count > 0)
                        mainPanel.Controls.Clear();
                    if (m_strReportName[i] == strReport[0] + strType[0])
                    {
                        var frm = new frmDayFeeder(this.treeView1);
                        mainPanel.Controls.Add(frm);
                        break;
                    }
                    else if (m_strReportName[i] == strReport[0] + strType[1])
                    {
                        var frm = new frmTenDayFeeder(this.treeView1);
                        mainPanel.Controls.Add(frm);
                        break;
                    }
                    else if (m_strReportName[i] == strReport[0] + strType[2])
                    {
                        var frm = new frmMonthFeeder();
                        mainPanel.Controls.Add(frm);
                        break;
                    }
                    else if (m_strReportName[i] == strReport[1] + strType[0])
                    {
                        var frm = new frmDayTransformer();
                        mainPanel.Controls.Add(frm);
                        break;
                    }
                    else if (m_strReportName[i] == strReport[1] + strType[1])
                    {
                        var frm = new frmTenDayTransformer();
                        mainPanel.Controls.Add(frm);
                        break;
                    }
                    else if (m_strReportName[i] == strReport[1] + strType[2])
                    {
                        var frm = new frmMonthTransformer();
                        mainPanel.Controls.Add(frm);
                        break;
                    }
                    //else if (m_strReportName[i] == strReport[2] + strType[0])
                    //{
                    //    var frm = new frmDay161kV();
                    //    mainPanel.Controls.Add(frm);
                    //    break;
                    //}
                    //else if (m_strReportName[i] == strReport[2] + strType[1])
                    //{
                    //    var frm = new frmTenDay161kV();
                    //    mainPanel.Controls.Add(frm);
                    //    break;
                    //}
                    //else if (m_strReportName[i] == strReport[2] + strType[2])
                    //{
                    //    var frm = new frmMonth161kV();
                    //    mainPanel.Controls.Add(frm);
                    //    break;
                    //}
                    else if (m_strReportName[i] == strAReport[0] + strType[0])
                    {
                        var frm = new frmDayCB();
                        mainPanel.Controls.Add(frm);
                        break;
                    }
                    else if (m_strReportName[i] == strAReport[0] + strType[1])
                    {
                        var frm = new frmTenDayCB();
                        mainPanel.Controls.Add(frm);
                        break;
                    }
                    else if (m_strReportName[i] == strAReport[0] + strType[2])
                    {
                        var frm = new frmMonthCB();
                        mainPanel.Controls.Add(frm);
                        break;
                    }
                    else if (m_strReportName[i] == strAReport[1] + strType[3])
                    {
                        var frm = new frmHistoryAlarm(this.treeView1);
                        mainPanel.Controls.Add(frm);
                        break;
                    }
                    else if (m_strReportName[i] == strAReport[2] + strType[3])
                    {
                        var frm = new frmHistoryEvent(this.treeView1);
                        mainPanel.Controls.Add(frm);
                        break;
                    }
                    else if (m_strReportName[i] == strAReport[3] + strType[3])
                    {
                        var frm = new frmHistoryLogin(this.treeView1);
                        mainPanel.Controls.Add(frm);
                        break;
                    }

                }
               
            }
        }
    }
}
