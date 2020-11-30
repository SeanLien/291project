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

        public AddAccount()
        {
            InitializeComponent();

            SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["291proj"].ConnectionString);



            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
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
            //myCommand.CommandText = "insert into Customers Values(";
            //myCommand.CommandText += "'" + NameBox.Text + "', '" + FamilyNameBox.Text + "', '" +
        }
    }
}
