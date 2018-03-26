using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Home4_Click(object sender, EventArgs e)
        {
            var myForm1 = new Form1();
            myForm1.Show();
            Visible = false;
        }

        private void btnHome4_Click(object sender, EventArgs e)
        {
            var myForm1 = new Form1();
            myForm1.Show();
            Visible = false;
        }

        private void Create4_Click(object sender, EventArgs e)
        {
            var myForm2 = new Form2();
            myForm2.Show();
            Visible = false;
        }

        private void btnCreate4_Click(object sender, EventArgs e)
        {
            var myForm2 = new Form2();
            myForm2.Show();
            Visible = false;
        }

        private void Reservation4_Click(object sender, EventArgs e)
        {
            var myForm3 = new Form3();
            myForm3.Show();
            Visible = false;
        }

        private void btnReservation4_Click(object sender, EventArgs e)
        {
            var myForm3 = new Form3();
            myForm3.Show();
            Visible = false;
        }

        private void Records4_Click(object sender, EventArgs e)
        {
            var myForm4 = new Form4();
            myForm4.Show();
            Visible = false;
        }

        private void btnRecords4_Click(object sender, EventArgs e)
        {
            var myForm4 = new Form4();
            myForm4.Show();
            Visible = false;
        }

        private void label29_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
