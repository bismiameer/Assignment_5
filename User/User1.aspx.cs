using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5.User
{
    public partial class User1 : System.Web.UI.Page
    {
        Db db = new Db();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = db.Executedataset("select * from Employee where loginid='" + Session["uid"] + "'");
                GridView1.DataBind();
            }
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string _id = GridView1.DataKeys[e.RowIndex].Value.ToString();
            db.Executenonquery("delete from Employee where EmployeeId='" + _id + "'");
            GridView1.DataSource = db.Executenonquery("select * from Employee where loginid='" + Session["uid"] + "'");
            GridView1.DataBind();

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = db.Executedataset("select * from Employee where loginid='" + Session["uid"] + "'");
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = db.Executedataset("select * from Employee where loginid='" + Session["uid"] + "'");
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string empid = GridView1.DataKeys[e.RowIndex].Value.ToString();

            TextBox txtname = new TextBox();
            txtname = (TextBox)GridView1.Rows[e.RowIndex].Cells[0].Controls[0];
            TextBox txtemail = new TextBox();
            txtemail = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
            TextBox txtphone = new TextBox();
            txtphone = (TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0];
            TextBox txtage = new TextBox();
            txtage = (TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0];


            db.Executenonquery("update Employee set Name='" + txtname.Text + "',Email='" + txtemail.Text + "',Phone='" + txtphone.Text + "',Age='" + txtage.Text + "' where EmployeeId='" + empid + "'");

            GridView1.EditIndex = -1;
            GridView1.DataSource = db.Executedataset("select * from Employee where loginid='" + Session["uid"] + "'");
            GridView1.DataBind();
        }
    }
}