using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatematikHesapları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int birkenar;
            int alan, çevre;
            birkenar=Convert.ToInt32(textBox1.Text);
            alan = birkenar * birkenar;
            çevre = 4 * birkenar;
            label3.Text="Alan="+alan.ToString();
            label4.Text="Çevre"+çevre.ToString();
            textBox1.Clear();




        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            panel1.Visible = true;
            button3.Visible = false;
            button4.Visible = true;
            button6.Visible = false;
            textBox2 .Visible = false;
            label5.Visible = false;
            label2.Visible = true;
           
            label1.Text = "Kare";
          
            label2.Text = "Bir kenar girin";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
           button4.Visible = false;
            button3.Visible = true;
            button3.Visible = true;
            button6.Visible = false;
            textBox2.Visible = true;
            label5.Visible=true;
            label1.Text = "Dikdörtgen";
            label2.Text = "Kısa Kenar";
          



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kısakenar, uzunkenar;
            int dikalan, dikçevre;
            kısakenar = Convert.ToInt32(textBox1.Text);
            uzunkenar = Convert.ToInt32(textBox2.Text);
            dikalan = kısakenar * uzunkenar;
            dikçevre = 2 * kısakenar + 2 * uzunkenar;
            label3.Text ="Alan="+ dikalan.ToString();
            label4.Text = "Çevre=" + dikçevre.ToString();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            panel1.Visible = true;
            button4.Visible = false;
            button3.Visible = false;
            button5.Visible = true;
            button6.Visible = true;
            textBox2.Visible = false;
            label5.Visible = false;
            label2.Visible = true;
            label1.Text = "Daire";

            label2.Text = "Yarı çapı girin";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double r;
           
            double dairealan, daireçevre;
            r = Convert.ToDouble(textBox1.Text);

            dairealan = Math.PI * r * r;
            daireçevre = 2 * Math.PI * r;
            label3.Text = "Alan=" + dairealan.ToString();
            label4.Text = "Çevre" + daireçevre.ToString();
            textBox1.Clear();

        }
    }
}
