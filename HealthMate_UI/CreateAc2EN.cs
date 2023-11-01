using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HealthMate_UI
{
    public partial class CreateAc2EN : Form
    {
        bool[] fieldEditedFlags = new bool[4]; // Create an array of boolean flags to track whether each field has been edited
        private bool passwordVisible = false;
        private bool passwordVisibleRE = false;

        private string fname;
        private string lname;
        private string email;
        private string username;
        private string gender;
        private DateTime birthdate;
        private string activityLevel;

        private DatabaseManager databaseManager;

        public CreateAc2EN(string Fname, string Lname, string Email, string Username, string Gender, DateTime Birthdate, string ActivityLevel)
        {
            InitializeComponent();
            progressBar1.Maximum = 11;

            for (int i = 0; i < fieldEditedFlags.Length; i++)
            {
                fieldEditedFlags[i] = false; // Initialize all flags to false
            }

            fname = Fname;
            lname = Lname;
            email = Email;
            username = Username;
            gender = Gender;
            birthdate = Birthdate;
            activityLevel = ActivityLevel;

            UpdateCreateAccbtnState();

            databaseManager = new DatabaseManager();

            Password.PasswordChar = '*';
            RePassword.PasswordChar = '*';

            // Set the initial image
            PasswordVisibility.BackgroundImage = Properties.Resources.hide_eye; // Use your initial image here
            PasswordVisibility.BackgroundImageLayout = ImageLayout.Stretch; // Set the layout to stretch
            PasswordVisibilityRE.BackgroundImage = Properties.Resources.hide_eye; // Use your initial image here
            PasswordVisibilityRE.BackgroundImageLayout = ImageLayout.Stretch; // Set the layout to stretch
        }

        private void CreateAc2EN_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 7;
        }

        private void CreateAccbtn_Click(object sender, EventArgs e)
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

            // The passwords match, so you can proceed to account creation
            string encryptionKey = "hTbHfq5rC5dAby6DJt8P3w==";
            string initializationVector = "6mRwZNlJb/WLbCyk4n+bBg==";

            var encryptionService = new EncryptionService(encryptionKey, initializationVector);

            string plainText1 = Password.Text;
            string encryptedText1 = encryptionService.Encrypt(plainText1);

            DateTime now = DateTime.Now;
            TimeSpan ageTimeSpan = now - birthdate;
            int Age = (int)Math.Floor(ageTimeSpan.TotalDays / 365.242199);

            int height, weight;

            if (!int.TryParse(Height_cm.Text, out height) || !int.TryParse(Weight.Text, out weight))
            {
                MessageBox.Show("Please enter valid height and weight.", "Validation Error", MessageBoxButtons.OK);
                Height_cm.Clear();
                Weight.Clear();
                return; // Don't proceed if height or weight is not valid
            }

            // Calculate BMI
            double BMI = Math.Round(weight / Math.Pow(height / 100.0, 2), 1);

            try
            {
                databaseManager.OpenConnection();

                // Insert user data into the database
                string insertQuery = "INSERT INTO UserInfo (FName, LName, Email, UserName, Password, BirthDate, Gender, Height, Weight, Age, ActivityLevel, BMI) " +
                                     "VALUES (@Fname, @Lname, @Email, @UserName, @Password, @BirthDate, @gender, @Height, @Weight, @Age, @activityLevel, @BMI)";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, databaseManager.GetConnection()))
                {
                    insertCommand.Parameters.AddWithValue("@Fname", fname);
                    insertCommand.Parameters.AddWithValue("@Lname", lname);
                    insertCommand.Parameters.AddWithValue("@Email", email);
                    insertCommand.Parameters.AddWithValue("@UserName", username);
                    insertCommand.Parameters.AddWithValue("@Password", encryptedText1);
                    insertCommand.Parameters.AddWithValue("@BirthDate", birthdate);
                    insertCommand.Parameters.AddWithValue("@gender", gender);
                    insertCommand.Parameters.AddWithValue("@Height", height);
                    insertCommand.Parameters.AddWithValue("@Weight", weight);
                    insertCommand.Parameters.AddWithValue("@Age", Age);
                    insertCommand.Parameters.AddWithValue("@activityLevel", activityLevel);
                    insertCommand.Parameters.AddWithValue("@BMI", BMI);

                    insertCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK);

                // Proceed to the next form
                this.Hide();
                LoginEN loginEN = new LoginEN();
                loginEN.Show();
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

        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Password.Text) && !fieldEditedFlags[0])
            {
                progressBar1.Value++;
                fieldEditedFlags[0] = true;
            }

            UpdateCreateAccbtnState();

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
            if (!string.IsNullOrWhiteSpace(RePassword.Text) && !fieldEditedFlags[1])
            {
                progressBar1.Value++;
                fieldEditedFlags[1] = true;
            }

            UpdateCreateAccbtnState();

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

        private void Height_cm_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Height_cm.Text) && !fieldEditedFlags[2])
            {
                progressBar1.Value++;
                fieldEditedFlags[2] = true;
            }

            UpdateCreateAccbtnState();
        }

        private void Weight_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Weight.Text) && !fieldEditedFlags[3])
            {
                progressBar1.Value++;
                fieldEditedFlags[3] = true;
            }

            UpdateCreateAccbtnState();
        }

        private void CreateAc2EN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAc1EN createAc1EN = new CreateAc1EN();
            createAc1EN.Show();
        }

        private void UpdateCreateAccbtnState()
        {
            CreateAccbtn.Enabled = progressBar1.Value >= 11;
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
    }
}