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
using System.Xml;
using Newtonsoft.Json;
using System.Net;
using System.Collections.Generic;

/// <summary>
/// Summary description for getprice
/// </summary>
public class getprice
{
    static string _importantData;
    public static string goldprice
    {
        get
        {
            //gold.commoditySoapClient c = new gold.commoditySoapClient();


            //XElement x = c.GetGoldPrice();
            //string[] ar = x.Value.Split('|');



            ////_importantData = Convert.ToString(ar[2]);
            _importantData = GetGoldPrice();
            if (_importantData == null)
            {
                _importantData = "18600";
                return _importantData;
            }
            else
            {
                return _importantData;
            }
        }
        set
        {
            _importantData = value;
        }
    }
    public static string GetGoldPrice()
    {
        using (WebClient webClient = new WebClient())
        {

            XmlDocument doc = new XmlDocument();
            var response = webClient.DownloadString("http://ekyafoundation.org.in/ml_rate/rates.json");

            var rootRates = JsonConvert.DeserializeObject<List<GoldRate>>(response);
            return rootRates[0].rate1;
        }
    }
}
public class GoldRate
{
    public string id { get; set; }
    public string rate1 { get; set; }
    public string rate2 { get; set; }
    public string rate3 { get; set; }
    public string rate4 { get; set; }
    public string rate5 { get; set; }
    public string rate6 { get; set; }
}

