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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bağlan = new SqlConnection("Data source=DESKTOP-8TO73FG\\SQLEXPRESS;Initial Catalog=bilgiyarışma;Integrated security=true;");

        int sayaç = 0;
        int puan = 0;
        int zaman =21;
        int dogrusayısı = 0;



        private void button5_Click(object sender, EventArgs e)
        {
            if (puan>50)
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
                " order by NEWID()",bağlan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                    

                   //pictureBox1.ImageLocation = (oku["resim"].ToString());

                 
                button1.Text=(oku["a"].ToString());
                button2.Text = (oku["b"].ToString());
                button3.Text =( oku["c"].ToString());
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

        private void Form1_Load(object sender, EventArgs e)
        {
            button7.Enabled= false;
           
            lblsoru.Text = sayaç.ToString();
            lbldogru.Enabled = false;
            lbldogru.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (lbldogru.Text==button1.Text)

            {
                
               
                button1.BackColor = Color.Green;
                dogrusayısı+=1;
                lbldogrusayısı.Text = dogrusayısı.ToString();


                puan += 10;
                lblpuan.Text = puan.ToString();
                
            }
            else
            {
                button1.BackColor = Color.Red;
            }
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lbldogru.Text == button2.Text)
            {
                dogrusayısı += 1;
                lbldogrusayısı.Text = dogrusayısı.ToString();

                puan += 10;
                lblpuan.Text = puan.ToString();
                button2.BackColor = Color.Green;
            }
            else
            {
                button2.BackColor = Color.Red;
            }
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lbldogru.Text == button3.Text)
            {
                dogrusayısı += 1;
                lbldogrusayısı.Text = dogrusayısı.ToString();
               
                button3.BackColor = Color.Green;
                puan += 10;
                lblpuan.Text = puan.ToString();
            }
            else
            {
                button3.BackColor = Color.Red;
            }
            button5.Enabled = true;
            button1.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (lbldogru.Text == button4.Text)
            {
                dogrusayısı += 1;
                lbldogrusayısı.Text = dogrusayısı.ToString();
                button4.BackColor = Color.Green;
                puan += 10;
                lblpuan.Text = puan.ToString();
            }

            else
            {
                button4.BackColor = Color.Red;
            }
            button5.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman -= 1;
            lblsüre.Text = zaman.ToString();
            if (zaman==0)
            {
                timer1.Enabled = false;
                MessageBox.Show("süreniz bitti");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            
            
            
            
            Form2 yeni = new Form2();
            yeni.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbldogrusayısı_Click(object sender, EventArgs e)
        {

        }

        private void lblsüre_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbldogru_Click(object sender, EventArgs e)
        {

        }

        private void lblsoru_Click(object sender, EventArgs e)
        {

        }

        private void lblpuan_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            form1_2 a = new form1_2();
            a.Show();
        }
    }
}
