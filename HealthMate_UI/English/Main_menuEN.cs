using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HealthMate_UI
{
    public partial class Main_MenuEN : Form
    {
        private DatabaseManager databaseManager;

        public Main_MenuEN()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
            line.Enabled = false;
            button1.Enabled = false;
        }

        private void Main_menuEN_Load(object sender, EventArgs e)
        {
            if (CommonValues.CurrentUserInfo.BirthDate == DateTime.Today)
            {
                HappyBirthday.Text = $"Happy Birthday {CommonValues.CurrentUserInfo.FName} <3";
            }

            string welcomeMessage = WelcomeMessageGenerator.GenerateWelcomeMessage(CommonValues.CurrentUserInfo.FName);
            WelcomeMsg.Text = welcomeMessage;
        }

        private void Main_menuEN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            CommonValues.CurrentUserInfo = null;

            this.Hide();
            LoginEN loginEN = new LoginEN();
            loginEN.Show();
        }

        private void AgeCalcBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgeCalcEN ageCalcEN = new AgeCalcEN();
            ageCalcEN.Show();
        }

        private void HealthMonitorBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HealthMonitorEN healthMonitorEN = new HealthMonitorEN();
            healthMonitorEN.Show();
        }

        private void UpdateInfoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateInfo updateInfoEN = new UpdateInfo();
            updateInfoEN.Show();
        }
    }
}