using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daud_group
{
    class productsdb
    {
        int id;
        public string name;
        public int quantity;
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;

        public productsdb()
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
            da = new SqlDataAdapter("Select product_id as product_id, name as Name, unit_price as unit_price, Ready as Ready from Products", con);
            da.Fill(dt);
            return dt;
        }



        public productsdb get(int id)
        {
            da = new SqlDataAdapter("Select * from Products where product_id=" + id, con);
            da.Fill(dt);
            id = Int32.Parse(dt.Rows[0]["product_id"].ToString());
            name = dt.Rows[0]["name"].ToString();
            quantity = Int32.Parse(dt.Rows[0]["Ready"].ToString());
            return this;
        }

        public void update(int id, string name, int quantity, int weight)
        {
            cmd.Connection = con;
            cmd.CommandText = "UPDATE products SET name =" + name + ", quantity=" + quantity + ",weight=" + weight + "WHERE id=" + id;
            da.Fill(dt);
        }

        public void delete(int id)
        {
            cmd.Connection = con;
            cmd.CommandText = "delete from products where id='" + id;
            da.Fill(dt);

        }
    }
}
