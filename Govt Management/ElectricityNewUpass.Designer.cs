namespace Govt_Management
{
    partial class ElectricityNewUpass
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
            this.labelEPassWrong = new System.Windows.Forms.Label();
            this.labelEPassRight = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxECPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEUName = new System.Windows.Forms.TextBox();
            this.textBoxEPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelEPassWrong
            // 
            this.labelEPassWrong.AutoSize = true;
            this.labelEPassWrong.ForeColor = System.Drawing.Color.Red;
            this.labelEPassWrong.Location = new System.Drawing.Point(585, 169);
            this.labelEPassWrong.Name = "labelEPassWrong";
            this.labelEPassWrong.Size = new System.Drawing.Size(19, 15);
            this.labelEPassWrong.TabIndex = 45;
            this.labelEPassWrong.Text = "❌";
            this.labelEPassWrong.Visible = false;
            // 
            // labelEPassRight
            // 
            this.labelEPassRight.AutoSize = true;
            this.labelEPassRight.ForeColor = System.Drawing.Color.Red;
            this.labelEPassRight.Location = new System.Drawing.Point(585, 169);
            this.labelEPassRight.Name = "labelEPassRight";
            this.labelEPassRight.Size = new System.Drawing.Size(19, 15);
            this.labelEPassRight.TabIndex = 44;
            this.labelEPassRight.Text = "✔";
            this.labelEPassRight.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(665, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxECPass
            // 
            this.textBoxECPass.Location = new System.Drawing.Point(216, 166);
            this.textBoxECPass.Name = "textBoxECPass";
            this.textBoxECPass.PasswordChar = '*';
            this.textBoxECPass.Size = new System.Drawing.Size(363, 23);
            this.textBoxECPass.TabIndex = 41;
            this.textBoxECPass.TextChanged += new System.EventHandler(this.textBoxECPass_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "Confirm Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Password :";
            // 
            // textBoxEUName
            // 
            this.textBoxEUName.Location = new System.Drawing.Point(216, 43);
            this.textBoxEUName.Name = "textBoxEUName";
            this.textBoxEUName.Size = new System.Drawing.Size(363, 23);
            this.textBoxEUName.TabIndex = 37;
            // 
            // textBoxEPass
            // 
            this.textBoxEPass.Location = new System.Drawing.Point(216, 112);
            this.textBoxEPass.Name = "textBoxEPass";
            this.textBoxEPass.PasswordChar = '*';
            this.textBoxEPass.Size = new System.Drawing.Size(363, 23);
            this.textBoxEPass.TabIndex = 36;
            this.textBoxEPass.TextChanged += new System.EventHandler(this.textBoxEPass_TextChanged);
            // 
            // ElectricityNewUpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEPassWrong);
            this.Controls.Add(this.labelEPassRight);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxECPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEUName);
            this.Controls.Add(this.textBoxEPass);
            this.Name = "ElectricityNewUpass";
            this.Text = "ElectricityNewUpass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelEPassWrong;
        private Label labelEPassRight;
        private Button button2;
        private Button button1;
        private TextBox textBoxECPass;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox textBoxEUName;
        private TextBox textBoxEPass;
    }
}