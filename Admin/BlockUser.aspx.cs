using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5.Admin
{
    public partial class BlockUser : System.Web.UI.Page
    {
        Db db = new Db();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = db.Executedataset("select * from Employee e inner join login l on e.loginid=l.loginid where l.status='request'");
                GridView1.DataBind();

                GridView2.DataSource = db.Executedataset("select * from Employee e inner join login l on e.loginid=l.loginid where l.status='Blocked'");
                GridView2.DataBind();
            }
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
            db.Executenonquery("update login set status='Blocked' where loginid='" + id + "'");

            GridView1.DataSource = db.Executedataset("select * from Employee e inner join login l on e.loginid=l.loginid where status='request'");
            GridView2.DataSource = db.Executedataset("select * from Employee e inner join login l on e.loginid=l.loginid where status='Blocked'");
            GridView1.DataBind();
            GridView2.DataBind();
        }
    }
}