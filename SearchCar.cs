using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Configuration;


namespace _291GroupProject
{
    public partial class SearchCar : Form
    {
        public string CarModel;
        SqlConnection BranchBoxConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["291proj"].ConnectionString);
        public SearchCar()
        {
            InitializeComponent();
        }

        private void SearchBackButton_Click(object sender, EventArgs e)
        {
            var newForm = new MainMenu();
            newForm.Show();
            this.Hide();
        }

        private void SearchCar_Load(object sender, EventArgs e)
        {
            try
            {
                BranchBoxConnection.Open();
                SqlCommand BranchBoxCommand = new SqlCommand("select (Branch_ID) from Branches", BranchBoxConnection);
                SqlDataReader myreader;
                myreader = BranchBoxCommand.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Columns.Add("Branch_ID", typeof(int));
                DT.Load(myreader);
                BranchBox.ValueMember = "Branch_ID";
                BranchBox.DataSource = DT;
                BranchBoxConnection.Close();
            }
            catch (Exception) 
            {
            
            }
        }

        private void TruckButton_Click(object sender, EventArgs e)
        {   //Need to create a function to make this less copy paste
            //Function would just take an input like truck/sedan, then just change button1-6

            button5.BackgroundImage = _291GroupProject.Properties.Resources.truck_1;
            button5.Tag = "Jeep_Gladiator";

            button4.BackgroundImage = _291GroupProject.Properties.Resources.truck_2;
            button4.Tag = "Dodge_Ram";

            button3.BackgroundImage = _291GroupProject.Properties.Resources.truck_3;
            button3.Tag = "Ford_Raptor";

            button6.BackgroundImage = _291GroupProject.Properties.Resources.truck_4;
            button6.Tag = "Chevy_Silverado";

            button2.BackgroundImage = _291GroupProject.Properties.Resources.truck_5;
            button2.Tag = "Ford-F350";

            button1.BackgroundImage = _291GroupProject.Properties.Resources.truck_6;
            button1.Tag = "Chevy_Sierra";
        }

        private void SUVbutton_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = _291GroupProject.Properties.Resources.suv_1;
            button2.BackgroundImage = _291GroupProject.Properties.Resources.suv_2;
            button3.BackgroundImage = _291GroupProject.Properties.Resources.suv_3;
            button4.BackgroundImage = _291GroupProject.Properties.Resources.suv_4;
            button5.BackgroundImage = _291GroupProject.Properties.Resources.suv_5;
            button6.BackgroundImage = _291GroupProject.Properties.Resources.suv_6;
        }

        private void SedanButton_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = _291GroupProject.Properties.Resources.sedan_1;
            button2.BackgroundImage = _291GroupProject.Properties.Resources.sedan_2;
            button3.BackgroundImage = _291GroupProject.Properties.Resources.sedan_3;
            button4.BackgroundImage = _291GroupProject.Properties.Resources.sedan_4;
            button5.BackgroundImage = _291GroupProject.Properties.Resources.sedan_5;
            button6.BackgroundImage = _291GroupProject.Properties.Resources.sedan_6;
        }

        private void JeepButton_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = _291GroupProject.Properties.Resources.jeep_1;
            button2.BackgroundImage = _291GroupProject.Properties.Resources.jeep_2;
            button3.BackgroundImage = _291GroupProject.Properties.Resources.jeep_3;
            button4.BackgroundImage = _291GroupProject.Properties.Resources.jeep_4;
            button5.BackgroundImage = _291GroupProject.Properties.Resources.jeep_5;
            button6.BackgroundImage = _291GroupProject.Properties.Resources.jeep_6;
        }

        private void SportsCarButton_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = _291GroupProject.Properties.Resources.sports_1;
            button2.BackgroundImage = _291GroupProject.Properties.Resources.sports_2;
            button3.BackgroundImage = _291GroupProject.Properties.Resources.sports_3;
            button4.BackgroundImage = _291GroupProject.Properties.Resources.sports_4;
            button5.BackgroundImage = _291GroupProject.Properties.Resources.sports_5;
            button6.BackgroundImage = _291GroupProject.Properties.Resources.sports_6;
        }

        private void HybridButton_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = _291GroupProject.Properties.Resources.hybrid_1;
            button2.BackgroundImage = _291GroupProject.Properties.Resources.hybrid_2;
            button3.BackgroundImage = _291GroupProject.Properties.Resources.hybrid_3;
            button4.BackgroundImage = _291GroupProject.Properties.Resources.hybrid_4;
            button5.BackgroundImage = _291GroupProject.Properties.Resources.hybrid_5;
            button6.BackgroundImage = _291GroupProject.Properties.Resources.hybrid_6;
        }

        private void CompactButton_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = _291GroupProject.Properties.Resources.compact_1;
            button2.BackgroundImage = _291GroupProject.Properties.Resources.compact_2;
            button3.BackgroundImage = _291GroupProject.Properties.Resources.compact_3;
            button4.BackgroundImage = _291GroupProject.Properties.Resources.compact_4;
            button5.BackgroundImage = _291GroupProject.Properties.Resources.compact_5;
            button6.BackgroundImage = _291GroupProject.Properties.Resources.compact_6;
        }

        private void ConvertibleButton_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = _291GroupProject.Properties.Resources.convertible_1;
            button2.BackgroundImage = _291GroupProject.Properties.Resources.convertible_2;
            button3.BackgroundImage = _291GroupProject.Properties.Resources.convertible_3;
            button4.BackgroundImage = _291GroupProject.Properties.Resources.convertible_4;
            button5.BackgroundImage = _291GroupProject.Properties.Resources.convertible_5;
            button6.BackgroundImage = _291GroupProject.Properties.Resources.convertible_6;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //The MessageBox is just for testing and visual purposes, we will delete it later.
            SelectedCarImage.BackgroundImage = button2.BackgroundImage;
            CarModel = (string)button2.Tag;
            MessageBox.Show(CarModel);
        }

        private void button1_click(object sender, EventArgs e)
        {
            SelectedCarImage.BackgroundImage = button1.BackgroundImage;
            CarModel = (string)button1.Tag;
            MessageBox.Show(CarModel);
        }

        private void button3_click(object sender, EventArgs e)
        {
            SelectedCarImage.BackgroundImage = button3.BackgroundImage;
            CarModel = (string)button3.Tag;
            MessageBox.Show(CarModel);
        }

        private void button4_click(object sender, EventArgs e)
        {
            SelectedCarImage.BackgroundImage = button4.BackgroundImage;
            CarModel = (string)button4.Tag;
            MessageBox.Show(CarModel);
        }

        private void button5_click(object sender, EventArgs e)
        {
            SelectedCarImage.BackgroundImage = button5.BackgroundImage;
            CarModel = (string)button5.Tag;
            MessageBox.Show(CarModel);
        }

        private void button6_click(object sender, EventArgs e)
        {
            SelectedCarImage.BackgroundImage = button6.BackgroundImage;
            CarModel = (string)button6.Tag;
            MessageBox.Show(CarModel);
        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            try
            {
                BranchBoxConnection.Open();
                SqlCommand RentCommand = new SqlCommand("Select * from Cars where Model = 'Dodge_Ram' and active != 'Yes';", BranchBoxConnection);
            }
            catch 
            
            {
            
            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
