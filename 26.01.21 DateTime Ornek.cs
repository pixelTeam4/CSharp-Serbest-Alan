using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeOdev_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList isimSoyisim = new ArrayList();
        ArrayList memleket = new ArrayList();
        ArrayList dTarihi = new ArrayList();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string adSoyad = txtAd.Text + " " + txtSoyad.Text;
            string sehir = txtMemleket.Text;
            int day = Convert.ToInt32(txtDay.Text);
            int month = Convert.ToInt32(txtMonth.Text);
            int year = Convert.ToInt32(txtYear.Text);
            DateTime bDay = new DateTime(year, month, day);
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtMemleket.Text = "";
            txtDay.Text = "";
            txtMonth.Text = "";
            txtYear.Text = "";
            isimSoyisim.Add(adSoyad);
            memleket.Add(sehir);
            dTarihi.Add(bDay.ToShortDateString());
            lstListe.Items.Clear();
            for (int i = 0; i < isimSoyisim.Count; i++)
            {
                string satir = isimSoyisim[i].ToString() + " " + memleket[i].ToString()+ " "+ dTarihi[i].ToString();
                lstListe.Items.Add(satir);
            }
        }

        private void btnBuyukSirala_Click(object sender, EventArgs e)
        {

            //lstListe.Items.Clear();
            //dTarihi.Sort();
            //foreach (var item in dTarihi)
            //{
            //    lstListe.Items.Add(item);
            //}


            for (int i = 0; i < dTarihi.Count; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    string a = dTarihi[i].ToString();
                    string[] dizi = a.Split('/');
                    string gun = dizi[0];
                    string ay = dizi[1];
                    string yil = dizi[2];
                    
                    string b = dTarihi[j].ToString();
                    string[] dizi2 = b.Split('/');
                    string gun2 = dizi2[0];
                    string ay2 = dizi2[1];
                    string yil2 = dizi2[2];
                    string gecici1 = "";
                    string gecici2 = "";
                    string gecici3 = "";
                    DateTime date = new DateTime(Convert.ToInt32(yil), Convert.ToInt32(ay), Convert.ToInt32(gun));
                    DateTime date2 = new DateTime(Convert.ToInt32(yil2), Convert.ToInt32(ay2), Convert.ToInt32(gun2));
                    
                    if (Convert.ToInt32(yil2) < Convert.ToInt32(yil))
                    {
                        gecici1 = dTarihi[i].ToString();
                        gecici2 = isimSoyisim[i].ToString();
                        gecici3 = memleket[i].ToString();
                        dTarihi[i] = dTarihi[j];
                        isimSoyisim[i] = isimSoyisim[j];
                        memleket[i] = memleket[j]; 
                        dTarihi[j] = gecici1;
                        isimSoyisim[j] = gecici2;
                        memleket[j] = gecici3;
                    }
                }
            }

            lstListe.Items.Clear();
            for (int list = 0; list < dTarihi.Count; list++)
            {
                string satir = isimSoyisim[list].ToString() + " " + memleket[list].ToString() + " " + dTarihi[list].ToString();
                lstListe.Items.Add(satir);
            }
        }

        private void btnKucukSirala_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dTarihi.Count; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    string a = dTarihi[i].ToString();
                    string[] dizi = a.Split('/');
                    string gun = dizi[0];
                    string ay = dizi[1];
                    string yil = dizi[2];

                    string b = dTarihi[j].ToString();
                    string[] dizi2 = b.Split('/');
                    string gun2 = dizi2[0];
                    string ay2 = dizi2[1];
                    string yil2 = dizi2[2];
                    string gecici1 = "";
                    string gecici2 = "";
                    string gecici3 = "";
                    DateTime date = new DateTime(Convert.ToInt32(yil), Convert.ToInt32(ay), Convert.ToInt32(gun));
                    DateTime date2 = new DateTime(Convert.ToInt32(yil2), Convert.ToInt32(ay2), Convert.ToInt32(gun2));

                    if (Convert.ToInt32(yil2) > Convert.ToInt32(yil))
                    {
                        gecici1 = dTarihi[i].ToString();
                        gecici2 = isimSoyisim[i].ToString();
                        gecici3 = memleket[i].ToString();
                        dTarihi[i] = dTarihi[j];
                        isimSoyisim[i] = isimSoyisim[j];
                        memleket[i] = memleket[j];
                        dTarihi[j] = gecici1;
                        isimSoyisim[j] = gecici2;
                        memleket[j] = gecici3;
                    }
                }
            }

            lstListe.Items.Clear();
            for (int list = 0; list < dTarihi.Count; list++)
            {
                string satir = isimSoyisim[list].ToString() + " " + memleket[list].ToString() + " " + dTarihi[list].ToString();
                lstListe.Items.Add(satir);
            }
        }
    }
}
