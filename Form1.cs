using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28012020_ders_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string Ekle(string a, string b)
        {
            return (a + " " + b+" "+date.ToString());
        }
        public void Aktar(int butonno,int indexno) {
            if (indexno==0 && butonno==1)//1ncu buton
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox2.Items.Add(listBox1.Items[i] + " " + date.ToString());
                }
                listBox1.Items.Clear();
            }
            else if (indexno == 1 && butonno == 1)//1ncu buton
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox3.Items.Add(listBox1.Items[i] + " " + date.ToString());
                }
                listBox1.Items.Clear();
            }
            else if (indexno == 0 && butonno == 2)//2ncu buton
            {
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    listBox1.Items.Add(listBox2.Items[i] + " " + date.ToString());
                }
                listBox2.Items.Clear();
            }
            else if (indexno == 1 && butonno == 2)//2ncu buton
            {
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    listBox3.Items.Add(listBox2.Items[i] + " " + date.ToString());
                }
                listBox2.Items.Clear();
            }
            else if (indexno == 0 && butonno == 3)//3üncu buton
            {
                for (int i = 0; i < listBox3.Items.Count; i++)
                {
                    listBox1.Items.Add(listBox3.Items[i] + " " + date.ToString());
                }
                listBox3.Items.Clear();
            }
            else if (indexno == 1 && butonno == 3)//3üncu buton
            {
                for (int i = 0; i < listBox3.Items.Count; i++)
                {
                    listBox2.Items.Add(listBox3.Items[i] + " " + date.ToString());
                }
                listBox3.Items.Clear();
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                listBox1.Items.Add(Ekle(textBox1.Text, textBox2.Text));
            }
            else if (checkBox2.Checked == true)
            {
                listBox2.Items.Add(Ekle(textBox1.Text, textBox2.Text));
            }
            else if (checkBox3.Checked == true)
            {
                listBox3.Items.Add(Ekle(textBox1.Text, textBox2.Text));
            }
        }
        DateTime date = DateTime.Now;

        private void button1_Click(object sender, EventArgs e)
        {
            Aktar(1, comboBox1.SelectedIndex);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Aktar(2, comboBox2.SelectedIndex);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Aktar(3, comboBox3.SelectedIndex);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)

        {
            
            checkBox1.Checked = false;
            checkBox3.Checked = false;
           
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
            checkBox2.Checked = false;
            checkBox1.Checked = false;
            
        }

        
    }
}
