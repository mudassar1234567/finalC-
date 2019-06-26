using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daud_group
{
    class raw_materialdb
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;
        public string name, purchased_from, purchase_date;
        public string cost;
        public double quantity;

        public raw_materialdb()
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
            da = new SqlDataAdapter("Select * from raw_material", con);
            da.Fill(dt);
            return dt;
        }
        public raw_materialdb get(int id)
        {
            cmd.Connection = con;
            da = new SqlDataAdapter("Select * from raw_material where ID=" + id, con);
            da.Fill(dt);
            id = Int32.Parse(dt.Rows[0]["ID"].ToString());
            name = dt.Rows[0]["Name"].ToString();
            quantity = float.Parse(dt.Rows[0]["quantity"].ToString());
            cost = (dt.Rows[0]["cost"].ToString());
            purchased_from = dt.Rows[0]["purchased_from"].ToString();
            purchase_date = dt.Rows[0]["purchase_date"].ToString();
            return this;
        }

        public void update(int id, string name, int quantity, int weight)
        {
            cmd.Connection = con;
            cmd.CommandText = "UPDATE raw_material SET name =" + name + ", quantity=" + quantity + ",weight=" + weight + "WHERE id=" + id;
            da.Fill(dt);
        }
        public void delete(int id)
        {
            cmd.Connection = con;
            cmd.CommandText = "delete from raw_material where id='" + id + "';";
            da.Fill(dt);

        }
    }
}
