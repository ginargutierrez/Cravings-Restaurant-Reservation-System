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
    //public static string SetValueForTable1 = "";
    public partial class Form1 : Form
    {
        public static string reservedDate;
        public static string reservedMeal;
        public static string reservedTable;
        public string table;
        public bool reserve1 = false;
        public bool reserve2 = false;
        public bool reserve3 = false;
        public bool reserve4 = false;
        public bool reserve5 = false;
        public bool reserve6 = false;
        public bool reserve7 = false;
        public bool reserve8 = false;
        public bool reserve9 = false;
        public bool reserve10 = false;
        public bool reserve11= false;
        public bool reserve12 = false;
        public bool reserve13 = false;
        public bool reserve14 = false;
        public bool reserve15 = false;
        public bool reserve16 = false;
        public bool reserve17 = false;
        public bool reserve18 = false;

        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Create1_Click(object sender, EventArgs e)
        {
            var myForm = new Form2();
            myForm.Show();
            Visible = false;

        }

        private void Reservation1_Click(object sender, EventArgs e)
        {
            var myForm3 = new Form3();
            myForm3.Show();
            Visible = false;
        }


        private void Records1_Click(object sender, EventArgs e)
        {
            var myForm4 = new Form4();
            myForm4.Show();
            Visible = false;
        }


        private void btnHome1_Click(object sender, EventArgs e)
        {
            var myForm1 = new Form1();
            myForm1.Show();
            Visible = false;
        }

        private void btnCreate1_Click(object sender, EventArgs e)
        {
            var myForm2 = new Form2();
            myForm2.Show();
            Visible = false;
        }

        private void Home1_Click(object sender, EventArgs e)
        {
            var myForm1 = new Form1();
            myForm1.Show();
            Visible = false;
        }

        private void Create1_Click_1(object sender, EventArgs e)
        {
            var myForm2 = new Form2();
            myForm2.Show();
            Visible = false;
        }

        private void btnReservation1_Click(object sender, EventArgs e)
        {
            var myForm3 = new Form3();
            myForm3.Show();
            Visible = false;
        }

        private void btnRecords1_Click(object sender, EventArgs e)
        {
            var myForm4 = new Form4();
            myForm4.Show();
            Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            reserve1 = true;

            pictureBox1.BackColor = Color.LimeGreen;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.Transparent;
            pictureBox18.BackColor = Color.Transparent;
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            reserve2 = true;

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.LimeGreen;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.Transparent;
            pictureBox18.BackColor = Color.Transparent;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            reserve3 = true;

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.LimeGreen;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.Transparent;
            pictureBox18.BackColor = Color.Transparent;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            reserve4 = true;

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.LimeGreen;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.Transparent;
            pictureBox18.BackColor = Color.Transparent;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            reserve5 = true;

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.LimeGreen;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.Transparent;
            pictureBox18.BackColor = Color.Transparent;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            reserve6 = true;

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.LimeGreen;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.Transparent;
            pictureBox18.BackColor = Color.Transparent;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            reserve7 = true;

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.LimeGreen;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.Transparent;
            pictureBox18.BackColor = Color.Transparent;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            reserve8 = true;

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.LimeGreen;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.Transparent;
            pictureBox18.BackColor = Color.Transparent;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            reserve9 = true;

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.LimeGreen;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.Transparent;
            pictureBox18.BackColor = Color.Transparent;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            reserve10 = true;

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.LimeGreen;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.Transparent;
            pictureBox18.BackColor = Color.Transparent;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            reserve11 = true;

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.LimeGreen;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.Transparent;
            pictureBox18.BackColor = Color.Transparent;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            reserve12 = true;

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.LimeGreen;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.Transparent;
            pictureBox18.BackColor = Color.Transparent;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            reserve13 = true;

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.LimeGreen;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.Transparent;
            pictureBox18.BackColor = Color.Transparent;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            reserve14 = true;

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.LimeGreen;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.Transparent;
            pictureBox18.BackColor = Color.Transparent;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            reserve15 = true;

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.LimeGreen;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.Transparent;
            pictureBox18.BackColor = Color.Transparent;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            reserve16 = true;

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.LimeGreen;
            pictureBox17.BackColor = Color.Transparent;
            pictureBox18.BackColor = Color.Transparent;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            reserve17 = true;

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.LimeGreen;
            pictureBox18.BackColor = Color.Transparent;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            reserve18 = true;

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.Transparent;
            pictureBox18.BackColor = Color.LimeGreen;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label29_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.Text;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (reserve1 == true){
                table = "S1";
            }else if (reserve2 == true){
                table = "S2";
            }else if (reserve3 == true){
                table = "S3";
            }else if (reserve4 == true){
                table = "S4";
            }else if (reserve5 == true){
                table = "F1";
            }else if (reserve6 == true){
                table = "F2";
            }else if (reserve7 == true){
                table = "T1";
            }else if (reserve8 == true){
                table = "T2";
            }else if (reserve9 == true){
                table = "Q1";
            }else if (reserve10 == true){
                table = "Q2";
            }else if (reserve11 == true){
                table = "Q3";
            }else if (reserve12 == true){
                table = "Q4";
            }else if (reserve13 == true){
                table = "D1";
            }else if (reserve14 == true){
                table = "D2";
            }else if (reserve15 == true){
                table = "D3";
            }else if (reserve16 == true){
                table = "D4";
            }else if (reserve17 == true){
                table = "D5";
            }else if (reserve18 == true){
                table = "D6";
            }
            else if (reserve1 == false || reserve2 == false || reserve3 == false || reserve4 == false || reserve5 == false || reserve6 == false || reserve7 == false
                  || reserve8 == false || reserve9 == false || reserve10 == false || reserve11 == false || reserve12 == false || reserve13 == false || reserve14 == false
                  || reserve15 == false || reserve16 == false || reserve17 == false || reserve18 == false)
            {
                table = "";
            }

            reservedMeal = comboBox1.Text;
            reservedDate = monthCalendar1.Text;
            reservedTable = table;

            if (reservedDate == "" || reservedMeal == "" || reservedTable == "")
            {
                MessageBox.Show("The date, meal or table is not yet complete. All fields are required!");
            }
            else
            {   Form2 form2 = new Form2();
                form2.Show();
                Visible = false;
            }
        }


    }
}
