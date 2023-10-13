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
            this.SuspendLayout();
            // 
            // RePassword
            // 
            this.RePassword.Location = new System.Drawing.Point(355, 223);
            this.RePassword.Name = "RePassword";
            this.RePassword.Size = new System.Drawing.Size(204, 33);
            this.RePassword.TabIndex = 34;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(61, 223);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(204, 33);
            this.Password.TabIndex = 33;
            // 
            // RePassLabel
            // 
            this.RePassLabel.AutoSize = true;
            this.RePassLabel.Location = new System.Drawing.Point(350, 195);
            this.RePassLabel.Name = "RePassLabel";
            this.RePassLabel.Size = new System.Drawing.Size(152, 25);
            this.RePassLabel.TabIndex = 32;
            this.RePassLabel.Text = "Re-Enter Password:";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(56, 195);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(84, 25);
            this.PassLabel.TabIndex = 31;
            this.PassLabel.Text = "Password:";
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(355, 142);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(204, 33);
            this.Weight.TabIndex = 30;
            // 
            // Height_cm
            // 
            this.Height_cm.Location = new System.Drawing.Point(61, 142);
            this.Height_cm.Name = "Height_cm";
            this.Height_cm.Size = new System.Drawing.Size(204, 33);
            this.Height_cm.TabIndex = 29;
            // 
            // WeightLable
            // 
            this.WeightLable.AutoSize = true;
            this.WeightLable.Location = new System.Drawing.Point(350, 114);
            this.WeightLable.Name = "WeightLable";
            this.WeightLable.Size = new System.Drawing.Size(109, 25);
            this.WeightLable.TabIndex = 28;
            this.WeightLable.Text = "Weight in KG:";
            // 
            // HeightLable
            // 
            this.HeightLable.AutoSize = true;
            this.HeightLable.Location = new System.Drawing.Point(56, 114);
            this.HeightLable.Name = "HeightLable";
            this.HeightLable.Size = new System.Drawing.Size(108, 25);
            this.HeightLable.TabIndex = 27;
            this.HeightLable.Text = "Height in CM:";
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
            this.CreateAccbtn.Location = new System.Drawing.Point(229, 310);
            this.CreateAccbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateAccbtn.Name = "CreateAccbtn";
            this.CreateAccbtn.Size = new System.Drawing.Size(156, 31);
            this.CreateAccbtn.TabIndex = 36;
            this.CreateAccbtn.Text = "Create an account";
            this.CreateAccbtn.UseVisualStyleBackColor = true;
            this.CreateAccbtn.Click += new System.EventHandler(this.CreateAccbtn_Click);
            // 
            // CreateAc2EN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(595, 390);
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
    }
}