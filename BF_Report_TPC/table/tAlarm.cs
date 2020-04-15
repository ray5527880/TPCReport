using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace TPCReport.Core.table
{
    public struct Alarm
    {
        public string Level;
        public DateTime DateTime;
        public string name;
        public string values;
        public string message;
    }
    public class tAlarm
    {
        
        public string _strConnectionAlarm;
        public tAlarm(string strConnectionAlarm)
        {
            _strConnectionAlarm = strConnectionAlarm;
        }
        public Alarm[] GetAlarms(int type,DateTime SDate,DateTime EDate)
        {
            var value = new List<Alarm>();
            string strType = string.Empty;
            switch (type)
            {
                case 0:
                    strType = "([SubConditionName]='Hi' OR [SubConditionName]='No' OR [SubConditionName]='Lo')";
                    break; 
                case 1:
                    strType = "[SubConditionName]='Hi' ";
                    break;
                case 2:
                    strType = "[SubConditionName]='No' ";
                    break;
                case 3:
                    strType = "[SubConditionName]='Lo'";
                    break;
            }
            using(var sqlConn=new SqlConnection(_strConnectionAlarm))
            {
                sqlConn.Open();
                string sqlTXT = string.Format("SELECT * FROM [dbo].[Alarms] WHERE [E3TimeStamp]>=@V1 AND " +
                    "[E3TimeStamp]<@V2 AND {0} AND [EventType]='Alarm' ORDER BY [E3TimeStamp]",strType);
                using (var sqlCmd = new SqlCommand(sqlTXT, sqlConn))
                {
                    sqlCmd.Parameters.Add("@V1", SqlDbType.DateTime);
                    sqlCmd.Parameters.Add("@V2", SqlDbType.DateTime);
                    sqlCmd.Parameters["@V1"].SqlValue = SDate;
                    sqlCmd.Parameters["@V2"].SqlValue = EDate;
                    using (var sqlRdr = sqlCmd.ExecuteReader())
                    {
                        while (sqlRdr.Read())
                        {
                            var item = new Alarm() 
                            {
                                DateTime = Convert.ToDateTime(sqlRdr["E3TimeStamp"]) ,
                                Level=Convert.ToString(sqlRdr["SubConditionName"]),
                                message=Convert.ToString(sqlRdr["Message"]),
                                name= Convert.ToString(sqlRdr["UserField1"]),
                                values = Convert.ToString(sqlRdr["FormattedValue"])
                            };
                            value.Add(item);
                        }
                    }
                }
            }
            return value.ToArray();
        }
        public Alarm[] GetEvent(int type, DateTime SDate, DateTime EDate)
        {
            var value = new List<Alarm>();
            string strType = string.Empty;
            switch (type)
            {
                case 0:
                    strType = "([SubConditionName]='Hi' OR [SubConditionName]='No' OR [SubConditionName]='Lo')";
                    break;
                case 1:
                    strType = "[SubConditionName]='Hi' ";
                    break;
                case 2:
                    strType = "[SubConditionName]='No' ";
                    break;
                case 3:
                    strType = "[SubConditionName]='Lo'";
                    break;
            }
            using (var sqlConn = new SqlConnection(_strConnectionAlarm))
            {
                sqlConn.Open();
                string sqlTXT = string.Format("SELECT * FROM [dbo].[Alarms] WHERE [E3TimeStamp]>=@V1 AND " +
                    "[E3TimeStamp]<@V2 AND {0} AND [EventType]='Event' ORDER BY [E3TimeStamp]", strType);
                using (var sqlCmd = new SqlCommand(sqlTXT, sqlConn))
                {
                    sqlCmd.Parameters.Add("@V1", SqlDbType.DateTime);
                    sqlCmd.Parameters.Add("@V2", SqlDbType.DateTime);
                    sqlCmd.Parameters["@V1"].SqlValue = SDate;
                    sqlCmd.Parameters["@V2"].SqlValue = EDate;
                    using (var sqlRdr = sqlCmd.ExecuteReader())
                    {
                        while (sqlRdr.Read())
                        {
                            var item = new Alarm()
                            {
                                DateTime = Convert.ToDateTime(sqlRdr["E3TimeStamp"]),
                                Level = Convert.ToString(sqlRdr["SubConditionName"]),
                                message = Convert.ToString(sqlRdr["Message"]),
                                name = Convert.ToString(sqlRdr["UserField1"]),
                                values = Convert.ToString(sqlRdr["FormattedValue"])
                            };
                            value.Add(item);
                        }
                    }
                }
            }
            return value.ToArray();
        }

    }
}
