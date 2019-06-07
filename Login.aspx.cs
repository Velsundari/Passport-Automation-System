using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Security;

namespace ASP_Login_Form {
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Page.User.Identity.IsAuthenticated)
            {
                string message = "Login Successful! ";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("');");
                ClientScript.RegisterOnSubmitStatement(this.GetType(), "alert", sb.ToString());
                Response.Redirect(FormsAuthentication.DefaultUrl);
            }
        }
        protected void Button_click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginConnectionString"].ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Table where uname=@Username and passwd=@Password", con);
                cmd.Parameters.AddWithValue("@Username", textbox1.Text);
                cmd.Parameters.AddWithValue("@Password", textbox2.Text);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {

                }
                else
                {
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}

