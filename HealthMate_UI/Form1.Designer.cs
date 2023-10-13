namespace HealthMate_UI
{
    partial class LoginEN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginEN));
            this.LoginButton = new System.Windows.Forms.Button();
            this.UserNameLable = new System.Windows.Forms.Label();
            this.PasswordLable = new System.Windows.Forms.Label();
            this.Subtitle = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateAccbtn = new System.Windows.Forms.Button();
            this.LoginCheck = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.SelectLanguage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Location = new System.Drawing.Point(265, 199);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(84, 31);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UserNameLable
            // 
            this.UserNameLable.AutoSize = true;
            this.UserNameLable.Location = new System.Drawing.Point(52, 83);
            this.UserNameLable.Name = "UserNameLable";
            this.UserNameLable.Size = new System.Drawing.Size(87, 25);
            this.UserNameLable.TabIndex = 1;
            this.UserNameLable.Text = "Username:";
            // 
            // PasswordLable
            // 
            this.PasswordLable.AutoSize = true;
            this.PasswordLable.Location = new System.Drawing.Point(346, 83);
            this.PasswordLable.Name = "PasswordLable";
            this.PasswordLable.Size = new System.Drawing.Size(84, 25);
            this.PasswordLable.TabIndex = 2;
            this.PasswordLable.Text = "Password:";
            // 
            // Subtitle
            // 
            this.Subtitle.AutoSize = true;
            this.Subtitle.Font = new System.Drawing.Font("El Messiri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtitle.Location = new System.Drawing.Point(238, 9);
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Size = new System.Drawing.Size(138, 37);
            this.Subtitle.TabIndex = 3;
            this.Subtitle.Text = "HealthMate";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(57, 111);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(204, 33);
            this.Username.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "If you do not have an account";
            // 
            // CreateAccbtn
            // 
            this.CreateAccbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateAccbtn.Location = new System.Drawing.Point(229, 305);
            this.CreateAccbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateAccbtn.Name = "CreateAccbtn";
            this.CreateAccbtn.Size = new System.Drawing.Size(156, 31);
            this.CreateAccbtn.TabIndex = 9;
            this.CreateAccbtn.Text = "Create an account";
            this.CreateAccbtn.UseVisualStyleBackColor = true;
            this.CreateAccbtn.Click += new System.EventHandler(this.CreateAccbtn_Click);
            // 
            // LoginCheck
            // 
            this.LoginCheck.AutoSize = true;
            this.LoginCheck.Font = new System.Drawing.Font("El Messiri", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginCheck.ForeColor = System.Drawing.Color.Red;
            this.LoginCheck.Location = new System.Drawing.Point(53, 156);
            this.LoginCheck.Name = "LoginCheck";
            this.LoginCheck.Size = new System.Drawing.Size(0, 19);
            this.LoginCheck.TabIndex = 10;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(351, 111);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(204, 33);
            this.Password.TabIndex = 11;
            // 
            // SelectLanguage
            // 
            this.SelectLanguage.FormattingEnabled = true;
            this.SelectLanguage.Items.AddRange(new object[] {
            "English",
            "عربي"});
            this.SelectLanguage.Location = new System.Drawing.Point(57, 303);
            this.SelectLanguage.Name = "SelectLanguage";
            this.SelectLanguage.Size = new System.Drawing.Size(121, 33);
            this.SelectLanguage.TabIndex = 12;
            this.SelectLanguage.SelectedIndexChanged += new System.EventHandler(this.SelectLanguage_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select language:";
            // 
            // LoginEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(595, 390);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectLanguage);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.LoginCheck);
            this.Controls.Add(this.CreateAccbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Subtitle);
            this.Controls.Add(this.PasswordLable);
            this.Controls.Add(this.UserNameLable);
            this.Controls.Add(this.LoginButton);
            this.Font = new System.Drawing.Font("El Messiri SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoginEN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HealthMate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label UserNameLable;
        private System.Windows.Forms.Label PasswordLable;
        private System.Windows.Forms.Label Subtitle;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateAccbtn;
        private System.Windows.Forms.Label LoginCheck;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.ComboBox SelectLanguage;
        private System.Windows.Forms.Label label2;
    }
}

