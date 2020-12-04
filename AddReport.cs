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
    public partial class AddReport : Form
    {
        public AddReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void report_car(object sender, AsyncCompletedEventArgs e)
        {
            //pictureBox1.BackgroundImage = SearchCar.SelectedCarImage.BackgroundImage;
        }

        private void report_car(object sender, PaintEventArgs e)
        {
            //pictureBox1.BackgroundImage = SearchCar.SelectedCarImage.BackgroundImage;
        }
    }
}
