using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

/// <summary>
/// Summary description for getamount
/// </summary>
public class getamount
{
    static string _importantData;

    public static string goldamount
    {
        get
        {
            //SqlConnection cn = null;
            //SqlDataReader dr = null;
            //try
            //{
            //    cn = new SqlConnection();
            //    cn.ConnectionString = ConfigurationManager.ConnectionStrings["mlcd"].ConnectionString;
            //    cn.Open();
            //    string sql = "SELECT * FROM MLCD_CurrentPrice";
            //    SqlCommand cmd = new SqlCommand(sql, cn);
            //    dr = cmd.ExecuteReader();
            //    if (dr.HasRows)
            //    {
            //        dr.Read();
            //        _importantData = dr["diamondrate"].ToString();
            //    }
            //    else
            //    {
            //        _importantData = "300";
            //    }


            //    dr.Close();
            //    cn.Close();


            //}
            //catch (Exception ex)
            //{
            //    if (dr != null)
            //    {
            //        dr.Close();
            //    }
            //    if (cn != null)
            //    {
            //        cn.Close();
            //    }
            //}
            return _importantData="0";
        }
        set
        {

            _importantData = value;
        }
    }
}
