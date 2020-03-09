using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Veriares_Securty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 342;
        }

        private void btnCoz_Click(object sender, EventArgs e)
        {
            if (NetworkInterface.GetIsNetworkAvailable() == true && txtSifre.Text != "")
            {
                this.Width = 674;
                string SifreCoz = txtSifre.Text;
                byte[] CozulenVeriYaz = Convert.FromBase64String(SifreCoz);
                string sifreliVeri = ASCIIEncoding.ASCII.GetString(CozulenVeriYaz);
                txtVeri.Text = sifreliVeri;
                txtSifre.Clear();
                GorunutuAlani.Image = Properties.Resources.tenor;
                lblDurum.Text = "Şifrelenen Veriler Çözüldü.";
                label5.ForeColor = Color.Yellow;
            }
            else
            {
                MessageBox.Show("İnternet Bağlantınız Yok Veya Çözülecek Şifre Alanı Boş Bırakıldı\nLütfen Tekrar Deneyiniz.", "Veriares Securty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Width = 342;
            }
        }
        private void btnSifrele_Click(object sender, EventArgs e)
        {
            if (NetworkInterface.GetIsNetworkAvailable() == true&&txtVeri.Text != "")
            {
                this.Width = 674;
                string veri = txtVeri.Text;
                byte[] veriYaz = ASCIIEncoding.ASCII.GetBytes(veri);
                string sifreliVeri = Convert.ToBase64String(veriYaz);
                txtSifre.Text = sifreliVeri;
                txtVeri.Clear();
                GorunutuAlani.Image = Properties.Resources.community_image_1419882638;
                lblDurum.Text = "Veriler Şifrelendi.";
                label5.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("İnternet Bağlantınız Yok Veya Şifrelenecek Veri Alanı Boş Bırakıldı.\nLütfen Tekrar Deneyiniz.", "Veriares Securty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Width = 342;
            }
            
        }
    }
}
