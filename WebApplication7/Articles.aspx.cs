using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

namespace WebApplication7
{
    public partial class Articles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var connectionString = WebConfigurationManager.ConnectionStrings["FlexBricksTestConnectionString"].ToString();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "insert into Articles(articleTitle,ArticleText) values('" + this.TextBox1.Text + "','" + this.TextBox2.Text + "')";
                command.ExecuteNonQuery();
            }
            this.Response.Redirect("Articles.aspx");
        }

        protected void GetSelectedRecords(object sender, EventArgs e)
        {
            this.Response.Write("<h3>Selected records</h3>");

            foreach (GridViewRow row in this.GridView1.Rows)
            {
                var chk = (CheckBox) row.FindControl("chkSelect");
                if (chk.Checked)
                {
                }
                this.Response.Redirect("CheckIn.aspx");
            }
        }
    }
}