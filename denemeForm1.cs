using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int topla(int a,int b)
        {
            int toplam = a + b;
            return a + b;

        }
        public int cikart(int a, int b)
        {
            int fark = a - b;
            return a - b;

        }
        public int carp(int a, int b)
        {
            int carpim = a * b;
            return a * b;

        }
        public double bol(double a, double b)
        {
            double bolum = a / b;
            return bolum;

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (cmbIslemler.SelectedItem=="Topla")
            {
                int toplam=topla(Convert.ToInt32(txtSayi1.Text), Convert.ToInt32(txtSayi2.Text));
                lblSonuc.Text = toplam.ToString();
            }
            else if (cmbIslemler.SelectedItem == "Çıkart")
            {
                int fark =cikart(Convert.ToInt32(txtSayi1.Text), Convert.ToInt32(txtSayi2.Text));
                lblSonuc.Text = fark.ToString();
            }
            else if (cmbIslemler.SelectedItem == "Çarp")
            {
                int carpim =carp(Convert.ToInt32(txtSayi1.Text), Convert.ToInt32(txtSayi2.Text));
                lblSonuc.Text = carpim.ToString();
            }
            else if (cmbIslemler.SelectedItem == "Böl")
            {
                double bolum =bol(Convert.ToDouble(txtSayi1.Text), Convert.ToDouble(txtSayi2.Text));
                lblSonuc.Text = bolum.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
