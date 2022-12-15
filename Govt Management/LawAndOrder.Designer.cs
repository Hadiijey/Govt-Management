namespace Govt_Management
{
    partial class LawAndOrder
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
            this.Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.EmergencyContact = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.Button();
            this.PoliceClearance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(695, 27);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login\r\n";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "👮‍♂️";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Exit.Location = new System.Drawing.Point(695, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // EmergencyContact
            // 
            this.EmergencyContact.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmergencyContact.Location = new System.Drawing.Point(12, 179);
            this.EmergencyContact.Name = "EmergencyContact";
            this.EmergencyContact.Size = new System.Drawing.Size(209, 103);
            this.EmergencyContact.TabIndex = 14;
            this.EmergencyContact.Text = "Emergency Contact With Police";
            this.EmergencyContact.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EmergencyContact.UseVisualStyleBackColor = true;
            this.EmergencyContact.Click += new System.EventHandler(this.EmergencyContact_Click);
            // 
            // Report
            // 
            this.Report.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Report.Location = new System.Drawing.Point(306, 179);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(209, 103);
            this.Report.TabIndex = 14;
            this.Report.Text = "File Report";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // PoliceClearance
            // 
            this.PoliceClearance.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PoliceClearance.Location = new System.Drawing.Point(561, 179);
            this.PoliceClearance.Name = "PoliceClearance";
            this.PoliceClearance.Size = new System.Drawing.Size(209, 103);
            this.PoliceClearance.TabIndex = 15;
            this.PoliceClearance.Text = "Police Clearance";
            this.PoliceClearance.UseVisualStyleBackColor = true;
            this.PoliceClearance.Click += new System.EventHandler(this.PoliceClearance_Click);
            // 
            // LawAndOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PoliceClearance);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.EmergencyContact);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Login);
            this.Name = "LawAndOrder";
            this.Text = "Law & Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Login;
        private Label label3;
        private Button Exit;
        private Button EmergencyContact;
        private Button Report;
        private Button PoliceClearance;
    }
}