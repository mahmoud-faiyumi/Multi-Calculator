using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HealthMate_UI
{
    public partial class CreateAc2EN : Form
    {
        bool[] fieldEditedFlags = new bool[4]; // Create an array of boolean flags to track whether each field has been edited

        private string fname;
        private string lname;
        private string email;
        private string username;
        private string gender;
        private DateTime birthdate;
        private string activityLevel;

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
        }

        private void CreateAc2EN_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 7;
        }

        private void CreateAccbtn_Click(object sender, EventArgs e)
        {
            int height = Convert.ToInt32(Height_cm.Text);
            int weight = Convert.ToInt32(Weight.Text);
            string password = Password.Text;
            string confirmPassword = RePassword.Text;

            bool isValid = false;

            do
            {
                if (password == confirmPassword)
                {
                    isValid = true; // Exit the loop
                    MessageBox.Show("Account created successfully");
                }
                if (!isValid)
                {
                    // Clear the password fields and wait for user input
                    Password.Clear();
                    RePassword.Clear();

                    var result = MessageBox.Show("The passwords do not match. Do you want to try again?", "Password Validation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        // User cancels the operation
                        break;
                    }
                    else if (result == DialogResult.No)
                    {
                        // User wants to proceed without a valid password
                        MessageBox.Show("Account not created");
                        Close();
                        LoginEN loginEN = new LoginEN();
                        loginEN.Show();
                        break;
                    }
                }
            } while (!isValid);

            string encryptionKey = "hTbHfq5rC5dAby6DJt8P3w==";
            string initializationVector = "6mRwZNlJb/WLbCyk4n+bBg==";

            var encryptionService = new EncryptionService(encryptionKey, initializationVector);

            string plainText1 = Password.Text;
            string encryptedText1 = encryptionService.Encrypt(plainText1);

            DateTime now = DateTime.Now;
            TimeSpan ageTimeSpan = now - birthdate;
            int Age = (int)Math.Floor(ageTimeSpan.TotalDays / 365.242199);

            //Calculate BMI
            double BMI = Math.Round(weight / Math.Pow(height / 100.0, 2), 1);

            //connect to the DataBase
            System.Data.SqlClient.SqlConnection sqlConnection;
            string connectionString = @"Data Source=DESKTOP-QUB8L8T\SQLEXPRESS;Initial Catalog=UserInfoDB;Integrated Security=True";

            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                //Insert user data into the DataBase
                string insertQuery = "INSERT INTO UserInfo (FName, LName, Email, UserName, Password, BirthDate, Gender, Height, Weight, Age, ActivityLevel, BMI) " +
                                     "VALUES (@Fname, @Lname, @Email, @UserName, @Password, @BirthDate, @gender, @Height, @Weight, @Age, @activityLevel, @BMI)";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection))
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK);
            }

            if (isValid)
            {
                // Proceed to the next form
                this.Hide();
                LoginEN loginEN = new LoginEN();
                loginEN.Show();
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

            UpdateCreateAccbtnState(); ;
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
    }
}