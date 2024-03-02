namespace HealthMate_UI
{
    partial class CreateAc2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAc2));
            this.RePassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.RePassLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.TextBox();
            this.Height_cm = new System.Windows.Forms.TextBox();
            this.WeightLable = new System.Windows.Forms.Label();
            this.HeightLable = new System.Windows.Forms.Label();
            this.CreateAccbtn = new System.Windows.Forms.Button();
            this.PasswordMatchLabel = new System.Windows.Forms.Label();
            this.PasswordStrengthLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.PasswordVisibilityRE = new System.Windows.Forms.Button();
            this.PasswordVisibility = new System.Windows.Forms.Button();
            this.InchesToCm = new System.Windows.Forms.Button();
            this.KGToLB = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Back = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.FileTextBox = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ChangePPlabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RePassword
            // 
            this.RePassword.Location = new System.Drawing.Point(355, 164);
            this.RePassword.Name = "RePassword";
            this.RePassword.Size = new System.Drawing.Size(204, 33);
            this.RePassword.TabIndex = 34;
            this.RePassword.TextChanged += new System.EventHandler(this.RePassword_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(51, 164);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(204, 33);
            this.Password.TabIndex = 33;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // RePassLabel
            // 
            this.RePassLabel.AutoSize = true;
            this.RePassLabel.Location = new System.Drawing.Point(350, 136);
            this.RePassLabel.Name = "RePassLabel";
            this.RePassLabel.Size = new System.Drawing.Size(152, 25);
            this.RePassLabel.TabIndex = 32;
            this.RePassLabel.Text = "Re-Enter Password:";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(46, 136);
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
            this.Height_cm.Location = new System.Drawing.Point(51, 76);
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
            this.HeightLable.Location = new System.Drawing.Point(46, 48);
            this.HeightLable.Name = "HeightLable";
            this.HeightLable.Size = new System.Drawing.Size(62, 25);
            this.HeightLable.TabIndex = 27;
            this.HeightLable.Text = "Height:";
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
            this.PasswordMatchLabel.Location = new System.Drawing.Point(352, 200);
            this.PasswordMatchLabel.Name = "PasswordMatchLabel";
            this.PasswordMatchLabel.Size = new System.Drawing.Size(0, 17);
            this.PasswordMatchLabel.TabIndex = 37;
            // 
            // PasswordStrengthLabel
            // 
            this.PasswordStrengthLabel.AutoSize = true;
            this.PasswordStrengthLabel.Font = new System.Drawing.Font("El Messiri", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordStrengthLabel.ForeColor = System.Drawing.Color.Black;
            this.PasswordStrengthLabel.Location = new System.Drawing.Point(48, 200);
            this.PasswordStrengthLabel.Name = "PasswordStrengthLabel";
            this.PasswordStrengthLabel.Size = new System.Drawing.Size(0, 17);
            this.PasswordStrengthLabel.TabIndex = 38;
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
            this.PasswordVisibilityRE.BackColor = System.Drawing.Color.White;
            this.PasswordVisibilityRE.Location = new System.Drawing.Point(526, 164);
            this.PasswordVisibilityRE.Name = "PasswordVisibilityRE";
            this.PasswordVisibilityRE.Size = new System.Drawing.Size(33, 33);
            this.PasswordVisibilityRE.TabIndex = 44;
            this.PasswordVisibilityRE.UseVisualStyleBackColor = false;
            this.PasswordVisibilityRE.Click += new System.EventHandler(this.PasswordVisibilityRE_Click);
            // 
            // PasswordVisibility
            // 
            this.PasswordVisibility.Location = new System.Drawing.Point(222, 164);
            this.PasswordVisibility.Name = "PasswordVisibility";
            this.PasswordVisibility.Size = new System.Drawing.Size(33, 33);
            this.PasswordVisibility.TabIndex = 45;
            this.PasswordVisibility.UseVisualStyleBackColor = true;
            this.PasswordVisibility.Click += new System.EventHandler(this.PasswordVisibility_Click);
            // 
            // InchesToCm
            // 
            this.InchesToCm.Location = new System.Drawing.Point(222, 76);
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
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Back,
            this.toolStripSeparator3,
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(595, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 59;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Back
            // 
            this.Back.Image = global::HealthMate_UI.Properties.Resources.Back;
            this.Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(52, 22);
            this.Back.Text = "Back";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(266, 254);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(73, 30);
            this.BrowseButton.TabIndex = 74;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // FileTextBox
            // 
            this.FileTextBox.AutoSize = true;
            this.FileTextBox.Font = new System.Drawing.Font("El Messiri SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.FileTextBox.Location = new System.Drawing.Point(267, 287);
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.Size = new System.Drawing.Size(0, 19);
            this.FileTextBox.TabIndex = 75;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ChangePPlabel
            // 
            this.ChangePPlabel.AutoSize = true;
            this.ChangePPlabel.Location = new System.Drawing.Point(50, 223);
            this.ChangePPlabel.Name = "ChangePPlabel";
            this.ChangePPlabel.Size = new System.Drawing.Size(0, 25);
            this.ChangePPlabel.TabIndex = 76;
            // 
            // CreateAc2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(595, 390);
            this.Controls.Add(this.ChangePPlabel);
            this.Controls.Add(this.FileTextBox);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.KGToLB);
            this.Controls.Add(this.InchesToCm);
            this.Controls.Add(this.PasswordVisibility);
            this.Controls.Add(this.PasswordVisibilityRE);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.PasswordStrengthLabel);
            this.Controls.Add(this.PasswordMatchLabel);
            this.Controls.Add(this.CreateAccbtn);
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
            this.Name = "CreateAc2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HealthMate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateAc2EN_FormClosing);
            this.Load += new System.EventHandler(this.CreateAc2EN_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.Button CreateAccbtn;
        private System.Windows.Forms.Label PasswordMatchLabel;
        private System.Windows.Forms.Label PasswordStrengthLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button PasswordVisibilityRE;
        private System.Windows.Forms.Button PasswordVisibility;
        private System.Windows.Forms.Button InchesToCm;
        private System.Windows.Forms.Button KGToLB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Back;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label FileTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label ChangePPlabel;
    }
}