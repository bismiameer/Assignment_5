using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Assignment_5.Guest
{
    public partial class Login : System.Web.UI.Page
    {
        Db db = new Db();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM login WHERE username='" + txtuname.Text + "' AND password='" + txtpswd.Text + "'";
            DataTable dtobj = db.Executedatatable(sql);

            if (dtobj.Rows.Count == 1)
            {

                Session["uid"] = dtobj.Rows[0]["loginid"];
                Session["uname"] = dtobj.Rows[0]["username"].ToString();
                string a = dtobj.Rows[0]["type"].ToString().Trim();

                if (a == "Admin")
                {
                    Response.Write("<script>alert('Admin Login ')</script>");
                    Response.Redirect("../Admin/Admin1.aspx");
                }
                else
                {
                    string c = dtobj.Rows[0]["status"].ToString().Trim();
                    if (c == "Confirmed")
                    {
                        Response.Write("<script>alert('Successfully logged in')</script>");
                        Response.Redirect("../User/User1.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Failed to login')</script>");
                        Response.Redirect("../Guest/Guest1.aspx");
                    }
                }
            }
        }
    }
}