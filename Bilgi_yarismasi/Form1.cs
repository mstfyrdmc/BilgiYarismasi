using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            label8.Text = button1.Text;
            if(label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
         
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            label8.Text = button2.Text;
            if(label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            label8.Text = button3.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            label8.Text = button4.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            soruno++;
            label4.Text = soruno.ToString();
            if(soruno==1)
            {
                richTextBox1.Text = "Türkiye'de Cumhuriyet Ne Zaman İlan Edilmiştir?";
                button1.Text = "1920";
                button2.Text = "1919";
                button3.Text = "1922";
                button4.Text = "1923";
                label7.Text = "1923";
                
            }
            if(soruno==2)
            {
                richTextBox1.Text = " Aşağıdakilerden Hangisi Ege Bölgemizde Yer Almamaktadır?";
                button1.Text = "İzmir";
                button2.Text = "Balıkesir";
                button3.Text = "Manisa";
                button4.Text = "İzmir";
                label7.Text = "Balıkesir";
            }
            if(soruno==3)
            {
                richTextBox1.Text = "Son Kuşlar Adlı Eser Hangi Yazarımıza Aittir?";
                button1.Text = "Sait Faik";
                button2.Text = "Cemal Süreya";
                button3.Text = "Atilla İlhan";
                button4.Text = "Reşat Nuri";
                label7.Text = "Sait Faik";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "64 ün Kare Kökü Aşağıdakilerden Hangisidir?";
                button1.Text = "4";
                button2.Text = "2";
                button3.Text = "8";
                button4.Text = "16";
                label7.Text = "8";
                button5.Text = "Sonuçlar: ";
            }
            if(soruno==5)
                {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);
                }
            
        }
    }
}
