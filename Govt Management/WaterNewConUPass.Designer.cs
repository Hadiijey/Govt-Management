namespace Govt_Management
{
    partial class WaterNewConUPass
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxWaterCPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWaterUName = new System.Windows.Forms.TextBox();
            this.textBoxWaterPass = new System.Windows.Forms.TextBox();
            this.labelWaterPassRight = new System.Windows.Forms.Label();
            this.labelWaterPassWrong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(688, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxWaterCPass
            // 
            this.textBoxWaterCPass.Location = new System.Drawing.Point(239, 191);
            this.textBoxWaterCPass.Name = "textBoxWaterCPass";
            this.textBoxWaterCPass.PasswordChar = '*';
            this.textBoxWaterCPass.Size = new System.Drawing.Size(363, 23);
            this.textBoxWaterCPass.TabIndex = 15;
            this.textBoxWaterCPass.TextChanged += new System.EventHandler(this.textBoxWaterCPass_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Confirm Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password :";
            // 
            // textBoxWaterUName
            // 
            this.textBoxWaterUName.Location = new System.Drawing.Point(239, 68);
            this.textBoxWaterUName.Name = "textBoxWaterUName";
            this.textBoxWaterUName.Size = new System.Drawing.Size(363, 23);
            this.textBoxWaterUName.TabIndex = 11;
            // 
            // textBoxWaterPass
            // 
            this.textBoxWaterPass.Location = new System.Drawing.Point(239, 137);
            this.textBoxWaterPass.Name = "textBoxWaterPass";
            this.textBoxWaterPass.PasswordChar = '*';
            this.textBoxWaterPass.Size = new System.Drawing.Size(363, 23);
            this.textBoxWaterPass.TabIndex = 10;
            this.textBoxWaterPass.TextChanged += new System.EventHandler(this.textBoxWaterPass_TextChanged);
            // 
            // labelWaterPassRight
            // 
            this.labelWaterPassRight.AutoSize = true;
            this.labelWaterPassRight.ForeColor = System.Drawing.Color.Red;
            this.labelWaterPassRight.Location = new System.Drawing.Point(608, 194);
            this.labelWaterPassRight.Name = "labelWaterPassRight";
            this.labelWaterPassRight.Size = new System.Drawing.Size(19, 15);
            this.labelWaterPassRight.TabIndex = 34;
            this.labelWaterPassRight.Text = "✔";
            this.labelWaterPassRight.Visible = false;
            // 
            // labelWaterPassWrong
            // 
            this.labelWaterPassWrong.AutoSize = true;
            this.labelWaterPassWrong.ForeColor = System.Drawing.Color.Red;
            this.labelWaterPassWrong.Location = new System.Drawing.Point(608, 194);
            this.labelWaterPassWrong.Name = "labelWaterPassWrong";
            this.labelWaterPassWrong.Size = new System.Drawing.Size(19, 15);
            this.labelWaterPassWrong.TabIndex = 35;
            this.labelWaterPassWrong.Text = "❌";
            this.labelWaterPassWrong.Visible = false;
            // 
            // WaterNewConUPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelWaterPassWrong);
            this.Controls.Add(this.labelWaterPassRight);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxWaterCPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxWaterUName);
            this.Controls.Add(this.textBoxWaterPass);
            this.Name = "WaterNewConUPass";
            this.Text = "WaterNewConUPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBoxWaterCPass;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox textBoxWaterUName;
        private TextBox textBoxWaterPass;
        private Label labelWaterPassRight;
        private Label labelWaterPassWrong;
    }
}