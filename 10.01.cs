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

namespace _10._01._2021_Ders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList name = new ArrayList();
        ArrayList surName = new ArrayList();
        ArrayList date = new ArrayList();
        ArrayList number = new ArrayList();

        //public void ara(string ara)
        //{
        //    if (name.Contains(ara)==true)
        //    {
        //        lblName.Text = nameTut;
        //        lblSurname.Text = surNameTut;
        //        lblNumber.Text = numberTut;
        //        lblDate.Text = dateTut;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Böyle bir Kayıt yok");
        //    }

        //}

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
        string nameTut;
        string surNameTut;
        string numberTut;
        string dateTut;
        string searchIndex;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            nameTut = txtName.Text;
            surNameTut = txtSurname.Text;
            numberTut = maskedTextBox1.Text;
            dateTut = maskedTextBox2.Text;
            name.Add(nameTut);
            surName.Add(surNameTut);
            number.Add(numberTut);
            date.Add(dateTut);
            listBox1.Items.Add(nameTut + " " + surNameTut + " " + numberTut + " " + dateTut);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            searchIndex = txtSearchIndex.Text;
            if (comboBox1.SelectedItem == "İsim")
            {
                if (name.Contains(searchIndex) ==true)
                {
                    lblName.Text = nameTut;
                    lblSurname.Text = surNameTut;
                    lblNumber.Text = numberTut;
                    lblDate.Text = dateTut;
                }
                else
                {
                    MessageBox.Show("Birşeyler Ters gitti");
                }
                
            }
            else if (comboBox1.SelectedItem == "Soyisim")
            {
                if (surName.Contains(searchIndex) == true)
                {
                    lblName.Text = nameTut;
                    lblSurname.Text = surNameTut;
                    lblNumber.Text = numberTut;
                    lblDate.Text = dateTut;
                }
                else
                {
                    MessageBox.Show("Birşeyler Ters gitti");
                }
            }
            else if (comboBox1.SelectedItem == "Telefon")
            {
                if (number.Contains(searchIndex) == true)
                {
                    lblName.Text = nameTut;
                    lblSurname.Text = surNameTut;
                    lblNumber.Text = numberTut;
                    lblDate.Text = dateTut;
                }
                else
                {
                    MessageBox.Show("Birşeyler Ters gitti");
                }
            }
            else if (comboBox1.SelectedItem == "D.Tarihi")
            {
                if (date.Contains(searchIndex) == true)
                {
                    lblName.Text = nameTut;
                    lblSurname.Text = surNameTut;
                    lblNumber.Text = numberTut;
                    lblDate.Text = dateTut;
                }
                else
                {
                    MessageBox.Show("Birşeyler Ters gitti");
                }
            }
        }
    }
}
