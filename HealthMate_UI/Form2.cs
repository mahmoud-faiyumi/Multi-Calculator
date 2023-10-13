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
    public partial class CreateAc1EN : Form
    {
        public CreateAc1EN()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAc2EN createAc2EN = new CreateAc2EN();
            createAc2EN.Show();
        }
    }
}
