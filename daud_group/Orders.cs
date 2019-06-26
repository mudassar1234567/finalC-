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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customerdb sdb = new customerdb();
            dataGridView1.DataSource = sdb.selectall();
            comboBox2.Items.Add("New");
            comboBox2.Items.Add("In preparation");
            comboBox2.Items.Add("In delivery");
            comboBox2.Items.Add("Delivered");
            comboBox3.Text = "Factory";
            comboBox3.Items.Add("Sales area xyz");
            comboBox3.Items.Add("Sales area xyz");
            comboBox3.Items.Add("Sales area xyz");
            for (int i = 1; i <= 16; i++)
            {
                productsdb pdb = new productsdb();
                pdb.get(i);
                comboBox1.Items.Add(pdb.name);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-H03A9OV;Initial Catalog=daudfactorydb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO orders (customer,material, quantity, price) values ('" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            cmd.ExecuteNonQuery();
            ordersdb edb = new ordersdb();
            if (comboBox2.Text == "Delivered")
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO sales (product,quantity, area, date) values ('" + comboBox1.Text + "','" + textBox2.Text + "','" + comboBox3.Text + "','" + dateTimePicker1.Text + "')";
                cmd.ExecuteNonQuery();

                //salesdb sdb = new salesdb();
            }
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            //dataGridView2.DataSource = edb.selectal();
            con.Close();
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ordersdb odb = new ordersdb();
            odb.get(Int32.Parse(id));
            string cus_name = odb.name;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12);
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ordersdb sdb = new ordersdb();
            textBox1.Text = cus_name;
            dataGridView2.DataSource = sdb.selectall(cus_name);
        }
    }
}
