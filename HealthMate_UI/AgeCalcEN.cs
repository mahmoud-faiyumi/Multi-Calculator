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
    public partial class AgeCalcEN : Form
    {
        public AgeCalcEN()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_MenuEN main_menuEN = new Main_MenuEN();
            main_menuEN.Show();
        }

        private void AgeCalcEN_Load(object sender, EventArgs e)
        {
            DateTime birthDate = CommonValues.CurrentUserInfo.BirthDate;
            DateTime now = DateTime.Now;
            TimeSpan ageTimeSpan = now - birthDate;

            int years = (int)Math.Floor(ageTimeSpan.TotalDays / 365.242199);
            int months = (int)Math.Floor((ageTimeSpan.TotalDays % 365.242199) / 30.4368499);
            int days = (int)Math.Floor(ageTimeSpan.TotalDays % 30.4368499);

            int nextBirthdayMonths = (int)Math.Floor(((years + 1) * 365.24199 - ageTimeSpan.TotalDays) / 30.4368499);
            int nextBirthdayDays = (int)Math.Ceiling(((years + 1) * 365.24199 - ageTimeSpan.TotalDays) % 30.4368499);

            int totalDays = (int)ageTimeSpan.TotalDays;
            int totalHours = (int)ageTimeSpan.TotalHours;
            long totalMinutes = (long)ageTimeSpan.TotalMinutes;

            long heartBeats = totalMinutes * 80;
            double totalFoodTonnes = Math.Round((years * 675.0 / 1000.0), 3);

            int WaterLitres = (int)Math.Floor(totalDays * 1.892079611964252);
            double totalSleepYears = Math.Round((totalDays / 365.242199) * 0.333333333333, 2);

            // Display the results in your Windows Forms controls (labels, text boxes, etc.)
            ageLabel.Text = $"Your Age: {years} Years, {months} Months, {days} Days";
            nextBirthdayLabel.Text = $"Next Birthday: {nextBirthdayMonths} Months, {nextBirthdayDays} Days";
            BirthDateDaylabel.Text = $"The day you were born is : {birthDate.DayOfWeek}";
            additionalFactsLabel.Text = $@"Amazing Facts About You...
- Your heart has beaten for {heartBeats.ToString("N0")} times.
- You ate {totalFoodTonnes} tons of food.
- You drank {WaterLitres.ToString("N0")} liters of water.
- You have slept for {totalSleepYears} years.";
            LivedForlabel.Text = $@"You Lived For:
- {years} Years.
- {(int)(totalDays / 30.4368499)} Months.
- {(int)(totalDays / 7)} Weeks.
- {totalDays.ToString("N0")} Days.
- {totalHours.ToString("N0")} Hours.";
        }

        private void AgeCalcEN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AnotherDateBtn_Click(object sender, EventArgs e)
        {
            DateTime birthDate = CustomdatePicker.Value;
            DateTime now = DateTime.Now;
            TimeSpan ageTimeSpan = now - birthDate;

            int years = (int)Math.Floor(ageTimeSpan.TotalDays / 365.242199);
            int months = (int)Math.Floor((ageTimeSpan.TotalDays % 365.242199) / 30.4368499);
            int days = (int)Math.Floor(ageTimeSpan.TotalDays % 30.4368499);

            int nextBirthdayMonths = (int)Math.Floor(((years + 1) * 365.24199 - ageTimeSpan.TotalDays) / 30.4368499);
            int nextBirthdayDays = (int)Math.Ceiling(((years + 1) * 365.24199 - ageTimeSpan.TotalDays) % 30.4368499);

            int totalDays = (int)ageTimeSpan.TotalDays;
            int totalHours = (int)ageTimeSpan.TotalHours;
            long totalMinutes = (long)ageTimeSpan.TotalMinutes;

            long heartBeats = totalMinutes * 80;
            double totalFoodTonnes = Math.Round((years * 675.0 / 1000.0), 3);

            int WaterLitres = (int)Math.Floor(totalDays * 1.892079611964252);
            double totalSleepYears = Math.Round((totalDays / 365.242199) * 0.333333333333, 2);

            // Display the results in your Windows Forms controls (labels, text boxes, etc.)
            ageLabel.Text = $"Your Age: {years} Years, {months} Months, {days} Days";
            nextBirthdayLabel.Text = $"Next Birthday: {nextBirthdayMonths} Months, {nextBirthdayDays} Days";
            BirthDateDaylabel.Text = $"The day you were born is : {birthDate.DayOfWeek}";
            additionalFactsLabel.Text = $@"Amazing Facts About You...
- Your heart has beaten for {heartBeats.ToString("N0")} times.
- You ate {totalFoodTonnes} tons of food.
- You drank {WaterLitres.ToString("N0")} liters of water.
- You have slept for {totalSleepYears} years.";
            LivedForlabel.Text = $@"You Lived For:
- {years} Years.
- {(int)(totalDays / 30.4368499)} Months.
- {(int)(totalDays / 7)} Weeks.
- {totalDays.ToString("N0")} Days.
- {totalHours.ToString("N0")} Hours.";
        }
    }
}
