namespace Govt_Management
{
    partial class OfficialsLogin
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
            this.textBox_LPass = new System.Windows.Forms.TextBox();
            this.textBox_L_Uname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_LPass
            // 
            this.textBox_LPass.Location = new System.Drawing.Point(378, 208);
            this.textBox_LPass.Name = "textBox_LPass";
            this.textBox_LPass.Size = new System.Drawing.Size(207, 23);
            this.textBox_LPass.TabIndex = 25;
            // 
            // textBox_L_Uname
            // 
            this.textBox_L_Uname.Location = new System.Drawing.Point(378, 149);
            this.textBox_L_Uname.Name = "textBox_L_Uname";
            this.textBox_L_Uname.Size = new System.Drawing.Size(207, 23);
            this.textBox_L_Uname.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(221, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(216, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "Username :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 42);
            this.button1.TabIndex = 21;
            this.button1.Text = "Forgot Password";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(449, 266);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 42);
            this.button6.TabIndex = 20;
            this.button6.Text = "Submit";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OfficialsLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_LPass);
            this.Controls.Add(this.textBox_L_Uname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Name = "OfficialsLogin";
            this.Text = "OfficialsLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_LPass;
        private TextBox textBox_L_Uname;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button6;
        private Button button2;
    }
}