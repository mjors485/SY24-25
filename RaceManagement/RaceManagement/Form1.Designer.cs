namespace RaceManagement
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
            this.EventID = new System.Windows.Forms.Label();
            this.EventName = new System.Windows.Forms.Label();
            this.EventDate = new System.Windows.Forms.Label();
            this.RaceDistance = new System.Windows.Forms.Label();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.txtRaceDistance = new System.Windows.Forms.TextBox();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EventID
            // 
            this.EventID.AutoSize = true;
            this.EventID.Location = new System.Drawing.Point(97, 63);
            this.EventID.Name = "EventID";
            this.EventID.Size = new System.Drawing.Size(20, 16);
            this.EventID.TabIndex = 2;
            this.EventID.Text = "ID";
            // 
            // EventName
            // 
            this.EventName.AutoSize = true;
            this.EventName.Location = new System.Drawing.Point(224, 63);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(46, 16);
            this.EventName.TabIndex = 3;
            this.EventName.Text = "NAME";
            // 
            // EventDate
            // 
            this.EventDate.AutoSize = true;
            this.EventDate.Location = new System.Drawing.Point(359, 63);
            this.EventDate.Name = "EventDate";
            this.EventDate.Size = new System.Drawing.Size(44, 16);
            this.EventDate.TabIndex = 4;
            this.EventDate.Text = "DATE";
            // 
            // RaceDistance
            // 
            this.RaceDistance.AutoSize = true;
            this.RaceDistance.Location = new System.Drawing.Point(587, 63);
            this.RaceDistance.Name = "RaceDistance";
            this.RaceDistance.Size = new System.Drawing.Size(75, 16);
            this.RaceDistance.TabIndex = 5;
            this.RaceDistance.Text = "DISTANCE";
            // 
            // txtEventID
            // 
            this.txtEventID.Location = new System.Drawing.Point(100, 93);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.Size = new System.Drawing.Size(100, 22);
            this.txtEventID.TabIndex = 6;
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(227, 93);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(100, 22);
            this.txtEventName.TabIndex = 7;
            // 
            // txtRaceDistance
            // 
            this.txtRaceDistance.Location = new System.Drawing.Point(590, 93);
            this.txtRaceDistance.Name = "txtRaceDistance";
            this.txtRaceDistance.Size = new System.Drawing.Size(100, 22);
            this.txtRaceDistance.TabIndex = 8;
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Location = new System.Drawing.Point(362, 93);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEventDate.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(339, 159);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpEventDate);
            this.Controls.Add(this.txtRaceDistance);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.txtEventID);
            this.Controls.Add(this.RaceDistance);
            this.Controls.Add(this.EventDate);
            this.Controls.Add(this.EventName);
            this.Controls.Add(this.EventID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EventID;
        private System.Windows.Forms.Label EventName;
        private System.Windows.Forms.Label EventDate;
        private System.Windows.Forms.Label RaceDistance;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtRaceDistance;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.Button btnSave;
    }
}

