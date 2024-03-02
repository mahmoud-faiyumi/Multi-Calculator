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
    public partial class HealthMonitorEN : Form
    {
        public HealthMonitorEN()
        {
            InitializeComponent();
            line.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_MenuEN main_menuEN = new Main_MenuEN();
            main_menuEN.Show();
        }

        private void HealthMonitorEN_Load(object sender, EventArgs e)
        {
            double weight = CommonValues.CurrentUserInfo.Weight;
            double height = CommonValues.CurrentUserInfo.Height;
            int age = CommonValues.CurrentUserInfo.Age;
            string gender = CommonValues.CurrentUserInfo.Gender;
            string activityLevel = CommonValues.CurrentUserInfo.ActivityLevel;
            double bmi = CommonValues.CurrentUserInfo.BMI;

            double bmr = gender == "Male" ? 66 + (13.7 * weight) + (5 * height) - (6.8 * age) : 655 + (9.6 * weight) + (1.8 * height) - (4.7 * age);

            double dailyCalorieNeeds = 0;

            if (activityLevel == "Lazy")
            {
                dailyCalorieNeeds = bmr * 1.2;
            }
            else if (activityLevel == "Lightly")
            {
                dailyCalorieNeeds = bmr * 1.375;
            }
            else if (activityLevel == "Medium")
            {
                dailyCalorieNeeds = bmr * 1.55;
            }
            else if (activityLevel == "Active")
            {
                dailyCalorieNeeds = bmr * 1.725;
            }

            int cal = Convert.ToInt32(dailyCalorieNeeds);

            string category = "";

            if (bmi < 18.5)
            {
                category = "Underweight";
            }
            else if (bmi < 25)
            {
                category = "Normal weight";
            }
            else if (bmi < 30)
            {
                category = "Overweight";
            }
            else
            {
                category = "Obesity";
            }

            double idealWeight = gender == "Male" ? height - 105 : height - 110;

            // Update the labels or textboxes on your form to display the results
            BMILabel.Text = "Your BMI Is: " + bmi;
            CategoryLabel.Text = "Your BMI Category Is: " + category;
            CalorieNeedsLabel.Text = "Daily calorie needs are: " + cal + " calories";
            IdealWeightLabel.Text = "Your Ideal Weight Is: " + idealWeight;

            if (category == "Underweight")
            {
                AdviceLabel.Text = "Your weight is under the minimum recommended weight.\nWe advise you to do the following:\n\n1. Eat more meals.\n2. Drink smoothies.\n3. Monitor and avoid drinks and foods that reduce appetite.\n4. Exercise regularly.\n\nIf you do not find a result, we recommend that you see a doctor.";
            }
            else if (category == "Obesity")
            {
                AdviceLabel.Text = "Your weight is over the maximum recommended weight.\nWe advise you to do the following:\n\n1. Exercise regularly.\n2. Follow a diet with specialist follow-up.\n3. Medicinal obesity treatment prescribed by a doctor.\n4. Surgical treatment.\n5. Do sports with a specialist or a professional coach.";
            }
            else if (category == "Overweight")
            {
                AdviceLabel.Text = "Your weight exceeds the recommended limit.\nTo prevent obesity, follow the following steps:\n\n1. Eat five small meals a day.\n2. Avoid processed foods such as sausage and canned meat.\n3. Reduce your sugar consumption.\n4. Reduce the use of artificial sweeteners.\n5. Avoid saturated fats.\n6. Cook food at home.\n7. Exercise regularly.";
            }
            else
            {
                AdviceLabel.Text = "Your BMI is comfortably nestled in the healthy zone.\nKeep up the great work and continue savoring nutritious meals\nand staying active.\nYour well-being is in good hands!";
            }
        }

        private void HealthMonitorEN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
