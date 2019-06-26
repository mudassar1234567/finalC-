using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daud_group
{
    class ordersdb
    {
        public SqlConnection con;
        public string name;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;

        public ordersdb()
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
        public DataTable selectall(string namez)
        {
            //cmd.Connection = con;
            da = new SqlDataAdapter("select * from orders where customer='" + namez + "'", con);
            da.Fill(dt);
            return dt;
        }
        public DataTable selectal()
        {
            //cmd.Connection = con;
            da = new SqlDataAdapter("Select * from orders", con);
            da.Fill(dt);
            return dt;
        }
        public ordersdb get(int id)
        {
            da = new SqlDataAdapter("Select * from customers where id=" + id, con);
            da.Fill(dt);
            id = Int32.Parse(dt.Rows[0]["ID"].ToString());
            name = dt.Rows[0]["Name"].ToString();
            return this;
        }
        public void update(int id, string name, int quantity, int weight)
        {
            cmd.Connection = con;
            cmd.CommandText = "UPDATE orders SET name =" + name + ", quantity=" + quantity + ",weight=" + weight + "WHERE id=" + id;
            da.Fill(dt);
        }
        public void delete(int id)
        {
            cmd.Connection = con;
            cmd.CommandText = "delete from orders where id='" + id + "';";
            da.Fill(dt);

        }
    }
}
