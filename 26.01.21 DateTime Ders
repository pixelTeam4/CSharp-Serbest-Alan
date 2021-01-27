using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime date = new DateTime(2021,3,21);
            string a = date.ToString("MM/dd/yyyy HH:mm"); //Format belirler
            //MessageBox.Show(a);

            //Now - Today
            DateTime date2 = DateTime.Now;//DateTime.Today
            //MessageBox.Show(date2.ToString("HH:mm:ss"));


            //DayOfWeek
            if (date.DayOfWeek != DayOfWeek.Thursday)
            {
                //MessageBox.Show(date.DayOfWeek.ToString());
            }


            //Month
            string c = date.Month.ToString();
            //MessageBox.Show(date2.Month.ToString());


            //DayOfYear - Alınan tarihin kaçıncı gün olduğunu verir. Örneğin 80.Gün yada 290. Gün
                //MessageBox.Show(date.DayOfYear.ToString());


            //UtcNow - Şimdiki zamanın evrensel zaman değerini verir.
            DateTime date3 = DateTime.UtcNow;
            //MessageBox.Show(date3.ToString("dd.MM.yyyy"));


            //Date - DateTime tipinde döndürür;
            DateTime date4 = DateTime.Now;
            string d = date4.Date.ToString();



            //-------------
            //AddDays, AddHours, AddMinutes, AddMilliseconds, AddMonths, AddYears
            date4.AddDays(3);
            date4.AddHours(3);
            date4.AddMinutes(3);
            date4.AddMilliseconds(3);
            date4.AddMonths(3);
            date4.AddYears(-3);


            //Compare Metod iki parametre arasından büyük olanı gösterir
            string buyukKucuk = DateTime.Compare(date, date4).ToString();
            //MessageBox.Show(buyukKucuk);


            //Equals -- Eşitlik sorgusu
            if (date.Equals(date4))
            {

            }
        }
    }
}
