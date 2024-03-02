﻿using HealthMate_UI.Constants;
using HealthMate_UI.Models;
using ImageRetrievalApp;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HealthMate_UI
{
    public partial class Login : Form
    {
        private DatabaseManager databaseManager;
        private bool passwordVisible = false;

        public Login()
        {
            InitializeComponent();
            CommonValues.CurrentUserInfo = new UserInfo();
            Password.PasswordChar = '*';
            databaseManager = new DatabaseManager();

            // Set the initial image
            PasswordVisibility.BackgroundImage = Properties.Resources.hide_eye; // Use your initial image here
            PasswordVisibility.BackgroundImageLayout = ImageLayout.Stretch; // Set the layout to stretch
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (CommonValues.CurrentUserInfo.IsDark == true)
            {
                ApplyDarkTheme();
            }
            else
            {
                ApplyLightTheme();
            }

            try
            {
                databaseManager.OpenConnection();
                string readQuery1 = "SELECT * FROM InitialPreference";
                using (SqlCommand command1 = new SqlCommand(readQuery1, databaseManager.GetConnection()))
                {
                    using (SqlDataReader reader1 = command1.ExecuteReader())
                    {
                        if (reader1.Read())
                        {
                            CommonValues.CurrentUserInfo.IsDark = (bool)reader1["IsDark"];
                            CommonValues.CurrentUserInfo.IsArabic = (bool)reader1["IsArabic"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                databaseManager.CloseConnection();
            }
            if(CommonValues.CurrentUserInfo.IsDark == true)
            {
                ApplyDarkTheme();
            }
            else
            {
                ApplyLightTheme();
            }
            if(CommonValues.CurrentUserInfo.IsArabic == true)
            {
                ArabicLanguage();
            }
            else
            {
                EnglishLanguage();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string usernameText = Username.Text;
            string passwordText = Password.Text;

            try
            {
                databaseManager.OpenConnection();

                string readQuery = "SELECT * FROM UserInfo WHERE UserName = @Username";
                string readQuery1 = "SELECT * FROM UserPreferences WHERE UserName_FK = @Username";
                // Insert user data into the database

                using (SqlCommand command = new SqlCommand(readQuery, databaseManager.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Username", usernameText);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CommonValues.CurrentUserInfo.FName = reader["FName"].ToString();
                            CommonValues.CurrentUserInfo.LName = reader["LName"].ToString();
                            CommonValues.CurrentUserInfo.UserName = reader["UserName"].ToString();
                            CommonValues.CurrentUserInfo.BirthDate = (DateTime)reader["BirthDate"];
                            CommonValues.CurrentUserInfo.ActivityLevel = reader["ActivityLevel"].ToString();
                            CommonValues.CurrentUserInfo.Age = (int)reader["Age"];
                            CommonValues.CurrentUserInfo.BMI = (double)reader["BMI"];
                            CommonValues.CurrentUserInfo.Gender = reader["Gender"].ToString();
                            CommonValues.CurrentUserInfo.Height = (double)reader["Height"];
                            CommonValues.CurrentUserInfo.Weight = (double)reader["Weight"];
                            object profilePictureValue = reader["ProfilePicture"];

                            if (profilePictureValue != DBNull.Value)
                            {
                                try
                                {
                                    byte[] imageData = (byte[])reader["ProfilePicture"];
                                    Image image = ImageUtils.ByteArrayToImage(imageData);
                                    CommonValues.CurrentUserInfo.PP = image;
                                    CommonValues.CurrentUserInfo.IsPPNull = true;
                                }
                                catch (InvalidCastException ex)
                                {
                                    // Handle the case where the value in the database is not a valid image
                                    // You can log the exception or handle it according to your application's logic
                                    MessageBox.Show($"Unable to cast ProfilePicture to Image: {ex.Message}");
                                }
                            }
                            else
                            {
                                CommonValues.CurrentUserInfo.IsPPNull = false;
                            }


                            string passwordFromDB = reader["Password"].ToString();
                            var encryptionService = new EncryptionService("hTbHfq5rC5dAby6DJt8P3w==", "6mRwZNlJb/WLbCyk4n+bBg==");
                            string decryptedPass = encryptionService.Decrypt(passwordFromDB);

                            if (passwordText == decryptedPass)
                            {
                                reader.Close();
                                // Login successful for UserInfo
                                // Now execute the query for UserPreferences
                               
                                using (SqlCommand command1 = new SqlCommand(readQuery1, databaseManager.GetConnection()))
                                {
                                    command1.Parameters.AddWithValue("@Username", usernameText);
                                    using (SqlDataReader reader1 = command1.ExecuteReader())
                                    {
                                        if (reader1.Read())
                                        {
                                            CommonValues.CurrentUserInfo.IsDark = (bool)reader1["IsDark"];
                                            CommonValues.CurrentUserInfo.IsArabic = (bool)reader1["IsArabic"];
                                        }
                                    }
                                }

                                this.Hide();
                                Main_MenuEN mainMenu = new Main_MenuEN();
                                mainMenu.Show();
                            }
                            else
                            {
                                if (CommonValues.CurrentUserInfo.IsArabic)
                                {
                                    MessageBox.Show(".فشل تسجيل الدخول. الرجاء التحقق من كلمة المرور الخاصة بك");
                                }
                                else
                                {
                                    MessageBox.Show("Login failed. Please check your password.");
                                }
                            }
                        }
                        else
                        {
                            if (CommonValues.CurrentUserInfo.IsArabic)
                            {
                                MessageBox.Show(".فشل تسجيل الدخول. اسم المستخدم غير موجود");
                            }
                            else
                            {
                                MessageBox.Show("Login failed. User not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                databaseManager.CloseConnection();
            }
        }


        private void CreateAccbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAc1 createAc1EN = new CreateAc1();
            createAc1EN.Show();
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

        private void Themes_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Handle the theme change
            string theme = e.ClickedItem.Text;

            if (theme == "Dark Theme" || theme == "النمط الغامق")
            {
                // Apply the dark theme
                Themes.Image = Properties.Resources.Dark;
                CommonValues.CurrentUserInfo.IsDark = true;
                ApplyDarkTheme();
                try
                {
                    databaseManager.OpenConnection();
                    string updateQuery = "UPDATE InitialPreference SET IsDark = @IsDark";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, databaseManager.GetConnection()))
                    {
                        updateCommand.Parameters.AddWithValue("@IsDark", CommonValues.CurrentUserInfo.IsDark ? 1 : 0);

                        updateCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                finally
                {
                    databaseManager.CloseConnection();
                }
            }
            else if (theme == "Light Theme" || theme == "النمط الفاتح")
            {
                // Apply the light theme
                Themes.Image = Properties.Resources.Light;
                CommonValues.CurrentUserInfo.IsDark = false;
                ApplyLightTheme();
                try
                {
                    databaseManager.OpenConnection();
                    string updateQuery = "UPDATE InitialPreference SET IsDark = @IsDark";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, databaseManager.GetConnection()))
                    {
                        updateCommand.Parameters.AddWithValue("@IsDark", CommonValues.CurrentUserInfo.IsDark ? 1 : 0);

                        updateCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                finally
                {
                    databaseManager.CloseConnection();
                }
            }
        }

        private void SelectLanguage_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string Lang = e.ClickedItem.Text;

            if (Lang == "English")
            {
                // Apply the dark theme

                CommonValues.CurrentUserInfo.IsArabic = false;
                EnglishLanguage();
                try
                {
                    databaseManager.OpenConnection();
                    string updateQuery = "UPDATE InitialPreference SET IsArabic = @IsArabic";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, databaseManager.GetConnection()))
                    {
                        updateCommand.Parameters.AddWithValue("@IsArabic", CommonValues.CurrentUserInfo.IsArabic ? 1 : 0);

                        updateCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                finally
                {
                    databaseManager.CloseConnection();
                }
            }
            else if (Lang == "العربية")
            {
                // Apply the light theme

                CommonValues.CurrentUserInfo.IsArabic = true;
                ArabicLanguage();
                try
                {
                    databaseManager.OpenConnection();
                    string updateQuery = "UPDATE InitialPreference SET IsArabic = @IsArabic";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, databaseManager.GetConnection()))
                    {
                        updateCommand.Parameters.AddWithValue("@IsArabic", CommonValues.CurrentUserInfo.IsArabic ? 1 : 0);

                        updateCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                finally
                {
                    databaseManager.CloseConnection();
                }
            }
        }

        private void ApplyDarkTheme()
        {
            this.BackColor = Color.FromArgb(70, 70, 70);
            this.ForeColor = Color.White;
            Username.ForeColor = Color.Black;
            Username.BackColor = Color.FromArgb(224, 224, 224);
            Password.ForeColor = Color.Black;
            Password.BackColor = Color.FromArgb(224, 224, 224);
            LoginButton.ForeColor = Color.Black;
            LoginButton.BackColor = Color.FromArgb(224, 224, 224);
            CreateAccbtn.ForeColor = Color.Black;
            CreateAccbtn.BackColor = Color.FromArgb(224, 224, 224);
            toolStrip1.ForeColor = Color.White;
            toolStrip1.BackColor = Color.FromArgb(55, 55, 55);
            PasswordVisibility.BackColor = Color.FromArgb(224, 224, 224);
            Themes.Image = Properties.Resources.Dark;
            if (!CommonValues.CurrentUserInfo.IsArabic)
            {
                SelectLanguage.Image = Properties.Resources.wEN;
            }
            else
            {
                SelectLanguage.Image = Properties.Resources.wAR;
            }
        }

        private void ApplyLightTheme()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            Username.ForeColor = Color.Black;
            Username.BackColor = Color.White;
            Password.ForeColor = Color.Black;
            Password.BackColor = Color.White;
            LoginButton.ForeColor = Color.Black;
            LoginButton.BackColor = Color.White;
            CreateAccbtn.ForeColor = Color.Black;
            CreateAccbtn.BackColor = Color.White;
            toolStrip1.ForeColor = Color.Black;
            toolStrip1.BackColor = Color.Gainsboro;
            PasswordVisibility.BackColor = Color.White;
            Themes.Image = Properties.Resources.Light;
            if (!CommonValues.CurrentUserInfo.IsArabic)
            {
                SelectLanguage.Image = Properties.Resources.EN;
            }
            else
            {
                SelectLanguage.Image = Properties.Resources.AR;
            }
        }

        private void ArabicLanguage()
        {
            base.RightToLeft = RightToLeft.Yes;
            UserNameLable.Text = "إسم المستخدم:";
            UserNameLable.Location = new Point(431, 100);
            Username.Location = new Point(346, 128);
            PasswordLable.Text = "كلمة المرور:";
            PasswordLable.Location = new Point(171, 100);
            Password.Location = new Point(56, 128);
            PasswordVisibility.Location = new Point(55, 128);
            LoginButton.Text = "تسجيل الدخول";
            LoginButton.Location = new Point(240, 216);
            label1.Text = "اذا كنت لا تمتلك حساب...";
            label1.Location = new Point(175, 292);
            CreateAccbtn.Text = "قم بإنشاء حساب";
            CreateAccbtn.Location = new Point(230, 322);
            Themes.Text = "النمط";
            lightThemeToolStripMenuItem.Text = "النمط الفاتح";
            darkThemeToolStripMenuItem.Text = "النمط الغامق";
            SelectLanguage.Text = "اللغة";
            if (!CommonValues.CurrentUserInfo.IsDark)
            {
                SelectLanguage.Image = Properties.Resources.AR;
            }
            else
            {
                SelectLanguage.Image = Properties.Resources.wAR;
            }
        }

        private void EnglishLanguage()
        {
            base.RightToLeft = RightToLeft.No;
            UserNameLable.Text = "Username:";
            UserNameLable.Location = new Point(52, 99);
            Username.Location = new Point(57, 127);
            PasswordLable.Text = "Password:";
            PasswordLable.Location = new Point(346, 99);
            Password.Location = new Point(351, 127);
            PasswordVisibility.Location = new Point(523, 127);
            LoginButton.Text = "Login";
            LoginButton.Location = new Point(265, 215);
            LoginButton.Size = new Size(84, 35);
            label1.Text = "If you do not have an account";
            label1.Location = new Point(197, 291);
            CreateAccbtn.Text = "Create an account";
            CreateAccbtn.Location = new Point(229, 321);
            Themes.Text = "Themes";
            lightThemeToolStripMenuItem.Text = "Light Theme";
            darkThemeToolStripMenuItem.Text = "Dark Theme";
            SelectLanguage.Text = "Language";
            if (!CommonValues.CurrentUserInfo.IsDark)
            {
                SelectLanguage.Image = Properties.Resources.EN;
            }
            else
            {
                SelectLanguage.Image = Properties.Resources.wEN;
            }
        }
    }
}