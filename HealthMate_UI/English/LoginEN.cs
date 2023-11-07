using HealthMate_UI.Models;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HealthMate_UI
{
    public partial class LoginEN : Form
    {
        private DatabaseManager databaseManager;
        private bool passwordVisible = false;
        public LoginEN()
        {
            InitializeComponent();
            Password.PasswordChar = '*';
            databaseManager = new DatabaseManager();

            // Set the initial image
            PasswordVisibility.BackgroundImage = Properties.Resources.hide_eye; // Use your initial image here
            PasswordVisibility.BackgroundImageLayout = ImageLayout.Stretch; // Set the layout to stretch
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("السلام عليكم");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string usernameText = Username.Text;
            string passwordText = Password.Text;

            try
            {
                databaseManager.OpenConnection();

                string readQuery = "SELECT * FROM UserInfo WHERE UserName = @Username";

                using (SqlCommand command = new SqlCommand(readQuery, databaseManager.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Username", usernameText);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CommonValues.CurrentUserInfo = new UserInfo
                            {
                                FName = reader["FName"].ToString(),
                                LName = reader["LName"].ToString(),
                                UserName = reader["UserName"].ToString(),
                                BirthDate = (DateTime)reader["BirthDate"],
                                ActivityLevel = reader["ActivityLevel"].ToString(),
                                Age = (int)reader["Age"],
                                BMI = (double)reader["BMI"],
                                Gender = reader["Gender"].ToString(),
                                Height = (double)reader["Height"],
                                Weight = (double)reader["Weight"]
                            };

                            string passwordFromDB = reader["Password"].ToString();

                            var encryptionService = new EncryptionService("hTbHfq5rC5dAby6DJt8P3w==", "6mRwZNlJb/WLbCyk4n+bBg==");

                            string decryptedPass = encryptionService.Decrypt(passwordFromDB);

                            if (passwordText == decryptedPass)
                            {
                                this.Hide();
                                Main_MenuEN mainMenu = new Main_MenuEN();
                                mainMenu.Show();
                            }
                            else
                            {
                                LoginCheck.Text = "Login failed. Please check your password.";
                            }
                        }
                        else
                        {
                            LoginCheck.Text = "Login failed. User not found.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LoginCheck.Text = "An error occurred: " + ex.Message;
            }
            finally
            {
                databaseManager.CloseConnection();
            }
        }
        private void CreateAccbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAc1EN createAc1EN = new CreateAc1EN();
            createAc1EN.Show();
        }

        private void SelectLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            // You can handle language selection here if needed.
        }

        private void LoginEN_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}