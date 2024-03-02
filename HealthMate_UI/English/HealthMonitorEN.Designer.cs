namespace HealthMate_UI
{
    partial class HealthMonitorEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HealthMonitorEN));
            this.BackBtn = new System.Windows.Forms.Button();
            this.BMILabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CalorieNeedsLabel = new System.Windows.Forms.Label();
            this.IdealWeightLabel = new System.Windows.Forms.Label();
            this.AdviceLabel = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Subtitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 9);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(55, 30);
            this.BackBtn.TabIndex = 44;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // BMILabel
            // 
            this.BMILabel.AutoSize = true;
            this.BMILabel.Location = new System.Drawing.Point(33, 86);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(83, 25);
            this.BMILabel.TabIndex = 45;
            this.BMILabel.Text = "BMI Label";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(33, 143);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(119, 25);
            this.CategoryLabel.TabIndex = 46;
            this.CategoryLabel.Text = "Category Label";
            // 
            // CalorieNeedsLabel
            // 
            this.CalorieNeedsLabel.AutoSize = true;
            this.CalorieNeedsLabel.Location = new System.Drawing.Point(33, 200);
            this.CalorieNeedsLabel.Name = "CalorieNeedsLabel";
            this.CalorieNeedsLabel.Size = new System.Drawing.Size(152, 25);
            this.CalorieNeedsLabel.TabIndex = 47;
            this.CalorieNeedsLabel.Text = "Calorie Needs Label";
            // 
            // IdealWeightLabel
            // 
            this.IdealWeightLabel.AutoSize = true;
            this.IdealWeightLabel.Location = new System.Drawing.Point(33, 261);
            this.IdealWeightLabel.Name = "IdealWeightLabel";
            this.IdealWeightLabel.Size = new System.Drawing.Size(141, 25);
            this.IdealWeightLabel.TabIndex = 48;
            this.IdealWeightLabel.Text = "Ideal Weight Label";
            // 
            // AdviceLabel
            // 
            this.AdviceLabel.AutoSize = true;
            this.AdviceLabel.Location = new System.Drawing.Point(337, 86);
            this.AdviceLabel.Name = "AdviceLabel";
            this.AdviceLabel.Size = new System.Drawing.Size(101, 25);
            this.AdviceLabel.TabIndex = 49;
            this.AdviceLabel.Text = "Advice Label";
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Gray;
            this.line.Location = new System.Drawing.Point(319, 86);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(10, 250);
            this.line.TabIndex = 50;
            this.line.Text = "button1";
            this.line.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(26, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 9);
            this.button1.TabIndex = 51;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(26, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 9);
            this.button2.TabIndex = 52;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Location = new System.Drawing.Point(26, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(262, 9);
            this.button3.TabIndex = 53;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Subtitle
            // 
            this.Subtitle.AutoSize = true;
            this.Subtitle.Font = new System.Drawing.Font("El Messiri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtitle.Location = new System.Drawing.Point(335, 9);
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Size = new System.Drawing.Size(138, 37);
            this.Subtitle.TabIndex = 54;
            this.Subtitle.Text = "HealthMate";
            // 
            // HealthMonitorEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 390);
            this.Controls.Add(this.Subtitle);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.line);
            this.Controls.Add(this.AdviceLabel);
            this.Controls.Add(this.IdealWeightLabel);
            this.Controls.Add(this.CalorieNeedsLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.BMILabel);
            this.Controls.Add(this.BackBtn);
            this.Font = new System.Drawing.Font("El Messiri SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "HealthMonitorEN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HealthMate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HealthMonitorEN_FormClosing);
            this.Load += new System.EventHandler(this.HealthMonitorEN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label BMILabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label CalorieNeedsLabel;
        private System.Windows.Forms.Label IdealWeightLabel;
        private System.Windows.Forms.Label AdviceLabel;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Subtitle;
    }
}