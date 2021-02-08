using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();
        }
        private void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8];

            int top = 0;
            int left = 0;
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)//GetUpperBound Listenin Hangi Boyutunda işlem yapacağımızı belirtiyoruz . Burada 0 yani ilk boyutunu.Satırları dönüyoruz.
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)//Burada listenin 1.index no lu boyutunu yani 2. boyutunu dönüyoruz .Sütunları bölüyoruz.
                {
                    buttons[i, j] = new Button();//8x8 lik döneceğimiz için Her seferinde yeni buton oluşması zorunlu.
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Top = top;
                    buttons[i, j].Left = left;
                    left += 50;//Eğer bunu belirtmezsek olduğu yerde 8x8 =64 tane butonu iç içe yazar.
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    //Burası Çokomelli ! Eğer aşağıdaki kod yazılmazsa yukarıdaki methodun ne yapacağını belirtmemiş oluruz . 
                    //This = Aktif form methodu
                    //Controls.add da formu kontrol et . Ekle (neyi = oluşturacağımız objeyi Yani butonu )
                    this.Controls.Add(buttons[i,j]);
                }

                top += 50;//Amacımız sol taraf bittikten sonra 8 tane yazdktan sonra aşağıdan ilerlemeye başlasın.
                left = 0;//Amacımız sol tarafı ekleyip bitirdikten sonra üzerine yazmasın .
            }

        }
    }
}
