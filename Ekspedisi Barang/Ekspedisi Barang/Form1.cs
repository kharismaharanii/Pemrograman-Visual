using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekspedisi_Barang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rkota_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rkota.Text == "Gresik")
            {
                tongkir.Text = "12000";
            }
            else if (rkota.Text == "Krian")
            {
                tongkir.Text = "18000";
            }
            else if (rkota.Text == "Pasuruan")
            {
                tongkir.Text = "21000";
            }
            else if (rkota.Text == "Surabaya")
            {
                tongkir.Text = "9000";
            }
            else if (rkota.Text == "Sidoarjo")
            {
                tongkir.Text = "15000";
            }
        }

        private void cekharga_Click(object sender, EventArgs e)
        {
            ttotal.Text = (int.Parse(bbarang.Text) * int.Parse(tongkir.Text)).ToString();
        }

        private void bproses_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terima kasih, telah menggunakan layanan Kami!");
        }
    }
}
