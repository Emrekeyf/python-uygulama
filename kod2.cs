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
    public partial class kod2 : Form
    {
        public kod2()
        {
            InitializeComponent();
        }
        int sayaç = 1;
        int puan = 0;
        int zaman = 21;
        int dogrusayısı = 0;
        SqlConnection bağlan = new SqlConnection("Data source=DESKTOP-8TO73FG\\SQLEXPRESS;Initial Catalog=bilgiyarışma;Integrated security=true;");

        private void button5_Click(object sender, EventArgs e)
        {
            if (puan>50)
            {
                button2.Enabled = true;
            }
            timer1.Enabled = true;
            zaman = 21;
            button10.BackColor = Color.Gray;
            button9.BackColor = Color.Gray;
            button8.BackColor = Color.Gray;
            button7.BackColor = Color.Gray;
            button10.Enabled = true;
            button9.Enabled = true;
            button8.Enabled = true;
            button7.Enabled = true;
            button5.Enabled = false;
            button5.Text = "SONRAKİ";
            sayaç++;
            lblsoru.Text = sayaç.ToString();



            bağlan.Open();
            SqlCommand komut = new SqlCommand("Select * from kod2" +
                " order by NEWID()", bağlan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {


                //pictureBox1.ImageLocation = (oku["resim"].ToString());


                button10.Text = (oku["a"].ToString());
                button9.Text = (oku["b"].ToString());
                button8.Text = (oku["c"].ToString());
                button7.Text = (oku["d"].ToString());
                richTextBox1.Text = (oku["soru"].ToString());
                lbldogru.Text = (oku["doğru"].ToString());

            }
            bağlan.Close();

            if (sayaç == 13)
            {
                button5.Text = "oyun bitti";
                button10.Enabled = false;
                button9.Enabled = false;
                button8.Enabled = false;
                button7.Enabled = false;
                button5.Enabled = false;
                timer1.Enabled = false;
            }
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

        private void kod2_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }
    }
}
