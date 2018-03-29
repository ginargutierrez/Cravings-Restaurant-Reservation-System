using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        DataTable dt = new DataTable();

        public static string LastName1;
        public static string FirstName1;
        public static string MiddleName1;
        public static string Address1;
        public static string ContactNo1;
        public static string Date1;
        public static string NoOfPeople1;
        public static string TableNo1;
        public static string TypeOfMeal1;
        public static string transactionNo;
        public bool button2_Clicked = false;

        public Form4()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\GinaG\\Documents\\CRRS\\Cravings Restaurant Reservation System (CS)\Reservation.accdb";
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

        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label29_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataGrid.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this.dataGrid.Reservation);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button2_Clicked = true;
            //LastName1 = null;
            //FirstName1 = null;
            //MiddleName1 = null;
            //Address1 = null;
            //ContactNo1 = null;
            //TypeOfMeal1 = null;
            //NoOfPeople1 = null;
            //TableNo1 = null;

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            try
            {
                //command.CommandText = "INSERT INTO Reservation (TransactionNo, FirstName, LastName, MiddleName, ContactNo, Address, TypeOfMeal, [Date], NoOfPeople, TableNo) VALUES (@transactionNo, @firstName, @lastName, @middleName, @contactNo, @address, @typeOfMeal, @datee, @noOfPeople, @tableNo)";

                command.CommandText = "UPDATE Reservation set FirstName = @firstName, LastName = @lastName, MiddleName = @middleName, ContactNo = @contactNo, Address = @address, Date = @datee, NoOfPeople = @noOfPeople, TableNo = @tableNo, TypeOfMeal = @typeOfMeal WHERE TransactionNo = @textBox1";

                //command.CommandText = "INSERT INTO Reservation (FirstName) VALUES ('  firstNameLabel1.Text  ')";
                //command.CommandText = "INSERT INTO Reservation (LastName) VALUES ('   lastNameLabel1.Text   ')";
                //command.CommandText = "INSERT INTO Reservation (MiddleName) VALUES ('middleNameLabel1.Text')";
                //command.CommandText = "INSERT INTO Reservation (ContactNo) VALUES ('contactNoLabel1.Text')";
                //command.CommandText = "INSERT INTO Reservation (Address) VALUES ('addressLabel1.Text')";
                //command.CommandText = "INSERT INTO Reservation (Date) VALUES ('dateLabel1.Text')";
                //command.CommandText = "INSERT INTO Reservation (NoOfPeople) VALUES ('noOfPeopleLabel1.Text')";
                //command.CommandText = "INSERT INTO Reservation (TableNo) VALUES ('tableNoLabel1.Text')";
                //command.CommandText = "INSERT INTO Reservation (TypeOfMeal) VALUES ('typeOfMealLabel1.Text')";

                //string transactionNo = textBox1.Text;
                //string firstName = firstNameTextBox.Text;
                //string lastName = lastNameTextBox.Text;
                //string middleName = middleNameTextBox.Text;
                //string contactNo = contactNoTextBox.Text;
                //string address = addressTextBox.Text;
                //string typeOfMeal = typeOfMealComboBox.Text;
                //string date = dateDateTimePicker.Text;
                //string noOfPeople = noOfPeopleNumericUpDown.Text;
                //string tableNo = tableNoTextBox.Text;

                //command.Parameters.AddWithValue("@transactionNo", transactionNo);
                //command.Parameters.AddWithValue("@firstName", firstName);
                //command.Parameters.AddWithValue("@lastName", lastName);
                //command.Parameters.AddWithValue("@middleName", middleName);
                //command.Parameters.AddWithValue("@contactNo", contactNo);
                //command.Parameters.AddWithValue("@address", address);
                //command.Parameters.AddWithValue("@typerOfMeal", typeOfMeal);
                //command.Parameters.AddWithValue("@datee", date);
                //command.Parameters.AddWithValue("@noOfPeople", noOfPeople);
                //command.Parameters.AddWithValue("@tableNo", tableNo);

                command.ExecuteNonQuery();
                command.Parameters.Clear();
                MessageBox.Show("Saved");
                command.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                command.Connection.Close();
            }
        }

        private void dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void typeOfMealComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Update")
            {
                if (MessageBox.Show("Are you sure you want to update this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    reservationBindingSource.EndEdit();
            }
        }
    }
}
