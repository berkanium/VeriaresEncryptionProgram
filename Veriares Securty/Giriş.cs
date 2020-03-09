using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Veriares_Securty
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        private void Giriş_Load(object sender, EventArgs e)
        {
            Loading.Image = Properties.Resources.loading;
            prgGiris.Maximum = 15;
            tmrZaman.Enabled = true;
            tmrZaman.Interval = 100;
        }
        
        Form1 frm1 = new Form1();
        private void tmrZaman_Tick(object sender, EventArgs e)
        {
            if (prgGiris.Value==prgGiris.Maximum)
            {
                tmrZaman.Enabled = false;
                this.Hide();
                frm1.ShowDialog();
            }
            else
            {
                prgGiris.Value +=1;
            }
        }
    }
}
