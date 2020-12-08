using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace _291GroupProject
{
    public partial class AddAccount : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public SqlCommand ErrorCheckCommand;

        public AddAccount()
        {
            InitializeComponent();

            SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["291proj"].ConnectionString);



            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                ErrorCheckCommand = new SqlCommand();
                ErrorCheckCommand.Connection = myConnection;
                myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void AddAccountBackButton_Click(object sender, EventArgs e)
        {
            var newForm = new MainMenu();
            newForm.Show();
            this.Hide();
        }

        private void ZipBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            // Need to error check for duplicates of customer_ID, which is simple

            ErrorCheckCommand.CommandText = "select Customer_ID from Customers where Customer_ID = '" + CustomerIDBox.Text + "';";
            if (ErrorCheckCommand.ExecuteScalar() == null || ErrorCheckCommand.ExecuteScalar() == DBNull.Value)

            {
                
                myCommand.CommandText = " insert into Customers(Customer_ID,first_name,last_name,Driving_licence,street_name,street_number,apt_number,city,province,zip,phone_number)";
                myCommand.CommandText += "Values ('" + CustomerIDBox.Text + "','" + FirstNameBox.Text + "','" + LastNameBox.Text + "','";
                myCommand.CommandText += DrivingLicenseBox.Text + "','" + StreetNameBox.Text + "','" + NumberBox.Text + "','" + Apt_NumberBox.Text + "','" + CityBox.Text + "','";
                myCommand.CommandText += ProvinceBox.Text + "','" + ZipBox.Text + "','" + PhoneBox.Text + "')";
                myCommand.ExecuteNonQuery();

                MessageBox.Show("Inserted a User into database (Message is a placeholder, I'll show the first name and ID or something", "Message");
            }
            else
            {
                MessageBox.Show("There is already a Customer with this ID!");
            }
           
           

            

        }

        private void LastNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
