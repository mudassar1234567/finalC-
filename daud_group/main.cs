using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace daud_group
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            formulation fm = new formulation();
            fm.ShowDialog();
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
        }

        private void Main_Load_1(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = false;
            chart2.Titles.Add("Products");
           
            for (int i=1;i<=16 ; i++)
            {
                productsdb pdb = new productsdb();
                pdb.get(i);
                chart2.Series["Products"].Points.AddXY(pdb.name, pdb.quantity);
            }

            for (int i = 1; i < 7; i++)
            {                
                raw_materialdb idb = new raw_materialdb();
                idb.get(i);
                chart1.Series["Raw material"].Points.AddXY(idb.name, idb.quantity);
                
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Production p = new Production();
            p.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Products pr = new Products();
            pr.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            customer c = new customer();
            c.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            employees em = new employees();
            em.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Orders or = new Orders();
            or.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            sales sl = new sales();
            sl.ShowDialog();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            expenditure exp = new expenditure();
            exp.ShowDialog();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Reports re = new Reports();
            re.ShowDialog();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Raw_material raw = new Raw_material();
            raw.ShowDialog();
        }
    }
}
