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

namespace metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Ekle()
        {
            lstListe.Items.Add(txtMetin.Text);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }



        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            lblSonuc.Text=(DortIslem(sayi1, sayi2).ToString());

        }

        public double DortIslem(int a, int b)
        {
            
            string islem = cmbIslem.Text;

            if (islem == "+")
            {
                return (a + b);
            }
            else if (islem == "-")
            {
                return (a - b);
            }
            else if (islem == "*")
            {
                return (a * b);
            }
            else if (islem == "/")
            {
                return (a / b);
            }
            else
            {
                MessageBox.Show("İşlem seçiniz.");
                return 0;
            }
        }
        ArrayList sirala = new ArrayList();

        public object Siralama(int a, int b, int c)
        {
            sirala.Add(a);
            sirala.Add(b);
            sirala.Add(c);

            sirala.Sort();
            sirala.Reverse();

            return sirala;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text=="label1")
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = Convert.ToInt32(textBox3.Text);

                Siralama(a, b, c);

                string toplam = "";
                for (int i = 0; i < sirala.Count; i++)
                {
                    toplam += sirala[i].ToString() + ">";
                }
                toplam = toplam.Substring(0, toplam.Length - 1);
                label1.Text = toplam;
            }
        }
    }

}
