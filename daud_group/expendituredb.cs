using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daud_group
{
    class expendituredb
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;
        public string name, amount, date, expentidure;

        public expendituredb()
        {
            con = new SqlConnection("Data Source=DESKTOP-H03A9OV;Initial Catalog=daudfactorydb;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = con;
            da = new SqlDataAdapter();
            dt = new DataTable();
            con.Open();
        }
        public void Sqlcommand(string queryText)
        {
            cmd = new SqlCommand(queryText, con);
        }
        public DataTable QueryEx()
        {
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void NonQueryEx()
        {
            cmd.ExecuteNonQuery();
        }
        public DataTable selectall()
        {
            //cmd.Connection = con;
            da = new SqlDataAdapter("Select * from expenditures", con);
            da.Fill(dt);
            return dt;
        }
        public expendituredb get(int id)
        {
            cmd.Connection = con;
            da = new SqlDataAdapter("Select * from expenditures where id=" + id, con);
            da.Fill(dt);
            id = Int32.Parse(dt.Rows[0]["ID"].ToString());
            name = dt.Rows[0]["Name"].ToString();
            amount = dt.Rows[0]["amount"].ToString();
            date = dt.Rows[0]["date"].ToString();
            expentidure = dt.Rows[0]["expenditure_for"].ToString();
            return this;
        }
        public void update(int id, string name, int quantity, int weight)
        {
            cmd.Connection = con;
            cmd.CommandText = "UPDATE expenditures SET name =" + name + ", quantity=" + quantity + ",weight=" + weight + "WHERE id=" + id;
            da.Fill(dt);
        }
        public void delete(int id)
        {
            cmd.Connection = con;
            cmd.CommandText = "delete from expenditures where id='" + id + "';";
            da.Fill(dt);

        }
    }
}
