namespace HealthMate_UI
{
    partial class Main_MenuEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_MenuEN));
            this.Subtitle = new System.Windows.Forms.Label();
            this.AgeCalcBtn = new System.Windows.Forms.Button();
            this.HealthMonitorBtn = new System.Windows.Forms.Button();
            this.UpdateInfoBtn = new System.Windows.Forms.Button();
            this.DateDifferenceBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.WelcomeMsg = new System.Windows.Forms.Label();
            this.HappyBirthday = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Subtitle
            // 
            this.Subtitle.AutoSize = true;
            this.Subtitle.Font = new System.Drawing.Font("El Messiri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtitle.Location = new System.Drawing.Point(238, 9);
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Size = new System.Drawing.Size(138, 37);
            this.Subtitle.TabIndex = 36;
            this.Subtitle.Text = "HealthMate";
            // 
            // AgeCalcBtn
            // 
            this.AgeCalcBtn.Location = new System.Drawing.Point(42, 114);
            this.AgeCalcBtn.Name = "AgeCalcBtn";
            this.AgeCalcBtn.Size = new System.Drawing.Size(192, 75);
            this.AgeCalcBtn.TabIndex = 37;
            this.AgeCalcBtn.Text = "Age Calculator";
            this.AgeCalcBtn.UseVisualStyleBackColor = true;
            this.AgeCalcBtn.Click += new System.EventHandler(this.AgeCalcBtn_Click);
            // 
            // HealthMonitorBtn
            // 
            this.HealthMonitorBtn.Location = new System.Drawing.Point(42, 222);
            this.HealthMonitorBtn.Name = "HealthMonitorBtn";
            this.HealthMonitorBtn.Size = new System.Drawing.Size(192, 75);
            this.HealthMonitorBtn.TabIndex = 38;
            this.HealthMonitorBtn.Text = "Health Monitor";
            this.HealthMonitorBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateInfoBtn
            // 
            this.UpdateInfoBtn.Location = new System.Drawing.Point(369, 222);
            this.UpdateInfoBtn.Name = "UpdateInfoBtn";
            this.UpdateInfoBtn.Size = new System.Drawing.Size(192, 75);
            this.UpdateInfoBtn.TabIndex = 39;
            this.UpdateInfoBtn.Text = "Update Your Data";
            this.UpdateInfoBtn.UseVisualStyleBackColor = true;
            // 
            // DateDifferenceBtn
            // 
            this.DateDifferenceBtn.Location = new System.Drawing.Point(369, 114);
            this.DateDifferenceBtn.Name = "DateDifferenceBtn";
            this.DateDifferenceBtn.Size = new System.Drawing.Size(192, 75);
            this.DateDifferenceBtn.TabIndex = 40;
            this.DateDifferenceBtn.Text = "Date Difference";
            this.DateDifferenceBtn.UseVisualStyleBackColor = true;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(12, 12);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(71, 35);
            this.LogOutBtn.TabIndex = 41;
            this.LogOutBtn.Text = "Logout";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // WelcomeMsg
            // 
            this.WelcomeMsg.AutoSize = true;
            this.WelcomeMsg.Font = new System.Drawing.Font("El Messiri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeMsg.Location = new System.Drawing.Point(37, 65);
            this.WelcomeMsg.Name = "WelcomeMsg";
            this.WelcomeMsg.Size = new System.Drawing.Size(0, 29);
            this.WelcomeMsg.TabIndex = 42;
            // 
            // HappyBirthday
            // 
            this.HappyBirthday.AutoSize = true;
            this.HappyBirthday.Location = new System.Drawing.Point(364, 65);
            this.HappyBirthday.Name = "HappyBirthday";
            this.HappyBirthday.Size = new System.Drawing.Size(0, 25);
            this.HappyBirthday.TabIndex = 43;
            // 
            // Main_MenuEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(595, 390);
            this.Controls.Add(this.HappyBirthday);
            this.Controls.Add(this.WelcomeMsg);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.DateDifferenceBtn);
            this.Controls.Add(this.UpdateInfoBtn);
            this.Controls.Add(this.HealthMonitorBtn);
            this.Controls.Add(this.AgeCalcBtn);
            this.Controls.Add(this.Subtitle);
            this.Font = new System.Drawing.Font("El Messiri SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "Main_MenuEN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HealthMate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_menuEN_FormClosing);
            this.Load += new System.EventHandler(this.Main_menuEN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Subtitle;
        private System.Windows.Forms.Button AgeCalcBtn;
        private System.Windows.Forms.Button HealthMonitorBtn;
        private System.Windows.Forms.Button UpdateInfoBtn;
        private System.Windows.Forms.Button DateDifferenceBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Label WelcomeMsg;
        private System.Windows.Forms.Label HappyBirthday;
    }
}