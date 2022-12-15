namespace Govt_Management
{
    partial class Login
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
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_L_Uname = new System.Windows.Forms.TextBox();
            this.textBox_LPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(485, 352);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 42);
            this.button6.TabIndex = 8;
            this.button6.Text = "Submit";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(496, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Forgot Password";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(292, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(297, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Password :";
            // 
            // textBox_L_Uname
            // 
            this.textBox_L_Uname.Location = new System.Drawing.Point(454, 199);
            this.textBox_L_Uname.Name = "textBox_L_Uname";
            this.textBox_L_Uname.Size = new System.Drawing.Size(207, 23);
            this.textBox_L_Uname.TabIndex = 12;
            this.textBox_L_Uname.TextChanged += new System.EventHandler(this.textBox_L_Uname_TextChanged);
            // 
            // textBox_LPass
            // 
            this.textBox_LPass.Location = new System.Drawing.Point(454, 258);
            this.textBox_LPass.Name = "textBox_LPass";
            this.textBox_LPass.Size = new System.Drawing.Size(207, 23);
            this.textBox_LPass.TabIndex = 13;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 640);
            this.Controls.Add(this.textBox_LPass);
            this.Controls.Add(this.textBox_L_Uname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button6;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox_L_Uname;
        private TextBox textBox_LPass;
    }
}