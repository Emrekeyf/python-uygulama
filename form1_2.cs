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
    public partial class form1_2 : Form
    {
        public form1_2()
        {
            InitializeComponent();
        }
        SqlConnection bağlan = new SqlConnection("Data source=DESKTOP-8TO73FG\\SQLEXPRESS;Initial Catalog=bilgiyarışma;Integrated security=true;");

        int sayaç = 0;
        int puan = 0;
        int zaman = 21;
        int dogrusayısı = 0;


        private void form1_2_Load(object sender, EventArgs e)
        {
            button7.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (puan >70 )
            {
                button7.Enabled = true;
                button7.BackColor = Color.Green;
            }
            timer1.Enabled = true;
            zaman = 21;
            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            button5.Text = "SONRAKİ";
            sayaç++;
            lblsoru.Text = sayaç.ToString();



            bağlan.Open();
            SqlCommand komut = new SqlCommand("Select * from soru" +
                " order by NEWID()", bağlan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {


                //pictureBox1.ImageLocation = (oku["resim"].ToString());


                button1.Text = (oku["a"].ToString());
                button2.Text = (oku["b"].ToString());
                button3.Text = (oku["c"].ToString());
                button4.Text = (oku["d"].ToString());
                textBox1.Text = (oku["soru"].ToString());
                lbldogru.Text = (oku["doğru"].ToString());

            }
            bağlan.Close();

            if (sayaç == 9)
            {
                button5.Text = "oyun bitti";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                timer1.Enabled = false;

            }










        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1_3 c = new Form1_3();
            c.Show();
        }
    }
}
