using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daud_group
{
    class customerdb
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;
        public int ids;
        public string name, address, phone;

        public customerdb()
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
            da = new SqlDataAdapter("Select * from customers", con);
            da.Fill(dt);
            return dt;
        }
        public customerdb get(int id)
        {
            cmd.Connection = con;
            da = new SqlDataAdapter("Select * from customers where ID=" + id, con);
            da.Fill(dt);
            id = Int32.Parse(dt.Rows[0]["ID"].ToString());
            name = dt.Rows[0]["Name"].ToString();
            address = dt.Rows[0]["address"].ToString();
            phone = dt.Rows[0]["phone"].ToString();
            return this;
        }
        public void update(int id, string name, int quantity, int weight)
        {
            cmd.Connection = con;
            cmd.CommandText = "UPDATE production_inventory SET name =" + name + ", quantity=" + quantity + ",weight=" + weight + "WHERE id=" + id;
            da.Fill(dt);
        }
        public void delete(int id)
        {
            cmd.Connection = con;
            cmd.CommandText = "delete from customers where id='" + id + "';";
            da.Fill(dt);
        }
    }
}
