namespace Govt_Management
{
    partial class Education
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
            this.buttonApplication = new System.Windows.Forms.Button();
            this.buttonBoardandInstitute = new System.Windows.Forms.Button();
            this.buttonCeritificate = new System.Windows.Forms.Button();
            this.buttonCorrection = new System.Windows.Forms.Button();
            this.buttonNewInstitute = new System.Windows.Forms.Button();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonApplication
            // 
            this.buttonApplication.Location = new System.Drawing.Point(214, 168);
            this.buttonApplication.Name = "buttonApplication";
            this.buttonApplication.Size = new System.Drawing.Size(107, 46);
            this.buttonApplication.TabIndex = 0;
            this.buttonApplication.Text = "Application";
            this.buttonApplication.UseVisualStyleBackColor = true;
            this.buttonApplication.Click += new System.EventHandler(this.buttonApplication_Click);
            // 
            // buttonBoardandInstitute
            // 
            this.buttonBoardandInstitute.Location = new System.Drawing.Point(440, 168);
            this.buttonBoardandInstitute.Name = "buttonBoardandInstitute";
            this.buttonBoardandInstitute.Size = new System.Drawing.Size(107, 46);
            this.buttonBoardandInstitute.TabIndex = 2;
            this.buttonBoardandInstitute.Text = "Board and Institute";
            this.buttonBoardandInstitute.UseVisualStyleBackColor = true;
            this.buttonBoardandInstitute.Click += new System.EventHandler(this.buttonBoardandInstitute_Click);
            // 
            // buttonCeritificate
            // 
            this.buttonCeritificate.Location = new System.Drawing.Point(78, 78);
            this.buttonCeritificate.Name = "buttonCeritificate";
            this.buttonCeritificate.Size = new System.Drawing.Size(173, 283);
            this.buttonCeritificate.TabIndex = 3;
            this.buttonCeritificate.Text = "Certificate";
            this.buttonCeritificate.UseVisualStyleBackColor = true;
            this.buttonCeritificate.Visible = false;
            this.buttonCeritificate.Click += new System.EventHandler(this.buttonCeritificate_Click);
            // 
            // buttonCorrection
            // 
            this.buttonCorrection.Location = new System.Drawing.Point(287, 78);
            this.buttonCorrection.Name = "buttonCorrection";
            this.buttonCorrection.Size = new System.Drawing.Size(173, 283);
            this.buttonCorrection.TabIndex = 4;
            this.buttonCorrection.Text = "Correction";
            this.buttonCorrection.UseVisualStyleBackColor = true;
            this.buttonCorrection.Visible = false;
            this.buttonCorrection.Click += new System.EventHandler(this.buttonCorrection_Click);
            // 
            // buttonNewInstitute
            // 
            this.buttonNewInstitute.Location = new System.Drawing.Point(507, 78);
            this.buttonNewInstitute.Name = "buttonNewInstitute";
            this.buttonNewInstitute.Size = new System.Drawing.Size(173, 283);
            this.buttonNewInstitute.TabIndex = 5;
            this.buttonNewInstitute.Text = "New Institute";
            this.buttonNewInstitute.UseVisualStyleBackColor = true;
            this.buttonNewInstitute.Visible = false;
            this.buttonNewInstitute.Click += new System.EventHandler(this.buttonNewInstitute_Click);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Location = new System.Drawing.Point(646, 407);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(106, 31);
            this.buttonGoBack.TabIndex = 10;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.UseWaitCursor = true;
            this.buttonGoBack.Visible = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "👮‍♂️";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(703, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 24);
            this.button7.TabIndex = 11;
            this.button7.Text = "Login";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(646, 407);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(106, 31);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.UseWaitCursor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Education
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 462);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonBoardandInstitute);
            this.Controls.Add(this.buttonApplication);
            this.Controls.Add(this.buttonCeritificate);
            this.Controls.Add(this.buttonCorrection);
            this.Controls.Add(this.buttonNewInstitute);
            this.Name = "Education";
            this.Text = "Education";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonApplication;
        private Button buttonBoardandInstitute;
        private Button buttonCeritificate;
        private Button buttonCorrection;
        private Button buttonNewInstitute;
        private Button buttonGoBack;
        private Label label3;
        private Button button7;
        private Button buttonExit;
    }
}