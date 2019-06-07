using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace AppStat
{
    public partial class Status : Page     
    {
        StringBuilder table= new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {

           
                if (!Page.IsPostBack)
                {

                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from [status]";
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                con.Close();
               /*
                if (textbox2.Text == "1")
                    {
                        this.para.InnerText = "This is a test of dynamicly adding paragraph text";
                    }
                    else
                        this.para.InnerText = "wrong";*/
                   
                }
            
        }
    }
}