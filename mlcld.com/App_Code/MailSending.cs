using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

/// <summary>
/// Summary description for MailSending
/// </summary>
public class MailSending
{
	public Boolean SendingMail(string From, string To, string Subject,string Body)
	{
        try
        {
            MailMessage m = new MailMessage("ML COLOURLESS DIAMOND<promotion@mlcld.com>", "info@mlvaranium.com");
            m.Subject = Subject;
            m.Body = Body;
            m.CC.Add("naturalgemsindia@gmail.com");
           // m.CC.Add("info@mlvaranium.com");

            //m.CC.Add("man.thakur@ymail.com");
           // m.CC.Add("truthstar.future@gmail.com");
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "mail.mlcldkdmlnatu.in";
            NetworkCredential authinfo = new NetworkCredential("promotion@mlcld.com", "123456.com");
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = authinfo;
            smtp.Send(m);
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
	}
    public Boolean SendingMailCutomer(string From, string To, string Subject, string Body)
    {
        try
        {
            MailMessage m = new MailMessage("ML COLOURLESS DIAMOND<promotion@mlcld.com>", To);
            m.Subject = Subject;
            m.Body = Body;
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "mail.mlcldkdmlnatu.in";
            NetworkCredential authinfo = new NetworkCredential("permlkromotion@mlcld.in", "123456.com");
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = authinfo;
            smtp.Send(m);
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}
