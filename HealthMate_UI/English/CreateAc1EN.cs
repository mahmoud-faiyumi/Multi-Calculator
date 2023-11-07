using System;
using System.Windows.Forms;

namespace HealthMate_UI
{
    public partial class CreateAc1EN : Form
    {
        bool[] fieldEditedFlags = new bool[7]; // Create an array of boolean flags to track whether each field has been edited

        public CreateAc1EN()
        {
            InitializeComponent();
            progressBar1.Maximum = 11;

            for (int i = 0; i < fieldEditedFlags.Length; i++)
            {
                fieldEditedFlags[i] = false; // Initialize all flags to false
            }

            UpdateNextBtnState();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            string fname = Fname.Text;
            string lname = Lname.Text;
            string email = Email.Text;
            string username = Username.Text;
            string gender = Gender.Text;
            string activityLevel = ActivityLevel.Text;
            DateTime birthdate = Birthdate.Value;

            this.Hide();
            CreateAc2EN createAc2EN = new CreateAc2EN(fname, lname, email, username, gender, birthdate, activityLevel);
            createAc2EN.Show();
        }

        private void CreateAc1EN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginEN loginEN = new LoginEN();
            loginEN.Show();
        }

        private void Fname_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Fname.Text) && !fieldEditedFlags[0])
            {
                progressBar1.Value++;
                fieldEditedFlags[0] = true;
            }

            UpdateNextBtnState();
        }

        private void Lname_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Lname.Text) && !fieldEditedFlags[1])
            {
                progressBar1.Value++;
                fieldEditedFlags[1] = true;
            }

            UpdateNextBtnState();
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Email.Text) && !fieldEditedFlags[2])
            {
                progressBar1.Value++;
                fieldEditedFlags[2] = true;
            }

            UpdateNextBtnState();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Username.Text) && !fieldEditedFlags[3])
            {
                progressBar1.Value++;
                fieldEditedFlags[3] = true;
            }

            UpdateNextBtnState();
        }

        private void Gender_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Gender.Text) && !fieldEditedFlags[4])
            {
                progressBar1.Value++;
                fieldEditedFlags[4] = true;
            }

            UpdateNextBtnState();
        }

        private void ActivityLevel_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ActivityLevel.Text) && !fieldEditedFlags[5])
            {
                progressBar1.Value++;
                fieldEditedFlags[5] = true;
            }

            UpdateNextBtnState();
        }

        private void Birthdate_ValueChanged(object sender, EventArgs e)
        {
            if (Birthdate.Value != DateTime.Today && !fieldEditedFlags[6])
            {
                progressBar1.Value++;
                fieldEditedFlags[6] = true;
            }

            UpdateNextBtnState();
        }

        private void UpdateNextBtnState()
        {
            Nextbtn.Enabled = progressBar1.Value >= 7;
        }
    }
}
