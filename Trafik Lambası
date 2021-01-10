using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafikLambasi
{
    public partial class FormTrafikLambasi : Form
    {
        public FormTrafikLambasi()
        {
            InitializeComponent();
        }

        int saniye = 25;
        int t = 3; // 3 tane olay var.Her bir olayı tutucak değişken.

        private void FormTrafikLambasi_Load(object sender, EventArgs e)
        {
            ovalshapered.BackColor = Color.Red;
            btntime.Text = saniye.ToString();

            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Interval = 1000; //1 saniyeye karşılık gelmektedir.

            if (t == 3) //kırmızı yanarken
            {
                saniye--;
                btntime.Text = saniye.ToString();
                if (saniye == 0)
                {
                    t = 2; //sarı
                    ovalshapered.BackColor = Color.Empty;

                    ovalshapeyellow.BackColor = Color.Yellow;
                    saniye = 3;
                }
            }
            else if (t == 2) //sarı yanarken
            {
                saniye--;
                btntime.Text = saniye.ToString();
                if (saniye == 0)
                {
                    t = 1; //yeşil
                    ovalshapeyellow.BackColor = Color.Empty;
                    ovalshapegreen.BackColor = Color.Green;
                    saniye = 15;
                }
            }
            else if (t == 1) // yeşil yanarken
            {
                saniye--;
                btntime.Text = saniye.ToString();
                if (saniye == 0)
                {
                    t = 3; //kırmızı
                    ovalshapegreen.BackColor = Color.Empty;
                    ovalshapered.BackColor = Color.Red;
                    saniye = 25;
                }
            }
        }
    }
}
