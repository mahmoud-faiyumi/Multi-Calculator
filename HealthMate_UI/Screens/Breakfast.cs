using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthMate_UI.Screens
{
    public partial class Breakfast : Form
    {
        public Breakfast()
        {
            InitializeComponent();
        }

        private void Breakfast_Load(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string breakCal = BrkFstCal.Text;
            this.Close();
            MessageBox.Show(breakCal);
        }
    }
}
