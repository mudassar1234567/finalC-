using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace daud_group
{
    public partial class employees : Form
    {
        public employees()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-H03A9OV;Initial Catalog=daudfactorydb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO employees (name, Father_name, address, CNIC, contact, designation, qualifation, salary) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
            cmd.ExecuteNonQuery();
            employeesdb edb = new employeesdb();
            dataGridView1.DataSource = edb.selectall();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeesdb edb = new employeesdb();
            dataGridView1.DataSource = edb.selectall();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-H03A9OV;Initial Catalog=daudfactorydb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update employees set name='" + textBox1.Text + "', Father_name='" + textBox2.Text + "', address='" + textBox3.Text + "', CNIC='" + textBox4.Text + "', contact='" + textBox5.Text + "', designation='" + textBox6.Text + "', qualifation='" + textBox7.Text + "', salary='" + textBox8.Text + "' where name='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            employeesdb edb = new employeesdb();
            //edb.delete(textBox1.Text);
            dataGridView1.DataSource = edb.selectall();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            employeesdb idb = new employeesdb();
            idb.get(Int32.Parse(id));
            textBox1.Text = idb.name;
            textBox2.Text = idb.Father_name;
            textBox3.Text = idb.address;
            textBox4.Text = idb.cnic;
            textBox5.Text = idb.contact;
            textBox6.Text = idb.designation;
            textBox7.Text = idb.qualifation;
            textBox8.Text = idb.salary;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-H03A9OV;Initial Catalog=daudfactorydb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from employees where name='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            employeesdb edb = new employeesdb();
            //edb.delete(textBox1.Text);
            dataGridView1.DataSource = edb.selectall();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }
    }
}
