using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace metotlar_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        ArrayList Kayitlar = new ArrayList();
        public void Kayit()
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string telefon = txtTelefon.Text;
            string dogumTarihi = txtDogum.Text;
            lstListe.Items.Add(ad + " " + soyad + " " + telefon + " " + dogumTarihi);
            
            Kayitlar.Add(ad);
            Kayitlar.Add(soyad);
            Kayitlar.Add(telefon);
            Kayitlar.Add(dogumTarihi);

        }

        public void Sil()
        {
            int a = lstListe.SelectedIndex;

            Kayitlar.RemoveRange(4 * a, 4);



            lstListe.Items.Remove(lstListe.SelectedItem);
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kayit();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }
        public void Ara()
        {
            if (cmbAra.Text==null)
            {
                MessageBox.Show("Lütfen seçim yapınız.");
            }
            else if (cmbAra.Text=="Ad")
            {
                for (int i = 0; i < Kayitlar.Count; i++)
                {
                    if (Kayitlar[i].ToString()==txtAra.Text)
                    {
                        lblAD.Text = Kayitlar[i].ToString();
                        lblSoyad.Text = Kayitlar[i+1].ToString();
                        lblTelefon.Text = Kayitlar[i + 2].ToString();
                        lblDogum.Text = Kayitlar[i + 3].ToString();

                    }
                    
                }
            }
            else if (cmbAra.Text == "Soyad")
            {
                for (int i = 0; i < Kayitlar.Count; i++)
                {
                    if (Kayitlar[i].ToString() == txtAra.Text)
                    {
                        lblAD.Text = Kayitlar[i-1].ToString();
                        lblSoyad.Text = Kayitlar[i ].ToString();
                        lblTelefon.Text = Kayitlar[i + 1].ToString();
                        lblDogum.Text = Kayitlar[i + 2].ToString();

                    }
                    
                }
            }
            else if (cmbAra.Text == "Telefon")
            {
                for (int i = 0; i < Kayitlar.Count; i++)
                {
                    if (Kayitlar[i].ToString() == txtAra.Text)
                    {
                        lblAD.Text = Kayitlar[i-2].ToString();
                        lblSoyad.Text = Kayitlar[i - 1].ToString();
                        lblTelefon.Text = Kayitlar[i ].ToString();
                        lblDogum.Text = Kayitlar[i + 1].ToString();

                    }
                    
                }
            }
            else if (cmbAra.Text == "Doğum Tarihi")
            {
                for (int i = 0; i < Kayitlar.Count; i++)
                {
                    if (Kayitlar[i].ToString() == txtAra.Text)
                    {
                        lblAD.Text = Kayitlar[i-3].ToString();
                        lblSoyad.Text = Kayitlar[i -2].ToString();
                        lblTelefon.Text = Kayitlar[i - 1].ToString();
                        lblDogum.Text = Kayitlar[i ].ToString();

                    }
                    
                }
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Ara();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string toplam = "";
            for (int i = 0; i < Kayitlar.Count; i++)    
            {
              toplam+=(i+1).ToString()+ "-"+ Kayitlar[i] + "\n";
            }
            MessageBox.Show(toplam);
        }
    }
}
