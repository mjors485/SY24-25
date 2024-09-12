namespace RNGgame
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
            this.activateButton = new System.Windows.Forms.Button();
            this.firstLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.higherButton = new System.Windows.Forms.Button();
            this.lowerButton = new System.Windows.Forms.Button();
            this.secondLabel = new System.Windows.Forms.Label();
            this.notifyLabel = new System.Windows.Forms.Label();
            this.secondLabelGen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // activateButton
            // 
            this.activateButton.Location = new System.Drawing.Point(12, 12);
            this.activateButton.Name = "activateButton";
            this.activateButton.Size = new System.Drawing.Size(157, 57);
            this.activateButton.TabIndex = 0;
            this.activateButton.Text = "START GAME";
            this.activateButton.UseVisualStyleBackColor = true;
            this.activateButton.Click += new System.EventHandler(this.activateButton_Click);
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLabel.Location = new System.Drawing.Point(344, 42);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(84, 91);
            this.firstLabel.TabIndex = 2;
            this.firstLabel.Text = "_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(476, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "WIll the next number be higher or lower than this one?";
            // 
            // higherButton
            // 
            this.higherButton.Location = new System.Drawing.Point(271, 195);
            this.higherButton.Name = "higherButton";
            this.higherButton.Size = new System.Drawing.Size(75, 23);
            this.higherButton.TabIndex = 4;
            this.higherButton.Text = "Higher";
            this.higherButton.UseVisualStyleBackColor = true;
            this.higherButton.Click += new System.EventHandler(this.higherButton_Click);
            // 
            // lowerButton
            // 
            this.lowerButton.Location = new System.Drawing.Point(423, 195);
            this.lowerButton.Name = "lowerButton";
            this.lowerButton.Size = new System.Drawing.Size(75, 23);
            this.lowerButton.TabIndex = 5;
            this.lowerButton.Text = "Lower";
            this.lowerButton.UseVisualStyleBackColor = true;
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLabel.Location = new System.Drawing.Point(344, 195);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(84, 91);
            this.secondLabel.TabIndex = 6;
            this.secondLabel.Text = "_";
            // 
            // notifyLabel
            // 
            this.notifyLabel.AutoSize = true;
            this.notifyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifyLabel.Location = new System.Drawing.Point(24, 375);
            this.notifyLabel.Name = "notifyLabel";
            this.notifyLabel.Size = new System.Drawing.Size(46, 18);
            this.notifyLabel.TabIndex = 7;
            this.notifyLabel.Text = "label1";
            // 
            // secondLabelGen
            // 
            this.secondLabelGen.AutoSize = true;
            this.secondLabelGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLabelGen.Location = new System.Drawing.Point(12, 269);
            this.secondLabelGen.Name = "secondLabelGen";
            this.secondLabelGen.Size = new System.Drawing.Size(84, 91);
            this.secondLabelGen.TabIndex = 8;
            this.secondLabelGen.Text = "_";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.secondLabelGen);
            this.Controls.Add(this.notifyLabel);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.lowerButton);
            this.Controls.Add(this.higherButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstLabel);
            this.Controls.Add(this.activateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button activateButton;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button higherButton;
        private System.Windows.Forms.Button lowerButton;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label notifyLabel;
        private System.Windows.Forms.Label secondLabelGen;
    }
}

