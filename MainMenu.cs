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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            Employee employee1 = new Employee();
            employee1.ShowDialog();
          
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            SearchCar Search = new SearchCar();
            Search.Show();
            this.Hide();
        }

        private void UserAccountButton_Click(object sender, EventArgs e)
        {
            var newForm = new AddAccount();
            newForm.Show();
            this.Hide();
        }
    }
}
