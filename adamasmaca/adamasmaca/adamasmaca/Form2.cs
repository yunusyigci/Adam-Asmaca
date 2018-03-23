using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace adamasmaca
{
    
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            guncelle();
        }

        public void guncelle()
        {
            listBox1.Items.Clear();
            StreamReader SR = new StreamReader("kelimeler.txt");
            while (!SR.EndOfStream)
            {
                listBox1.Items.Add(SR.ReadLine());
            }
            SR.Close();
        }
        
        public void ekleme()
        {
            int i = 0;
            StreamReader SR = new StreamReader("kelimeler.txt");
            string siradaki_satir = SR.ReadLine();
            string kelime = text_kelime.Text.ToUpper();
            while (siradaki_satir != null)
            {
                if(kelime == siradaki_satir)
                {
                    i++;
                }
                siradaki_satir = SR.ReadLine();
            }
            SR.Close();

            if(i==0)
            {
                StreamWriter WR = new StreamWriter("kelimeler.txt", append: true);
                WR.WriteLine(kelime);
                WR.Close();
                guncelle();
    }
            else
            {
                MessageBox.Show("Zaten var!");
            }
        }




        public void cikar()
        {
            if(listBox1.SelectedItem==null)
            {
                MessageBox.Show("Seçim yapmalısınız!");
                return;
            }

            int yok = 0;
            StreamReader SR = new StreamReader("kelimeler.txt");
            StreamWriter SW = new StreamWriter("kelimeler2.txt");


            String gecici = "";
            while (!SR.EndOfStream)
            {
                gecici = SR.ReadLine();
                if (gecici != Convert.ToString(listBox1.SelectedItem))
                {
                    SW.WriteLine(gecici);
                   
                }
                else
                {
                    yok = 1;
                }
            }

            SW.Close();
            SR.Close();
            File.Delete("kelimeler.txt");
            File.Copy("kelimeler2.txt","kelimeler.txt");
            File.Delete("kelimeler2.txt");
            
            if (yok==1)
            {
                MessageBox.Show("Çıkartıldı");
                guncelle();
            }
            else
            {
                MessageBox.Show("Zaten böyle bir kelime yok!");
            }
            
            
        }




        private void oyun_dön_Click(object sender, EventArgs e)
        {
            form form1 = new form();
            form1.Show();
            this.Hide();
        }



        private void button1_ekle_Click(object sender, EventArgs e)
        {
            ekleme();
        }



        private void button1_cikar_Click(object sender, EventArgs e)
        {
            cikar();
        }
    }
}



