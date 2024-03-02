using HealthMate_UI.Constants;
using HealthMate_UI.Screens;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HealthMate_UI
{
    public partial class Main_MenuEN : Form
    {
        private DatabaseManager databaseManager;
        private PictureBox circularPictureBox;

        public Main_MenuEN()
        {
            InitializeComponent();
            InitializeCircularPictureBox();
            databaseManager = new DatabaseManager();
            line.Enabled = false;
            button1.Enabled = false;
        }

        private void InitializeCircularPictureBox()
        {
            // Create PictureBox
            circularPictureBox = new PictureBox();
            circularPictureBox.Location = new Point(490, 40);
            circularPictureBox.Size = new Size(60, 60);
            circularPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // Load Image
            if (CommonValues.CurrentUserInfo.IsPPNull)
            {
                circularPictureBox.Image = CommonValues.CurrentUserInfo.PP;
            }
            else
            {
                if (CommonValues.CurrentUserInfo.Gender == "Male")
                {
                    circularPictureBox.Image = Properties.Resources.malePP;
                }
                else
                {
                    circularPictureBox.Image = Properties.Resources.femalePP;
                }
            }
            // Make PictureBox Circular
            MakePictureBoxCircular(circularPictureBox);

            // Add PictureBox to Form
            Controls.Add(circularPictureBox);
            //circularPictureBox.Image = CommonValues.CurrentUserInfo.ProfilePicture;
        }

        private void MakePictureBoxCircular(PictureBox pictureBox)
        {
            // Create a GraphicsPath object
            GraphicsPath path = new GraphicsPath();

            // Add an ellipse to the GraphicsPath
            path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);

            // Set the Region property of the PictureBox to the newly created GraphicsPath
            pictureBox.Region = new Region(path);
        }

        private void Main_menuEN_Load(object sender, EventArgs e)
        {
            if (CommonValues.CurrentUserInfo.BirthDate == DateTime.Today)
            {
                if (CommonValues.CurrentUserInfo.IsArabic == true)
                {
                    HappyBirthday.Text = $"يوم ميلاد سعيد {CommonValues.CurrentUserInfo.FName} <3";
                }
                else
                {
                    HappyBirthday.Text = $"Happy Birthday {CommonValues.CurrentUserInfo.FName} <3";
                }
            }

            if (CommonValues.CurrentUserInfo.IsDark == true)
            {
                ApplyDarkTheme();
            }
            else
            {
                ApplyLightTheme();
            }
            if (CommonValues.CurrentUserInfo.IsArabic == true)
            {
                ArabicLanguage();
                string welcomeMessage = WelcomeMessageGeneratorAR.GenerateWelcomeMessage(CommonValues.CurrentUserInfo.FName);
                WelcomeMsg.Text = welcomeMessage;
            }
            else
            {
                EnglishLanguage();
                string welcomeMessage = WelcomeMessageGeneratorEN.GenerateWelcomeMessage(CommonValues.CurrentUserInfo.FName);
                WelcomeMsg.Text = welcomeMessage;
            }
        }

        private void Main_menuEN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AgeCalcBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgeCalc ageCalcEN = new AgeCalc();
            ageCalcEN.Show();
        }

        private void HealthMonitorBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HealthMonitor healthMonitorEN = new HealthMonitor();
            healthMonitorEN.Show();
        }

        private void UpdateInfoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateInfo updateInfoEN = new UpdateInfo();
            updateInfoEN.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            CommonValues.CurrentUserInfo = null;

            this.Hide();
            Login loginEN = new Login();
            loginEN.Show();
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
                    string updateQuery = "UPDATE UserPreferences SET IsDark = @IsDark WHERE UserName_FK = @Username";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, databaseManager.GetConnection()))
                    {
                        updateCommand.Parameters.AddWithValue("@Username", CommonValues.CurrentUserInfo.UserName);
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
                CommonValues.CurrentUserInfo.IsDark = false;
                ApplyLightTheme();
                try
                {
                    databaseManager.OpenConnection();
                    string updateQuery = "UPDATE UserPreferences SET IsDark = @IsDark WHERE UserName_FK = @Username";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, databaseManager.GetConnection()))
                    {
                        updateCommand.Parameters.AddWithValue("@Username", CommonValues.CurrentUserInfo.UserName);
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
                    string updateQuery = "UPDATE UserPreferences SET IsArabic = @IsArabic WHERE UserName_FK = @Username";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, databaseManager.GetConnection()))
                    {
                        updateCommand.Parameters.AddWithValue("@Username", CommonValues.CurrentUserInfo.UserName);
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
                    string updateQuery = "UPDATE UserPreferences SET IsArabic = @IsArabic WHERE UserName_FK = @Username";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, databaseManager.GetConnection()))
                    {
                        updateCommand.Parameters.AddWithValue("@Username", CommonValues.CurrentUserInfo.UserName);
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
            // Apply the dark theme
            this.BackColor = Color.FromArgb(70, 70, 70);
            this.ForeColor = Color.White;
            AgeCalcBtn.ForeColor = Color.Black;
            AgeCalcBtn.BackColor = Color.FromArgb(224, 224, 224);
            HealthMonitorBtn.ForeColor = Color.Black;
            HealthMonitorBtn.BackColor = Color.FromArgb(224, 224, 224);
            UpdateInfoBtn.ForeColor = Color.Black;
            UpdateInfoBtn.BackColor = Color.FromArgb(224, 224, 224);
            CaloriesTrackerBtn.ForeColor = Color.Black;
            CaloriesTrackerBtn.BackColor = Color.FromArgb(224, 224, 224);
            toolStrip1.ForeColor = Color.White;
            toolStrip1.BackColor = Color.FromArgb(55, 55, 55);
            Themes.ForeColor = Color.White;
            Logout.ForeColor = Color.White;
            Logout.Image = Properties.Resources.WLogout;
            SelectLanguage.ForeColor = Color.White;
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
            // Apply the light theme
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            AgeCalcBtn.ForeColor = Color.Black;
            AgeCalcBtn.BackColor = Color.White;
            HealthMonitorBtn.ForeColor = Color.Black;
            HealthMonitorBtn.BackColor = Color.White;
            UpdateInfoBtn.ForeColor = Color.Black;
            UpdateInfoBtn.BackColor = Color.White;
            CaloriesTrackerBtn.ForeColor = Color.Black;
            CaloriesTrackerBtn.BackColor = Color.White;
            toolStrip1.ForeColor = Color.White;
            toolStrip1.BackColor = Color.Gainsboro;
            Themes.ForeColor = Color.Black;
            Logout.ForeColor = Color.Black;
            Logout.Image = Properties.Resources.Logout;
            SelectLanguage.ForeColor = Color.Black;
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
            AgeCalcBtn.Text = "حساب العمر";
            HealthMonitorBtn.Text = "مراقب الصحة";
            UpdateInfoBtn.Text = "تحديث بياناتك";
            CaloriesTrackerBtn.Text = "تتبع السعرات الحرارية";

            Themes.Text = "النمط";
            lightThemeToolStripMenuItem.Text = "النمط الفاتح";
            darkThemeToolStripMenuItem.Text = "النمط الغامق";
            SelectLanguage.Text = "اللغة";
            Logout.Text = "تسجيل الخروج";
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
            AgeCalcBtn.Text = "Age Calculator";
            HealthMonitorBtn.Text = "Health Monitor";
            UpdateInfoBtn.Text = "Update Your Data";
            CaloriesTrackerBtn.Text = "Calories Tracker";
            Themes.Text = "Themes";
            lightThemeToolStripMenuItem.Text = "Light Theme";
            darkThemeToolStripMenuItem.Text = "Dark Theme";
            SelectLanguage.Text = "Language";
            Logout.Text = "Logout";
            if (!CommonValues.CurrentUserInfo.IsDark)
            {
                SelectLanguage.Image = Properties.Resources.EN;
            }
            else
            {
                SelectLanguage.Image = Properties.Resources.wEN;
            }
        }

        private void CaloriesTrackerBtn_Click(object sender, EventArgs e)
        {
            if (CommonValues.CurrentUserInfo.IsArabic)
            {
                MessageBox.Show(".الميزة ما زالت تحت التطوير\nكن صبوراً", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            else
            {
                MessageBox.Show("The feature is still under development.\nPlease be patient.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            this.Hide();
            Calories_Tracker calories_Tracker = new Calories_Tracker();
            calories_Tracker.Show();
        }
    }
}