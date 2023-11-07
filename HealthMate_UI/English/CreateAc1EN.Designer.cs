namespace HealthMate_UI
{
    partial class CreateAc1EN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAc1EN));
            this.Subtitle = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.LnameLable = new System.Windows.Forms.Label();
            this.FnameLable = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.BirthdateLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.Birthdate = new System.Windows.Forms.DateTimePicker();
            this.Nextbtn = new System.Windows.Forms.Button();
            this.ActivityLevel = new System.Windows.Forms.ComboBox();
            this.ActivityLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Subtitle
            // 
            this.Subtitle.AutoSize = true;
            this.Subtitle.Font = new System.Drawing.Font("El Messiri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtitle.Location = new System.Drawing.Point(238, 9);
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Size = new System.Drawing.Size(138, 37);
            this.Subtitle.TabIndex = 15;
            this.Subtitle.Text = "HealthMate";
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(355, 87);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(204, 33);
            this.Lname.TabIndex = 22;
            this.Lname.TextChanged += new System.EventHandler(this.Lname_TextChanged);
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(61, 87);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(204, 33);
            this.Fname.TabIndex = 21;
            this.Fname.TextChanged += new System.EventHandler(this.Fname_TextChanged);
            // 
            // LnameLable
            // 
            this.LnameLable.AutoSize = true;
            this.LnameLable.Location = new System.Drawing.Point(350, 59);
            this.LnameLable.Name = "LnameLable";
            this.LnameLable.Size = new System.Drawing.Size(90, 25);
            this.LnameLable.TabIndex = 20;
            this.LnameLable.Text = "Last Name:";
            // 
            // FnameLable
            // 
            this.FnameLable.AutoSize = true;
            this.FnameLable.Location = new System.Drawing.Point(56, 59);
            this.FnameLable.Name = "FnameLable";
            this.FnameLable.Size = new System.Drawing.Size(93, 25);
            this.FnameLable.TabIndex = 19;
            this.FnameLable.Text = "First Name:";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(355, 168);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(204, 33);
            this.Username.TabIndex = 26;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(61, 168);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(204, 33);
            this.Email.TabIndex = 25;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(350, 140);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(87, 25);
            this.UsernameLabel.TabIndex = 24;
            this.UsernameLabel.Text = "Username:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(56, 140);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(55, 25);
            this.EmailLabel.TabIndex = 23;
            this.EmailLabel.Text = "Email:";
            // 
            // BirthdateLabel
            // 
            this.BirthdateLabel.AutoSize = true;
            this.BirthdateLabel.Location = new System.Drawing.Point(268, 223);
            this.BirthdateLabel.Name = "BirthdateLabel";
            this.BirthdateLabel.Size = new System.Drawing.Size(83, 25);
            this.BirthdateLabel.TabIndex = 28;
            this.BirthdateLabel.Text = "Birthdate:";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(56, 223);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(69, 25);
            this.GenderLabel.TabIndex = 27;
            this.GenderLabel.Text = "Gender:";
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(61, 251);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(106, 33);
            this.Gender.TabIndex = 29;
            this.Gender.SelectedIndexChanged += new System.EventHandler(this.Gender_TextChanged);
            // 
            // Birthdate
            // 
            this.Birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Birthdate.Location = new System.Drawing.Point(245, 251);
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Birthdate.Size = new System.Drawing.Size(122, 33);
            this.Birthdate.TabIndex = 30;
            this.Birthdate.ValueChanged += new System.EventHandler(this.Birthdate_ValueChanged);
            // 
            // Nextbtn
            // 
            this.Nextbtn.Location = new System.Drawing.Point(273, 312);
            this.Nextbtn.Name = "Nextbtn";
            this.Nextbtn.Size = new System.Drawing.Size(67, 30);
            this.Nextbtn.TabIndex = 31;
            this.Nextbtn.Text = "Next";
            this.Nextbtn.UseVisualStyleBackColor = true;
            this.Nextbtn.Click += new System.EventHandler(this.Nextbtn_Click);
            // 
            // ActivityLevel
            // 
            this.ActivityLevel.FormattingEnabled = true;
            this.ActivityLevel.Items.AddRange(new object[] {
            "Lazy",
            "Lightly",
            "Medium",
            "Active"});
            this.ActivityLevel.Location = new System.Drawing.Point(438, 254);
            this.ActivityLevel.Name = "ActivityLevel";
            this.ActivityLevel.Size = new System.Drawing.Size(106, 33);
            this.ActivityLevel.TabIndex = 39;
            this.ActivityLevel.SelectedIndexChanged += new System.EventHandler(this.ActivityLevel_TextChanged);
            // 
            // ActivityLabel
            // 
            this.ActivityLabel.AutoSize = true;
            this.ActivityLabel.Location = new System.Drawing.Point(433, 223);
            this.ActivityLabel.Name = "ActivityLabel";
            this.ActivityLabel.Size = new System.Drawing.Size(111, 25);
            this.ActivityLabel.TabIndex = 38;
            this.ActivityLabel.Text = "Activity Level:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(236, 348);
            this.progressBar1.Maximum = 11;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(143, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 40;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 9);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(54, 30);
            this.BackBtn.TabIndex = 41;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // CreateAc1EN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(595, 390);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ActivityLevel);
            this.Controls.Add(this.ActivityLabel);
            this.Controls.Add(this.Nextbtn);
            this.Controls.Add(this.Birthdate);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.BirthdateLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.LnameLable);
            this.Controls.Add(this.FnameLable);
            this.Controls.Add(this.Subtitle);
            this.Font = new System.Drawing.Font("El Messiri SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "CreateAc1EN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HealthMate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateAc1EN_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Subtitle;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.Label LnameLable;
        private System.Windows.Forms.Label FnameLable;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label BirthdateLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.DateTimePicker Birthdate;
        private System.Windows.Forms.Button Nextbtn;
        private System.Windows.Forms.ComboBox ActivityLevel;
        private System.Windows.Forms.Label ActivityLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button BackBtn;
    }
}