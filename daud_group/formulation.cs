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
    public partial class formulation : Form
    {
        public formulation()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-H03A9OV;Initial Catalog=daudfactorydb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            double resin, uvtax, pack, titanium, dop, chock;
            raw_materialdb rmdb = new raw_materialdb();
            rmdb.get(1);
            resin = rmdb.quantity;
            raw_materialdb rmdb2 = new raw_materialdb();
            rmdb2.get(2);
            chock = rmdb2.quantity;
            raw_materialdb rmdb3 = new raw_materialdb();
            rmdb3.get(3);
            pack = rmdb3.quantity;
            raw_materialdb rmdb4 = new raw_materialdb();
            rmdb4.get(4);
            titanium = rmdb4.quantity;
            raw_materialdb rmdb5 = new raw_materialdb();
            rmdb5.get(5);
            dop = rmdb5.quantity;
            raw_materialdb rmdb6 = new raw_materialdb();
            rmdb6.get(6);
            uvtax = rmdb6.quantity;
            int qnt = Int32.Parse(textBox1.Text);

            if (comboBox1.Text == "2inch13ft,1.7kg")
            {
                resin = resin - (qnt * 1.3239);
                chock = chock - (qnt * 0.2647);
                pack = pack - (qnt * 0.07414);
                titanium = titanium - (qnt * 0.02118);
                dop = dop - (qnt * 0.0132);
                uvtax = uvtax - (qnt * 0.000264);
                cmd.CommandText = "update raw_material set  quantity=" + resin + " where name= 'Resin'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + uvtax + " where name= 'Uvdex'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + pack + " where name= 'One pack'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + titanium + " where name= 'Titanium'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + dop + " where name= 'DOP'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + chock + " where name= 'Chowk'";
                cmd.ExecuteNonQuery();
                double total = (qnt * 1.7);
                cmd.CommandText = "INSERT INTO inventory (name, quantity, date, weight) values ('" + comboBox1.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + total + "')";
                cmd.ExecuteNonQuery();
                productsdb edb = new productsdb();
                string name = comboBox1.Text;
                edb.get(1);
                int x;
                x = edb.quantity + qnt;
                cmd.CommandText = "update Products set Ready='" + x + "' where name='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
            }
            else if (comboBox1.Text == "2inch13ft,2kg")
            {
                resin = resin - (qnt * 1.5576);
                uvtax = uvtax - (qnt * 0.0003115);
                pack = pack - (qnt * 0.08722);
                titanium = titanium - (qnt * 0.02492);
                dop = dop - (qnt * 0.01557);
                chock = chock - (qnt * 0.31152);
                cmd.CommandText = "update raw_material set  quantity=" + resin + " where name= 'Resin'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + uvtax + " where name= 'Uvdex'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + pack + " where name= 'One pack'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + titanium + " where name= 'Titanium'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + dop + " where name= 'DOP'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + chock + " where name= 'Chowk'";
                cmd.ExecuteNonQuery();
                double total = (qnt * 2);
                cmd.CommandText = "INSERT INTO inventory (name, quantity, date, weight) values ('" + comboBox1.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + total + "')";
                cmd.ExecuteNonQuery();
                productsdb edb = new productsdb();
                string name = comboBox1.Text;
                edb.get(2);
                int x;
                x = edb.quantity + qnt;
                cmd.CommandText = "update Products set Ready='" + x + "' where name='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
            }
            else if (comboBox1.Text == "2inch10ft,1.3kg")
            {

                resin = resin - (qnt * 1.01246);
                uvtax = uvtax - (qnt * 0.00020249);
                pack = pack - (qnt * 0.0566978);
                titanium = titanium - (qnt * 0.016199);
                dop = dop - (qnt * 0.01012461);
                chock = chock - (qnt * 0.20249);
                cmd.CommandText = "update raw_material set  quantity=" + resin + " where name= 'Resin'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + uvtax + " where name= 'Uvdex'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + pack + " where name= 'One pack'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + titanium + " where name= 'Titanium'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + dop + " where name= 'DOP'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + chock + " where name= 'Chowk'";
                cmd.ExecuteNonQuery();
                double total = (qnt * 1.3);
                cmd.CommandText = "INSERT INTO inventory (name, quantity, date, weight) values ('" + comboBox1.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + total + "')";
                cmd.ExecuteNonQuery();
                productsdb edb = new productsdb();
                edb.get(3);
                int x;
                x = edb.quantity + qnt;
                cmd.CommandText = "update Products set Ready='" + x + "' where name='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
            }
            else if (comboBox1.Text == "3inch13ft,2.6kg")
            {
                resin = resin - (qnt * 2.024922);
                uvtax = uvtax - (qnt * 0.0004049);
                pack = pack - (qnt * 0.113395);
                titanium = titanium - (qnt * 0.0323987);
                dop = dop - (qnt * 0.020249);
                chock = chock - (qnt * 0.404984);
                cmd.CommandText = "update raw_material set  quantity=" + resin + " where name= 'Resin'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + uvtax + " where name= 'Uvdex'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + pack + " where name= 'One pack'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + titanium + " where name= 'Titanium'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + dop + " where name= 'DOP'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + chock + " where name= 'Chowk'";
                cmd.ExecuteNonQuery();
                double total = (qnt * 2.6);
                cmd.CommandText = "INSERT INTO inventory (name, quantity, date, weight) values ('" + comboBox1.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + total + "')";
                cmd.ExecuteNonQuery();
                productsdb edb = new productsdb();
                edb.get(4);
                int x;
                x = edb.quantity + qnt;
                cmd.CommandText = "update Products set Ready='" + x + "' where name='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
            }
            else if (comboBox1.Text == "3inch13ft,3.6kg")
            {
                resin = resin - (qnt * 2.8037);
                uvtax = uvtax - (qnt * 0.00056);
                pack = pack - (qnt * 0.157009);
                titanium = titanium - (qnt * 0.04485);
                dop = dop - (qnt * 0.02803);
                chock = chock - (qnt * 0.56074);
                cmd.CommandText = "update raw_material set  quantity=" + resin + " where name= 'Resin'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + uvtax + " where name= 'Uvdex'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + pack + " where name= 'One pack'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + titanium + " where name= 'Titanium'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + dop + " where name= 'DOP'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + chock + " where name= 'Chowk'";
                cmd.ExecuteNonQuery();
                double total = (qnt * 3.6);
                cmd.CommandText = "INSERT INTO inventory (name, quantity, date, weight) values ('" + comboBox1.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + total + "')";
                cmd.ExecuteNonQuery();
                productsdb edb = new productsdb();
                edb.get(5);
                int x;
                x = edb.quantity + qnt;
                cmd.CommandText = "update Products set Ready='" + x + "' where name='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
            }
            else if (comboBox1.Text == "3inch13ft,4kg")
            {

                resin = resin - (qnt * 3.11526);
                uvtax = uvtax - (qnt * 0.000623);
                pack = pack - (qnt * 0.17445);
                titanium = titanium - (qnt * 0.049844);
                dop = dop - (qnt * 0.031152);
                chock = chock - (qnt * 0.62305);
                cmd.CommandText = "update raw_material set  quantity=" + resin + " where name= 'Resin'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + uvtax + " where name= 'Uvdex'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + pack + " where name= 'One pack'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + titanium + " where name= 'Titanium'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + dop + " where name= 'DOP'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + chock + " where name= 'Chowk'";
                cmd.ExecuteNonQuery();
                double total = (qnt * 4);
                cmd.CommandText = "INSERT INTO inventory (name, quantity, date, weight) values ('" + comboBox1.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + total + "')";
                cmd.ExecuteNonQuery();
                productsdb edb = new productsdb();
                edb.get(6);
                int x;
                x = edb.quantity + qnt;
                cmd.CommandText = "update Products set Ready='" + x + "' where name='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
            }
            else if (comboBox1.Text == "3inch10ft,1.8kg")
            {
                resin = resin - (qnt * 1.401868);
                uvtax = uvtax - (qnt * 0.00028036);
                pack = pack - (qnt * 0.07850);
                titanium = titanium - (qnt * 0.022429);
                dop = dop - (qnt * 0.014018);
                chock = chock - (qnt * 0.280373);
                cmd.CommandText = "update raw_material set  quantity=" + resin + " where name= 'Resin'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + uvtax + " where name= 'Uvdex'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + pack + " where name= 'One pack'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + titanium + " where name= 'Titanium'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + dop + " where name= 'DOP'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + chock + " where name= 'Chowk'";
                cmd.ExecuteNonQuery();
                double total = (qnt * 1.8);
                cmd.CommandText = "INSERT INTO inventory (name, quantity, date, weight) values ('" + comboBox1.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + total + "')";
                cmd.ExecuteNonQuery();
                productsdb edb = new productsdb();
                edb.get(7);
                int x;
                x = edb.quantity + qnt;
                cmd.CommandText = "update Products set Ready='" + x + "' where name='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
            }
            else if (comboBox1.Text == "3inch10ft,3.6kg")
            {

                resin = resin - (qnt * 2.8037);
                uvtax = uvtax - (qnt * 0.00056);
                pack = pack - (qnt * 0.157009);
                titanium = titanium - (qnt * 0.04485);
                dop = dop - (qnt * 0.02803);
                chock = chock - (qnt * 0.56074);
                cmd.CommandText = "update raw_material set  quantity=" + resin + " where name= 'Resin'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + uvtax + " where name= 'Uvdex'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + pack + " where name= 'One pack'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + titanium + " where name= 'Titanium'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + dop + " where name= 'DOP'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + chock + " where name= 'Chowk'";
                cmd.ExecuteNonQuery();
                double total = (qnt * 3.6);
                cmd.CommandText = "INSERT INTO inventory (name, quantity, date, weight) values ('" + comboBox1.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + total + "')";
                cmd.ExecuteNonQuery();
                productsdb edb = new productsdb();
                edb.get(8);
                int x;
                x = edb.quantity + qnt;
                cmd.CommandText = "update Products set Ready='" + x + "' where name='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
            }
            else if (comboBox1.Text == "4inch13ft,3.6kg")
            {

                resin = resin - (qnt * 2.8037);
                uvtax = uvtax - (qnt * 0.00056);
                pack = pack - (qnt * 0.157009);
                titanium = titanium - (qnt * 0.04485);
                dop = dop - (qnt * 0.02803);
                chock = chock - (qnt * 0.56074);
                cmd.CommandText = "update raw_material set  quantity=" + resin + " where name= 'Resin'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + uvtax + " where name= 'Uvdex'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + pack + " where name= 'One pack'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + titanium + " where name= 'Titanium'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + dop + " where name= 'DOP'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + chock + " where name= 'Chowk'";
                cmd.ExecuteNonQuery();
                double total = (qnt * 3.6);
                cmd.CommandText = "INSERT INTO inventory (name, quantity, date, weight) values ('" + comboBox1.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + total + "')";
                cmd.ExecuteNonQuery();
                productsdb edb = new productsdb();
                edb.get(9);
                int x;
                x = edb.quantity + qnt;
                cmd.CommandText = "update Products set Ready='" + x + "' where name='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
            }
            else if (comboBox1.Text == "4inch13ft,4.6kg")
            {

                resin = resin - (qnt * 3.5825);
                uvtax = uvtax - (qnt * 0.0007165);
                pack = pack - (qnt * 0.20062);
                titanium = titanium - (qnt * 0.057320);
                dop = dop - (qnt * 0.035825);
                chock = chock - (qnt * 0.716510);
                cmd.CommandText = "update raw_material set  quantity=" + resin + " where name= 'Resin'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + uvtax + " where name= 'Uvdex'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + pack + " where name= 'One pack'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + titanium + " where name= 'Titanium'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + dop + " where name= 'DOP'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + chock + " where name= 'Chowk'";
                cmd.ExecuteNonQuery();
                double total = (qnt * 4.6);
                cmd.CommandText = "INSERT INTO inventory (name, quantity, date, weight) values ('" + comboBox1.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + total + "')";
                cmd.ExecuteNonQuery();
                productsdb edb = new productsdb();
                edb.get(10);
                int x;
                x = edb.quantity + qnt;
                cmd.CommandText = "update Products set Ready='" + x + "' where name='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
            }
            else if (comboBox1.Text == "4inch13ft,6kg")
            {

                resin = resin - (qnt * 4.672896);
                uvtax = uvtax - (qnt * 0.0009345);
                pack = pack - (qnt * 0.26168);
                titanium = titanium - (qnt * 0.074766);
                dop = dop - (qnt * 0.046728);
                chock = chock - (qnt * 0.934579);
                cmd.CommandText = "update raw_material set  quantity=" + resin + " where name= 'Resin'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + uvtax + " where name= 'Uvdex'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + pack + " where name= 'One pack'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + titanium + " where name= 'Titanium'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + dop + " where name= 'DOP'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + chock + " where name= 'Chowk'";
                cmd.ExecuteNonQuery();
                double total = (qnt * 6);
                cmd.CommandText = "INSERT INTO inventory (name, quantity, date, weight) values ('" + comboBox1.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + total + "')";
                cmd.ExecuteNonQuery();
                productsdb edb = new productsdb();
                edb.get(11);
                int x;
                x = edb.quantity + qnt;
                cmd.CommandText = "update Products set Ready='" + x + "' where name='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
            }
            else if (comboBox1.Text == "4inch10ft,2.6kg")
            {

                resin = resin - (qnt * 2.024922);
                uvtax = uvtax - (qnt * 0.0004049);
                pack = pack - (qnt * 0.113395);
                titanium = titanium - (qnt * 0.0323987);
                dop = dop - (qnt * 0.020249);
                chock = chock - (qnt * 0.404984);
                cmd.CommandText = "update raw_material set  quantity=" + resin + " where name= 'Resin'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + uvtax + " where name= 'Uvdex'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + pack + " where name= 'One pack'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + titanium + " where name= 'Titanium'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + dop + " where name= 'DOP'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + chock + " where name= 'Chowk'";
                cmd.ExecuteNonQuery();
                double total = (qnt * 2.6);
                cmd.CommandText = "INSERT INTO inventory (name, quantity, date, weight) values ('" + comboBox1.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + total + "')";
                cmd.ExecuteNonQuery();
                productsdb edb = new productsdb();
                edb.get(12);
                int x;
                x = edb.quantity + qnt;
                cmd.CommandText = "update Products set Ready='" + x + "' where name='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
            }
            else if (comboBox1.Text == "4inch10ft,3.6kg")
            {

                resin = resin - (qnt * 2.8037);
                uvtax = uvtax - (qnt * 0.00056);
                pack = pack - (qnt * 0.157009);
                titanium = titanium - (qnt * 0.04485);
                dop = dop - (qnt * 0.02803);
                chock = chock - (qnt * 0.56074);
                cmd.CommandText = "update raw_material set  quantity=" + resin + " where name= 'Resin'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + uvtax + " where name= 'Uvdex'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + pack + " where name= 'One pack'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + titanium + " where name= 'Titanium'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + dop + " where name= 'DOP'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + chock + " where name= 'Chowk'";
                cmd.ExecuteNonQuery();
                double total = (qnt * 3.6);
                cmd.CommandText = "INSERT INTO inventory (name, quantity, date, weight) values ('" + comboBox1.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + total + "')";
                cmd.ExecuteNonQuery();
                productsdb edb = new productsdb();
                edb.get(13);
                int x;
                x = edb.quantity + qnt;
                cmd.CommandText = "update Products set Ready='" + x + "' where name='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
            }
            else if (comboBox1.Text == "5inch13ft,5.5kg")
            {

                resin = resin - (qnt * 4.2834);
                uvtax = uvtax - (qnt * 0.00085668);
                pack = pack - (qnt * 0.239875);
                titanium = titanium - (qnt * 0.06853);
                dop = dop - (qnt * 0.04283);
                chock = chock - (qnt * 0.85669);
                cmd.CommandText = "update raw_material set  quantity=" + resin + " where name= 'Resin'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + uvtax + " where name= 'Uvdex'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + pack + " where name= 'One pack'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + titanium + " where name= 'Titanium'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + dop + " where name= 'DOP'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + chock + " where name= 'Chowk'";
                cmd.ExecuteNonQuery();
                double total = (qnt * 5.5);
                cmd.CommandText = "INSERT INTO inventory (name, quantity, date, weight) values ('" + comboBox1.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + total + "')";
                cmd.ExecuteNonQuery();
                productsdb edb = new productsdb();
                edb.get(14);
                int x;
                x = edb.quantity + qnt;
                cmd.CommandText = "update Products set Ready='" + x + "' where name='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
            }
            else if (comboBox1.Text == "5inch13ft,7kg")
            {
                resin = resin - (qnt * 5.451712);
                uvtax = uvtax - (qnt * 0.00109);
                pack = pack - (qnt * 0.305291);
                titanium = titanium - (qnt * 0.087227);
                dop = dop - (qnt * 0.054517);
                chock = chock - (qnt * 1.09034);
                cmd.CommandText = "update raw_material set  quantity=" + resin + " where name= 'Resin'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + uvtax + " where name= 'Uvdex'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + pack + " where name= 'One pack'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + titanium + " where name= 'Titanium'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + dop + " where name= 'DOP'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + chock + " where name= 'Chowk'";
                cmd.ExecuteNonQuery();
                double total = (qnt * 7);
                cmd.CommandText = "INSERT INTO inventory (name, quantity, date, weight) values ('" + comboBox1.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + total + "')";
                cmd.ExecuteNonQuery();
                productsdb edb = new productsdb();
                edb.get(15);
                int x;
                x = edb.quantity + qnt;
                cmd.CommandText = "update Products set Ready='" + x + "' where name='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
            }
            else if (comboBox1.Text == "6inch13ft,7.5kg")
            {

                resin = resin - (qnt * 5.84112);
                uvtax = uvtax - (qnt * 0.0011682);
                pack = pack - (qnt * 0.321702);
                titanium = titanium - (qnt * 0.093457);
                dop = dop - (qnt * 0.0584112);
                chock = chock - (qnt * 1.1682);
                cmd.CommandText = "update raw_material set  quantity=" + resin + " where name= 'Resin'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + uvtax + " where name= 'Uvdex'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + pack + " where name= 'One pack'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + titanium + " where name= 'Titanium'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + dop + " where name= 'DOP'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update raw_material set  quantity=" + chock + " where name= 'Chowk'";
                cmd.ExecuteNonQuery();
                double total = (qnt * 7.5);
                cmd.CommandText = "INSERT INTO inventory (name, quantity, date, weight) values ('" + comboBox1.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + total + "')";
                cmd.ExecuteNonQuery();
                productsdb edb = new productsdb();
                edb.get(16);
                int x;
                x = edb.quantity + qnt;
                cmd.CommandText = "update Products set Ready='" + x + "' where name='" + comboBox1.Text + "'";
                cmd.ExecuteNonQuery();
            }
        }

        private void Formulation_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = false;
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
    }
}
