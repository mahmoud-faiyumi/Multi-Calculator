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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("السلام عليكم");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string usernameText = Username.Text; // Get the text from the TextBox
            Username.Text = string.Empty; // Clear the TextBox
            string passwordText = Password.Text; // Get the text from the TextBox
            Password.Text = string.Empty; // Clear the TextBox
        }
    }
}
