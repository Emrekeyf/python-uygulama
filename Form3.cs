using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bilgıyarışması
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 AÇ = new Form1();
            AÇ.Show();

      }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(1) + textBox1.Text.Substring(0, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DERS2 DRS = new DERS2();
            DRS.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ders3 aç = new Ders3();
            aç.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DERSS4 yeni = new DERSS4();
            yeni.Show();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ders5 a= new Ders5();
            a.Show();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            kod1 k = new kod1();
            k.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            kod2 k2 = new kod2();
            k2.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Drs6 m = new Drs6();
                m.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            ders7 a = new ders7();
            a.Show();
        }
    }
    }




