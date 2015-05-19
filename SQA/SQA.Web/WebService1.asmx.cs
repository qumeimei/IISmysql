using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data.Odbc;
using System.Web.Configuration;


namespace SQA.Web
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        //string ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Port=3306;Database=bim;uid=root;pwd=root;option=3;";
        

        //string constr = "server=localhost;user=root;pwd=root;database=bim;";

        //string constr = ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
        string ConnStr = WebConfigurationManager.ConnectionStrings["mysql"].ConnectionString;

        [WebMethod]
        public string ExecuteScalar(string sql)
        {
            try
            {
                string result = "";
               
                //using (MySqlConnection conn = new MySqlConnection(constr))
                using (OdbcConnection con=new OdbcConnection(ConnStr))
                {
                    //using (MySqlCommand cmd = new MySqlCommand())\
                    using(OdbcCommand cmd=new OdbcCommand())
                    {
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = sql;
                        result = cmd.ExecuteScalar() + "";
                        con.Close();
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [WebMethod]
        public string ExecuteNonQuery(string sql)
        {
            try
            {
                long i = 0;
                using (OdbcConnection con = new OdbcConnection(ConnStr))
                {
                    using (OdbcCommand cmd = new OdbcCommand())
                    {
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = sql;
                        i = cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                return i + " row(s) affected by the last command, no resultset returned.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }  
    }
}
