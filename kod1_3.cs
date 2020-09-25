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
    public partial class kod1_3 : Form
    {
        public kod1_3()
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
            SqlCommand komut = new SqlCommand("Select * from kod1" +
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
              
            }
        }
    }
}
