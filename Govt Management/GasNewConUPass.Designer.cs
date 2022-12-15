namespace Govt_Management
{
    partial class GasNewConUPass
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
            this.textBoxGasPass = new System.Windows.Forms.TextBox();
            this.textBoxGasUname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGasCPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelPassWrong = new System.Windows.Forms.Label();
            this.labelPassRight = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxGasPass
            // 
            this.textBoxGasPass.Location = new System.Drawing.Point(230, 156);
            this.textBoxGasPass.Name = "textBoxGasPass";
            this.textBoxGasPass.PasswordChar = '*';
            this.textBoxGasPass.Size = new System.Drawing.Size(363, 23);
            this.textBoxGasPass.TabIndex = 2;
            this.textBoxGasPass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxGasUname
            // 
            this.textBoxGasUname.Location = new System.Drawing.Point(230, 87);
            this.textBoxGasUname.Name = "textBoxGasUname";
            this.textBoxGasUname.Size = new System.Drawing.Size(363, 23);
            this.textBoxGasUname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm Password :";
            // 
            // textBoxGasCPass
            // 
            this.textBoxGasCPass.Location = new System.Drawing.Point(230, 210);
            this.textBoxGasCPass.Name = "textBoxGasCPass";
            this.textBoxGasCPass.PasswordChar = '*';
            this.textBoxGasCPass.Size = new System.Drawing.Size(363, 23);
            this.textBoxGasCPass.TabIndex = 7;
            this.textBoxGasCPass.TextChanged += new System.EventHandler(this.textBoxGasCPass_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(679, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelPassWrong
            // 
            this.labelPassWrong.AutoSize = true;
            this.labelPassWrong.ForeColor = System.Drawing.Color.Red;
            this.labelPassWrong.Location = new System.Drawing.Point(599, 213);
            this.labelPassWrong.Name = "labelPassWrong";
            this.labelPassWrong.Size = new System.Drawing.Size(19, 15);
            this.labelPassWrong.TabIndex = 32;
            this.labelPassWrong.Text = "❌";
            this.labelPassWrong.Visible = false;
            // 
            // labelPassRight
            // 
            this.labelPassRight.AutoSize = true;
            this.labelPassRight.ForeColor = System.Drawing.Color.Red;
            this.labelPassRight.Location = new System.Drawing.Point(599, 213);
            this.labelPassRight.Name = "labelPassRight";
            this.labelPassRight.Size = new System.Drawing.Size(19, 15);
            this.labelPassRight.TabIndex = 33;
            this.labelPassRight.Text = "✔";
            this.labelPassRight.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(599, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Username already taken";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Security Question :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Confirm Password :";
            // 
            // GasNewConUPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 494);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelPassRight);
            this.Controls.Add(this.labelPassWrong);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxGasCPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxGasUname);
            this.Controls.Add(this.textBoxGasPass);
            this.Name = "GasNewConUPass";
            this.Text = "GasNewConUPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxGasPass;
        private TextBox textBoxGasUname;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textBoxGasCPass;
        private Button button1;
        private Button button2;
        private Label labelPassWrong;
        private Label labelPassRight;
        private Label label5;
        private Label label4;
        private Label label6;
    }
}