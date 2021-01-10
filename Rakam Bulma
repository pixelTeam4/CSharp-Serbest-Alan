using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rakamBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool sayiMi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            if (sayiMi(txtText.Text) == true)
            {
                lblDurum.Text = "sayı";
            }
            else
            {
                lblDurum.Text = "sayı değil";
            }
        }
    }
}
