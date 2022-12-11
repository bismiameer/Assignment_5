using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Assignment_5
{
    public class Db
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public Db()
        {
            con.ConnectionString = "Data Source=NTP-LAP-928;Initial Catalog=registration;Integrated Security=True;Pooling=False";
            cmd.Connection = con;
        }
        public SqlConnection Getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void dbclose()
        {
            con.Close();
        }
        public int Executenonquery(String Sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sql;
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        public DataSet Executedataset(String sql)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public object Executescalar(String sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            object ob = cmd.ExecuteScalar();
            return ob;
        }
        public DataTable Executedatatable(String sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtobj = new DataTable();
            da.Fill(dtobj);
            return dtobj;
        }
        public void fillgrid(String sql, GridView dv)
        {
            dv.DataSource = Executedataset(sql);
            dv.DataBind();
        }
    }
}