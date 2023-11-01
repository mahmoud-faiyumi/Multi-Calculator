namespace HealthMate_UI
{
    partial class AgeCalcEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgeCalcEN));
            this.Subtitle = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.AnotherDateBtn = new System.Windows.Forms.Button();
            this.ageLabel = new System.Windows.Forms.Label();
            this.nextBirthdayLabel = new System.Windows.Forms.Label();
            this.additionalFactsLabel = new System.Windows.Forms.Label();
            this.BirthDateDaylabel = new System.Windows.Forms.Label();
            this.LivedForlabel = new System.Windows.Forms.Label();
            this.CustomdatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Subtitle
            // 
            this.Subtitle.AutoSize = true;
            this.Subtitle.Font = new System.Drawing.Font("El Messiri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtitle.Location = new System.Drawing.Point(238, 9);
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Size = new System.Drawing.Size(138, 37);
            this.Subtitle.TabIndex = 4;
            this.Subtitle.Text = "HealthMate";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 9);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(55, 30);
            this.BackBtn.TabIndex = 43;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // AnotherDateBtn
            // 
            this.AnotherDateBtn.Location = new System.Drawing.Point(436, 25);
            this.AnotherDateBtn.Name = "AnotherDateBtn";
            this.AnotherDateBtn.Size = new System.Drawing.Size(111, 37);
            this.AnotherDateBtn.TabIndex = 44;
            this.AnotherDateBtn.Text = "Custom date";
            this.AnotherDateBtn.UseVisualStyleBackColor = true;
            this.AnotherDateBtn.Click += new System.EventHandler(this.AnotherDateBtn_Click);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(30, 85);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(74, 25);
            this.ageLabel.TabIndex = 46;
            this.ageLabel.Text = "ageLabel";
            // 
            // nextBirthdayLabel
            // 
            this.nextBirthdayLabel.AutoSize = true;
            this.nextBirthdayLabel.Location = new System.Drawing.Point(30, 124);
            this.nextBirthdayLabel.Name = "nextBirthdayLabel";
            this.nextBirthdayLabel.Size = new System.Drawing.Size(142, 25);
            this.nextBirthdayLabel.TabIndex = 47;
            this.nextBirthdayLabel.Text = "nextBirthdayLabel";
            // 
            // additionalFactsLabel
            // 
            this.additionalFactsLabel.AutoSize = true;
            this.additionalFactsLabel.Location = new System.Drawing.Point(30, 204);
            this.additionalFactsLabel.Name = "additionalFactsLabel";
            this.additionalFactsLabel.Size = new System.Drawing.Size(158, 25);
            this.additionalFactsLabel.TabIndex = 48;
            this.additionalFactsLabel.Text = "additionalFactsLabel";
            // 
            // BirthDateDaylabel
            // 
            this.BirthDateDaylabel.AutoSize = true;
            this.BirthDateDaylabel.Location = new System.Drawing.Point(30, 165);
            this.BirthDateDaylabel.Name = "BirthDateDaylabel";
            this.BirthDateDaylabel.Size = new System.Drawing.Size(143, 25);
            this.BirthDateDaylabel.TabIndex = 49;
            this.BirthDateDaylabel.Text = "BirthDateDaylabel";
            // 
            // LivedForlabel
            // 
            this.LivedForlabel.AutoSize = true;
            this.LivedForlabel.Location = new System.Drawing.Point(411, 146);
            this.LivedForlabel.Name = "LivedForlabel";
            this.LivedForlabel.Size = new System.Drawing.Size(108, 25);
            this.LivedForlabel.TabIndex = 50;
            this.LivedForlabel.Text = "LivedForlabel";
            // 
            // CustomdatePicker
            // 
            this.CustomdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CustomdatePicker.Location = new System.Drawing.Point(427, 68);
            this.CustomdatePicker.Name = "CustomdatePicker";
            this.CustomdatePicker.Size = new System.Drawing.Size(127, 33);
            this.CustomdatePicker.TabIndex = 51;
            // 
            // AgeCalcEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(595, 390);
            this.Controls.Add(this.CustomdatePicker);
            this.Controls.Add(this.LivedForlabel);
            this.Controls.Add(this.BirthDateDaylabel);
            this.Controls.Add(this.additionalFactsLabel);
            this.Controls.Add(this.nextBirthdayLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.AnotherDateBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.Subtitle);
            this.Font = new System.Drawing.Font("El Messiri SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "AgeCalcEN";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HealthMate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgeCalcEN_FormClosing);
            this.Load += new System.EventHandler(this.AgeCalcEN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Subtitle;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button AnotherDateBtn;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label nextBirthdayLabel;
        private System.Windows.Forms.Label additionalFactsLabel;
        private System.Windows.Forms.Label BirthDateDaylabel;
        private System.Windows.Forms.Label LivedForlabel;
        private System.Windows.Forms.DateTimePicker CustomdatePicker;
    }
}