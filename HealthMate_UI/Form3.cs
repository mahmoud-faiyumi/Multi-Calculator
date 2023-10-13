using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthMate_UI
{
    public partial class CreateAc2EN : Form
    {
        public CreateAc2EN()
        {
            InitializeComponent();
        }

        private void CreateAccbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginEN loginEN = new LoginEN();
            MessageBox.Show("Account created successfully");
            loginEN.Show();
        }
    }
}
