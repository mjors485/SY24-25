namespace QuartetGame
{
    partial class Form1
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
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.labelZeroToSixty = new System.Windows.Forms.Label();
            this.labelHP = new System.Windows.Forms.Label();
            this.labelRPM = new System.Windows.Forms.Label();
            this.labelCylinders = new System.Windows.Forms.Label();
            this.labelCC = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.A1Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Location = new System.Drawing.Point(268, 100);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(221, 137);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar.TabIndex = 0;
            this.pictureBoxCar.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(390, 65);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(265, 262);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(76, 16);
            this.labelMaxSpeed.TabIndex = 2;
            this.labelMaxSpeed.Text = "Max Speed";
            // 
            // labelZeroToSixty
            // 
            this.labelZeroToSixty.AutoSize = true;
            this.labelZeroToSixty.Location = new System.Drawing.Point(265, 312);
            this.labelZeroToSixty.Name = "labelZeroToSixty";
            this.labelZeroToSixty.Size = new System.Drawing.Size(80, 16);
            this.labelZeroToSixty.TabIndex = 3;
            this.labelZeroToSixty.Text = "Zero to Sixty";
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Location = new System.Drawing.Point(265, 361);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(26, 16);
            this.labelHP.TabIndex = 4;
            this.labelHP.Text = "HP";
            // 
            // labelRPM
            // 
            this.labelRPM.AutoSize = true;
            this.labelRPM.Location = new System.Drawing.Point(445, 361);
            this.labelRPM.Name = "labelRPM";
            this.labelRPM.Size = new System.Drawing.Size(37, 16);
            this.labelRPM.TabIndex = 7;
            this.labelRPM.Text = "RPM";
            // 
            // labelCylinders
            // 
            this.labelCylinders.AutoSize = true;
            this.labelCylinders.Location = new System.Drawing.Point(445, 312);
            this.labelCylinders.Name = "labelCylinders";
            this.labelCylinders.Size = new System.Drawing.Size(63, 16);
            this.labelCylinders.TabIndex = 6;
            this.labelCylinders.Text = "Cylinders";
            // 
            // labelCC
            // 
            this.labelCC.AutoSize = true;
            this.labelCC.Location = new System.Drawing.Point(445, 262);
            this.labelCC.Name = "labelCC";
            this.labelCC.Size = new System.Drawing.Size(25, 16);
            this.labelCC.TabIndex = 5;
            this.labelCC.Text = "CC";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(311, 65);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(20, 16);
            this.labelID.TabIndex = 8;
            this.labelID.Text = "ID";
            // 
            // A1Button
            // 
            this.A1Button.Location = new System.Drawing.Point(618, 214);
            this.A1Button.Name = "A1Button";
            this.A1Button.Size = new System.Drawing.Size(75, 23);
            this.A1Button.TabIndex = 9;
            this.A1Button.Text = "A1";
            this.A1Button.UseVisualStyleBackColor = true;
            this.A1Button.Click += new System.EventHandler(this.A1Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.A1Button);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelRPM);
            this.Controls.Add(this.labelCylinders);
            this.Controls.Add(this.labelCC);
            this.Controls.Add(this.labelHP);
            this.Controls.Add(this.labelZeroToSixty);
            this.Controls.Add(this.labelMaxSpeed);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxCar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.Label labelZeroToSixty;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelRPM;
        private System.Windows.Forms.Label labelCylinders;
        private System.Windows.Forms.Label labelCC;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button A1Button;
    }
}

