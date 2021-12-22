using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse

         );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            panel.Height = buttonja.Height;
            panel.Top = buttonda.Top;
            panel.Left = buttonua.Left;
            buttonda.BackColor = Color.FromArgb(46, 51, 73);

            Kim.Text = "Dashboard";
            this.formloader.Controls.Clear();
            frm1 frm1cs = new frm1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm1cs.FormBorderStyle = FormBorderStyle.None;
            this.formloader.Controls.Add(frm1cs);
            frm1cs.Show();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dashboardDataSet.Dashboard' table. You can move, or remove it, as needed.
            this.dashboardTableAdapter.Fill(this.dashboardDataSet.Dashboard);

        }

        private void buttonda_Click(object sender, EventArgs e)
        {
            panel.Height = buttonja.Height;
            panel.Top = buttonda.Top;
            panel.Left = buttonua.Left;
            buttonda.BackColor = Color.FromArgb(46, 51, 73);

            Kim.Text = "Dashboard";
            this.formloader.Controls.Clear();
            frm1 frm1cs = new frm1 { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm1cs.FormBorderStyle = FormBorderStyle.None;
            this.formloader.Controls.Add(frm1cs);
            frm1cs.Show();


        }

        private void buttonja_Click(object sender, EventArgs e)
        {
            panel.Height = buttonja.Height;
            panel.Top = buttonja.Top;
            buttonja.BackColor = Color.FromArgb(46, 51, 73);

            Kim.Text = "Jenis Alat";
            this.formloader.Controls.Clear();
            frm2 frm2cs = new frm2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm2cs.FormBorderStyle = FormBorderStyle.None;
            this.formloader.Controls.Add(frm2cs);
            frm2cs.Show();
        }

        private void buttonua_Click(object sender, EventArgs e)
        {
            panel.Height = buttonua.Height;
            panel.Top = buttonua.Top;
            buttonua.BackColor = Color.FromArgb(46, 51, 73);

            Kim.Text = "Utilitas Alat";
            this.formloader.Controls.Clear();
            frm3 frm3cs = new frm3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm3cs.FormBorderStyle = FormBorderStyle.None;
            this.formloader.Controls.Add(frm3cs);
            frm3cs.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonda_Leave(object sender, EventArgs e)
        {
            buttonda.BackColor = Color.FromArgb(28, 40, 65);
        }

        private void buttonja_Leave(object sender, EventArgs e)
        {
            buttonja.BackColor = Color.FromArgb(28, 40, 65);
        }

        private void buttonua_Leave(object sender, EventArgs e)
        {
            buttonua.BackColor = Color.FromArgb(28, 40, 65);
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(28, 40, 65);
        }
    }
}
