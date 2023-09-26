using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basithesapmakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSayi2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(txtSayi2.Text);
            sayi2 = Convert.ToInt32(txtSayi1.Text);
            sonuc = sayi1 + sayi2;
            lblSonuc.Text = "Sonuç: " + sonuc.ToString();


        }

        private void btnÇıkarma_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(txtSayi2.Text);
            sayi2 = Convert.ToInt32(txtSayi1.Text);
            sonuc = sayi1 - sayi2;
            lblSonuc.Text = "Fark: " + sonuc.ToString();
        }

        private void btnÇarpa_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(txtSayi2.Text);
            sayi2 = Convert.ToInt32(txtSayi1.Text);
            sonuc = sayi1 * sayi2;
            lblSonuc.Text = "Çarpım: " + sonuc.ToString();
        }

        private void btnBölme_Click(object sender, EventArgs e)
        {
            float sayi1, sayi2, sonuc;
            sayi1 = Convert.ToSingle(txtSayi2.Text);
            sayi2 = Convert.ToSingle(txtSayi1.Text);
            sonuc = sayi1 / sayi2;
            lblSonuc.Text = "Bölüm: " + sonuc.ToString();
        }
    }
}
    

