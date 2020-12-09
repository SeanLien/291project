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
        public SqlConnection BranchBoxConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["291proj"].ConnectionString);
        public SqlConnection BranchBoxColor = new SqlConnection(ConfigurationManager.ConnectionStrings["291proj"].ConnectionString);
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

        private void SUVbutton_Click(object sender, EventArgs e)
        {
            CarType = (string)SUVbutton.Tag;
            button1.BackgroundImage = _291GroupProject.Properties.Resources.suv_1;
            button2.BackgroundImage = _291GroupProject.Properties.Resources.suv_2;
            button3.BackgroundImage = _291GroupProject.Properties.Resources.suv_3;
            button4.BackgroundImage = _291GroupProject.Properties.Resources.suv_4;
            button5.BackgroundImage = _291GroupProject.Properties.Resources.suv_5;
            button6.BackgroundImage = _291GroupProject.Properties.Resources.suv_6;

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

        private void SedanButton_Click(object sender, EventArgs e)
        {
            CarType = (string)SedanButton.Tag;
            button1.BackgroundImage = _291GroupProject.Properties.Resources.sedan_1;
            button2.BackgroundImage = _291GroupProject.Properties.Resources.sedan_2;
            button3.BackgroundImage = _291GroupProject.Properties.Resources.sedan_3;
            button4.BackgroundImage = _291GroupProject.Properties.Resources.sedan_4;
            button5.BackgroundImage = _291GroupProject.Properties.Resources.sedan_5;
            button6.BackgroundImage = _291GroupProject.Properties.Resources.sedan_6;

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
            button1.BackgroundImage = _291GroupProject.Properties.Resources.jeep_1;
            button2.BackgroundImage = _291GroupProject.Properties.Resources.jeep_2;
            button3.BackgroundImage = _291GroupProject.Properties.Resources.jeep_3;
            button4.BackgroundImage = _291GroupProject.Properties.Resources.jeep_4;
            button5.BackgroundImage = _291GroupProject.Properties.Resources.jeep_5;

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
            button2.BackgroundImage = _291GroupProject.Properties.Resources.sports_2;
            button3.BackgroundImage = _291GroupProject.Properties.Resources.sports_3;
            button4.BackgroundImage = _291GroupProject.Properties.Resources.sports_4;
            button5.BackgroundImage = _291GroupProject.Properties.Resources.sports_5;
            button6.BackgroundImage = _291GroupProject.Properties.Resources.sports_6;

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
            button2.BackgroundImage = _291GroupProject.Properties.Resources.hybrid_2;
            button3.BackgroundImage = _291GroupProject.Properties.Resources.hybrid_3;
            button4.BackgroundImage = _291GroupProject.Properties.Resources.hybrid_4;
            button5.BackgroundImage = _291GroupProject.Properties.Resources.hybrid_5;
            button6.BackgroundImage = _291GroupProject.Properties.Resources.hybrid_6;

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
            button2.BackgroundImage = _291GroupProject.Properties.Resources.compact_2;
            button3.BackgroundImage = _291GroupProject.Properties.Resources.compact_3;
            button4.BackgroundImage = _291GroupProject.Properties.Resources.compact_4;
            button5.BackgroundImage = _291GroupProject.Properties.Resources.compact_5;
            button6.BackgroundImage = _291GroupProject.Properties.Resources.compact_6;

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
            button2.BackgroundImage = _291GroupProject.Properties.Resources.convertible_2;
            button3.BackgroundImage = _291GroupProject.Properties.Resources.convertible_3;
            button4.BackgroundImage = _291GroupProject.Properties.Resources.convertible_4;
            button5.BackgroundImage = _291GroupProject.Properties.Resources.convertible_5;
            button6.BackgroundImage = _291GroupProject.Properties.Resources.convertible_6;

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
            //MessageBox.Show(CarModel);
            BranchBox.ResetText();
            ColorComboBox.ResetText();
            vin_rental.ResetText();

            try
            {
                BranchBoxConnection.Open();
                SqlCommand BranchBoxCommand = new SqlCommand("select distinct(C.Branch_ID) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.Model = '" + CarModel + "';", BranchBoxConnection);
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
                SqlCommand BranchBoxColours = new SqlCommand("select distinct(C.Color) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.Model = '" + CarModel + "';", BranchBoxColor);
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
            try
            {
                BranchBoxConnection.Open();
                SqlCommand readLabelVIN = new SqlCommand("select (C.VIN) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.Model = '" + CarModel + "';", BranchBoxColor);
                SqlDataReader myreader2;
                myreader2 = readLabelVIN.ExecuteReader();
                while (myreader2.Read())
                {
                    vin_rental.Text = myreader2["VIN"].ToString();
                }
                myreader2.Close();
                BranchBoxConnection.Close();
            }
            catch (Exception) { }
        }

        private void button1_click(object sender, EventArgs e)
        {
            SelectedCarImage.BackgroundImage = button1.BackgroundImage;
            CarModel = (string)button1.Tag;
            //MessageBox.Show(CarModel);
            BranchBox.ResetText();
            ColorComboBox.ResetText();
            vin_rental.ResetText();
            try
            {
                BranchBoxConnection.Open();
                SqlCommand BranchBoxCommand = new SqlCommand("select distinct(C.Branch_ID) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.Model = '" + CarModel + "';", BranchBoxConnection);
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
                SqlCommand BranchBoxColours = new SqlCommand("select distinct(C.Color) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.Model = '" + CarModel + "';", BranchBoxColor);
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
            try
            {
                BranchBoxConnection.Open();
                SqlCommand readLabelVIN = new SqlCommand("select (C.VIN) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.Model = '" + CarModel + "';", BranchBoxColor);
                SqlDataReader myreader2;
                myreader2 = readLabelVIN.ExecuteReader();
                while (myreader2.Read())
                {
                    vin_rental.Text = myreader2["VIN"].ToString();
                }
                myreader2.Close();
                BranchBoxConnection.Close();
            }
            catch (Exception) { }
        }

        private void button3_click(object sender, EventArgs e)
        {
            SelectedCarImage.BackgroundImage = button3.BackgroundImage;
            CarModel = (string)button3.Tag;
            //MessageBox.Show(CarModel);
            BranchBox.ResetText();
            ColorComboBox.ResetText();
            vin_rental.ResetText();
            try
            {
                BranchBoxConnection.Open();
                SqlCommand BranchBoxCommand = new SqlCommand("select distinct(C.Branch_ID) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.Model = '" + CarModel + "';", BranchBoxConnection);
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
                SqlCommand BranchBoxColours = new SqlCommand("select distinct(C.Color) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.Model = '" + CarModel + "';", BranchBoxColor);
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
            try
            {
                BranchBoxConnection.Open();
                SqlCommand readLabelVIN = new SqlCommand("select (C.VIN) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.Model = '" + CarModel + "';", BranchBoxColor);
                SqlDataReader myreader2;
                myreader2 = readLabelVIN.ExecuteReader();
                while (myreader2.Read())
                {
                    vin_rental.Text = myreader2["VIN"].ToString();
                }
                myreader2.Close();
                BranchBoxConnection.Close();
            }
            catch (Exception) { }
        }

        private void button4_click(object sender, EventArgs e)
        {
            SelectedCarImage.BackgroundImage = button4.BackgroundImage;
            CarModel = (string)button4.Tag;
            //MessageBox.Show(CarModel);
            BranchBox.ResetText();
            ColorComboBox.ResetText();
            vin_rental.ResetText();
            try
            {
                BranchBoxConnection.Open();
                SqlCommand BranchBoxCommand = new SqlCommand("select distinct(C.Branch_ID) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.Model = '" + CarModel + "';", BranchBoxConnection);
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
                SqlCommand BranchBoxColours = new SqlCommand("select distinct(C.Color) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.Model = '" + CarModel + "';", BranchBoxColor);
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
            try
            {
                BranchBoxConnection.Open();
                SqlCommand readLabelVIN = new SqlCommand("select (C.VIN) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.Model = '" + CarModel + "';", BranchBoxColor);
                SqlDataReader myreader2;
                myreader2 = readLabelVIN.ExecuteReader();
                while (myreader2.Read())
                {
                    vin_rental.Text = myreader2["VIN"].ToString();
                }
                myreader2.Close();
                BranchBoxConnection.Close();
            }
            catch (Exception) { }
        }

        private void button5_click(object sender, EventArgs e)
        {
            SelectedCarImage.BackgroundImage = button5.BackgroundImage;
            CarModel = (string)button5.Tag;
            //MessageBox.Show(CarModel);
            BranchBox.ResetText();
            ColorComboBox.ResetText();
            vin_rental.ResetText();
            try
            {
                BranchBoxConnection.Open();
                SqlCommand BranchBoxCommand = new SqlCommand("select distinct(C.Branch_ID) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.Model = '" + CarModel + "';", BranchBoxConnection);
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
                SqlCommand BranchBoxColours = new SqlCommand("select distinct(C.Color) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.Model = '" + CarModel + "';", BranchBoxColor);
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
            try
            {
                BranchBoxConnection.Open();
                SqlCommand readLabelVIN = new SqlCommand("select (C.VIN) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.Model = '" + CarModel + "';", BranchBoxColor);
                SqlDataReader myreader2;
                myreader2 = readLabelVIN.ExecuteReader();
                while (myreader2.Read())
                {
                    vin_rental.Text = myreader2["VIN"].ToString();
                }
                myreader2.Close();
                BranchBoxConnection.Close();
            }
            catch (Exception) { }
        }

        private void button6_click(object sender, EventArgs e)
        {
            SelectedCarImage.BackgroundImage = button6.BackgroundImage;
            CarModel = (string)button6.Tag;
            //MessageBox.Show(CarModel);
            BranchBox.ResetText();
            ColorComboBox.ResetText();
            vin_rental.ResetText();
            try
            {
                BranchBoxConnection.Open();
                SqlCommand BranchBoxCommand = new SqlCommand("select distinct(C.Branch_ID) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.Model = '" + CarModel + "';", BranchBoxConnection);
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
                SqlCommand BranchBoxColours = new SqlCommand("select distinct(C.Color) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.Model = '" + CarModel + "';", BranchBoxColor);
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
            try
            {
                BranchBoxConnection.Open();
                SqlCommand readLabelVIN = new SqlCommand("select (C.VIN) from Cars as C, Branches as B where C.Branch_ID=B.Branch_ID and C.CarType = '" + CarType + "' and C.Model = '" + CarModel + "';", BranchBoxColor);
                SqlDataReader myreader2;
                myreader2 = readLabelVIN.ExecuteReader();
                while (myreader2.Read())
                {
                    vin_rental.Text = myreader2["VIN"].ToString();
                }
                myreader2.Close();
                BranchBoxConnection.Close();
            }
            catch (Exception) { }
        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            try
            {
                BranchBoxConnection.Open();
                //Need to include the branch ID in the sql command and the color
                SqlCommand RentCommand = new SqlCommand("Select (VIN) from Cars where Model = '" + CarModel + "'" + " and active != 'Yes' and Branch_ID = '" + BranchBox.Text + "';", BranchBoxConnection);
                if (RentCommand.ExecuteScalar() == null)
                {
                    MessageBox.Show("No VIN came up");
                    BranchBoxConnection.Close();
                }
                else
                {
                    //testing purposes, it shows the VIN number that is returned
                    int VIN = (int)RentCommand.ExecuteScalar();
                    MessageBox.Show(VIN.ToString());
                    BranchBoxConnection.Close();
                    //Here we would also have a rental trans sqlcommand
                    //Change the car active to no.

                }
               
                    
                
                
            }
            catch 
            
            {
            
            }
            
        }

        private void customer_report_show(object sender, EventArgs e)
        {
            int selectedIndex = comboBox_customerReport.SelectedIndex;
            Object selectedItem = comboBox_customerReport.SelectedItem;

            MessageBox.Show("Selected Item Text: " + selectedItem.ToString() + "'\n" + "Index: " + selectedIndex.ToString());
        }
    }
}
