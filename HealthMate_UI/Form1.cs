using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace HealthMate_UI
{
    public partial class LoginEN : Form
    {
        public LoginEN()
        {
            InitializeComponent();
            Password.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("السلام عليكم");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string usernameText = Username.Text; // Get the text from the TextBox
            Username.Text = string.Empty; // Clear the TextBox
            string passwordText = Password.Text; // Get the text from the TextBox
            Password.Text = string.Empty; // Clear the TextBox

            //connect to the DataBase
            System.Data.SqlClient.SqlConnection sqlConnection;
            string connectionString = @"Data Source=DESKTOP-QUB8L8T\SQLEXPRESS;Initial Catalog=UserInfoDB;Integrated Security=True";

            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string readQuery = "SELECT * FROM UserInfo WHERE UserName = @Username";

                using (SqlCommand command = new SqlCommand(readQuery, sqlConnection))
                {
                    command.Parameters.AddWithValue("@Username", usernameText);

                    SqlDataReader reader = command.ExecuteReader();
                    //Add login logic and read data from DataBase
                    if (reader.Read())
                    {
                        string userNameFromDB = reader["UserName"].ToString();
                        string passwordFromDB = reader["Password"].ToString();

                        string encryptionKey0 = "hTbHfq5rC5dAby6DJt8P3w==";
                        string initializationVector0 = "6mRwZNlJb/WLbCyk4n+bBg==";

                        var encryptionService0 = new EncryptionService(encryptionKey0, initializationVector0);

                        string decryptedPass = encryptionService0.Decrypt(passwordFromDB);

                        if (passwordText == decryptedPass)
                        {
                            string WlcMessage = reader["FName"].ToString();
                            MessageBox.Show($"Login successful!\nWelcome {WlcMessage}");

                            this.Hide();
                            Main_menuEN mainMenu = new Main_menuEN();
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
            catch (Exception ex)
            {
                LoginCheck.Text = "An error occurred: " + ex.Message;
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateAccbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAc1EN createAc1EN = new CreateAc1EN();
            createAc1EN.Show();
        }

        private void SelectLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string language = SelectLanguage.Text;
            //if (language == "عربي")
            //{
            //    this.Hide();
            //    CreateAc1EN createAc1EN = new CreateAc1EN();
            //    createAc1EN.Show();
            //}
        }

        public class EncryptionService
        {
            private readonly Aes aes;

            public EncryptionService(string encryptionKey, string initializationVector)
            {
                aes = Aes.Create();
                aes.Key = Convert.FromBase64String(encryptionKey);
                aes.IV = Convert.FromBase64String(initializationVector);
            }

            public string Encrypt(string plainText)
            {
                using (var memoryStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        var bytesToEncrypt = Encoding.UTF8.GetBytes(plainText);

                        // Encrypt the data and write it to the crypto stream
                        cryptoStream.Write(bytesToEncrypt, 0, bytesToEncrypt.Length);
                        cryptoStream.FlushFinalBlock();
                    }
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }

            public string Decrypt(string encryptedText)
            {
                using (var memoryStream = new MemoryStream(Convert.FromBase64String(encryptedText)))
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        var decryptedBytes = new List<byte>();
                        int data;
                        while ((data = cryptoStream.ReadByte()) != -1)
                        {
                            decryptedBytes.Add((byte)data);
                        }

                        return Encoding.UTF8.GetString(decryptedBytes.ToArray());
                    }
                }
            }
        }
    }
}
