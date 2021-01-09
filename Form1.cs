using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayiTahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi = 0, tahminSayisi = 0, puan = 1000;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            btnTamam.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (btnTamam.Enabled==false)
            {
                MessageBox.Show("Oyunu başlatmak için BAŞLA butonuna basmayı unutmayın !","Hata");
            }
            
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            int tahmin;

            tahminSayisi++;
            lblTahmin.Text = tahminSayisi.ToString();

            if (tahminSayisi<=10)
            {
                
                tahmin = int.Parse(textBox1.Text);
                lblDurum.Text = tahminSayisi.ToString();
                if (sayi<tahmin)
                {
                    lblDurum.Text = "Tahmini Azalt";
                    puan = puan - 100;
                    lblPuan.Text = puan.ToString();
                }
                else if (tahmin<sayi)
                {
                    lblDurum.Text = "Tahmini Büyüt";
                    puan = puan - 100;
                    lblPuan.Text = puan.ToString();
                }
                else
                {
                    lblDurum.Text = "Tebrikler ! " + lblTahmin.Text + " Defada bilip, " + lblPuan.Text + " puan aldınız ! ";
                    btnStart.Enabled = true;
                    btnTamam.Enabled = false;
                }
                textBox1.Text = "";
            }
            else
            {
                textBox1.Enabled = false;
                MessageBox.Show("Tahmin Hakkınız kalmadı ! Oyun kapatılacak ...");
                this.Close();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnTamam.Enabled = true;
            btnStart.Enabled = false;
            Random rnd = new Random();
            sayi = rnd.Next(50);
            label5.Text = sayi.ToString();
            lblDurum.Text = " ";
            lblTahmin.Text = "0";
            lblPuan.Text = "1000";

        }
    }
}
