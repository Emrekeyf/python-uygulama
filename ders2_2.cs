using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bilgıyarışması
{
    public partial class ders2_2 : Form
    {
        public ders2_2()
        {
            InitializeComponent();
        }
        SqlConnection bağlan = new SqlConnection("Data source=DESKTOP-8TO73FG\\SQLEXPRESS;Initial Catalog=bilgiyarışma;Integrated security=true;");

        int sayaç = 1;
        int puan = 0;
        int zaman = 21;
        int dogrusayısı = 0;


        private void button5_Click(object sender, EventArgs e)
        {
            if (puan>60)
            {
                button12.Enabled = true;
            }
        }

        private void ders2_2_Load(object sender, EventArgs e)
        {
            button12.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (lbldogru.Text == button10.Text)

            {


                button10.BackColor = Color.Green;
                dogrusayısı += 1;
                lbldogrusayısı.Text = dogrusayısı.ToString();


                puan += 10;
                lblpuan.Text = puan.ToString();

            }
            else
            {
                button10.BackColor = Color.Red;
            }
            button5.Enabled = true;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (lbldogru.Text == button9.Text)
            {
                dogrusayısı += 1;
                lbldogrusayısı.Text = dogrusayısı.ToString();

                puan += 10;
                lblpuan.Text = puan.ToString();
                button9.BackColor = Color.Green;
            }
            else
            {
                button9.BackColor = Color.Red;
            }
            button5.Enabled = true;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (lbldogru.Text == button8.Text)
            {
                dogrusayısı += 1;
                lbldogrusayısı.Text = dogrusayısı.ToString();

                button8.BackColor = Color.Green;
                puan += 10;
                lblpuan.Text = puan.ToString();
            }
            else
            {
                button8.BackColor = Color.Red;
            }
            button5.Enabled = true;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (lbldogru.Text == button7.Text)
            {
                dogrusayısı += 1;
                lbldogrusayısı.Text = dogrusayısı.ToString();
                button7.BackColor = Color.Green;
                puan += 10;
                lblpuan.Text = puan.ToString();
            }

            else
            {
                button7.BackColor = Color.Red;
            }
            button5.Enabled = true;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Ders2_3 n = new Ders2_3();
            n.Show();
        }
    }
}
