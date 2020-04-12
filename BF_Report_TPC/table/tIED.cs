using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace TPCReport.Core.table
{
    public struct stuIED
    {
        public string IEDName;
        public int IEDID;
        public int IEDTypeID;
    }

    public class tIED
    {
        private string _strConnectionSetting;
        public tIED(string strConnectionSetting)
        {
            _strConnectionSetting = strConnectionSetting;
        }
        public stuIED[] GetData()
        {
            var feeder = new List<stuIED>();
            using(var sqlConn=new SqlConnection(_strConnectionSetting))
            {
                sqlConn.Open();
                string str = string.Format("SELECT * FROM [dbo].[tIED]");
                using(var sqlCmd=new SqlCommand(str, sqlConn))
                {
                    using (var sqlRdr = sqlCmd.ExecuteReader())
                    {
                        while (sqlRdr.Read())
                        {
                            var _feeder = new stuIED();
                            _feeder.IEDTypeID= sqlRdr.GetInt32(0);
                            _feeder.IEDID = sqlRdr.GetInt32(1);
                            _feeder.IEDName = sqlRdr.GetString(2);
                            feeder.Add(_feeder);
                        }                           
                    }
                }
            }
            return feeder.ToArray();
        }
        public stuIED[] GetData(int IEDTypeID)
        {
            var feeder = new List<stuIED>();
            using (var sqlConn = new SqlConnection(_strConnectionSetting))
            {
                sqlConn.Open();
                string str = string.Format("SELECT * FROM [dbo].[tIED] WHERE [IEDTypeID]={0}",IEDTypeID);
                using (var sqlCmd = new SqlCommand(str, sqlConn))
                {
                    using (var sqlRdr = sqlCmd.ExecuteReader())
                    {
                        while (sqlRdr.Read())
                        {
                            var _feeder = new stuIED();
                            _feeder.IEDTypeID = sqlRdr.GetInt32(0);
                            _feeder.IEDID = sqlRdr.GetInt32(1);
                            _feeder.IEDName = sqlRdr.GetString(2);
                            feeder.Add(_feeder);
                        }
                    }
                }
            }
            return feeder.ToArray();
        }
        public void DelectData(int Id)
        {
            string strSQL = "delete [dbo].[tFeeder]"
                          + " where [tFeederID]='" + Id.ToString() + "'";
            
            using (var sqlConn = new SqlConnection(_strConnectionSetting))
            {
                sqlConn.Open();
                using(var sqlCmd=new SqlCommand(strSQL, sqlConn))
                {
                    sqlCmd.ExecuteNonQuery();
                }
            }             
        }
        public void UpData(int Id,string FeederId, string FeederName)
        {
            string strSQL = "Update [dbo].[tFeeder] "
                          + " set [FeederID]=@V1, [FeederName]=@V2"
                          + " where [FeederID]='" + Id.ToString() + "'";
            using (var sqlConn = new SqlConnection(_strConnectionSetting))
            {
                sqlConn.Open();
                using (var sqlCmd = new SqlCommand(strSQL, sqlConn))
                {
                    sqlCmd.Parameters.AddWithValue("@V1", FeederId);
                    sqlCmd.Parameters.AddWithValue("@V2", FeederName);

                    sqlCmd.ExecuteNonQuery();
                }
            }         
        }
        public void AddData(string FeederId, string FeederName)
        {
            string strSQL = "Insert into [dbo].[tFeeder]"
                         + "([FeederID],[FeederName])"
                         + " values(@V1,@V2)";
            using (var sqlConn = new SqlConnection(_strConnectionSetting))
            {
                sqlConn.Open();
                using (var sqlCmd = new SqlCommand(strSQL, sqlConn))
                {
                    sqlCmd.Parameters.AddWithValue("@V1", FeederId);
                    sqlCmd.Parameters.AddWithValue("@V2", FeederName);

                    sqlCmd.ExecuteNonQuery();
                }
            }           
        }
    }
}
