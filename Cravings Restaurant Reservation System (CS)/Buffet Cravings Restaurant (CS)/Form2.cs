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
    public partial class Form2 : Form
    {
        public static string LastName;
        public static string FirstName;
        public static string MiddleName;
        public static string Address;
        public static string ContactNo;
        public static string Date;
        public static int NoOfPeople;
        public static string TableNo;
        public static string TypeOfMeal;
        public static string Confirmation;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'typeOfMeal.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter5.Fill(this.typeOfMeal.Reservation);
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
            // TODO: This line of code loads data into the 'middleName.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter2.Fill(this.middleName.Reservation);
            // TODO: This line of code loads data into the 'firstName1.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter1.Fill(this.firstName1.Reservation);
            // TODO: This line of code loads data into the 'lastName.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this.lastName.Reservation);

           

            lastNameTextBox.Text = Form3.LastName1;
            firstNameTextBox.Text = Form3.FirstName1;
            middleNameTextBox.Text = Form3.MiddleName1;
            addressTextBox.Text = Form3.Address1;
            contactNoTextBox.Text = Form3.ContactNo1;
            dateDateTimePicker.Text = Form3.Date1;
            noOfPeopleNumericUpDown.Value = Form3.NoOfPeople1;
            tableNoTextBox.Text = Form3.TableNo1;
            typeOfMealComboBox.Text = Form3.TypeOfMeal1;

            typeOfMealComboBox.Text = Form1.reservedMeal;
            dateDateTimePicker.Text = Form1.reservedDate;
            tableNoTextBox.Text = Form1.reservedTable;
        }

        public void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            lastNameTextBox.MaxLength = 15;

            if (!(System.Text.RegularExpressions.Regex.IsMatch(lastNameTextBox.Text, "^[a-z A-Z]+$")))
            {
                if (!(lastNameTextBox.TextLength == 0))
                {
                    lastNameTextBox.Text = lastNameTextBox.Text.Remove(lastNameTextBox.Text.Length - 1);
                    lastNameTextBox.SelectionStart = lastNameTextBox.Text.Length + 1;
                }

            }
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            firstNameTextBox.MaxLength = 10;
            if (!(System.Text.RegularExpressions.Regex.IsMatch(firstNameTextBox.Text, "^[a-z A-Z]+$")))
           { 
                if (!(firstNameTextBox.TextLength == 0))
                { 
                    firstNameTextBox.Text = firstNameTextBox.Text.Remove(firstNameTextBox.Text.Length - 1);
                    firstNameTextBox.SelectionStart = firstNameTextBox.Text.Length + 1;
                }
             }
        }

        private void middleNameTextBox_TextChanged(object sender, EventArgs e)
        {
            middleNameTextBox.MaxLength = 10;
            if (!(System.Text.RegularExpressions.Regex.IsMatch(middleNameTextBox.Text, "^[a-z A-Z]+$")))
            {
                if (!(middleNameTextBox.TextLength == 0))
                {
                    middleNameTextBox.Text = middleNameTextBox.Text.Remove(middleNameTextBox.Text.Length - 1);
                    middleNameTextBox.SelectionStart = middleNameTextBox.Text.Length + 1;
                }

            }
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            Address = addressTextBox.Text;
            addressTextBox.MaxLength = 30;
        }

        private void contactNoTextBox_TextChanged(object sender, EventArgs e) 
        {
            contactNoTextBox.MaxLength = 11;
            if (System.Text.RegularExpressions.Regex.IsMatch(contactNoTextBox.Text, "[^0-9]"))
            {
                if (!(contactNoTextBox.TextLength == 0))
                {
                    contactNoTextBox.Text = contactNoTextBox.Text.Remove(contactNoTextBox.Text.Length - 1);
                    contactNoTextBox.SelectionStart = contactNoTextBox.Text.Length + 1;
                   
                }

            }
        }

        private void typeOfMealComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeOfMeal = typeOfMealComboBox.Text;
        }

        private void dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Date = dateDateTimePicker.Text;
        }

        private void noOfPeopleNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NoOfPeople = Convert.ToInt32(noOfPeopleNumericUpDown.Value);
        }

        private void Home2_Click(object sender, EventArgs e)
        {
            var myForm1 = new Form1();
            myForm1.Show();
            Visible = false;
        }

        private void btnHome2_Click(object sender, EventArgs e)
        {
            var myForm1 = new Form1();
            myForm1.Show();
            Visible = false;
        }

        private void btnCreate2_Click(object sender, EventArgs e)
        {
        }

        private void Reservation2_Click(object sender, EventArgs e)
        {
            var myForm3 = new Form3();
            myForm3.Show();
            Visible = false;
        }

        private void btnReservation2_Click(object sender, EventArgs e)
        {
            var myForm3 = new Form3();
            myForm3.Show();
            Visible = false;
        }

        private void Records2_Click(object sender, EventArgs e)
        {
            var myForm4 = new Form4();
            myForm4.Show();
            Visible = false;
        }

        private void btnRecords2_Click(object sender, EventArgs e)
        {
            if (!(typeOfMealComboBox.Text == "" || dateDateTimePicker.Text == "" || typeOfMealComboBox.Text == ""))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to leave?\n" + "Unsaved changes will be void.", "Attention!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Form4 myForm4 = new Form4();
                    myForm4.Show();
                    this.Visible = false;
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var myForm1 = new Form1();
            myForm1.Show();
            Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lastNameTextBox.Text = "";
            firstNameTextBox.Text = "";
            middleNameTextBox.Text = "";
            addressTextBox.Text = "";
            contactNoTextBox.Text = "";
            noOfPeopleNumericUpDown.Value = 0;
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableNoNumericUpDown_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void tableNoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            LastName = lastNameTextBox.Text;
            FirstName = firstNameTextBox.Text;
            MiddleName = middleNameTextBox.Text;
            Address = addressTextBox.Text;
            ContactNo = contactNoTextBox.Text;
            Date = dateDateTimePicker.Text;
            NoOfPeople = Convert.ToInt32(noOfPeopleNumericUpDown.Value);
            TableNo = tableNoTextBox.Text;
            TypeOfMeal = typeOfMealComboBox.Text;

            if (LastName == "" || FirstName == "" || MiddleName == "" || Address == "" || ContactNo == "" || NoOfPeople == 0)
            {
                DialogResult d = MessageBox.Show("All fields are required!\n" + "Please complete the form.", "Attention!");
            }
            else
            {
                Form3 form3 = new Form3();
                form3.Show();
                Visible = false;
            }
        }

        private void typeOfMealComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label29_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
