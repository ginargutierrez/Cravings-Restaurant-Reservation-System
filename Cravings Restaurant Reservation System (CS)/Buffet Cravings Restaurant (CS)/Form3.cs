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
   
    public partial class Form3 : Form
    { 
        public static string LastName1;
        public static string FirstName1;
        public static string MiddleName1;
        public static string Address1;
        public static string ContactNo1;
        public static string Date1;
        public static string NoOfPeople1;
        public static string TableNo1;
        public static string TypeOfMeal1;
        public bool button2_Clicked = false;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transactionNo.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter9.Fill(this.transactionNo.Reservation);
            // TODO: This line of code loads data into the 'tableNo.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter8.Fill(this.tableNo.Reservation);
            // TODO: This line of code loads data into the 'noOfPeople.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter7.Fill(this.noOfPeople.Reservation);
            // TODO: This line of code loads data into the 'date.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter6.Fill(this.date.Reservation);
            // TODO: This line of code loads data into the 'typeOfMeal.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter5.Fill(this.typeOfMeal.Reservation);
            // TODO: This line of code loads data into the 'typeOfMeal.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter5.Fill(this.typeOfMeal.Reservation);
            // TODO: This line of code loads data into the 'contactNo.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter4.Fill(this.contactNo.Reservation);
            // TODO: This line of code loads data into the 'address.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter3.Fill(this.address.Reservation);
            // TODO: This line of code loads data into the 'address.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter3.Fill(this.address.Reservation);
            // TODO: This line of code loads data into the 'middleName.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter2.Fill(this.middleName.Reservation);
            // TODO: This line of code loads data into the 'firstName.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter1.Fill(this.firstName.Reservation);
            // TODO: This line of code loads data into the 'lastName.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this.lastName.Reservation);

            lastNameLabel1.Text = Form2.LastName;
            firstNameLabel1.Text = Form2.FirstName;
            middleNameLabel1.Text = Form2.MiddleName;
            addressLabel1.Text =  Form2.Address;
            contactNoLabel1.Text = Form2.ContactNo;
            dateLabel1.Text = Form2.Date;
            noOfPeopleLabel1.Text = Form2.NoOfPeople;
            tableNoLabel1.Text = Form2.TableNo;
            typeOfMealLabel1.Text = Form2.TypeOfMeal;
        }

        private void lastNameLabel1_Click(object sender, EventArgs e)
        {
            //lastNameLabel1.Text = Form2.LastName;
        }

        private void firstNameLabel1_Click(object sender, EventArgs e)
        {
            //firstNameLabel1.Text = Form2.FirstName;
        }

        private void middleNameLabel1_Click(object sender, EventArgs e)
        {
            //middleNameLabel1.Text = Form2.MiddleName;
        }

        private void addressLabel1_Click(object sender, EventArgs e)
        {
            //addressLabel1.Text = Form2.Address;
        }

        private void contactNoLabel1_Click(object sender, EventArgs e)
        {
            //contactNoLabel1.Text = Form2.ContactNo;
        }

        private void typeOfMealLabel1_Click(object sender, EventArgs e)
        {
            //typeOfMealLabel1.Text = Form2.TypeOfMeal;
        }

        private void dateLabel1_Click(object sender, EventArgs e)
        {
            //dateLabel1.Text = Form2.Date;
        }

        private void noOfPeopleLabel1_Click(object sender, EventArgs e)
        {
            //noOfPeopleLabel1.Text = Form2.NoOfPeople;
        }

        private void tableNoLabel1_Click(object sender, EventArgs e)
        {
            //tableNoLabel1.Text = Form2.TableNo;
        }

        private void transactionNoLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void Home3_Click(object sender, EventArgs e)
        {
            var myForm1 = new Form1();
            myForm1.Show();
            Visible = false;
        }

        private void btnHome3_Click(object sender, EventArgs e)
        {
            var myForm1 = new Form1();
            myForm1.Show();
            Visible = false;
        }

        private void Create3_Click(object sender, EventArgs e)
        {
            var myForm2 = new Form2();
            myForm2.Show();
            Visible = false;
        }

        private void btnCreate3_Click(object sender, EventArgs e)
        {
            var myForm2 = new Form2();
            myForm2.Show();
            Visible = false;
        }

        private void Reservation3_Click(object sender, EventArgs e)
        {
            var myForm3 = new Form3();
            myForm3.Show();
            Visible = false;
        }

        private void btnReservation3_Click(object sender, EventArgs e)
        {
            var myForm3 = new Form3();
            myForm3.Show();
            Visible = false;
        }

        private void Records3_Click(object sender, EventArgs e)
        {
            var myForm4 = new Form4();
            myForm4.Show();
            Visible = false;
        }

        private void btnRecords3_Click(object sender, EventArgs e)
        {
            var myForm4 = new Form4();
            myForm4.Show();
            Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var myForm2 = new Form2();
            myForm2.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2_Clicked = true;
            LastName1 = null;
            FirstName1 = null;
            MiddleName1 = null;
            Address1 = null;
            ContactNo1 = null;
            TypeOfMeal1 = null;
            NoOfPeople1 = null;
            TableNo1 = null;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (button2_Clicked == true)
            {
                LastName1 = null;
                FirstName1 = null;
                MiddleName1 = null;
                Address1 = null;
                ContactNo1 = null;
                TypeOfMeal1 = null;
                NoOfPeople1 = null;
                TableNo1 = null;
            }
            else
            {
                LastName1 = lastNameLabel1.Text;
                FirstName1 = firstNameLabel1.Text;
                MiddleName1 = middleNameLabel1.Text;
                Address1 = addressLabel1.Text;
                ContactNo1 = contactNoLabel1.Text;
                Date1 = dateLabel1.Text;
                NoOfPeople1 = noOfPeopleLabel1.Text;
                TableNo1 = tableNoLabel1.Text;
                TypeOfMeal1 = typeOfMealLabel1.Text;
            }

            Form2 form2 = new Form2();
            form2.Show();
            Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label29_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
