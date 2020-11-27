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
    public partial class Employee : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;


        public Employee()
        {
            InitializeComponent();

            //String connectionString = "Server= 34.94.59.37;Database= 291_group_project ; User Id= sqlserver; Password=1245;";


            /* Starting the connection */
            /*  SqlConnection myConnection = new SqlConnection("user id=temp2;" + // Username
                                         "password=adminadmin;" + // Password
                                         "server=localhost;" + // IP for the server
                                                               //"Trusted_Connection=yes;" +
                                         "database=ConnectTutorial; " + // Database to connect to
                                         "connection timeout=30"); // Timeout in seconds */

            //SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds
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

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            dspl_first.Clear();
            dspl_last.Clear();
            dspl_mid.Clear();
            dspl_str_nm.Clear();
            dspl_str_num.Clear();
            dspl_cty.Clear();
            dspl_prov.Clear();
            dspl_zip.Clear();
            dspl_tel.Clear();


            myCommand.CommandText = "select * from Employee";
            if (employee_txt.Text != " ")
            myCommand.CommandText += " where Employee.Employee_ID = " + employee_txt.Text;


            try
            {

                MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();
             
               


                while (myReader.Read())
                {
                    dspl_first.Text = myReader.GetString(1);
                    dspl_last.Text = myReader.GetString(3);
                    dspl_mid.Text = myReader.GetString(2);
                    dspl_str_nm.Text = myReader.GetString(4);
                    dspl_str_num.Text = myReader.GetString(5);
                    dspl_cty.Text = myReader.GetString(6);
                    dspl_prov.Text = myReader.GetString(7);
                    dspl_zip.Text = myReader.GetString(8);
                    dspl_tel.Text = myReader.GetString(9);


                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }



        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void update_employee_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "update Employee";

            myCommand.CommandText += " set " + "first_name = '" + dspl_first.Text + "', last_name = '" + dspl_last.Text+"',";
            myCommand.CommandText += "middle_initial ='" + dspl_mid.Text + "', street_name = '" + dspl_str_nm.Text+"',";
            myCommand.CommandText += "street_number = '" + dspl_str_num.Text + "', city = '" + dspl_cty.Text+"',";
            myCommand.CommandText += "province = '" + dspl_prov.Text + "', zip = '" + dspl_zip.Text + "', phone_number ='" + dspl_tel.Text +"'";
            myCommand.CommandText += " where Employee.Employee_ID = " + employee_txt.Text;

            try
            {

                MessageBox.Show(myCommand.CommandText);
                myCommand.ExecuteNonQuery();
                dspl_first.Clear();
                dspl_last.Clear();
                dspl_mid.Clear();
                dspl_str_nm.Clear();
                dspl_str_num.Clear();
                dspl_cty.Clear();
                dspl_prov.Clear();
                dspl_zip.Clear();
                dspl_tel.Clear();
                employee_txt.Clear();



            }
            catch (Exception)
            {
                MessageBox.Show("Cannot Add, make please enter employee ID");
            }
        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_employee_btn_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "insert into Employee Values(";
            myCommand.CommandText += "'" + add_employee_Id.Text + "', '" + add_last.Text + "', '" + add_middle_initial.Text+" ', '" + add_first.Text + "', '";
            myCommand.CommandText += add_str_name.Text + "', '" + add_str_num.Text + "', '" + add_city.Text + "', '";
            myCommand.CommandText += add_prov.Text+ "', '"+add_zip.Text+ "', '"+add_phone.Text+"' )";




            try
            {

                MessageBox.Show(myCommand.CommandText);
                myCommand.ExecuteNonQuery();
                add_employee_Id.Clear();
                add_last.Clear();
                add_first.Clear();
                add_middle_initial.Clear();
                add_str_name.Clear();
                add_str_num.Clear();
                add_zip.Clear();
                add_phone.Clear();
                add_city.Clear();
                add_prov.Clear();


            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }
    }
}
