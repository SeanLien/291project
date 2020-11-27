using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
