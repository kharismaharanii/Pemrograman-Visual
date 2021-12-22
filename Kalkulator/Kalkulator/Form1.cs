using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        private float operasi1 = 0;
        private string operasi2 = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void nol_Click_1(object sender, EventArgs e)
        {
            string tampil = operasi.Text;
            if (tampil == "")
            {
                tampil = "0";
            }
            else
            {
                tampil = tampil + "0";
            }
            operasi.Text = tampil;
        }

        private void satu_Click(object sender, EventArgs e)
        {
            string tampil = operasi.Text;
            if (tampil == "")
            {
                tampil = "1";
            }
            else
            {
                tampil = tampil + "1";
            }
            operasi.Text = tampil;
        }

        private void dua_Click(object sender, EventArgs e)
        {
            string tampil = operasi.Text;
            if (tampil == "")
            {
                tampil = "2";
            }
            else
            {
                tampil = tampil + "2";
            }
            operasi.Text = tampil;
        }

        private void tiga_Click(object sender, EventArgs e)
        {
            string tampil = operasi.Text;
            if (tampil == "")
            {
                tampil = "3";
            }
            else
            {
                tampil = tampil + "3";
            }
            operasi.Text = tampil;
        }

        private void empat_Click(object sender, EventArgs e)
        {
            string tampil = operasi.Text;
            if (tampil == "")
            {
                tampil = "4";
            }
            else
            {
                tampil = tampil + "4";
            }
            operasi.Text = tampil;
        }

        private void lima_Click(object sender, EventArgs e)
        {
            string tampil = operasi.Text;
            if (tampil == "")
            {
                tampil = "5";
            }
            else
            {
                tampil = tampil + "5";
            }
            operasi.Text = tampil;
        }

        private void enam_Click(object sender, EventArgs e)
        {
            string tampil = operasi.Text;
            if (tampil == "")
            {
                tampil = "6";
            }
            else
            {
                tampil = tampil + "6";
            }
            operasi.Text = tampil;
        }

        private void tujuh_Click(object sender, EventArgs e)
        {
            string tampil = operasi.Text;
            if (tampil == "")
            {
                tampil = "7";
            }
            else
            {
                tampil = tampil + "7";
            }
            operasi.Text = tampil;
        }

        private void delapan_Click(object sender, EventArgs e)
        {
            string tampil = operasi.Text;
            if (tampil == "")
            {
                tampil = "8";
            }
            else
            {
                tampil = tampil + "8";
            }
            operasi.Text = tampil;
        }

        private void sembilan_Click(object sender, EventArgs e)
        {
            string tampil = operasi.Text;
            if (tampil == "")
            {
                tampil = "9";
            }
            else
            {
                tampil = tampil + "9";
            }
            operasi.Text = tampil;
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            operasi.Text = "";
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            float tampil = Convert.ToInt32(operasi.Text);
            this.operasi1 = tampil;
            this.operasi2 = "+";
            operasi.Text = "";
        }

        private void kurang_Click(object sender, EventArgs e)
        {
            float tampil = Convert.ToInt32(operasi.Text);
            this.operasi1 = tampil;
            this.operasi2 = "-";
            operasi.Text = "";
        }

        private void kali_Click(object sender, EventArgs e)
        {
            float tampil = Convert.ToInt32(operasi.Text);
            this.operasi1 = tampil;
            this.operasi2 = "*";
            operasi.Text = "";
        }

        private void bagi_Click(object sender, EventArgs e)
        {
            float tampil = Convert.ToInt32(operasi.Text);
            this.operasi1 = tampil;
            this.operasi2 = "/";
            operasi.Text = "";
        }

        private void hasil_Click(object sender, EventArgs e)
        {
            float hasil = 0;
            float tampil = 0;

            if (operasi.Text.Equals(""))
            {
                tampil = 0;
            }
            else
            {
                tampil = Convert.ToInt32(operasi.Text);
            }

            if (this.operasi2 == "+")
            {
                hasil = this.operasi1 + tampil;
            }

            else if (this.operasi2 == "*")
            {
                hasil = this.operasi1 * tampil;
            }

            else if (this.operasi2 == "/")
            {
                hasil = this.operasi1 / tampil;
            }

            if (this.operasi2 == "-")
            {
                hasil = this.operasi1 - tampil;
            }

            operasi.Text = Convert.ToString(hasil);
            this.operasi1 = 0;
            this.operasi2 = "";
        }
    }
}
