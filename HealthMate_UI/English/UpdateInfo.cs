using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HealthMate_UI
{
    public partial class UpdateInfo : Form
    {
        private bool passwordVisible = false;
        private bool passwordVisibleRE = false;
        private bool inches = true; // Initially set to inches
        private bool LB = true;  // Initially set to pounds
        private DatabaseManager databaseManager;
        int rowsAffected = 0;
        string username = CommonValues.CurrentUserInfo.UserName;

        public UpdateInfo()
        {
            InitializeComponent();

            databaseManager = new DatabaseManager();

            Password.PasswordChar = '*';
            RePassword.PasswordChar = '*';

            // Set the initial image
            PasswordVisibility.BackgroundImage = Properties.Resources.hide_eye; // Use your initial image here
            PasswordVisibility.BackgroundImageLayout = ImageLayout.Stretch; // Set the layout to stretch
            PasswordVisibilityRE.BackgroundImage = Properties.Resources.hide_eye; // Use your initial image here
            PasswordVisibilityRE.BackgroundImageLayout = ImageLayout.Stretch; // Set the layout to stretch
            InchesToCm.BackgroundImage = Properties.Resources.inches_01; // Use the CM image
            InchesToCm.BackgroundImageLayout = ImageLayout.Stretch; // Set the layout to stretch
            KGToLB.BackgroundImage = Properties.Resources.LB_01; // Use the LB image
            KGToLB.BackgroundImageLayout = ImageLayout.Stretch; // Set the layout to stretch
        }

        private void UpdateInfo_Load(object sender, EventArgs e)
        {

        }

        private void InchesToCm_Click(object sender, EventArgs e)
        {
            inches = !inches;

            if (inches)
            {
                InchesToCm.BackgroundImage = Properties.Resources.inches_01; // Use the Inches image
            }
            else
            {
                InchesToCm.BackgroundImage = Properties.Resources.CM_01; // Use the CM image
            }
            // Set the image layout to stretch within the button
            InchesToCm.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void KGToLB_Click(object sender, EventArgs e)
        {
            LB = !LB;

            if (LB)
            {
                KGToLB.BackgroundImage = Properties.Resources.LB_01; // Use the LB image
            }
            else
            {
                KGToLB.BackgroundImage = Properties.Resources.KG_01; // Use the KG image
            }
            // Set the image layout to stretch within the button
            KGToLB.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_MenuEN main_menuEN = new Main_MenuEN();
            main_menuEN.Show();
        }

        private void UpdateInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PasswordVisibility_Click(object sender, EventArgs e)
        {
            // Toggle password visibility
            passwordVisible = !passwordVisible;
            Password.PasswordChar = passwordVisible ? '\0' : '*';

            // Change the eye icon
            if (passwordVisible)
            {
                PasswordVisibility.BackgroundImage = Properties.Resources.show_eye; // Use the open eye image
            }
            else
            {
                PasswordVisibility.BackgroundImage = Properties.Resources.hide_eye; // Use the closed eye image
            }
            // Set the image layout to stretch within the button
            PasswordVisibility.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void PasswordVisibilityRE_Click(object sender, EventArgs e)
        {
            // Toggle password visibility
            passwordVisibleRE = !passwordVisibleRE;
            RePassword.PasswordChar = passwordVisibleRE ? '\0' : '*';

            // Change the eye icon
            if (passwordVisibleRE)
            {
                PasswordVisibilityRE.BackgroundImage = Properties.Resources.show_eye; // Use the open eye image
            }
            else
            {
                PasswordVisibilityRE.BackgroundImage = Properties.Resources.hide_eye; // Use the closed eye image
            }
            // Set the image layout to stretch within the button
            PasswordVisibilityRE.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            string password = Password.Text;

            // Check if the password is empty or null
            if (string.IsNullOrWhiteSpace(password))
            {
                PasswordStrengthLabel.Text = "Password Strength: N/A";
                PasswordStrengthLabel.ForeColor = Color.Black;
                return; // Exit the event handler
            }

            var result = Zxcvbn.Core.EvaluatePassword(password);

            int strength = result.Score; // Zxcvbn's password strength score (0-4)

            // Combine Zxcvbn's suggestions into a single string
            string suggestions = string.Join(". ", result.Feedback.Suggestions);

            // Set text color and strength level based on strength score
            string strengthMessage;
            Color strengthColor;

            switch (strength)
            {
                case 0:
                    strengthMessage = "Very Weak";
                    strengthColor = Color.DarkRed;
                    break;
                case 1:
                    strengthMessage = "Weak";
                    strengthColor = Color.OrangeRed;
                    break;
                case 2:
                    strengthMessage = "Moderate";
                    strengthColor = Color.Orange;
                    break;
                case 3:
                    strengthMessage = "Strong";
                    strengthColor = Color.Green;
                    break;
                case 4:
                    strengthMessage = "Very Strong";
                    strengthColor = Color.Blue;
                    break;
                default:
                    strengthMessage = "N/A";
                    strengthColor = Color.Black;
                    break;
            }

            PasswordStrengthLabel.Text = $"Password Strength: {strengthMessage}\n({suggestions})";
            PasswordStrengthLabel.ForeColor = strengthColor;

        }

        private void RePassword_TextChanged(object sender, EventArgs e)
        {
            string password = Password.Text;
            string confirmPassword = RePassword.Text;

            if (password != confirmPassword)
            {
                // Passwords do not match
                PasswordMatchLabel.Text = "Passwords do not match!";
            }
            else
            {
                PasswordMatchLabel.Text = "";
            }
        }

        private void UpdateUser()
        {
            try
            {
                databaseManager.OpenConnection();
                string updateQuery = "UPDATE UserInfo SET ";
                string comma = "";

                using (SqlCommand command1 = new SqlCommand("", databaseManager.GetConnection()))
                {
                    if (!string.IsNullOrWhiteSpace(Fname.Text))
                    {
                        updateQuery += comma + "FName = @NewValue1";
                        command1.Parameters.AddWithValue("@NewValue1", Fname.Text);
                        comma = ", ";
                    }

                    if (!string.IsNullOrWhiteSpace(Lname.Text))
                    {
                        updateQuery += comma + "LName = @NewValue2";
                        command1.Parameters.AddWithValue("@NewValue2", Lname.Text);
                        comma = ", ";
                    }

                    if (!string.IsNullOrWhiteSpace(Username.Text))
                    {
                        updateQuery += comma + "UserName = @NewValue3";
                        command1.Parameters.AddWithValue("@NewValue3", Username.Text);
                        comma = ", ";
                    }

                    if (!string.IsNullOrWhiteSpace(ActivityLevel.Text))
                    {
                        updateQuery += comma + "ActivityLevel = @NewValue4";
                        command1.Parameters.AddWithValue("@NewValue4", ActivityLevel.Text);
                        comma = ", ";
                    }

                    if (!string.IsNullOrWhiteSpace(Email.Text))
                    {
                        updateQuery += comma + "Email = @NewValue5";
                        command1.Parameters.AddWithValue("@NewValue5", Email.Text);
                        comma = ", ";
                    }

                    if (double.TryParse(Weight.Text, out double weightValue))
                    {
                        weightValue = WeightConverter.ConvertWeight(weightValue, LB);
                        updateQuery += comma + "Weight = @NewValue6";
                        command1.Parameters.AddWithValue("@NewValue6", weightValue.ToString());
                        comma = ", ";
                    }

                    if (double.TryParse(Height_cm.Text, out double heightValue))
                    {
                        heightValue = HeightConverter.ConvertHeight(heightValue, inches);
                        updateQuery += comma + "Height = @NewValue7";
                        command1.Parameters.AddWithValue("@NewValue7", heightValue.ToString());
                    }

                    if (!string.IsNullOrWhiteSpace(Password.Text))
                    {
                        string encryptionKey1 = "hTbHfq5rC5dAby6DJt8P3w==";
                        string initializationVector1 = "6mRwZNlJb/WLbCyk4n+bBg==";

                        var encryptionService1 = new EncryptionService(encryptionKey1, initializationVector1);

                        string plainText = Password.Text;
                        string encryptedText = encryptionService1.Encrypt(plainText); updateQuery += comma + "Password = @NewValue8";
                        command1.Parameters.AddWithValue("@NewValue8", encryptedText);
                    }

                    // Add the common part of the SQL query
                    updateQuery += " WHERE UserName = @Username";
                    command1.Parameters.AddWithValue("@Username", username);
                    command1.CommandText = updateQuery;

                    // Execute the update query
                    int rowsAffected = command1.ExecuteNonQuery();

                    // Check how many rows were updated
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(rowsAffected + " rows updated.", "Update Success", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("No rows updated.", "Update Result", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
            finally
            {
                databaseManager.CloseConnection();
            }
        }

        private void UpdateUsrInfo_Click(object sender, EventArgs e)
        {
            string password = Password.Text;
            string confirmPassword = RePassword.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("The passwords do not match. Please try again.", "Password Validation", MessageBoxButtons.OK);
                Password.Clear();
                RePassword.Clear();
                return; // Don't proceed if passwords don't match
            }

            double height, weight;

            if (!double.TryParse(Weight.Text, out weight) && !string.IsNullOrWhiteSpace(Weight.Text))
            {
                MessageBox.Show("Please enter valid weight.", "Validation Error", MessageBoxButtons.OK);
                Weight.Clear();
                return; // Don't proceed if weight is not valid
            }

            if (!double.TryParse(Height_cm.Text, out height) && !string.IsNullOrWhiteSpace(Height_cm.Text))
            {
                MessageBox.Show("Please enter valid height.", "Validation Error", MessageBoxButtons.OK);
                Height_cm.Clear();
                return; // Don't proceed if height is not valid
            }
            UpdateUser();
            Fname.Clear();
            Lname.Clear();
            Username.Clear();
            ActivityLevel.Items.Clear();
            Email.Clear();
            Weight.Clear();
            Height_cm.Clear();
            Password.Clear();
            RePassword.Clear();
        }
    }
}
