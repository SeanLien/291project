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
        public string CarType;
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlCommand Rental2;
        public SqlDataReader myReader;
        public SqlConnection BranchBoxConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["291proj"].ConnectionString);
        public SqlConnection BranchBoxColor = new SqlConnection(ConfigurationManager.ConnectionStrings["291proj"].ConnectionString);
        public SqlConnection RentingConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["291proj"].ConnectionString);
        public SearchCar()
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

        private void SearchBackButton_Click(object sender, EventArgs e)
        {
            var newForm = new MainMenu();
            newForm.Show();
            this.Hide();
        }
        
        private void SearchCar_Load(object sender, EventArgs e)
        {/*
            try
            {
                BranchBoxConnection.Open();
                SqlCommand BranchBoxCommand = new SqlCommand("select B.Branch_ID from Branches as B, Cars as C where B.Branch_ID = C.Branch_ID and B.active = 'Yes' and C.active = 'Yes';", BranchBoxConnection);
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
        */}
        
        private void TruckButton_Click(object sender, EventArgs e)
        {   //Need to create a function to make this less copy paste
            //Function would just take an input like truck/sedan, then just change button1-6
            CarType = (string)TruckButton.Tag;

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

            BranchBox.ResetText();
            ColorComboBox.ResetText();

            try
            {
                BranchBoxConnection.Open();
                SqlCommand BranchBoxCommand = new SqlCommand("select distinct(C.Branch_ID) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.active = 'Yes' and C.CarType = '" + CarType + "';", BranchBoxConnection);
                SqlDataReader myreader;
                myreader = BranchBoxCommand.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Columns.Add("Branch_ID", typeof(int));
                DT.Load(myreader);
                BranchBox.ValueMember = "Branch_ID";
                BranchBox.DataSource = DT;
                BranchBoxConnection.Close();
            }
            catch (Exception) { }
            try
            {
                BranchBoxColor.Open();
                SqlCommand BranchBoxColours = new SqlCommand("select distinct(C.Color) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.active = 'Yes' and C.CarType = '" + CarType + "';", BranchBoxColor);
                SqlDataReader myreader1;
                myreader1 = BranchBoxColours.ExecuteReader();
                DataTable DT1 = new DataTable();
                DT1.Columns.Add("Color", typeof(string));
                DT1.Load(myreader1);
                ColorComboBox.ValueMember = "Color";
                ColorComboBox.DataSource = DT1;
                BranchBoxColor.Close();
            }
            catch (Exception) { }
        }

        private void SUVbutton_Click(object sender, EventArgs e)
        {
            CarType = (string)SUVbutton.Tag;
            button1.BackgroundImage = _291GroupProject.Properties.Resources.suv_1;
            button1.Tag = "Hyundai_Santafe";
            button2.BackgroundImage = _291GroupProject.Properties.Resources.suv_2;
            button2.Tag = "Infiniti_Qx50";
            button3.BackgroundImage = _291GroupProject.Properties.Resources.suv_3;
            button3.Tag = "Volkswagen_Tiguan";
            button4.BackgroundImage = _291GroupProject.Properties.Resources.suv_4;
            button4.Tag = "Jeep_Cherokee";
            button5.BackgroundImage = _291GroupProject.Properties.Resources.suv_5;
            button5.Tag = "Cadillac_Escalade";
            button6.BackgroundImage = _291GroupProject.Properties.Resources.suv_6;
            button6.Tag = "Jeep_Compass";

            try
            {
                BranchBoxConnection.Open();
                SqlCommand BranchBoxCommand = new SqlCommand("select distinct(C.Branch_ID) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "';", BranchBoxConnection);
                SqlDataReader myreader;
                myreader = BranchBoxCommand.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Columns.Add("Branch_ID", typeof(int));
                DT.Load(myreader);
                BranchBox.ValueMember = "Branch_ID";
                BranchBox.DataSource = DT;
                BranchBoxConnection.Close();
            }
            catch (Exception) { }
            try
            {
                BranchBoxColor.Open();
                SqlCommand BranchBoxColours = new SqlCommand("select distinct(C.Color) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "';", BranchBoxColor);
                SqlDataReader myreader1;
                myreader1 = BranchBoxColours.ExecuteReader();
                DataTable DT1 = new DataTable();
                DT1.Columns.Add("Color", typeof(string));
                DT1.Load(myreader1);
                ColorComboBox.ValueMember = "Color";
                ColorComboBox.DataSource = DT1;
                BranchBoxColor.Close();
            }
            catch (Exception) { }
        }

        private void SedanButton_Click(object sender, EventArgs e)
        {
            CarType = (string)SedanButton.Tag;
            button1.BackgroundImage = _291GroupProject.Properties.Resources.sedan_1;
            button1.Tag = "Toyota_Yaris";
            button2.BackgroundImage = _291GroupProject.Properties.Resources.sedan_2;
            button2.Tag = "Ford_Fusion";
            button3.BackgroundImage = _291GroupProject.Properties.Resources.sedan_3;
            button3.Tag = "Honda_CivicSi";
            button4.BackgroundImage = _291GroupProject.Properties.Resources.sedan_4;
            button4.Tag = "Honda_Accord";
            button5.BackgroundImage = _291GroupProject.Properties.Resources.sedan_5;
            button5.Tag = "Hyundai_Elantra";
            button6.BackgroundImage = _291GroupProject.Properties.Resources.sedan_6;
            button6.Tag = "Honda_Civic";

            BranchBox.ResetText();
            ColorComboBox.ResetText();

            try
            {
                BranchBoxConnection.Open();
                SqlCommand BranchBoxCommand = new SqlCommand("select distinct(C.Branch_ID) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "';", BranchBoxConnection);
                SqlDataReader myreader;
                myreader = BranchBoxCommand.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Columns.Add("Branch_ID", typeof(int));
                DT.Load(myreader);
                BranchBox.ValueMember = "Branch_ID";
                BranchBox.DataSource = DT;
                BranchBoxConnection.Close();
            }
            catch (Exception) { }
            try
            {
                BranchBoxColor.Open();
                SqlCommand BranchBoxColours = new SqlCommand("select distinct(C.Color) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "';", BranchBoxColor);
                SqlDataReader myreader1;
                myreader1 = BranchBoxColours.ExecuteReader();
                DataTable DT1 = new DataTable();
                DT1.Columns.Add("Color", typeof(string));
                DT1.Load(myreader1);
                ColorComboBox.ValueMember = "Color";
                ColorComboBox.DataSource = DT1;
                BranchBoxColor.Close();
            }
            catch (Exception) { }
        }

        private void JeepButton_Click(object sender, EventArgs e)
        {
            CarType = (string)JeepButton.Tag;
            button6.BackgroundImage = _291GroupProject.Properties.Resources.jeep_6;
            button6.Tag = "Jeep_1950";
            button1.BackgroundImage = _291GroupProject.Properties.Resources.jeep_1;
            button1.Tag = "Jeep_Patriot";
            button2.BackgroundImage = _291GroupProject.Properties.Resources.jeep_2;
            button2.Tag = "Jeep_WranglerOutback";
            button3.BackgroundImage = _291GroupProject.Properties.Resources.jeep_3;
            button3.Tag = "Jeep_Wrangler";
            button4.BackgroundImage = _291GroupProject.Properties.Resources.jeep_4;
            button4.Tag = "Jeep_GladiatorEvolved";
            button5.BackgroundImage = _291GroupProject.Properties.Resources.jeep_5;
            button5.Tag = "Jeep_WranglerOutdoor";

            BranchBox.ResetText();
            ColorComboBox.ResetText();

            try
            {
                BranchBoxConnection.Open();
                SqlCommand BranchBoxCommand = new SqlCommand("select distinct(C.Branch_ID) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "';", BranchBoxConnection);
                SqlDataReader myreader;
                myreader = BranchBoxCommand.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Columns.Add("Branch_ID", typeof(int));
                DT.Load(myreader);
                BranchBox.ValueMember = "Branch_ID";
                BranchBox.DataSource = DT;
                BranchBoxConnection.Close();
            }
            catch (Exception) { }
            try
            {
                BranchBoxColor.Open();
                SqlCommand BranchBoxColours = new SqlCommand("select distinct(C.Color) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "';", BranchBoxColor);
                SqlDataReader myreader1;
                myreader1 = BranchBoxColours.ExecuteReader();
                DataTable DT1 = new DataTable();
                DT1.Columns.Add("Color", typeof(string));
                DT1.Load(myreader1);
                ColorComboBox.ValueMember = "Color";
                ColorComboBox.DataSource = DT1;
                BranchBoxColor.Close();
            }
            catch (Exception) { }
        }

        private void SportsCarButton_Click(object sender, EventArgs e)
        {
            CarType = (string)SportsCarButton.Tag;
            button1.BackgroundImage = _291GroupProject.Properties.Resources.sports_1;
            button1.Tag = "Ferrari_Spyder";
            button2.BackgroundImage = _291GroupProject.Properties.Resources.sports_2;
            button2.Tag = "Lambo_Countach";
            button3.BackgroundImage = _291GroupProject.Properties.Resources.sports_3;
            button3.Tag = "Corvette";
            button4.BackgroundImage = _291GroupProject.Properties.Resources.sports_4;
            button4.Tag = "Porsche_911";
            button5.BackgroundImage = _291GroupProject.Properties.Resources.sports_5;
            button5.Tag = "Lambo_Gallardo";
            button6.BackgroundImage = _291GroupProject.Properties.Resources.sports_6;
            button6.Tag = "Honda_Sports";

            BranchBox.ResetText();
            ColorComboBox.ResetText();

            try
            {
                BranchBoxConnection.Open();
                SqlCommand BranchBoxCommand = new SqlCommand("select distinct(C.Branch_ID) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "';", BranchBoxConnection);
                SqlDataReader myreader;
                myreader = BranchBoxCommand.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Columns.Add("Branch_ID", typeof(int));
                DT.Load(myreader);
                BranchBox.ValueMember = "Branch_ID";
                BranchBox.DataSource = DT;
                BranchBoxConnection.Close();
            }
            catch (Exception) { }
            try
            {
                BranchBoxColor.Open();
                SqlCommand BranchBoxColours = new SqlCommand("select distinct(C.Color) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "';", BranchBoxColor);
                SqlDataReader myreader1;
                myreader1 = BranchBoxColours.ExecuteReader();
                DataTable DT1 = new DataTable();
                DT1.Columns.Add("Color", typeof(string));
                DT1.Load(myreader1);
                ColorComboBox.ValueMember = "Color";
                ColorComboBox.DataSource = DT1;
                BranchBoxColor.Close();
            }
            catch (Exception) { }
        }

        private void HybridButton_Click(object sender, EventArgs e)
        {
            CarType = (string)HybridButton.Tag;
            button1.BackgroundImage = _291GroupProject.Properties.Resources.hybrid_1;
            button1.Tag = "Toyota_PriusV";
            button2.BackgroundImage = _291GroupProject.Properties.Resources.hybrid_2;
            button2.Tag = "Hyundai_Hybrid";
            button3.BackgroundImage = _291GroupProject.Properties.Resources.hybrid_3;
            button3.Tag = "Yellow_Hybrid";
            button4.BackgroundImage = _291GroupProject.Properties.Resources.hybrid_4;
            button4.Tag = "BMW_Hybrid";
            button5.BackgroundImage = _291GroupProject.Properties.Resources.hybrid_5;
            button5.Tag = "Audi_Hybrid";
            button6.BackgroundImage = _291GroupProject.Properties.Resources.hybrid_6;
            button6.Tag = "Honda_Insight";

            BranchBox.ResetText();
            ColorComboBox.ResetText();

            try
            {
                BranchBoxConnection.Open();
                SqlCommand BranchBoxCommand = new SqlCommand("select distinct(C.Branch_ID) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "';", BranchBoxConnection);
                SqlDataReader myreader;
                myreader = BranchBoxCommand.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Columns.Add("Branch_ID", typeof(int));
                DT.Load(myreader);
                BranchBox.ValueMember = "Branch_ID";
                BranchBox.DataSource = DT;
                BranchBoxConnection.Close();
            }
            catch (Exception) { }
            try
            {
                BranchBoxColor.Open();
                SqlCommand BranchBoxColours = new SqlCommand("select distinct(C.Color) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "';", BranchBoxColor);
                SqlDataReader myreader1;
                myreader1 = BranchBoxColours.ExecuteReader();
                DataTable DT1 = new DataTable();
                DT1.Columns.Add("Color", typeof(string));
                DT1.Load(myreader1);
                ColorComboBox.ValueMember = "Color";
                ColorComboBox.DataSource = DT1;
                BranchBoxColor.Close();
            }
            catch (Exception) { }
        }

        private void CompactButton_Click(object sender, EventArgs e)
        {
            CarType = (string)CompactButton.Tag;
            button1.BackgroundImage = _291GroupProject.Properties.Resources.compact_1;
            button1.Tag = "Mazda3";
            button2.BackgroundImage = _291GroupProject.Properties.Resources.compact_2;
            button2.Tag = "Volkswagen_Jetta";
            button3.BackgroundImage = _291GroupProject.Properties.Resources.compact_3;
            button3.Tag = "Kia_Forte";
            button4.BackgroundImage = _291GroupProject.Properties.Resources.compact_4;
            button4.Tag = "Volkswagen_OldBeetle";
            button5.BackgroundImage = _291GroupProject.Properties.Resources.compact_5;
            button5.Tag = "Volkswagen_Beetle";
            button6.BackgroundImage = _291GroupProject.Properties.Resources.compact_6;
            button6.Tag = "Hyundai_Compact";

            BranchBox.ResetText();
            ColorComboBox.ResetText();

            try
            {
                BranchBoxConnection.Open();
                SqlCommand BranchBoxCommand = new SqlCommand("select distinct(C.Branch_ID) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "';", BranchBoxConnection);
                SqlDataReader myreader;
                myreader = BranchBoxCommand.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Columns.Add("Branch_ID", typeof(int));
                DT.Load(myreader);
                BranchBox.ValueMember = "Branch_ID";
                BranchBox.DataSource = DT;
                BranchBoxConnection.Close();
            }
            catch (Exception) { }
            try
            {
                BranchBoxColor.Open();
                SqlCommand BranchBoxColours = new SqlCommand("select distinct(C.Color) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "';", BranchBoxColor);
                SqlDataReader myreader1;
                myreader1 = BranchBoxColours.ExecuteReader();
                DataTable DT1 = new DataTable();
                DT1.Columns.Add("Color", typeof(string));
                DT1.Load(myreader1);
                ColorComboBox.ValueMember = "Color";
                ColorComboBox.DataSource = DT1;
                BranchBoxColor.Close();
            }
            catch (Exception) { }
        }

        private void ConvertibleButton_Click(object sender, EventArgs e)
        {
            CarType = (string)ConvertibleButton.Tag;
            button1.BackgroundImage = _291GroupProject.Properties.Resources.convertible_1;
            button1.Tag = "Ferrari_Convertible";
            button2.BackgroundImage = _291GroupProject.Properties.Resources.convertible_2;
            button2.Tag = "Volkswagen_Convertible";
            button3.BackgroundImage = _291GroupProject.Properties.Resources.convertible_3;
            button3.Tag = "Ford_1950Convertible";
            button4.BackgroundImage = _291GroupProject.Properties.Resources.convertible_4;
            button4.Tag = "Camero_Convertible";
            button5.BackgroundImage = _291GroupProject.Properties.Resources.convertible_5;
            button5.Tag = "BMW_Convertible";
            button6.BackgroundImage = _291GroupProject.Properties.Resources.convertible_6;
            button6.Tag = "Rolls_Convertible";

            BranchBox.ResetText();
            ColorComboBox.ResetText();

            try
            {
                BranchBoxConnection.Open();
                SqlCommand BranchBoxCommand = new SqlCommand("select distinct(C.Branch_ID) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "';", BranchBoxConnection);
                SqlDataReader myreader;
                myreader = BranchBoxCommand.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Columns.Add("Branch_ID", typeof(int));
                DT.Load(myreader);
                BranchBox.ValueMember = "Branch_ID";
                BranchBox.DataSource = DT;
                BranchBoxConnection.Close();
            }
            catch (Exception) { }
            try
            {
                BranchBoxColor.Open();
                SqlCommand BranchBoxColours = new SqlCommand("select distinct(C.Color) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "';", BranchBoxColor);
                SqlDataReader myreader1;
                myreader1 = BranchBoxColours.ExecuteReader();
                DataTable DT1 = new DataTable();
                DT1.Columns.Add("Color", typeof(string));
                DT1.Load(myreader1);
                ColorComboBox.ValueMember = "Color";
                ColorComboBox.DataSource = DT1;
                BranchBoxColor.Close();
            }
            catch (Exception) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //The MessageBox is just for testing and visual purposes, we will delete it later.
            SelectedCarImage.BackgroundImage = button2.BackgroundImage;
            CarModel = (string)button2.Tag;
            CarTitle.Text = CarModel;
            //MessageBox.Show(CarModel);
            BranchBox.ResetText();
            ColorComboBox.ResetText();
            try
            {
                BranchBoxConnection.Open();
                SqlCommand BranchBoxCommand = new SqlCommand("select distinct(C.Branch_ID) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.active = 'Yes' and C.Model = '" + CarModel + "';", BranchBoxConnection);
                SqlDataReader myreader;
                myreader = BranchBoxCommand.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Columns.Add("Branch_ID", typeof(int));
                DT.Load(myreader);
                BranchBox.ValueMember = "Branch_ID";
                BranchBox.DataSource = DT;
                BranchBoxConnection.Close();
            }
            catch (Exception) { }
            try
            {
                BranchBoxColor.Open();
                SqlCommand BranchBoxColours = new SqlCommand("select distinct(C.Color) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.active = 'Yes' and C.Model = '" + CarModel + "';", BranchBoxColor);
                SqlDataReader myreader1;
                myreader1 = BranchBoxColours.ExecuteReader();
                DataTable DT1 = new DataTable();
                DT1.Columns.Add("Color", typeof(string));
                DT1.Load(myreader1);
                ColorComboBox.ValueMember = "Color";
                ColorComboBox.DataSource = DT1;
                BranchBoxColor.Close();
            }
            catch (Exception) { }
        }

        private void button1_click(object sender, EventArgs e)
        {
            SelectedCarImage.BackgroundImage = button1.BackgroundImage;
            CarModel = (string)button1.Tag;
            CarTitle.Text = CarModel;
            //MessageBox.Show(CarModel);
            BranchBox.ResetText();
            ColorComboBox.ResetText();
            try
            {
                BranchBoxConnection.Open();
                SqlCommand BranchBoxCommand = new SqlCommand("select distinct(C.Branch_ID) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.active = 'Yes' and C.Model = '" + CarModel + "';", BranchBoxConnection);
                SqlDataReader myreader;
                myreader = BranchBoxCommand.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Columns.Add("Branch_ID", typeof(int));
                DT.Load(myreader);
                BranchBox.ValueMember = "Branch_ID";
                BranchBox.DataSource = DT;
                BranchBoxConnection.Close();
            }
            catch (Exception) { }
            try
            {
                BranchBoxColor.Open();
                SqlCommand BranchBoxColours = new SqlCommand("select distinct(C.Color) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.active = 'Yes' and C.Model = '" + CarModel + "';", BranchBoxColor);
                SqlDataReader myreader1;
                myreader1 = BranchBoxColours.ExecuteReader();
                DataTable DT1 = new DataTable();
                DT1.Columns.Add("Color", typeof(string));
                DT1.Load(myreader1);
                ColorComboBox.ValueMember = "Color";
                ColorComboBox.DataSource = DT1;
                BranchBoxColor.Close();
            }
            catch (Exception) { }
        }

        private void button3_click(object sender, EventArgs e)
        {
            SelectedCarImage.BackgroundImage = button3.BackgroundImage;
            CarModel = (string)button3.Tag;
            CarTitle.Text = CarModel;
            //MessageBox.Show(CarModel);
            BranchBox.ResetText();
            ColorComboBox.ResetText();
            try
            {
                BranchBoxConnection.Open();
                SqlCommand BranchBoxCommand = new SqlCommand("select distinct(C.Branch_ID) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.active = 'Yes' and C.Model = '" + CarModel + "';", BranchBoxConnection);
                SqlDataReader myreader;
                myreader = BranchBoxCommand.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Columns.Add("Branch_ID", typeof(int));
                DT.Load(myreader);
                BranchBox.ValueMember = "Branch_ID";
                BranchBox.DataSource = DT;
                BranchBoxConnection.Close();
            }
            catch (Exception) { }
            try
            {
                BranchBoxColor.Open();
                SqlCommand BranchBoxColours = new SqlCommand("select distinct(C.Color) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.active = 'Yes' and C.Model = '" + CarModel + "';", BranchBoxColor);
                SqlDataReader myreader1;
                myreader1 = BranchBoxColours.ExecuteReader();
                DataTable DT1 = new DataTable();
                DT1.Columns.Add("Color", typeof(string));
                DT1.Load(myreader1);
                ColorComboBox.ValueMember = "Color";
                ColorComboBox.DataSource = DT1;
                BranchBoxColor.Close();
            }
            catch (Exception) { }
        }

        private void button4_click(object sender, EventArgs e)
        {
            
            SelectedCarImage.BackgroundImage = button4.BackgroundImage;
            CarModel = (string)button4.Tag;
            CarTitle.Text = CarModel;
            //MessageBox.Show(CarModel);
            BranchBox.ResetText();
            ColorComboBox.ResetText();
            try
            {
                BranchBoxConnection.Open();
                SqlCommand BranchBoxCommand = new SqlCommand("select distinct(C.Branch_ID) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.active = 'Yes' and C.Model = '" + CarModel + "';", BranchBoxConnection);
                SqlDataReader myreader;
                myreader = BranchBoxCommand.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Columns.Add("Branch_ID", typeof(int));
                DT.Load(myreader);
                BranchBox.ValueMember = "Branch_ID";
                BranchBox.DataSource = DT;
                BranchBoxConnection.Close();
            }
            catch (Exception) { }
            try
            {
                BranchBoxColor.Open();
                SqlCommand BranchBoxColours = new SqlCommand("select distinct(C.Color) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.active = 'Yes' and C.Model = '" + CarModel + "';", BranchBoxColor);
                SqlDataReader myreader1;
                myreader1 = BranchBoxColours.ExecuteReader();
                DataTable DT1 = new DataTable();
                DT1.Columns.Add("Color", typeof(string));
                DT1.Load(myreader1);
                ColorComboBox.ValueMember = "Color";
                ColorComboBox.DataSource = DT1;
                BranchBoxColor.Close();
            }
            catch (Exception) { }
        }

        private void button5_click(object sender, EventArgs e)
        {
            SelectedCarImage.BackgroundImage = button5.BackgroundImage;
            CarModel = (string)button5.Tag;
            CarTitle.Text = CarModel;
            //MessageBox.Show(CarModel);
            BranchBox.ResetText();
            ColorComboBox.ResetText();
            try
            {
                BranchBoxConnection.Open();
                SqlCommand BranchBoxCommand = new SqlCommand("select distinct(C.Branch_ID) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.active = 'Yes' and C.Model = '" + CarModel + "';", BranchBoxConnection);
                SqlDataReader myreader;
                myreader = BranchBoxCommand.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Columns.Add("Branch_ID", typeof(int));
                DT.Load(myreader);
                BranchBox.ValueMember = "Branch_ID";
                BranchBox.DataSource = DT;
                BranchBoxConnection.Close();
            }
            catch (Exception) { }
            try
            {
                BranchBoxColor.Open();
                SqlCommand BranchBoxColours = new SqlCommand("select distinct(C.Color) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.active = 'Yes' and C.Model = '" + CarModel + "';", BranchBoxColor);
                SqlDataReader myreader1;
                myreader1 = BranchBoxColours.ExecuteReader();
                DataTable DT1 = new DataTable();
                DT1.Columns.Add("Color", typeof(string));
                DT1.Load(myreader1);
                ColorComboBox.ValueMember = "Color";
                ColorComboBox.DataSource = DT1;
                BranchBoxColor.Close();
            }
            catch (Exception) { }
        }

        private void button6_click(object sender, EventArgs e)
        {
            SelectedCarImage.BackgroundImage = button6.BackgroundImage;
            CarModel = (string)button6.Tag;
            CarTitle.Text = CarModel;
            //MessageBox.Show(CarModel);
            BranchBox.ResetText();
            ColorComboBox.ResetText();
            try
            {
                BranchBoxConnection.Open();
                SqlCommand BranchBoxCommand = new SqlCommand("select distinct(C.Branch_ID) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.active = 'Yes' and C.Model = '" + CarModel + "';", BranchBoxConnection);
                SqlDataReader myreader;
                myreader = BranchBoxCommand.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Columns.Add("Branch_ID", typeof(int));
                DT.Load(myreader);
                BranchBox.ValueMember = "Branch_ID";
                BranchBox.DataSource = DT;
                BranchBoxConnection.Close();
            }
            catch (Exception) { }
            try
            {
                BranchBoxColor.Open();
                SqlCommand BranchBoxColours = new SqlCommand("select distinct(C.Color) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.active = 'Yes' and C.Model = '" + CarModel + "';", BranchBoxColor);
                SqlDataReader myreader1;
                myreader1 = BranchBoxColours.ExecuteReader();
                DataTable DT1 = new DataTable();
                DT1.Columns.Add("Color", typeof(string));
                DT1.Load(myreader1);
                ColorComboBox.ValueMember = "Color";
                ColorComboBox.DataSource = DT1;
                BranchBoxColor.Close();
            }
            catch (Exception) { }
        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            //TODO, change the car with the VIN to be not active inside dbo.Cars, use an UPDATE statement
            try
            {
                BranchBoxConnection.Open();
                SqlCommand CheckCustomer = new SqlCommand("Select Customer_ID from Customers where Customer_ID = " + textBox10.Text + ";", BranchBoxConnection);
                if (CheckCustomer.ExecuteScalar() == null) 
                {
                    MessageBox.Show("This customer does not exist");
                    BranchBoxConnection.Close();
                }
                //Need to include the branch ID in the sql command and the color
                SqlCommand RentCommand = new SqlCommand("Select (VIN) from Cars where Model = '" + CarModel + "'" + " and active = 'Yes' and Branch_ID = '" + BranchBox.Text + "'" + " and color = '" + ColorComboBox.Text + "';", BranchBoxConnection);
                if (RentCommand.ExecuteScalar() == null)
                {
                    MessageBox.Show("Sorry, this is not available");
                    BranchBoxConnection.Close();
                }
                else
                {
                    //testing purposes, it shows the VIN number that is returned
                    int VIN = (int)RentCommand.ExecuteScalar();
                    //Used this for errorchecking to see the VIN
                    // MessageBox.Show(VIN.ToString());
                    //Create the command to add a rental to rental_trans

                    SqlCommand AddRental = new SqlCommand();
                    //Use myCommand for finding the price

                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = BranchBoxConnection;
                    AddRental.Connection = BranchBoxConnection;

                    //find out number of days
                    int total = (dateTimePicker2.Value - dateTimePicker1.Value).Days;
                    int month, weeks, days;
                    double total_price = 0, monthly_price = 0, daily_price = 0, weekly_price = 0;

                    //Construct price command

                    myCommand.CommandText = "select price_D, price_W, price_M from Car_Types";
                    myCommand.CommandText += " where CarType = " + "'" + CarType + "'" + ";";
                    try
                    {
                        SqlDataReader PriceReader;
                        PriceReader = myCommand.ExecuteReader();
                        while (PriceReader.Read())
                        {
                            daily_price = PriceReader.GetDouble(0);
                            weekly_price = PriceReader.GetDouble(1);
                            monthly_price = PriceReader.GetDouble(2);
                        }
                        PriceReader.Close();
                    }
                    catch (Exception)
                    {

                    }
                    month = (int)total / 30;
                    days = (int)total % 30;
                    weeks = (int)days / 7;
                    days = (int)days % 7;
                    total_price = days * daily_price + weeks * weekly_price + month * monthly_price;
                    //Shows total price of the current VIN with the return dates
                    //MessageBox.Show(total_price.ToString());


                    AddRental.CommandText = "insert into Rental_trans Values(";
                    AddRental.CommandText += "'" + dateTimePicker1.Value + "', '" + dateTimePicker2.Value + "', '" + total_price.ToString() + "', '" + textBox10.Text + "', '" + "1" + "', '" + BranchBox.Text + "', '" + BranchBox.Text + "', '" + VIN.ToString() + "')";
                    AddRental.ExecuteNonQuery();
                    AddRental.CommandText = "UPDATE Cars SET active = 'No' WHERE VIN = " + VIN.ToString() + ";";
                    AddRental.ExecuteNonQuery();
                    MessageBox.Show("Thank you for renting with us!");
                    BranchBoxConnection.Close();
                }
            }
            catch
            {

            }
        }
        private void customer_selection(object sender, EventArgs e)
        {
            int selectedIndex = comboBox_customerReport.SelectedIndex;
            DateTime localDate = DateTime.Now.Date;
            switch (selectedIndex)
            {
                case 0:
                    myCommand.CommandText = "select * from Rental_trans as RT where RT.Customer_ID = '" + customer_id.Text + "'";
                    break;
                case 1:
                    myCommand.CommandText = "select * from Rental_trans as RT where RT.Customer_ID = '" + customer_id.Text + "' and RT.pickup_branch_id = '" + null + "' ";
                    break;
                case 2:
                    myCommand.CommandText = "select * from Rental_trans as RT where RT.Customer_ID = '" + customer_id.Text + "' and RT.pickup_branch_id != '" + null + "' and RT.return_branch_id = '" + null + "'";
                    break;
                case 3:
                    myCommand.CommandText = "select * from Rental_trans as RT where RT.Customer_ID = '" + customer_id.Text + "' and RT.return_branch_id != null";
                    break;
                case 4:
                    myCommand.CommandText = "select * from Rental_trans as RT where RT.Customer_ID = '" + customer_id.Text + "' and RT.return_date < '" + localDate + "' ";
                    break;
                default:
                    myCommand.CommandText = "select * from Rental_trans as RT where RT.Customer_ID = '" + customer_id.Text + "'";
                    break;
            }
        }

        private void customer_report_button(object sender, MouseEventArgs e)
        {
            try
            {
                myReader = myCommand.ExecuteReader();
                //MessageBox.Show(myCommand.CommandText);
                dataGridView1.Rows.Clear();

                while (myReader.Read())
                {
                    dataGridView1.Rows.Add(myReader["Rental_ID"].ToString(), myReader["Customer_ID"].ToString(), myReader["VIN"].ToString(), myReader["price"].ToString(), myReader["pickup_Branch_ID"].ToString(), myReader["return_Branch_ID"].ToString(), myReader["pickup_date"].ToString(), myReader["return_date"].ToString());
                }
                myReader.Close();
            }
            catch(Exception) {}
        }

        private void search_time_MouseClick(object sender, MouseEventArgs e)
        {
            myCommand.CommandText = "Select * from Rental_trans where Customer_ID = '" + customer_id.Text + "'";
            if (!string.IsNullOrEmpty(textBox01.Text))
            {
                myCommand.CommandText += " and year(return_date) = '" + textBox01.Text + "'";
                if (!string.IsNullOrEmpty(textBox02.Text))
                {
                    myCommand.CommandText += " and month(return_date) = '" + textBox02.Text + "'";
                    if (!string.IsNullOrEmpty(textBox03.Text))
                    {
                        myCommand.CommandText += " and day(return_date) = '" + textBox03.Text + "'";
                    }
                }
                if (!string.IsNullOrEmpty(textBox03.Text))
                {
                    myCommand.CommandText += " and day(return_date) = '" + textBox03.Text + "'";
                }
            }
            if (!string.IsNullOrEmpty(textBox02.Text))
            {
                myCommand.CommandText += " and month(return_date) = '" + textBox02.Text + "'";
                if (!string.IsNullOrEmpty(textBox03.Text))
                {
                    myCommand.CommandText += " and day(return_date) = '" + textBox03.Text + "'";
                }
            }
            if (!string.IsNullOrEmpty(textBox03.Text))
            {
                myCommand.CommandText += " and day(return_date) = '" + textBox03.Text + "'";
            }
            try
            {
                myReader = myCommand.ExecuteReader();
                //MessageBox.Show(myCommand.CommandText);
                dataGridView1.Rows.Clear();
                while (myReader.Read())
                {
                    dataGridView1.Rows.Add(myReader["Rental_ID"].ToString(), myReader["Customer_ID"].ToString(), myReader["VIN"].ToString(), myReader["price"].ToString(), myReader["pickup_Branch_ID"].ToString(), myReader["return_Branch_ID"].ToString(), myReader["pickup_date"].ToString(), myReader["return_date"].ToString());
                }
                myReader.Close();
            }
            catch (Exception) { }
        }

        private void searchCar_MouseClick(object sender, MouseEventArgs e)
        {
            myCommand.CommandText = "Select * from Rental_trans as RT, Cars as C where Customer_ID = '" + customer_id.Text + "' and C.VIN=RT.VIN";
            if (!string.IsNullOrEmpty(textBox04.Text))
            {
                myCommand.CommandText += " and C.VIN = '" + textBox04.Text + "'";
                if (!string.IsNullOrEmpty(textBox05.Text))
                {
                    myCommand.CommandText += " and C.CarType = '" + textBox05.Text + "'";
                    if (!string.IsNullOrEmpty(textBox06.Text))
                    {
                        myCommand.CommandText += " and C.Model = '" + textBox06.Text + "'";
                        if (!string.IsNullOrEmpty(textBox07.Text))
                        {
                            myCommand.CommandText += " and Car.Color = '" + textBox07.Text + "'";
                        }
                    }
                    if (!string.IsNullOrEmpty(textBox07.Text))
                    {
                        myCommand.CommandText += " and Car.Color = '" + textBox07.Text + "'";
                    }
                }
                if (!string.IsNullOrEmpty(textBox06.Text))
                {
                    myCommand.CommandText += " and C.Model = '" + textBox06.Text + "'";
                    if (!string.IsNullOrEmpty(textBox07.Text))
                    {
                        myCommand.CommandText += " and Car.Color = '" + textBox07.Text + "'";
                    }
                }
                if (!string.IsNullOrEmpty(textBox07.Text))
                {
                    myCommand.CommandText += " and Car.Color = '" + textBox07.Text + "'";
                }
            }
            if (!string.IsNullOrEmpty(textBox05.Text))
            {
                myCommand.CommandText += " and C.CarType = '" + textBox05.Text + "'";
                if (!string.IsNullOrEmpty(textBox06.Text))
                {
                    myCommand.CommandText += " and C.Model = '" + textBox06.Text + "'";
                    if (!string.IsNullOrEmpty(textBox07.Text))
                    {
                        myCommand.CommandText += " and Car.Color = '" + textBox07.Text + "'";
                    }
                }
                if (!string.IsNullOrEmpty(textBox07.Text))
                {
                    myCommand.CommandText += " and Car.Color = '" + textBox07.Text + "'";
                }
            }
            if (!string.IsNullOrEmpty(textBox06.Text))
            {
                myCommand.CommandText += " and C.Model = '" + textBox06.Text + "'";
                if (!string.IsNullOrEmpty(textBox07.Text))
                {
                    myCommand.CommandText += " and Car.Color = '" + textBox07.Text + "'";
                }
            }
            if (!string.IsNullOrEmpty(textBox07.Text))
            {
                myCommand.CommandText += " and Car.Color = '" + textBox07.Text + "'";
            }
            try
            {
                myReader = myCommand.ExecuteReader();
                //MessageBox.Show(myCommand.CommandText);
                dataGridView1.Rows.Clear();
                while (myReader.Read())
                {
                    dataGridView1.Rows.Add(myReader["Rental_ID"].ToString(), myReader["Customer_ID"].ToString(), myReader["VIN"].ToString(), myReader["price"].ToString(), myReader["pickup_Branch_ID"].ToString(), myReader["return_Branch_ID"].ToString(), myReader["pickup_date"].ToString(), myReader["return_date"].ToString());
                }
                myReader.Close();
            }
            catch (Exception) { }
        }

        private void searchPrice_MouseClick(object sender, MouseEventArgs e)
        {
            myCommand.CommandText = "Select * from Rental_trans where Customer_ID = '" + customer_id.Text + "'";
            if (!string.IsNullOrEmpty(textBox08.Text))
            {
                myCommand.CommandText += " and price = '" + textBox08.Text + "'";
                if (!string.IsNullOrEmpty(textBox09.Text))
                {
                    myCommand.CommandText += " and price <= '" + textBox09.Text + "'";
                    if (!string.IsNullOrEmpty(textBox11.Text))
                    {
                        myCommand.CommandText += " and price >= '" + textBox11.Text + "'";
                    }
                }
                if (!string.IsNullOrEmpty(textBox11.Text))
                {
                    myCommand.CommandText += " and price >= '" + textBox11.Text + "'";
                }
            }
            if (!string.IsNullOrEmpty(textBox09.Text))
            {
                myCommand.CommandText += " and price <= '" + textBox09.Text + "'";
                if (!string.IsNullOrEmpty(textBox11.Text))
                {
                    myCommand.CommandText += " and price >= '" + textBox11.Text + "'";
                }
            }
            if (!string.IsNullOrEmpty(textBox11.Text))
            {
                myCommand.CommandText += " and price >= '" + textBox11.Text + "'";
            }
            try
            {
                myReader = myCommand.ExecuteReader();
                //MessageBox.Show(myCommand.CommandText);
                dataGridView1.Rows.Clear();
                while (myReader.Read())
                {
                    dataGridView1.Rows.Add(myReader["Rental_ID"].ToString(), myReader["Customer_ID"].ToString(), myReader["VIN"].ToString(), myReader["price"].ToString(), myReader["pickup_Branch_ID"].ToString(), myReader["return_Branch_ID"].ToString(), myReader["pickup_date"].ToString(), myReader["return_date"].ToString());
                }
                myReader.Close();
            }
            catch (Exception) { }
        }

        private void searchBranch_MouseClick(object sender, MouseEventArgs e)
        {
            myCommand.CommandText = "Select * from Rental_trans where Customer_ID = '" + customer_id.Text + "'";
            if (!string.IsNullOrEmpty(textBox12.Text))
            {
                myCommand.CommandText += " and (pickup_Branch_ID = '" + textBox12.Text + "' or return_Branch_ID = '" + textBox12.Text + "')";
            }
                try
            {
                myReader = myCommand.ExecuteReader();
                //MessageBox.Show(myCommand.CommandText);
                dataGridView1.Rows.Clear();
                while (myReader.Read())
                {
                    dataGridView1.Rows.Add(myReader["Rental_ID"].ToString(), myReader["Customer_ID"].ToString(), myReader["VIN"].ToString(), myReader["price"].ToString(), myReader["pickup_Branch_ID"].ToString(), myReader["return_Branch_ID"].ToString(), myReader["pickup_date"].ToString(), myReader["return_date"].ToString());
                }
                myReader.Close();
            }
            catch (Exception) { }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            BranchBoxConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = BranchBoxConnection;
            //find out number of days
            int total = (dateTimePicker2.Value - dateTimePicker1.Value).Days;
            int month, weeks, days;
            double total_price = 0, monthly_price = 0, daily_price = 0, weekly_price = 0;

            //Construct price command

            myCommand.CommandText = "select price_D, price_W, price_M from Car_Types";
            myCommand.CommandText += " where CarType = " + "'" + CarType + "'" + ";";
            try
            {
                SqlDataReader PriceReader;
                PriceReader = myCommand.ExecuteReader();
                while (PriceReader.Read())
                {
                    daily_price = PriceReader.GetDouble(0);
                    weekly_price = PriceReader.GetDouble(1);
                    monthly_price = PriceReader.GetDouble(2);
                }
                PriceReader.Close();
            }
            catch (Exception)
            {
                BranchBoxConnection.Close();
            }
            month = (int)total / 30;
            days = (int)total % 30;
            weeks = (int)days / 7;
            days = (int)days % 7;
            total_price = days * daily_price + weeks * weekly_price + month * monthly_price;
            label4.Text = "$" + total_price.ToString();
            BranchBoxConnection.Close();
        }
    }
}
