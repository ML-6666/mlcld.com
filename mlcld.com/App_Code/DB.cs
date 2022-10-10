using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

/// <summary>
/// This CommonData Name have DB Class
/// </summary>
namespace CommonData
{
    public partial class DB
    {
        /*-----Function For Return Connection ------------------------------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static SqlConnection GetConnection()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["mlcd"].ToString();
            return cn;
        }

        /*-----Function For Close Connection -------------------------------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static void CloseConnection()
        {
            SqlConnection cn = GetConnection();
            if (cn.State == ConnectionState.Open)
                cn.Close();
        }

        /*-----Function For Execute Non Query------------------------------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static int ExecuteNonQuery(string query)
        {
            int i = 0;
            using (SqlConnection cn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                i = cmd.ExecuteNonQuery();
            }
            return i;
        }

        public static string ExecuteScaler(string query)
        {
            string i = "";
            using (SqlConnection cn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = query;
                i = cmd.ExecuteScalar().ToString();
            }
            return i;
        }
        
        /*-----Function For Open Connection --------------------------------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static void OpenConnection()
        {
            SqlConnection cn = GetConnection();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            cn.Close();
        }

        /*-----Function For Execute Non Query By Procedure------------------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static string ExecuteScaler(string DatabaseProcedureName, SqlParameter[] NewParameters)
        {
            string str ="";  
            using (SqlConnection cn = GetConnection()) 
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cn.Open();
                SqlParameter SParameter = new SqlParameter();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = DatabaseProcedureName;
                if (cmd.Parameters.Count > 0)
                    cmd.Parameters.Clear();
                foreach (SqlParameter LoopVarParam in NewParameters)
                {
                    SParameter = LoopVarParam;
                    cmd.Parameters.Add(SParameter);
                }
                 str = cmd.ExecuteScalar().ToString();
            }
            return str;
        }
        public static object ExecuteScalervalue(string DatabaseProcedureName, SqlParameter[] NewParameters)
        {
            object str = "";
            using (SqlConnection cn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cn.Open();
                SqlParameter SParameter = new SqlParameter();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = DatabaseProcedureName;
                if (cmd.Parameters.Count > 0)
                    cmd.Parameters.Clear();
                foreach (SqlParameter LoopVarParam in NewParameters)
                {
                    SParameter = LoopVarParam;
                    cmd.Parameters.Add(SParameter);
                }
                str = cmd.ExecuteScalar();
            }
            return str;
        }
        public static int ExecuteNonQueryByProc(string DatabaseProcedureName, SqlParameter[] NewParameters)
        {
            int i = 0;
            using (SqlConnection cn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cn.Open();
                SqlParameter SParameter = new SqlParameter();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = DatabaseProcedureName;
                if (cmd.Parameters.Count > 0)
                    cmd.Parameters.Clear();
                foreach (SqlParameter LoopVarParam in NewParameters)
                {
                    SParameter = LoopVarParam;
                    cmd.Parameters.Add(SParameter);
                }
                i = cmd.ExecuteNonQuery();
            }
            return i;
        }

        /*-----Function For Execute Reader ---------------------------------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static SqlDataReader ExecuteReader(string Query)
        {
            SqlDataReader dr = null;
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection cn = GetConnection())
            {
                cn.Open();
                cmd.CommandText = Query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();
            }
            return dr;
        }

        /*-----Function For Return Data Table ------------------------------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetDataTable(string Query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            using (SqlConnection cn = GetConnection())
            {
                try
                {
                    da = new SqlDataAdapter(Query, cn);
                    da.Fill(dt);

                }
                catch
                {
                    dt = null;
                }
                return dt;
            }
        }

        /*-----Function For Execute Query By Procedure----------------------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable ExecuteQueryByProc(string DatabaseProcedureName)
        {
            int i = 0;
            using (SqlConnection cn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand();
                DataTable dt = new DataTable();
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = DatabaseProcedureName;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }

        }

        /*-----Function For Execute Query By Procedure----------------------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable ExecuteQueryByProc(string DatabaseProcedureName, SqlParameter[] NewParameters)
        {
            int i = 0;
            using (SqlConnection cn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand();
                DataTable dt = new DataTable();
                cmd.Connection = cn;
                cn.Open();
                SqlParameter SParameter = new SqlParameter();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = DatabaseProcedureName;
                if (cmd.Parameters.Count > 0)
                    cmd.Parameters.Clear();
                foreach (SqlParameter LoopVarParam in NewParameters)
                {
                    SParameter = LoopVarParam;
                    cmd.Parameters.Add(SParameter);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }

        }

        /*-----Function For Return Data Table with 3 Argument---------------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataStatus(string TableName, string TableStatus, char StatusValue)
        {
            DataTable dt = DB.GetDataTable("select * from " + TableName + " where " + TableStatus + "=" + "'" + StatusValue + "'");
            return dt;
        }

        /*-----Function For Return Data Table with 5 Argument---------------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataStatus(string TableName, string TableStatus1, char StatusValue1, string TableStatus2, char StatusValue2)
        {
            string sql = "select * from " + TableName + " where " + TableStatus1 + "=" + "'" + StatusValue1 + "'" + " AND " + TableStatus2 + "=" + "'" + StatusValue2 + "'";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        public static DataTable GetTableDataStatusP(string TableName, string TableStatus1, string StatusValue1,  string StatusValue2, char status)
        {
            string sql = "select DID from " + TableName + " where " + TableStatus1 + " IN (" + "'" + StatusValue1 + "','" + StatusValue2 + "','" + status + "'" + ") AND Isactive=1";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with 3 Argument with Order By-------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataStatus(string TableName, string TableStatus, char StatusValue, string OderByColumn)
        {
            DataTable dt = DB.GetDataTable("select * from " + TableName + " where " + TableStatus + "=" + "'" + StatusValue + "'" + " ORDER BY " + OderByColumn + " DESC");
            return dt;
        }

        /*-----Function For Return Data Table with 5 Argument --------------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataStatus(string TableName, string ColumnName, string ColumnValue, string TableStatus, char StatusValue)
        {
            string sql = "select * from " + TableName + " where " + ColumnName + "=" + "'" + ColumnValue + "'" + " " + "AND" + " " + TableStatus + "=" + "'" + StatusValue + "'";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with 5 Argument with Order BY-------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataStatus(string TableName, string ColumnName, string ColumnValue, string TableStatus, char StatusValue, string OderByColumn)
        {
            string sql = "select * from " + TableName + " where " + ColumnName + "=" + "'" + ColumnValue + "'" + " " + "AND" + " " + TableStatus + "=" + "'" + StatusValue + "'" + " ORDER BY " + OderByColumn + " DESC";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with 5 Argument with Like-----------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataByLike(string TableName, string ColumnName1, string ColumnValue1, string TableStatus, char StatusValue)
        {
            string sql = "select * from " + TableName + " where " + ColumnName1 + " like " + "'" + ColumnValue1 + "%'" + " " + " AND " + " " + TableStatus + "=" + "'" + StatusValue + "'";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with 5 Argument with Between--------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataByBetween(string TableName, string ColumnName1, string ColumnValue11, string ColumnValue12, string TableStatus, char StatusValue)
        {
            string sql = "select * from " + TableName + " where " + ColumnName1 + " Between " + "'" + ColumnValue11 + "'" + "  AND " + "'" + ColumnValue12 + "'" + " AND " + " " + TableStatus + "=" + "'" + StatusValue + "'";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with 7 Argument --------------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataStatus(string TableName, string ColumnName1, string ColumnValue1, string ColumnName2, string ColumnValue2, string TableStatus, char StatusValue)
        {
            string sql = "select * from " + TableName + " where " + ColumnName1 + "=" + "'" + ColumnValue1 + "'" + " AND " + ColumnName2 + "=" + "'" + ColumnValue2 + "'" + " " + "AND" + " " + TableStatus + "=" + "'" + StatusValue + "'";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with 7 Argument with Order By-------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataStatus(string TableName, string ColumnName1, string ColumnValue1, string ColumnName2, string ColumnValue2, string TableStatus, char StatusValue, string OderByColumn)
        {
            string sql = "select * from " + TableName + " where " + ColumnName1 + "=" + "'" + ColumnValue1 + "'" + " AND " + ColumnName2 + "=" + "'" + ColumnValue2 + "'" + " " + "AND" + " " + TableStatus + "=" + "'" + StatusValue + "'" + " ORDER BY " + OderByColumn + " DESC";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with 7 Argument with Like-----------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataByLike(string TableName, string ColumnName1, string ColumnValue1, string ColumnName2, string ColumnValue2, string TableStatus, char StatusValue)
        {
            string sql = "select * from " + TableName + " where " + ColumnName1 + " like " + "'" + ColumnValue1 + "%'" + " " + " AND " + ColumnName2 + "=" + "'" + ColumnValue2 + "'" + " AND " + " " + TableStatus + "=" + "'" + StatusValue + "'";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with 7 Argument with Between--------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataByBetween(string TableName, string ColumnName1, string ColumnValue11, string ColumnValue12, string ColumnName2, string ColumnValue21, string TableStatus, char StatusValue)
        {
            string sql = "select * from " + TableName + " where " + ColumnName1 + " Between " + "'" + ColumnValue11 + "'" + "  AND " + "'" + ColumnValue12 + "'" + " AND " + ColumnName2 + "=" + "'" + ColumnValue21 + "'" + " " + " AND " + " " + TableStatus + "=" + "'" + StatusValue + "'";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with 9 Argument --------------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataStatus(string TableName, string ColumnName1, string ColumnValue1, string ColumnName2, string ColumnValue2, string TableStatus1, string StatusValue1, string TableStatus2, char StatusValue2)
        {
            string sql = "select * from " + TableName + " where " + ColumnName1 + "=" + "'" + ColumnValue1 + "'" + " AND " + ColumnName2 + "=" + "'" + ColumnValue2 + "'" + " " + " AND " + TableStatus1 + "=" + "'" + StatusValue1 + "'" + " AND " + " " + TableStatus2 + "=" + "'" + StatusValue2 + "'";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with 9 Argument with Order By-------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataStatus(string TableName, string ColumnName1, string ColumnValue1, string ColumnName2, string ColumnValue2, string TableStatus1, string StatusValue1, string TableStatus2, char StatusValue2, string OderByColumn)
        {
            string sql = "select * from " + TableName + " where " + ColumnName1 + "=" + "'" + ColumnValue1 + "'" + " AND " + ColumnName2 + "=" + "'" + ColumnValue2 + "'" + " " + " AND " + TableStatus1 + "=" + "'" + StatusValue1 + "'" + " AND " + " " + TableStatus2 + "=" + "'" + StatusValue2 + "'" + " ORDER BY " + OderByColumn + " DESC";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with 9 Argument with Like-----------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataByLike(string TableName, string ColumnName1, string ColumnValue1, string ColumnName2, string ColumnValue2, string TableStatus1, string StatusValue1, string TableStatus2, char StatusValue2)
        {
            string sql = "select * from " + TableName + " where " + ColumnName1 + " like " + "'" + ColumnValue1 + "%'" + " " + " AND " + ColumnName2 + "=" + "'" + ColumnValue2 + "'" + " " + " AND " + TableStatus1 + "=" + "'" + StatusValue1 + "'" + " AND " + " " + TableStatus2 + "=" + "'" + StatusValue2 + "'";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }
        
        /*-----Function For Return Data Table with 9 Argument with Between--------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataByBetween(string TableName, string ColumnName1, string ColumnValue11, string ColumnValue12, string ColumnName2, string ColumnValue21, string TableStatus1, string StatusValue1, string TableStatus2, char StatusValue2)
        {
            string sql = "select * from " + TableName + " where " + ColumnName1 + " Between " + "'" + ColumnValue11 + "'" + "  AND " + "'" + ColumnValue12 + "'" + " AND " + ColumnName2 + "=" + "'" + ColumnValue21 + "'" + " " + " AND " + TableStatus1 + "=" + "'" + StatusValue1 + "'" + " AND " + " " + TableStatus2 + "=" + "'" + StatusValue2 + "'";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*------------Function For Checking Duplicacy with 3 Argument-------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable CheckForDuplicacyStatus(string TableName, string ColumnName1, string ColumnValue1)
        {
            DataTable dt = DB.GetDataTable("select * from " + TableName + " where  " + ColumnName1 + "='" + ColumnValue1 + "'");
            return dt;
        }

        public static DataTable CheckForDuplicacy(string TableName, string ColumnName1, string ColumnValue1, string TableStatus, char StatusValue)
        {
            DataTable dt = DB.GetDataTable("select * from " + TableName + " where  " + ColumnName1 + "='" + ColumnValue1 + "' AND " + " " + TableStatus + "=" + "'" + StatusValue + "'");
            return dt;
        }

        /*------------Function For Checking Duplicacy with 5 Argument-------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable CheckForDuplicacy(string TableName, string ColumnName1, string ColumnValue1, string ColumnName2, string ColumnValue2, string TableStatus, char StatusValue)
        {
            DataTable dt = DB.GetDataTable("select * from " + TableName + " where  " + ColumnName1 + "='" + ColumnValue1 + "' AND " + ColumnName2 + "='" + ColumnValue2 + "' AND " + " " + TableStatus + "=" + "'" + StatusValue + "'");
            return dt;
        }

        /*------------Function For Checking Permission----------------------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static bool CheckForPermission(string TableName, string ColumnName, string ColumnValue, string PermissionName, char PermissionValue)
        {
            DataTable dt1 = DB.GetDataTable("select * from " + TableName + " where " + ColumnName + "=" + "'" + ColumnValue + "'" + " " + "AND" + " " + PermissionName + "=" + "'" + PermissionValue + "'");
            if (dt1 != null && dt1.Rows.Count > 0)
                return true;
            else
                return false;
        }

        /*------------Function For Fatch Top Record Integer Value-----------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static int FatchTopRecord(string TableName, string ReturnColumn, string TableStatus, char StatusValue)
        {
            try
            {
                DataTable dt = DB.GetDataTable("SELECT TOP 1 " + ReturnColumn + " FROM " + TableName + " WHERE " + " " + TableStatus + "=" + "'" + StatusValue + "'");
                if (String.IsNullOrEmpty(dt.Rows[0][0].ToString()))
                    return 0;
                else
                    return Convert.ToInt32(dt.Rows[0][0].ToString());

            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        /*------------Function For Fatch MIN Record Integer Value-----------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static int FatchMinRecordInt(string TableName, string ReturnColumn, string TableStatus, char StatusValue)
        {
            DataTable dt = DB.GetDataTable("SELECT MIN (" + ReturnColumn + ") FROM " + TableName + " WHERE " + " " + TableStatus + "=" + "'" + StatusValue + "'");
            if (String.IsNullOrEmpty(dt.Rows[0][0].ToString()))
                return 0;
            else
                return Convert.ToInt32(dt.Rows[0][0].ToString());

        }
        /*------------Function For Fatch MIN Record Double Value------------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static double FatchMinRecordDouble(string TableName, string ReturnColumn, string TableStatus, char StatusValue)
        {
            DataTable dt = DB.GetDataTable("SELECT MIN (" + ReturnColumn + ") FROM " + TableName + " WHERE " + " " + TableStatus + "=" + "'" + StatusValue + "'");
            if (String.IsNullOrEmpty(dt.Rows[0][0].ToString()))
                return 0.00;
            else
                return Convert.ToDouble(dt.Rows[0][0].ToString());

        }
    
        /*------------Function For Fatch MAX Record Integer Value-----------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static int FatchMaxRecord(string TableName, string ReturnColumn, string TableStatus, char StatusValue)
        {
            DataTable dt = DB.GetDataTable("SELECT MAX (" + ReturnColumn + ") FROM " + TableName + " WHERE " + " " + TableStatus + "=" + "'" + StatusValue + "'");
            if (String.IsNullOrEmpty(dt.Rows[0][0].ToString()))
                return 0;
            else
                return Convert.ToInt32(dt.Rows[0][0].ToString());

        }
        /*------------Function For Fatch MAX Record Double Value------------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static double FatchMaxRecordDouble(string TableName, string ReturnColumn, string TableStatus, char StatusValue)
        {
            DataTable dt = DB.GetDataTable("SELECT MAX (" + ReturnColumn + ") FROM " + TableName + " WHERE " + " " + TableStatus + "=" + "'" + StatusValue + "'");
            if (String.IsNullOrEmpty(dt.Rows[0][0].ToString()))
                return 0.00;
            else
                return Convert.ToDouble(dt.Rows[0][0].ToString());

        }
        /*------------Function For Fatching Column Name String Value-------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static string FatchColumnNameString(string TableName, string ColumnName1, string ColumnValue1, string ReturnColumn)
        {
            string sql = "select " + ReturnColumn + " from " + TableName + " where  " + ColumnName1 + "='" + ColumnValue1 + "'";
            DataTable dt = DB.GetDataTable(sql);
            if (String.IsNullOrEmpty(dt.Rows[0][0].ToString()))
                return "0";
            else
                return dt.Rows[0][0].ToString();
        }

        /*------------Function For Fatching Column Name String Value-------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static string FatchColumnNameString(string TableName, string ColumnName1, string ColumnValue1, string ReturnColumn, string TableStatus, char StatusValue)
        {
            string sql = "select " + ReturnColumn + " from " + TableName + " where  " + ColumnName1 + "='" + ColumnValue1 + "' AND " + " " + TableStatus + "=" + "'" + StatusValue + "'";
            DataTable dt = DB.GetDataTable(sql);
            if (String.IsNullOrEmpty(dt.Rows[0][0].ToString()))
                return "0";
            else
                return dt.Rows[0][0].ToString();
        }

        /*------------Function For Fatching Column Name Integer Value-------------------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static int FatchColumnName(string TableName, string ColumnName1, string ColumnValue1, string ReturnColumn, string TableStatus, char StatusValue)
        {
            string sql = "select " + ReturnColumn + " from " + TableName + " where  " + ColumnName1 + "='" + ColumnValue1 + "' AND " + " " + TableStatus + "=" + "'" + StatusValue + "'";
            DataTable dt = DB.GetDataTable(sql);
            if (String.IsNullOrEmpty(dt.Rows[0][0].ToString()))
                return 0;
            else
                return Convert.ToInt32(dt.Rows[0][0].ToString());
        }

        /*------------Function For Fatching SUM of Column Integer Value with 5 Argument-------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static int FatchColumnSum(string TableName, string ColumnName1, string ColumnValue1, string SumColumn, string TableStatus, char StatusValue)
        {
            DataTable dt = DB.GetDataTable("select " + " SUM " + " ( " + SumColumn + " ) " + " from " + TableName + " where  "+ ColumnName1 + "<'" + ColumnValue1 + "' AND " + " " + TableStatus + "=" + "'" + StatusValue + "'");
            if (String.IsNullOrEmpty(dt.Rows[0][0].ToString()))
                return 0;
            else
                return Convert.ToInt32(dt.Rows[0][0].ToString());
        }

        /*------------Function For Fatching SUM of Column Integer Value with 7 Argument-------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static int FatchColumnSum(string TableName, string ColumnName1, string ColumnValue1, string ColumnName2, string ColumnValue2, string SumColumn, string TableStatus, char StatusValue)
        {
            DataTable dt = DB.GetDataTable("select " + " SUM " + " ( " + SumColumn + " ) " + " from " + TableName + " where  " + ColumnName1 + "='" + ColumnValue1 + "' AND " + ColumnName2 + "<'" + ColumnValue2 + "' AND " + " " + TableStatus + "=" + "'" + StatusValue + "'");
            if (String.IsNullOrEmpty(dt.Rows[0][0].ToString()))
                return 0;
            else
                return Convert.ToInt32(dt.Rows[0][0].ToString());
        }
        
        /*-----Function For Return Data Table with Greater Case with 5 Argument---------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataGreater(string TableName, string GColumnName, string GColumnValue, string TableStatus, char StatusValue)
        {
            string sql = "select * from " + TableName + " where " + GColumnName + ">" + "'" + GColumnValue + "'" + " " + "AND" + " " + TableStatus + "=" + "'" + StatusValue + "'";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with Greater Case with 5 Argument with Order BY-------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataGreater(string TableName, string GColumnName, string GColumnValue, string TableStatus, char StatusValue, string OderByColumn)
        {
            string sql = "select * from " + TableName + " where " + GColumnName + ">" + "'" + GColumnValue + "'" + " " + "AND" + " " + TableStatus + "=" + "'" + StatusValue + "'" + " ORDER BY " + OderByColumn + " DESC";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }


        /*-----Function For Return Data Table with Greater Case with 7 Argument --------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataGreater(string TableName, string GColumnName1, string GColumnValue1, string ColumnName2, string ColumnValue2, string TableStatus, char StatusValue)
        {
            string sql = "select * from " + TableName + " where " + GColumnName1 + ">" + "'" + GColumnValue1 + "'" + " AND " + ColumnName2 + "=" + "'" + ColumnValue2 + "'" + " " + "AND" + " " + TableStatus + "=" + "'" + StatusValue + "'";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with Greater Case with 7 Argument with Order By-------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataGreater(string TableName, string GColumnName1, string GColumnValue1, string ColumnName2, string ColumnValue2, string TableStatus, char StatusValue, string OderByColumn)
        {
            string sql = "select * from " + TableName + " where " + GColumnName1 + ">" + "'" + GColumnValue1 + "'" + " AND " + ColumnName2 + "=" + "'" + ColumnValue2 + "'" + " " + "AND" + " " + TableStatus + "=" + "'" + StatusValue + "'" + " ORDER BY " + OderByColumn + " DESC";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with Greater Case with 9 Argument --------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataGreater(string TableName, string GColumnName1, string GColumnValue1, string ColumnName2, string ColumnValue2, string TableStatus1, string StatusValue1, string TableStatus2, char StatusValue2)
        {
            string sql = "select * from " + TableName + " where " + GColumnName1 + ">" + "'" + GColumnValue1 + "'" + " AND " + ColumnName2 + "=" + "'" + ColumnValue2 + "'" + " " + " AND " + TableStatus1 + "=" + "'" + StatusValue1 + "'" + " AND " + " " + TableStatus2 + "=" + "'" + StatusValue2 + "'";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with Greater Case with 9 Argument with Order By-------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataGreater(string TableName, string GColumnName1, string GColumnValue1, string ColumnName2, string ColumnValue2, string TableStatus1, string StatusValue1, string TableStatus2, char StatusValue2, string OderByColumn)
        {
            string sql = "select * from " + TableName + " where " + GColumnName1 + ">" + "'" + GColumnValue1 + "'" + " AND " + ColumnName2 + "=" + "'" + ColumnValue2 + "'" + " " + " AND " + TableStatus1 + "=" + "'" + StatusValue1 + "'" + " AND " + " " + TableStatus2 + "=" + "'" + StatusValue2 + "'" + " ORDER BY " + OderByColumn + " DESC";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with Greater Equal Case with 5 Argument---------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataGreaterEqual(string TableName, string GColumnName, string GColumnValue, string TableStatus, char StatusValue)
        {
            string sql = "select * from " + TableName + " where " + GColumnName + ">=" + "'" + GColumnValue + "'" + " " + "AND" + " " + TableStatus + "=" + "'" + StatusValue + "'";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with Greater Equal Case with 5 Argument with Order BY-------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataGreaterEqual(string TableName, string GColumnName, string GColumnValue, string TableStatus, char StatusValue, string OderByColumn)
        {
            string sql = "select * from " + TableName + " where " + GColumnName + ">=" + "'" + GColumnValue + "'" + " " + "AND" + " " + TableStatus + "=" + "'" + StatusValue + "'" + " ORDER BY " + OderByColumn + " DESC";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with Greater Equal Case with 7 Argument --------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataGreaterEqual(string TableName, string GColumnName1, string GColumnValue1, string ColumnName2, string ColumnValue2, string TableStatus, char StatusValue)
        {
            string sql = "select * from " + TableName + " where " + GColumnName1 + ">=" + "'" + GColumnValue1 + "'" + " AND " + ColumnName2 + "=" + "'" + ColumnValue2 + "'" + " " + "AND" + " " + TableStatus + "=" + "'" + StatusValue + "'";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with Greater Equal Case with 7 Argument with Order By-------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataGreaterEqual(string TableName, string GColumnName1, string GColumnValue1, string ColumnName2, string ColumnValue2, string TableStatus, char StatusValue, string OderByColumn)
        {
            string sql = "select * from " + TableName + " where " + GColumnName1 + ">=" + "'" + GColumnValue1 + "'" + " AND " + ColumnName2 + "=" + "'" + ColumnValue2 + "'" + " " + "AND" + " " + TableStatus + "=" + "'" + StatusValue + "'" + " ORDER BY " + OderByColumn + " DESC";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with Greater Equal Case with 9 Argument --------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataGreaterEqual(string TableName, string GColumnName1, string GColumnValue1, string ColumnName2, string ColumnValue2, string TableStatus1, string StatusValue1, string TableStatus2, char StatusValue2)
        {
            string sql = "select * from " + TableName + " where " + GColumnName1 + ">=" + "'" + GColumnValue1 + "'" + " AND " + ColumnName2 + "=" + "'" + ColumnValue2 + "'" + " " + " AND " + TableStatus1 + "=" + "'" + StatusValue1 + "'" + " AND " + " " + TableStatus2 + "=" + "'" + StatusValue2 + "'";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with Greater Equal Case with 9 Argument with Order By-------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataGreaterEqual(string TableName, string GColumnName1, string GColumnValue1, string ColumnName2, string ColumnValue2, string TableStatus1, string StatusValue1, string TableStatus2, char StatusValue2, string OderByColumn)
        {
            string sql = "select * from " + TableName + " where " + GColumnName1 + ">=" + "'" + GColumnValue1 + "'" + " AND " + ColumnName2 + "=" + "'" + ColumnValue2 + "'" + " " + " AND " + TableStatus1 + "=" + "'" + StatusValue1 + "'" + " AND " + " " + TableStatus2 + "=" + "'" + StatusValue2 + "'" + " ORDER BY " + OderByColumn + " DESC";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with Less Equal Case with 5 Argument------------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataLessEqual(string TableName, string LColumnName, string LColumnValue, string TableStatus, char StatusValue)
        {
            string sql = "select * from " + TableName + " where " + LColumnName + "<=" + "'" + LColumnValue + "'" + " " + "AND" + " " + TableStatus + "=" + "'" + StatusValue + "'";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with Less Equal Case with 5 Argument with Order BY----------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataLessEqual(string TableName, string LColumnName, string LColumnValue, string TableStatus, char StatusValue, string OderByColumn)
        {
            string sql = "select * from " + TableName + " where " + LColumnName + "<=" + "'" + LColumnValue + "'" + " " + "AND" + " " + TableStatus + "=" + "'" + StatusValue + "'" + " ORDER BY " + OderByColumn + " DESC";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }
        
        /*-----Function For Return Data Table with Less Equal Case with 7 Argument -----------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataLessEqual(string TableName, string LColumnName1, string LColumnValue1, string ColumnName2, string ColumnValue2, string TableStatus, char StatusValue)
        {
            string sql = "select * from " + TableName + " where " + LColumnName1 + "<=" + "'" + LColumnValue1 + "'" + " AND " + ColumnName2 + "=" + "'" + ColumnValue2 + "'" + " " + "AND" + " " + TableStatus + "=" + "'" + StatusValue + "'";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with Less Equal Case with 7 Argument with Order By----------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataLessEqual(string TableName, string LColumnName1, string LColumnValue1, string ColumnName2, string ColumnValue2, string TableStatus, char StatusValue, string OderByColumn)
        {
            string sql = "select * from " + TableName + " where " + LColumnName1 + "<=" + "'" + LColumnValue1 + "'" + " AND " + ColumnName2 + "=" + "'" + ColumnValue2 + "'" + " " + "AND" + " " + TableStatus + "=" + "'" + StatusValue + "'" + " ORDER BY " + OderByColumn + " DESC";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with Less Equal Case with 9 Argument -----------------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataLessEqual(string TableName, string LColumnName1, string LColumnValue1, string ColumnName2, string ColumnValue2, string TableStatus1, string StatusValue1, string TableStatus2, char StatusValue2)
        {
            string sql = "select * from " + TableName + " where " + LColumnName1 + "<=" + "'" + LColumnValue1 + "'" + " AND " + ColumnName2 + "=" + "'" + ColumnValue2 + "'" + " " + " AND " + TableStatus1 + "=" + "'" + StatusValue1 + "'" + " AND " + " " + TableStatus2 + "=" + "'" + StatusValue2 + "'";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }

        /*-----Function For Return Data Table with Less Equal Case with 9 Argument with Order By-------------*/
        /*------------------------------------------------------------------------------------------------*/
        public static DataTable GetTableDataLessEqual(string TableName, string LColumnName1, string LColumnValue1, string ColumnName2, string ColumnValue2, string TableStatus1, string StatusValue1, string TableStatus2, char StatusValue2, string OderByColumn)
        {
            string sql = "select * from " + TableName + " where " + LColumnName1 + "<=" + "'" + LColumnValue1 + "'" + " AND " + ColumnName2 + "=" + "'" + ColumnValue2 + "'" + " " + " AND " + TableStatus1 + "=" + "'" + StatusValue1 + "'" + " AND " + " " + TableStatus2 + "=" + "'" + StatusValue2 + "'" + " ORDER BY " + OderByColumn + " DESC";
            DataTable dt = DB.GetDataTable(sql);
            return dt;
        }
                
    }
}