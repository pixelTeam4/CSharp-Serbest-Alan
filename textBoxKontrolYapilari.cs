using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textBoxKontrolYapılari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Harf Hariç Tutmak 
        char[] harf = { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'i', 'ı', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };
        // Sayı Hariç Tutmak
        int[] sayi = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        // Karakter Hariç Tutmak
        char[] karakter = { '!', '"', ',', '^', '+', '%', '&', '/', '(', ')', '=', '*', '?' };
       
    }
}
