namespace HealthMate_UI
{
    partial class CreateAc2EN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAc2EN));
            this.RePassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.RePassLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.TextBox();
            this.Height_cm = new System.Windows.Forms.TextBox();
            this.WeightLable = new System.Windows.Forms.Label();
            this.HeightLable = new System.Windows.Forms.Label();
            this.Subtitle = new System.Windows.Forms.Label();
            this.CreateAccbtn = new System.Windows.Forms.Button();
            this.PasswordMatchLabel = new System.Windows.Forms.Label();
            this.PasswordStrengthLabel = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.PasswordVisibilityRE = new System.Windows.Forms.Button();
            this.PasswordVisibility = new System.Windows.Forms.Button();
            this.InchesToCm = new System.Windows.Forms.Button();
            this.KGToLB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RePassword
            // 
            this.RePassword.Location = new System.Drawing.Point(355, 157);
            this.RePassword.Name = "RePassword";
            this.RePassword.Size = new System.Drawing.Size(204, 33);
            this.RePassword.TabIndex = 34;
            this.RePassword.TextChanged += new System.EventHandler(this.RePassword_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(61, 157);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(204, 33);
            this.Password.TabIndex = 33;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // RePassLabel
            // 
            this.RePassLabel.AutoSize = true;
            this.RePassLabel.Location = new System.Drawing.Point(350, 129);
            this.RePassLabel.Name = "RePassLabel";
            this.RePassLabel.Size = new System.Drawing.Size(152, 25);
            this.RePassLabel.TabIndex = 32;
            this.RePassLabel.Text = "Re-Enter Password:";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(56, 129);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(84, 25);
            this.PassLabel.TabIndex = 31;
            this.PassLabel.Text = "Password:";
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(355, 76);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(204, 33);
            this.Weight.TabIndex = 30;
            this.Weight.TextChanged += new System.EventHandler(this.Weight_TextChanged);
            // 
            // Height_cm
            // 
            this.Height_cm.Location = new System.Drawing.Point(61, 76);
            this.Height_cm.Name = "Height_cm";
            this.Height_cm.Size = new System.Drawing.Size(204, 33);
            this.Height_cm.TabIndex = 29;
            this.Height_cm.TextChanged += new System.EventHandler(this.Height_cm_TextChanged);
            // 
            // WeightLable
            // 
            this.WeightLable.AutoSize = true;
            this.WeightLable.Location = new System.Drawing.Point(350, 48);
            this.WeightLable.Name = "WeightLable";
            this.WeightLable.Size = new System.Drawing.Size(65, 25);
            this.WeightLable.TabIndex = 28;
            this.WeightLable.Text = "Weight:";
            // 
            // HeightLable
            // 
            this.HeightLable.AutoSize = true;
            this.HeightLable.Location = new System.Drawing.Point(56, 48);
            this.HeightLable.Name = "HeightLable";
            this.HeightLable.Size = new System.Drawing.Size(62, 25);
            this.HeightLable.TabIndex = 27;
            this.HeightLable.Text = "Height:";
            // 
            // Subtitle
            // 
            this.Subtitle.AutoSize = true;
            this.Subtitle.Font = new System.Drawing.Font("El Messiri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtitle.Location = new System.Drawing.Point(238, 9);
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Size = new System.Drawing.Size(138, 37);
            this.Subtitle.TabIndex = 35;
            this.Subtitle.Text = "HealthMate";
            // 
            // CreateAccbtn
            // 
            this.CreateAccbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateAccbtn.Location = new System.Drawing.Point(229, 314);
            this.CreateAccbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateAccbtn.Name = "CreateAccbtn";
            this.CreateAccbtn.Size = new System.Drawing.Size(156, 31);
            this.CreateAccbtn.TabIndex = 36;
            this.CreateAccbtn.Text = "Create an account";
            this.CreateAccbtn.UseVisualStyleBackColor = true;
            this.CreateAccbtn.Click += new System.EventHandler(this.CreateAccbtn_Click);
            // 
            // PasswordMatchLabel
            // 
            this.PasswordMatchLabel.AutoSize = true;
            this.PasswordMatchLabel.Font = new System.Drawing.Font("El Messiri", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordMatchLabel.ForeColor = System.Drawing.Color.Red;
            this.PasswordMatchLabel.Location = new System.Drawing.Point(352, 193);
            this.PasswordMatchLabel.Name = "PasswordMatchLabel";
            this.PasswordMatchLabel.Size = new System.Drawing.Size(0, 17);
            this.PasswordMatchLabel.TabIndex = 37;
            // 
            // PasswordStrengthLabel
            // 
            this.PasswordStrengthLabel.AutoSize = true;
            this.PasswordStrengthLabel.Font = new System.Drawing.Font("El Messiri", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordStrengthLabel.ForeColor = System.Drawing.Color.Black;
            this.PasswordStrengthLabel.Location = new System.Drawing.Point(58, 193);
            this.PasswordStrengthLabel.Name = "PasswordStrengthLabel";
            this.PasswordStrengthLabel.Size = new System.Drawing.Size(0, 17);
            this.PasswordStrengthLabel.TabIndex = 38;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 9);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(55, 30);
            this.BackBtn.TabIndex = 42;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(236, 352);
            this.progressBar1.Maximum = 11;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(143, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 43;
            // 
            // PasswordVisibilityRE
            // 
            this.PasswordVisibilityRE.Location = new System.Drawing.Point(526, 157);
            this.PasswordVisibilityRE.Name = "PasswordVisibilityRE";
            this.PasswordVisibilityRE.Size = new System.Drawing.Size(33, 33);
            this.PasswordVisibilityRE.TabIndex = 44;
            this.PasswordVisibilityRE.UseVisualStyleBackColor = true;
            this.PasswordVisibilityRE.Click += new System.EventHandler(this.PasswordVisibilityRE_Click);
            // 
            // PasswordVisibility
            // 
            this.PasswordVisibility.Location = new System.Drawing.Point(232, 157);
            this.PasswordVisibility.Name = "PasswordVisibility";
            this.PasswordVisibility.Size = new System.Drawing.Size(33, 33);
            this.PasswordVisibility.TabIndex = 45;
            this.PasswordVisibility.UseVisualStyleBackColor = true;
            this.PasswordVisibility.Click += new System.EventHandler(this.PasswordVisibility_Click);
            // 
            // InchesToCm
            // 
            this.InchesToCm.Location = new System.Drawing.Point(232, 76);
            this.InchesToCm.Name = "InchesToCm";
            this.InchesToCm.Size = new System.Drawing.Size(33, 33);
            this.InchesToCm.TabIndex = 46;
            this.InchesToCm.UseVisualStyleBackColor = true;
            this.InchesToCm.Click += new System.EventHandler(this.InchesToCm_Click);
            // 
            // KGToLB
            // 
            this.KGToLB.Location = new System.Drawing.Point(526, 76);
            this.KGToLB.Name = "KGToLB";
            this.KGToLB.Size = new System.Drawing.Size(33, 33);
            this.KGToLB.TabIndex = 47;
            this.KGToLB.UseVisualStyleBackColor = true;
            this.KGToLB.Click += new System.EventHandler(this.KGToLB_Click);
            // 
            // CreateAc2EN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(595, 390);
            this.Controls.Add(this.KGToLB);
            this.Controls.Add(this.InchesToCm);
            this.Controls.Add(this.PasswordVisibility);
            this.Controls.Add(this.PasswordVisibilityRE);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.PasswordStrengthLabel);
            this.Controls.Add(this.PasswordMatchLabel);
            this.Controls.Add(this.CreateAccbtn);
            this.Controls.Add(this.Subtitle);
            this.Controls.Add(this.RePassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.RePassLabel);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.Height_cm);
            this.Controls.Add(this.WeightLable);
            this.Controls.Add(this.HeightLable);
            this.Font = new System.Drawing.Font("El Messiri SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "CreateAc2EN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HealthMate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateAc2EN_FormClosing);
            this.Load += new System.EventHandler(this.CreateAc2EN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RePassword;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label RePassLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.TextBox Height_cm;
        private System.Windows.Forms.Label WeightLable;
        private System.Windows.Forms.Label HeightLable;
        private System.Windows.Forms.Label Subtitle;
        private System.Windows.Forms.Button CreateAccbtn;
        private System.Windows.Forms.Label PasswordMatchLabel;
        private System.Windows.Forms.Label PasswordStrengthLabel;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button PasswordVisibilityRE;
        private System.Windows.Forms.Button PasswordVisibility;
        private System.Windows.Forms.Button InchesToCm;
        private System.Windows.Forms.Button KGToLB;
    }
}