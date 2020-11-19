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
    }
}
