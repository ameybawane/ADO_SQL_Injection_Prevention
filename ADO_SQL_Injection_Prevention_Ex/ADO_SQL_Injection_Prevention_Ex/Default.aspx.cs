using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ADO_SQL_Injection_Prevention_Ex
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetDevice_Click(object sender, EventArgs e)
        {
            string db = ConfigurationManager.ConnectionStrings["dbSample"].ConnectionString;
            using (SqlConnection con = new SqlConnection(db))
            {
                SqlCommand cmd = new SqlCommand("sptblDevice", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DeviceName", tbGetDevice.Text + "%");
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();

                GridView1.Visible = true;

            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            tbGetDevice.Text = "";
            GridView1.Visible = false;
        }
    }
}