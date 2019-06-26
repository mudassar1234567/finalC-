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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 20);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customerdb cdb = new customerdb();
            dataGridView1.DataSource = cdb.selectall();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            customerdb idb = new customerdb();
            idb.get(Int32.Parse(id));
            textBox1.Text = idb.name;
            textBox2.Text = idb.address;
            textBox3.Text = idb.phone;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-H03A9OV;Initial Catalog=daudfactorydb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO customers (Name, address, phone) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            cmd.ExecuteNonQuery();
            customerdb edb = new customerdb();
            dataGridView1.DataSource = edb.selectall();
            con.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-H03A9OV;Initial Catalog=daudfactorydb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update customers set Name='" + textBox1.Text + "', address='" + textBox2.Text + "', phone='" + textBox3.Text + "' where Name='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            customerdb edb = new customerdb();
            //edb.delete(textBox1.Text);
            dataGridView1.DataSource = edb.selectall();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-H03A9OV;Initial Catalog=daudfactorydb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from customers where Name='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            customerdb edb = new customerdb();
            //edb.delete(textBox1.Text);
            dataGridView1.DataSource = edb.selectall();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
