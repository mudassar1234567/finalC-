using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daud_group
{
    class inventorydb
    {
        int id;
        public string name;
        int quantity;
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;

        public inventorydb()
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
            da = new SqlDataAdapter("Select id AS ID, name as Name, quantity as Quantity, date as Date, weight as Weight from inventory", con);
            da.Fill(dt);
            return dt;
        }
        public inventorydb get(int id)
        {
            da = new SqlDataAdapter("Select * from production_inventory where id=" + id, con);
            da.Fill(dt);
            id = Int32.Parse(dt.Rows[0]["id"].ToString());
            name = dt.Rows[0]["name"].ToString();
            quantity = Int32.Parse(dt.Rows[0]["quantity"].ToString());

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
            cmd.CommandText = "delete from production_inventory where id='" + id + "';";
            da.Fill(dt);

        }
    }
}
