using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SehirIsmiBulmaOyunu
{
    public partial class Form1 : Form
    {
        string bulunacakKelime = "";
        int bulunanHarfSayisi = 0;
        int kalanHak = 4;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKelimeGir_Click(object sender, EventArgs e)
        {
            bulunacakKelime = txtBulunacakKelime1.Text;

            txtBulunacakKelime1.Text = "";
        }

        private void btnYeniOyunuBaslat_Click(object sender, EventArgs e)
        {
            bulunanHarfSayisi = 0;
            btnHarfGir.Enabled = true;
            lblGirilenHarfler.Text = "";
            kalanHak = 4;
            lblKalanHak.Text = kalanHak.ToString();

            grpOyunAlani.Controls.Clear();

            for (int i = 0; i < bulunacakKelime.Length; i++)
            {
                Label label = new Label();
                label.Location = new Point(20 * i + 30, 20);
                label.Text = bulunacakKelime[i].ToString();
                label.Size = new System.Drawing.Size(15, 13);
                label.BackColor = Color.Red;
                label.ForeColor = Color.Red;
                grpOyunAlani.Controls.Add(label);
            }
        }

        private void btnHarfGir_Click(object sender, EventArgs e)
        {
            bool harfVarMi = false;

            if (txtBulunacakKelime2.TextLength != 1)
            {
                MessageBox.Show("Lütfen tek harf giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (lblGirilenHarfler.Text.Contains(txtBulunacakKelime2.Text))
                {
                    MessageBox.Show("Bu harfi daha önce girdiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtBulunacakKelime2.Text = "";
                    txtBulunacakKelime2.Focus();

                    return;
                }
                foreach (Control item in grpOyunAlani.Controls)
                {
                    if (item is Label)
                    {
                        Label label = item as Label;
                        if (label.Text.ToUpper() == txtBulunacakKelime2.Text.ToUpper())
                        {
                            label.ForeColor = Color.Black;
                            label.BackColor = Color.Lime;
                            harfVarMi = true;
                            bulunanHarfSayisi++;
                        }
                    }
                }
            }
            if (!harfVarMi)
            {
                kalanHak--;
                lblKalanHak.Text = kalanHak.ToString();
                if (kalanHak == 0)
                {
                    btnHarfGir.Enabled = false;
                    MessageBox.Show("Oyun Bitti. Kaybettiniz. Yeni oyun için yeni kelime giriniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            lblGirilenHarfler.Text += txtBulunacakKelime2.Text + " ";

            if (bulunanHarfSayisi == bulunacakKelime.Length)
            {
                btnHarfGir.Enabled = false;
                MessageBox.Show("Oyun bitti. Kazandınız. Yeni oyun için yeni kelime giriniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtBulunacakKelime2.Text = "";
            txtBulunacakKelime2.Focus();
        }
    }
}
