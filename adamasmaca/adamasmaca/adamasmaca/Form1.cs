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
    public partial class form : Form
    {
        
        public form()
        {
            InitializeComponent();
        
            if (File.Exists("D:\\deneme.txt"))
            {
                StreamReader SR = new StreamReader("D:\\deneme.txt");
                skor.Text = SR.ReadLine();
                SR.Close();
            }
            adam.ImageLocation ="Resimler\\" + 0 + ".png";
        }
        
        
        public string[] kelimeler;
        string sorgu;

        public void yenikelime()
        {
            int i=0,j=0;
            aranan_kelime.Text = "";

            
            if (numeric_hrfs.Value >= 1)
            {
                int hrfs = Convert.ToInt32(numeric_hrfs.Value);
                j = 1;
                while (kelimeler.Length>i)
                {
                    if(kelimeler[i].Length== hrfs)
                    {
                        bulunacakkelime = kelimeler[i];
                        j++;
                    }
                    i++;
                }
            }
            else
            {
                bulunacakkelime = kelimeler[r.Next(kelimeler.Length)];
            }
            if(j==1)
            {
                MessageBox.Show("İstediğiniz karakter sayısında kelime yok! Farklı bir kelime seçildi.");
                bulunacakkelime = kelimeler[r.Next(kelimeler.Length)];
            }
            for (i = 0; i < bulunacakkelime.Length; i++)
            {
                aranan_kelime.Text += "_ ";
            }

            hata_say = 0;
            adam.ImageLocation ="Resimler\\" + 0 + ".png";
            denenenhrf.Items.Clear();

            return;
        }

        
        public void kelimelerimiz()
        {
            int i= 0;
            StreamReader SR = new StreamReader("kelimeler.txt");

            while (SR.Read() >0)
            {
                SR.ReadLine();
                i++;
            }
            kelimeler = new string[i];
            
            SR.Close();
            i = 0;
            StreamReader SR2 = new StreamReader("kelimeler.txt");
            string siradaki_satir = SR2.ReadLine();
            while (siradaki_satir != null) 
            {
                //denenenhrf.Items.Add(siradaki_satir);
                kelimeler[i]=siradaki_satir;
                siradaki_satir = SR2.ReadLine();
                i++;
            }
            SR2.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kelimelerimiz();
        }

        string bulunacakkelime;
        int hata_say;
        Random r = new Random();
        private void yeni_kelime_Click(object sender, EventArgs e)
        {
            yenikelime();
        }
        
        private void button_hrfdene_Click(object sender, EventArgs e)
        {

            if(harf.Text=="")
            {
                MessageBox.Show("Lütfen harf girin!");
                return;
            }
            if (aranan_kelime.Text == "")
            {
                MessageBox.Show("Lütfen önce kelime isteyin");
                return;
            }
            int skortoplam = Convert.ToInt32(skor.Text);
            char aranacakhrf = char.Parse(harf.Text.ToUpper());
            char[] karakterler = bulunacakkelime.ToCharArray();
            bool varmi = false;
            for (int i = 0; i <= denenenhrf.Items.Count - 1; i++)
            {
                if (denenenhrf.Items[i].ToString() == aranacakhrf.ToString())
                {
                    MessageBox.Show("Bu harf daha önce girdiniz. Başka Harf deneyin.");
                    return;
                }
            }
            denenenhrf.Items.Add(aranacakhrf.ToString());
            int j = 0;
            for (int i = 0; i < karakterler.Length; i++)
            {
                
                if (karakterler[i] == aranacakhrf)
                {
                    aranan_kelime.Text = aranan_kelime.Text.Remove(j, 1);
                    aranan_kelime.Text = aranan_kelime.Text.Insert(j, aranacakhrf.ToString());
                    varmi = true;
                }
                j = j + 2;
            }

            
            sorgu = aranan_kelime.Text;
            for (int i = 1; i <= sorgu.Length; i++)
            {
                sorgu = sorgu.Remove(i, 1);
            }

            if (sorgu == bulunacakkelime)
            {
                aranan_kelime.Text = bulunacakkelime;
                skortoplam += 10;
                StreamWriter SW = new StreamWriter("D:\\deneme.txt");
                SW.WriteLine(skortoplam);
                SW.Close();
                skor.Text = skortoplam.ToString();
                MessageBox.Show("Kelime'yi bildiniz.TEBRİKLER. Yeni kelime için tamama basın.", "Tebrikler", MessageBoxButtons.OK);
                yenikelime();
                return;
            }

            harf.Text = "";

            if (varmi == false)
            {
                hata_say++;
                adam.ImageLocation ="Resimler\\" + hata_say + ".png";
                if (hata_say == 7)
                {
                    MessageBox.Show("Bütün Haklarınız doldu oyunu kaybettiniz. Yeni kelime için tamama basın", "Hakkınız bitti", MessageBoxButtons.OK);
                    yenikelime();
                    return;
                }
            }
        }

        private void tahmin_Click(object sender, EventArgs e)
        {
            int skortoplam = Convert.ToInt32(skor.Text);
            string tahmin = text_tahmin.Text.ToUpper();
            text_tahmin.Text = "";
            if (tahmin == bulunacakkelime)
            {
                aranan_kelime.Text = bulunacakkelime;
                skortoplam += 10;
                StreamWriter SW = new StreamWriter("D:\\deneme.txt");
                SW.WriteLine(skortoplam);
                SW.Close();
                skor.Text = skortoplam.ToString();
                MessageBox.Show("Kelime'yi bildiniz.TEBRİKLER. Yeni kelime için tamama basın.", "Tebrikler", MessageBoxButtons.OK);
                yenikelime();
            }
            else
            {
                MessageBox.Show("YANLIŞ TAHMİN");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void harf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 97 && (int)e.KeyChar <= 122 || (int)e.KeyChar >= 65 && (int)e.KeyChar <= 90
                || (int)e.KeyChar == 231 || (int)e.KeyChar == 305 || (int)e.KeyChar == 287 || (int)e.KeyChar == 246
                || (int)e.KeyChar == 351 || (int)e.KeyChar == 252 || (int)e.KeyChar == 199 || (int)e.KeyChar == 304
                || (int)e.KeyChar == 208 || (int)e.KeyChar == 214 || (int)e.KeyChar == 350 || (int)e.KeyChar == 220)
            {
                e.Handled = false;//eğer harf ise  yazdır.
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//silme.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }

        private void denenenhrf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
