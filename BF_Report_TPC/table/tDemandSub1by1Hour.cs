using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace TPCReport.Core.table
{
    public struct stuDemandSub
    {
        public int IEDID;
        public DateTime datetime;
        public decimal Ipr;
        public decimal Ips;
        public decimal Ipt;
        public decimal Ipn;
        public decimal Vpr;
        public decimal Vps;
        public decimal Vpt;
        public decimal Vpn;
        public decimal kW;
        public decimal kVar;
        public decimal kWh;
        public decimal kVarh;
        public decimal kWhN;
        public decimal kVarhN;
        public decimal Hz;
        public decimal PF;
        public decimal Tempature;
    }
    public class tDemandSub1by1Hour
    {

        string _strConnectionHistory;
        public tDemandSub1by1Hour(string strConnectionHistory)
        {
            _strConnectionHistory = strConnectionHistory;
        }
        public stuDemandSub[] GetData(int IEDID, DateTime StartTiem, DateTime EndTime)
        {
            var _DemandList = new List<stuDemandSub>();

            using (var sqlConn = new SqlConnection(_strConnectionHistory))
            {
                sqlConn.Open();
                var strTxt = string.Format("SELECT * FROM [dbo].[tDemandSub1by1Hour] WHERE [IEDID]=@V1 AND [E3TimeStamp]>=@V2 " +
                    "AND [E3TimeStamp]<@V3");
                using (var sqlCmd = new SqlCommand(strTxt, sqlConn))
                {
                    sqlCmd.Parameters.Add("@V1", SqlDbType.Int);
                    sqlCmd.Parameters.Add("@V2", SqlDbType.DateTime);
                    sqlCmd.Parameters.Add("@V3", SqlDbType.DateTime);
                    sqlCmd.Parameters["@V1"].SqlValue = IEDID;
                    sqlCmd.Parameters["@V2"].SqlValue = StartTiem;
                    sqlCmd.Parameters["@V3"].SqlValue = EndTime;
                    using (var reader = sqlCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new stuDemandSub()
                            {
                                IEDID = reader.GetInt32(0),
                                datetime = reader.GetDateTime(1),
                                Ipr = reader.GetDecimal(2),
                                Ipt = reader.GetDecimal(3),
                                Ips = reader.GetDecimal(4),
                                Ipn = reader.GetDecimal(5),
                                Vpr = reader.GetDecimal(6),
                                Vpt = reader.GetDecimal(7),
                                Vps = reader.GetDecimal(8),
                                Vpn = reader.GetDecimal(9),
                                kW = reader.GetDecimal(10),
                                kVar = reader.GetDecimal(11),
                                kWh = reader.GetDecimal(12),
                                kVarh = reader.GetDecimal(13),
                                kWhN = reader.GetDecimal(14),
                                kVarhN = reader.GetDecimal(15),
                                Hz = reader.GetDecimal(16),
                                PF = reader.GetDecimal(17),
                                Tempature = reader.GetDecimal(18)
                            };
                            _DemandList.Add(item);
                        }
                    }
                }
            }

            return _DemandList.ToArray();
        }
        public stuDemandSub GetDataByDay(int IEDID, DateTime StartTiem, DateTime EndTime)
        {
            var _Demand = new stuDemandSub();

            using (var sqlConn = new SqlConnection(_strConnectionHistory))
            {
                sqlConn.Open();
                decimal[] kWh = new decimal[2];
                decimal[] kVarh = new decimal[2];
                decimal[] kWhN = new decimal[2];
                decimal[] kVarhN = new decimal[2];

                var strTxt = string.Format("SELECT kWh,kVarh,kWhN,kVarhN FROM [dbo].[tDemandSub1by1Hour]" +
                    " WHERE [IEDID]=@V1 AND [E3TimeStamp]=@V2");
                using (var sqlCmd = new SqlCommand(strTxt, sqlConn))
                {
                    sqlCmd.Parameters.Add("@V1", SqlDbType.Int);
                    sqlCmd.Parameters.Add("@V2", SqlDbType.DateTime);
                    sqlCmd.Parameters["@V1"].SqlValue = IEDID;
                    sqlCmd.Parameters["@V2"].SqlValue = StartTiem;
                    using (var reader = sqlCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kWh[0] = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                            kVarh[0] = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                            kWhN[0] = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                            kVarhN[0] = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
                        }
                    }
                }
                strTxt = string.Format("SELECT kWh,kVarh,kWhN,kVarhN FROM [dbo].[tDemandSub1by1Hour]" +
                    " WHERE [IEDID]=@V1 AND [E3TimeStamp]=@V2");
                using (var sqlCmd = new SqlCommand(strTxt, sqlConn))
                {
                    sqlCmd.Parameters.Add("@V1", SqlDbType.Int);
                    sqlCmd.Parameters.Add("@V2", SqlDbType.DateTime);
                    sqlCmd.Parameters["@V1"].SqlValue = IEDID;
                    sqlCmd.Parameters["@V2"].SqlValue = EndTime;
                    using (var reader = sqlCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kWh[1] = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                            kVarh[1] = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                            kWhN[1] = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                            kVarhN[1] = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
                        }
                    }
                }
                _Demand.IEDID = IEDID;
                _Demand.datetime = StartTiem;
                _Demand.kWh = kWh[1] - kWh[0] > 0 ? kWh[1] - kWh[0] : kWh[1];
                _Demand.kVarh = kVarh[1] - kVarh[0] > 0 ? kVarh[1] - kVarh[0] : kVarh[1];
                _Demand.kWhN = kWhN[1] - kWhN[0] > 0 ? kWhN[1] - kWhN[0] : kWhN[1];
                _Demand.kVarhN = kVarhN[1] - kVarhN[0] > 0 ? kVarhN[1] - kVarhN[0] : kVarhN[1];


                strTxt = string.Format("SELECT AVG([Ipr])Ipr , AVG([Ips])Ips, AVG([Ipt])Ipt, AVG([Ipn])Ipn " +
                    ",AVG([Vpr])Vpr , AVG([Vps])Vps, AVG([Vpt])Vpt, AVG([Vpn])Vpn " +
                    ",AVG([kW])kW ,AVG([kVar])kVar,AVG([Hz])Hz,AVG([PF]),AVG([Tempature])Tempature" +
                    " FROM [dbo].[tDemandSub1by1Hour] WHERE [IEDID]=@V1 AND [E3TimeStamp]>=@V2 " +
                    "AND [E3TimeStamp]<@V3");
                using (var sqlCmd = new SqlCommand(strTxt, sqlConn))
                {
                    sqlCmd.Parameters.Add("@V1", SqlDbType.Int);
                    sqlCmd.Parameters.Add("@V2", SqlDbType.DateTime);
                    sqlCmd.Parameters.Add("@V3", SqlDbType.DateTime);
                    sqlCmd.Parameters["@V1"].SqlValue = IEDID;
                    sqlCmd.Parameters["@V2"].SqlValue = StartTiem;
                    sqlCmd.Parameters["@V3"].SqlValue = EndTime;
                    using (var reader = sqlCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _Demand.Ipr = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                            _Demand.Ipt = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                            _Demand.Ips = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                            _Demand.Ipn = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
                            _Demand.Vpr = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
                            _Demand.Vpt = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5);
                            _Demand.Vps = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);
                            _Demand.Vpn = reader.IsDBNull(7) ? 0 : reader.GetDecimal(7);
                            _Demand.kW = reader.IsDBNull(8) ? 0 : reader.GetDecimal(8);
                            _Demand.kVar = reader.IsDBNull(9) ? 0 : reader.GetDecimal(9);
                            _Demand.Hz = reader.IsDBNull(10) ? 0 : reader.GetDecimal(10);
                            _Demand.PF = reader.IsDBNull(11) ? 0 : reader.GetDecimal(11);
                            _Demand.Tempature = reader.IsDBNull(12) ? 0 : reader.GetDecimal(12);
                        }
                    }
                }
            }

            return _Demand;
        }
        public stuDemandSub[] GetDataByHour(int IEDID, DateTime StartTiem, DateTime EndTime)
        {

            var data = new List<stuDemandSub>();
            using (var sqlConn = new SqlConnection(_strConnectionHistory))
            {
                sqlConn.Open();
                for (int i = 0; i < 24; i++)
                {
                    var _Demand = new stuDemandSub();
                    DateTime STime = Convert.ToDateTime(StartTiem.ToString("yyyy-MM-dd") + string.Format(" {0:00}:00:00", i));
                    DateTime ETime = i == 23 ? Convert.ToDateTime(StartTiem.AddDays(1).ToString("yyyy-MM-dd") + string.Format(" 00:00:00")) :
                        Convert.ToDateTime(StartTiem.ToString("yyyy-MM-dd") + string.Format(" {0:00}:00:00", i + 1));
                    
                    decimal[] kWh = new decimal[2];
                    decimal[] kVarh = new decimal[2];
                    decimal[] kWhN = new decimal[2];
                    decimal[] kVarhN = new decimal[2];

                    var strTxt = string.Format("SELECT kWh,kVarh,kWhN,kVarhN FROM [dbo].[tDemandSub1by1Hour]" +
                        " WHERE [IEDID]=@V1 AND [E3TimeStamp]=@V2");
                    using (var sqlCmd = new SqlCommand(strTxt, sqlConn))
                    {
                        sqlCmd.Parameters.Add("@V1", SqlDbType.Int);
                        sqlCmd.Parameters.Add("@V2", SqlDbType.DateTime);
                        sqlCmd.Parameters["@V1"].SqlValue = IEDID;
                        sqlCmd.Parameters["@V2"].SqlValue = StartTiem;
                        using (var reader = sqlCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                kWh[0] = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                                kVarh[0] = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                                kWhN[0] = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                                kVarhN[0] = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
                            }
                        }
                    }
                    strTxt = string.Format("SELECT kWh,kVarh,kWhN,kVarhN FROM [dbo].[tDemandSub1by1Hour]" +
                        " WHERE [IEDID]=@V1 AND [E3TimeStamp]=@V2");
                    using (var sqlCmd = new SqlCommand(strTxt, sqlConn))
                    {
                        sqlCmd.Parameters.Add("@V1", SqlDbType.Int);
                        sqlCmd.Parameters.Add("@V2", SqlDbType.DateTime);
                        sqlCmd.Parameters["@V1"].SqlValue = IEDID;
                        sqlCmd.Parameters["@V2"].SqlValue = EndTime;
                        using (var reader = sqlCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                kWh[1] = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                                kVarh[1] = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                                kWhN[1] = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                                kVarhN[1] = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
                            }
                        }
                    }
                    _Demand.IEDID = IEDID;
                    _Demand.datetime = StartTiem;
                    _Demand.kWh = kWh[1] - kWh[0] > 0 ? kWh[1] - kWh[0] : kWh[1];
                    _Demand.kVarh = kVarh[1] - kVarh[0] > 0 ? kVarh[1] - kVarh[0] : kVarh[1];
                    _Demand.kWhN = kWhN[1] - kWhN[0] > 0 ? kWhN[1] - kWhN[0] : kWhN[1];
                    _Demand.kVarhN = kVarhN[1] - kVarhN[0] > 0 ? kVarhN[1] - kVarhN[0] : kVarhN[1];


                    strTxt = string.Format("SELECT AVG([Ipr])Ipr , AVG([Ips])Ips, AVG([Ipt])Ipt, AVG([Ipn])Ipn " +
                        ",AVG([Vpr])Vpr , AVG([Vps])Vps, AVG([Vpt])Vpt, AVG([Vpn])Vpn " +
                        ",AVG([kW])kW ,AVG([kVar])kVar,AVG([Hz])Hz,AVG([PF]),AVG([Tempature])Tempature" +
                        " FROM [dbo].[tDemandSub1by1Hour] WHERE [IEDID]=@V1 AND [E3TimeStamp]>=@V2 " +
                        "AND [E3TimeStamp]<@V3");
                    using (var sqlCmd = new SqlCommand(strTxt, sqlConn))
                    {
                        sqlCmd.Parameters.Add("@V1", SqlDbType.Int);
                        sqlCmd.Parameters.Add("@V2", SqlDbType.DateTime);
                        sqlCmd.Parameters.Add("@V3", SqlDbType.DateTime);
                        sqlCmd.Parameters["@V1"].SqlValue = IEDID;
                        sqlCmd.Parameters["@V2"].SqlValue = StartTiem;
                        sqlCmd.Parameters["@V3"].SqlValue = EndTime;
                        using (var reader = sqlCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                _Demand.Ipr = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                                _Demand.Ipt = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                                _Demand.Ips = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                                _Demand.Ipn = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
                                _Demand.Vpr = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
                                _Demand.Vpt = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5);
                                _Demand.Vps = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);
                                _Demand.Vpn = reader.IsDBNull(7) ? 0 : reader.GetDecimal(7);
                                _Demand.kW = reader.IsDBNull(8) ? 0 : reader.GetDecimal(8);
                                _Demand.kVar = reader.IsDBNull(9) ? 0 : reader.GetDecimal(9);
                                _Demand.Hz = reader.IsDBNull(10) ? 0 : reader.GetDecimal(10);
                                _Demand.PF = reader.IsDBNull(11) ? 0 : reader.GetDecimal(11);
                                _Demand.Tempature = reader.IsDBNull(12) ? 0 : reader.GetDecimal(12);
                            }
                        }
                    }
                    data.Add(_Demand);
                }
            }

            return data.ToArray();
        }
    }
}
