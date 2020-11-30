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

namespace _291GroupProject
{
    public partial class SearchCar : Form
    {
        public SearchCar()
        {
            InitializeComponent();
            SelectedCarImage.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void SearchBackButton_Click(object sender, EventArgs e)
        {
            var newForm = new MainMenu();
            newForm.Show();
            this.Hide();
        }

        private void redClick(object sender, MouseEventArgs e)
        {
            SelectedCarImage.BackColor = Color.Red;
        }

        private void cyanClick(object sender, MouseEventArgs e)
        {
            SelectedCarImage.BackColor = Color.Cyan;
        }

        private void whiteClick(object sender, MouseEventArgs e)
        {
            SelectedCarImage.BackColor = Color.White;
        }

        private void blackClick(object sender, MouseEventArgs e)
        {
            SelectedCarImage.BackColor = Color.Black;
        }

        private void greenClick(object sender, MouseEventArgs e)
        {
            SelectedCarImage.BackColor = Color.Green;
        }

        private void yellowClick(object sender, MouseEventArgs e)
        {
            SelectedCarImage.BackColor = Color.Yellow;
        }

        private void blueClick(object sender, MouseEventArgs e)
        {
            SelectedCarImage.BackColor = Color.Blue;
        }

        private void greyClick(object sender, MouseEventArgs e)
        {
            SelectedCarImage.BackColor = Color.Gray;
        }

        private void orangeClick(object sender, MouseEventArgs e)
        {
            SelectedCarImage.BackColor = Color.Orange;
        }

        private void purpleClick(object sender, MouseEventArgs e)
        {
            SelectedCarImage.BackColor = Color.Purple;
        }

        private void SearchCar_Load(object sender, EventArgs e)
        {

        }

        private void TruckButton_Click(object sender, EventArgs e)
        {   //Need to create a function to make this less copy paste
            //Function would just take an input like truck/sedan, then just change button1-6

            button1.BackgroundImage = _291GroupProject.Properties.Resources.truck_1;
            button2.BackgroundImage = _291GroupProject.Properties.Resources.truck_2;
            button3.BackgroundImage = _291GroupProject.Properties.Resources.truck_3;
            button4.BackgroundImage = _291GroupProject.Properties.Resources.truck_4;
            button5.BackgroundImage = _291GroupProject.Properties.Resources.truck_5;
            button6.BackgroundImage = _291GroupProject.Properties.Resources.truck_6;
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
    }
}
