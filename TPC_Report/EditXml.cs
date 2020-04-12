using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TPC_Report
{
    public class EditXml
    {
        public static string strConnectionAlarms;
        public static string strConnectionSetting;
        public static string strConnectionHistory;
        string m_strXmlFile;

        public EditXml()
        {
            m_strXmlFile = this.GetType().Assembly.Location;
            m_strXmlFile = m_strXmlFile.Replace(".exe", ".xml");
        }
        public void GetDB()
        {
            strConnectionSetting = "server=" + GetXmlString("root/connectionsetting/server") + "; database=" + GetXmlString("root/connectionsetting/database") + ";uid=" + GetXmlString("root/connectionsetting/uid") + ";pwd=" + GetXmlString("root/connectionsetting/pwd");
            strConnectionHistory = "server=" + GetXmlString("root/connectionhistory/server") + "; database=" + GetXmlString("root/connectionhistory/database") + ";uid=" + GetXmlString("root/connectionhistory/uid") + ";pwd=" + GetXmlString("root/connectionhistory/pwd");
            strConnectionAlarms = "server=" + GetXmlString("root/connectionalarms/server") + "; database=" + GetXmlString("root/connectionalarms/database") + ";uid=" + GetXmlString("root/connectionalarms/uid") + ";pwd=" + GetXmlString("root/connectionalarms/pwd");
        }
        public string GetXmlString(string strNode)
        {
            //使用XmlDocument讀入XML格式資料
            XmlDocument xmlDoc = new XmlDocument();
            // string strPath = System.Windows.Forms.Application.StartupPath + strXmlFile;
            xmlDoc.Load(m_strXmlFile);
            //使用XmlNode讀取節點
            XmlNode strTag = xmlDoc.SelectSingleNode(strNode); //注意節點的指定方式
            return strTag.InnerText;
        }
    }
    
}
