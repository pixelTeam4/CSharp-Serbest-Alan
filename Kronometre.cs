using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int dakika = 0;
        int saniye = 1;
        int salise = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            timerdakika.Interval = 60000; 
            timersaniye.Interval = 1000; 
            timersalise.Interval = 10;  
            lbldk.Text = "0";
            lblsn.Text = "0";
            lblsl.Text = "0";
        }

        private void btnbasla_Click(object sender, EventArgs e)
        {
            timerdakika.Start();
            timersaniye.Start();
            timersalise.Start();
        }

        private void timerdakika_Tick(object sender, EventArgs e)
        {
            dakika++;
            lbldk.Text = Convert.ToString(dakika);
        }

        private void timersaniye_Tick(object sender, EventArgs e)
        {
            if (saniye == 60)
            {
                saniye = 0;
            }
            lblsn.Text = Convert.ToString(saniye);
            saniye++;
        }

        private void timersalise_Tick(object sender, EventArgs e)
        {
            if (salise == 100)
            {
                salise = 0;
            }
            lblsl.Text = Convert.ToString(salise);
            salise++;
        }

        private void btnbitir_Click(object sender, EventArgs e)
        {
            timerdakika.Stop();
            timersaniye.Stop();
            timersalise.Stop();
        }
    }
}
