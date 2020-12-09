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
        public SqlDataReader myReader;
        public SqlConnection BranchBoxConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["291proj"].ConnectionString);
        public SqlConnection BranchBoxColor = new SqlConnection(ConfigurationManager.ConnectionStrings["291proj"].ConnectionString);
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
        }

        private void button1_click(object sender, EventArgs e)
        {
            SelectedCarImage.BackgroundImage = button1.BackgroundImage;
            CarModel = (string)button1.Tag;
            //MessageBox.Show(CarModel);
            BranchBox.ResetText();
            ColorComboBox.ResetText();
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
        }

        private void button3_click(object sender, EventArgs e)
        {
            SelectedCarImage.BackgroundImage = button3.BackgroundImage;
            CarModel = (string)button3.Tag;
            //MessageBox.Show(CarModel);
            BranchBox.ResetText();
            ColorComboBox.ResetText();
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
        }

        private void button4_click(object sender, EventArgs e)
        {
            SelectedCarImage.BackgroundImage = button4.BackgroundImage;
            CarModel = (string)button4.Tag;
            //MessageBox.Show(CarModel);
            BranchBox.ResetText();
            ColorComboBox.ResetText();
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
        }

        private void button5_click(object sender, EventArgs e)
        {
            SelectedCarImage.BackgroundImage = button5.BackgroundImage;
            CarModel = (string)button5.Tag;
            //MessageBox.Show(CarModel);
            BranchBox.ResetText();
            ColorComboBox.ResetText();
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
        }

        private void button6_click(object sender, EventArgs e)
        {
            SelectedCarImage.BackgroundImage = button6.BackgroundImage;
            CarModel = (string)button6.Tag;
            //MessageBox.Show(CarModel);
            BranchBox.ResetText();
            ColorComboBox.ResetText();
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
        private void customer_report_button(object sender, MouseEventArgs e)
        {
            dataGridView1.Rows.Clear(); // clears the current table when inputting
            textBox01.Clear();
            textBox02.Clear();
            textBox03.Clear();
            textBox04.Clear();
            textBox05.Clear();
            textBox06.Clear();
            textBox07.Clear();
            textBox08.Clear();
            textBox09.Clear();
            textBox11.Clear();
            textBox12.Clear();

            myCommand.CommandText = "Select * from Rental_trans as RT where ";

            if (textBox01 != null) {
                myCommand.CommandText += "year(return_date) <= '" + textBox01.Text + "'";
            }
            if (textBox02 != null) {
                myCommand.CommandText += "month(return_date) <= '" + textBox02.Text + "'";
            }
            if (textBox03 != null) {
                myCommand.CommandText += "day(return_date) <= '" + textBox03.Text + "'";
            }
            if (textBox04 != null) {
                myCommand.CommandText += "VIN = '" + textBox04.Text + "'";
            }
            if (textBox05 != null) {
                myCommand.CommandText = "select * from Rental_trans as RT where RT.VIN = (select VIN from Cars as C where C.CarType = '" + textBox05 + "')";
            }
            if (textBox06 != null) {
                myCommand.CommandText = "select * from Rental_trans as RT where RT.VIN = (select VIN from Cars as C where C.Model = '" + textBox06 + "')";
            }
            if (textBox07 != null) {
                myCommand.CommandText = "select * from Rental_trans as RT where RT.VIN = (select VIN from Cars as C where C.Color = '" + textBox07 + "')";
            }
            if (textBox08 != null) {
                myCommand.CommandText += "price = '" + textBox08.Text + "'";
            }
            if (textBox09 != null) {
                myCommand.CommandText += "price <= '" + textBox09.Text + "'";
            }
            if (textBox11 != null) {
                myCommand.CommandText += "price >= '" + textBox11.Text + "'";
            }
            if (textBox12 != null) {
                myCommand.CommandText += "pickup_Branch_ID = '" + textBox12.Text + "' or return_Branch_ID = '" + textBox12.Text + "'";
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
            catch(Exception) {}
        }

        private void searchTime(object sender, MouseEventArgs e)
        {

        }

        private void searchCar(object sender, MouseEventArgs e)
        {

        }

        private void searchPrice(object sender, MouseEventArgs e)
        {

        }

        private void searchBranch(object sender, MouseEventArgs e)
        {

        }
    }
}
