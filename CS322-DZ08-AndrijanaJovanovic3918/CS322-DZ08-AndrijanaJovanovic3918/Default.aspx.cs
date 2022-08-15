using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CS322_DZ08_AndrijanaJovanovic3918
{
    public partial class _Default : Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Osoba values('" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "')",con);
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Data has been inserted";
            GridView1.DataBind();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";

                
         }
    }
}