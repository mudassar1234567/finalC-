using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daud_group
{
    class employeesdb
    {
        public SqlConnection con;
        public string name, Father_name, address, cnic, contact, designation, qualifation, salary;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;

        public employeesdb()
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
            cmd.Connection = con;
            da = new SqlDataAdapter("Select * from employees", con);
            da.Fill(dt);
            return dt;
        }
        public employeesdb get(int id)
        {
            da = new SqlDataAdapter("Select * from employees where id=" + id, con);
            da.Fill(dt);
            id = Int32.Parse(dt.Rows[0]["id"].ToString());
            name = dt.Rows[0]["name"].ToString();
            Father_name = dt.Rows[0]["Father_name"].ToString();
            address = dt.Rows[0]["address"].ToString();
            cnic = dt.Rows[0]["CNIC"].ToString();
            contact = dt.Rows[0]["contact"].ToString();
            designation = dt.Rows[0]["designation"].ToString();
            qualifation = dt.Rows[0]["qualifation"].ToString();
            salary = dt.Rows[0]["salary"].ToString();
            return this;
        }
        public void update(int id, string name, int quantity, int weight)
        {
            cmd.Connection = con;
            cmd.CommandText = "UPDATE employees SET name =" + name + ", quantity=" + quantity + ",weight=" + weight + "WHERE id=" + id;
            da.Fill(dt);
        }
        public void delete(string namez)
        {
            cmd.Connection = con;
            cmd.CommandText = "delete from employees where name='" + namez + "';";
            da.Fill(dt);

        }
    }
}
