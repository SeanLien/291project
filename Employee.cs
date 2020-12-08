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
        public SqlCommand myCommand2;
        public SqlCommand myCommand3;



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
                myCommand2 = new SqlCommand();
                myCommand3 = new SqlCommand();
                myCommand3.Connection = myConnection;
                myCommand2.Connection = myConnection;
                myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }


        }

       

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_291_group_projectDataSet.Branches' table. You can move, or remove it, as needed.
            this.branchesTableAdapter.Fill(this._291_group_projectDataSet.Branches);
            myCommand.CommandText = "select Branch_ID from Branches;";
            myCommand2.CommandText = "select CarType from Car_Types;";

            try
            {
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {


                    employee_add_branch_combo.Items.Add(myReader.GetValue(0).ToString());
                    edit_empl_branch.Items.Add(myReader.GetValue(0).ToString());
                    add_car_branch.Items.Add(myReader.GetValue(0).ToString());




                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                myReader.Close();
            }


            try
            {
                myReader = myCommand2.ExecuteReader();

                while (myReader.Read())
                {
                    
                    add_car_type.Items.Add(myReader.GetValue(0).ToString());



                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                myReader.Close();
            }




        }

    private void employee_search_Click(object sender, EventArgs e)
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
            active_combo.ResetText();

            myCommand.CommandText = "select * from Employees";
            if (employee_txt.Text != " ")
                myCommand.CommandText += " where Employees.Employee_ID = " + employee_txt.Text;


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
                    chng_epmoyee_id.Text = myReader.GetInt32(0).ToString();
                    edit_empl_branch.Text = myReader.GetInt32(10).ToString();
                    active_combo.Text = myReader.GetString(11);


                }
                employee_txt.Clear();
                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }



        

        


        private void button4_Click_1(object sender, EventArgs e)
        {
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from Customers";

            try
            {
                MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                dataGridView1.Rows.Clear();
                while (myReader.Read())
                {
                    dataGridView1.Rows.Add(myReader["Customer_ID"].ToString(), myReader["first_name"].ToString(), myReader["last_name"].ToString(), myReader["Driving_licence"].ToString(), myReader["membership"].ToString(), myReader["street_name"].ToString(), myReader["street_number"].ToString(), myReader["apt_number"].ToString(), myReader["city"].ToString(), myReader["province"].ToString(), myReader["zip"].ToString(), myReader["phone_number"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from Cars";

            try
            {
                MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                dataGridView5.Rows.Clear();
                while (myReader.Read())
                {
                    dataGridView5.Rows.Add(myReader["VIN"].ToString(), myReader["Color"].ToString(), myReader["Model"].ToString(), myReader["CarType"].ToString(), myReader["Branch_ID"].ToString(), myReader["active"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from Car_types";

            try
            {
                MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                dataGridView4.Rows.Clear();
                while (myReader.Read())
                {
                    dataGridView4.Rows.Add(myReader["CarType"].ToString(), myReader["price_D"].ToString(), myReader["price_W"].ToString(), myReader["price_M"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from Branches";

            try
            {
                MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                dataGridView3.Rows.Clear();
                while (myReader.Read())
                {
                    dataGridView3.Rows.Add(myReader["Branch_ID"].ToString(), myReader["street_name"].ToString(), myReader["street_number"].ToString(), myReader["city"].ToString(), myReader["province"].ToString(), myReader["zip"].ToString(), myReader["phone_number"].ToString(), myReader["active"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from Employees";

            try
            {
                MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                dataGridView2.Rows.Clear();
                while (myReader.Read())
                {
                    dataGridView2.Rows.Add(myReader["Employee_ID"].ToString(), myReader["first_name"].ToString(), myReader["middle_initial"].ToString(), myReader["last_name"].ToString(), myReader["street_name"].ToString(), myReader["street_number"].ToString(), myReader["city"].ToString(), myReader["province"].ToString(), myReader["zip"].ToString(), myReader["phone_number"].ToString(), myReader["Branch_ID"].ToString(), myReader["active"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from Rental_trans";

            try
            {
                MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                dataGridView6.Rows.Clear();
                while (myReader.Read())
                {
                    dataGridView6.Rows.Add(myReader["Rental_ID"].ToString(), myReader["pickup_date"].ToString(), myReader["return_date"].ToString(), myReader["price"].ToString(), myReader["returnDate"].ToString(), myReader["Customer_ID"].ToString(), myReader["Employee_ID"].ToString(), myReader["pickup_Branch_ID"].ToString(), myReader["return_Branch_ID"].ToString(), myReader["VIN"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        

        private void button16_Click(object sender, EventArgs e)
        {

            myCommand2.CommandText = "select count (*) From Branches Where Branch_ID = '" + employee_add_branch_combo.Text + "';";
            int num_branch = (int)myCommand2.ExecuteScalar();

            if (num_branch < 1)
            {
                MessageBox.Show("Branch not valid try again");
                
            }

            else
            {
                myCommand.CommandText = "insert into Employees Values(";
                myCommand.CommandText += "'" + first_add.Text + "', '" + init_add.Text + " ', '" + last_add.Text + "', '";
                myCommand.CommandText += street_name_add.Text + "', '" + street_no_add.Text + "', '" + city_add.Text + "', '";
                myCommand.CommandText += prov_add.Text + "', '" + postal_add.Text + "', '" + phone_add.Text + "', '" + employee_add_branch_combo.Text + "', 'Yes' )";




                try
                {

                    MessageBox.Show(myCommand.CommandText);
                    myCommand.ExecuteNonQuery();
                    first_add.Clear();
                    init_add.Clear();
                    last_add.Clear();
                    street_name_add.Clear();
                    street_no_add.Clear();
                    postal_add.Clear();
                    phone_add.Clear();
                    city_add.Clear();
                    prov_add.Clear();
                    employee_add_branch_combo.ResetText();

                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
        }

        private void employee_edit_Click_1(object sender, EventArgs e)
        {
            myCommand2.CommandText = "select count (*) From Branches Where Branch_ID = '" + edit_empl_branch.Text + "';";
            int num_branch = (int)myCommand2.ExecuteScalar();

            if (num_branch < 1)
            {
                MessageBox.Show("Invalid Branch ID try again");
            }

            else
            {

                myCommand.CommandText = "update Employees";

                myCommand.CommandText += " set " + "first_name = '" + dspl_first.Text + "', last_name = '" + dspl_last.Text + "',";
                myCommand.CommandText += "middle_initial ='" + dspl_mid.Text + "', street_name = '" + dspl_str_nm.Text + "',";
                myCommand.CommandText += "street_number = '" + dspl_str_num.Text + "', city = '" + dspl_cty.Text + "',";
                myCommand.CommandText += "province = '" + dspl_prov.Text + "', zip = '" + dspl_zip.Text + "', phone_number ='" + dspl_tel.Text + "', Branch_ID ='" + edit_empl_branch.Text + "', active='"+ active_combo.Text+"'";
                myCommand.CommandText += " where Employees.Employee_ID = " + chng_epmoyee_id.Text;

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
                    active_combo.ResetText();
                    edit_empl_branch.ResetText();
                    chng_epmoyee_id.Clear();




                }
                catch (Exception)
                {
                    MessageBox.Show(e.ToString(), "Error");
                }
            }
        }

        

        private void cancel_edit_Click(object sender, EventArgs e)
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
            employee_txt.Clear();
            chng_epmoyee_id.Clear();
            edit_empl_branch.ResetText();
            active_combo.ResetText();


        }

        private void clear_add_Click(object sender, EventArgs e)
        {
            first_add.Clear();
            init_add.Clear();
            last_add.Clear();
            street_name_add.Clear();
            street_no_add.Clear();
            postal_add.Clear();
            phone_add.Clear();
            city_add.Clear();
            prov_add.Clear();
            employee_add_branch_combo.ResetText();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "insert into Branches Values(";
            myCommand.CommandText += "'" + branch_add_str_name.Text + "', '" + branch_add_str_num.Text + " ', '" + branch_add_city.Text + "', '";
            myCommand.CommandText += branch_add_prov.Text + "', '" + branch_add_zip.Text + "', '" + branch_add_phone.Text + "', 'Yes')";
            




            try
            {

                MessageBox.Show(myCommand.CommandText);
                myCommand.ExecuteNonQuery();
                branch_add_str_name.Clear();
                branch_add_str_num.Clear();
                branch_add_city.Clear();
                branch_add_prov.Clear();
                branch_add_zip.Clear();
                branch_add_phone.Clear();
                



            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void search_branch_Click(object sender, EventArgs e)
        {
            dspl_branch_str_name.Clear();
            dspl_branch_str_no.Clear();
            dspl_branch_city.Clear();
            dspl_branch_prov.Clear();
            dspl_branch_zip.Clear();
            dspl_branch_phone.Clear();
            branch_active_combo.ResetText();

            myCommand.CommandText = "select * from Branches";
            if (dspl_branch_id.Text != " ")
            {
                myCommand.CommandText += " where Branches.Branch_ID = " + dspl_branch_id.Text;
            }

            try
            {

                MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();




                while (myReader.Read())
                {
                   if (!myReader.IsDBNull(0))
                    change_branch_txt.Text = myReader.GetInt32(0).ToString();
                   if (!myReader.IsDBNull(1))
                     dspl_branch_str_name.Text = myReader.GetString(1);
                   if (!myReader.IsDBNull(2))
                      dspl_branch_str_no.Text = myReader.GetString(2);
                   if (!myReader.IsDBNull(3))
                       dspl_branch_city.Text = myReader.GetString(3);
                   if (!myReader.IsDBNull(4))
                        dspl_branch_prov.Text = myReader.GetString(4);
                   if (!myReader.IsDBNull(5))
                        dspl_branch_zip.Text = myReader.GetString(5);
                   if (!myReader.IsDBNull(6))
                        dspl_branch_phone.Text = myReader.GetString(6);
                    if (!myReader.IsDBNull(7))
                        branch_active_combo.Text = myReader.GetString(7);


                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                myReader.Close();
            }
            dspl_branch_id.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "update Branches";

            myCommand.CommandText += " set " + "street_name = '" + dspl_branch_str_name.Text + "', street_number = '" + dspl_branch_str_no.Text+ "',";
            myCommand.CommandText += "city ='" + dspl_branch_city.Text + "', province = '" + dspl_branch_prov.Text + "',";
            myCommand.CommandText += "zip = '" + dspl_branch_zip.Text + "', phone_number = '" + dspl_branch_phone.Text + "', active ='"+ branch_active_combo.Text +"'";
            myCommand.CommandText += " where Branches.Branch_ID = " + change_branch_txt.Text;

            try
            {

                MessageBox.Show(myCommand.CommandText);
                myCommand.ExecuteNonQuery();
                dspl_branch_str_name.Clear();
                dspl_branch_str_no.Clear();
                dspl_branch_city.Clear();
                dspl_branch_prov.Clear();
                dspl_branch_zip.Clear();
                dspl_branch_phone.Clear();
                branch_active_combo.ResetText();





            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString(), "Error");
            }
            change_branch_txt.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            dspl_branch_str_name.Clear();
            dspl_branch_str_no.Clear();
            dspl_branch_city.Clear();
            dspl_branch_prov.Clear();
            dspl_branch_zip.Clear();
            dspl_branch_phone.Clear();
            change_branch_txt.Clear();
            branch_active_combo.ResetText();
        }

        private void button21_Click(object sender, EventArgs e)

        {
            myCommand3.CommandText = "select count  (*) From Car_Types where CarType ='" + add_car_type.Text + "';";
            myCommand2.CommandText = "select count (*) From Branches Where Branch_ID = '" + add_car_branch.Text + "';";
            int num_branch = (int)myCommand2.ExecuteScalar();
            int car_num = (int)myCommand3.ExecuteScalar();

            if (num_branch < 1 || car_num <1)
            {
                MessageBox.Show("Branch not valid or car_type not Valid try again");

            }

            else
            {
                myCommand.CommandText = "insert into Cars Values(";
                myCommand.CommandText += "'" + add_car_color.Text + "', '" + add_car_model.Text + " ', '" + add_car_type.Text + "', '";
                
                myCommand.CommandText += add_car_branch.Text + "', 'Yes' )";




                try
                {

                    MessageBox.Show(myCommand.CommandText);
                    myCommand.ExecuteNonQuery();
                    add_car_branch.ResetText();
                    add_car_color.Clear();
                    add_car_model.Clear();
                    add_car_type.ResetText();

                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }
        }

        private void emply_search_btn_Click(object sender, EventArgs e)
        {
            dspl_car_branch_combo.ResetText();
            dspl_car_col.Clear();
            dspl_car_model.ResetText();
            dspl_car_type_combo.ResetText();

            myCommand.CommandText = "select * from Cars";
            if (search_vin_empl.Text != " ")
            {
                myCommand.CommandText += " where Cars.VIN = " + search_vin_empl.Text;
            }

            try
            {

                MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();




                while (myReader.Read())
                {
                    if (!myReader.IsDBNull(0))
                        dspl_vin.Text = myReader.GetInt32(0).ToString();
                    if (!myReader.IsDBNull(1))
                        dspl_car_col.Text = myReader.GetString(1);
                    if (!myReader.IsDBNull(2))
                        dspl_car_model.Text = myReader.GetString(2);
                    if (!myReader.IsDBNull(3))
                        dspl_car_type_combo.Text = myReader.GetString(3);
                    if (!myReader.IsDBNull(4))
                        dspl_car_branch_combo.Text = myReader.GetInt32(4).ToString();
                    if (!myReader.IsDBNull(5))
                        dspl_car_active.Text = myReader.GetString(5);
                    


                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
                myReader.Close();
            }
           search_vin_empl.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "update Cars";

            myCommand.CommandText += " set " + "Color = '" + dspl_car_col.Text + "', Model = '" + dspl_car_model.Text + "',";
            myCommand.CommandText += "CarType ='" + dspl_car_type_combo.Text + "', Branch_ID = '" + dspl_car_branch_combo.Text + "',";
            myCommand.CommandText += "active = '" + dspl_car_active.Text + "'";
            myCommand.CommandText += " where Cars.VIN = " + dspl_vin.Text;

            try
            {

                MessageBox.Show(myCommand.CommandText);
                myCommand.ExecuteNonQuery();
                dspl_vin.Clear();
                dspl_car_col.Clear();
                dspl_car_model.Clear();
                dspl_car_branch_combo.ResetText();
                dspl_car_type_combo.ResetText();
                dspl_car_active.ResetText();





            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString(), "Error");
            }
            change_branch_txt.Clear();
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            dspl_vin.Clear();
            dspl_car_col.Clear();
            dspl_car_model.Clear();
            dspl_car_branch_combo.ResetText();
            dspl_car_type_combo.ResetText();
            dspl_car_active.ResetText();
        }
    }
}

