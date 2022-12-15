namespace Govt_Management
{
    partial class Gas
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
            this.buttonGasNewCon = new System.Windows.Forms.Button();
            this.buttonGasBill = new System.Windows.Forms.Button();
            this.buttonGasComplain = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGasNewCon
            // 
            this.buttonGasNewCon.Location = new System.Drawing.Point(56, 165);
            this.buttonGasNewCon.Name = "buttonGasNewCon";
            this.buttonGasNewCon.Size = new System.Drawing.Size(133, 58);
            this.buttonGasNewCon.TabIndex = 0;
            this.buttonGasNewCon.Text = "New Connection";
            this.buttonGasNewCon.UseVisualStyleBackColor = true;
            this.buttonGasNewCon.Click += new System.EventHandler(this.buttonGasNewCon_Click);
            // 
            // buttonGasBill
            // 
            this.buttonGasBill.Location = new System.Drawing.Point(317, 165);
            this.buttonGasBill.Name = "buttonGasBill";
            this.buttonGasBill.Size = new System.Drawing.Size(133, 58);
            this.buttonGasBill.TabIndex = 1;
            this.buttonGasBill.Text = "Bill";
            this.buttonGasBill.UseVisualStyleBackColor = true;
            this.buttonGasBill.Click += new System.EventHandler(this.buttonGasBill_Click);
            // 
            // buttonGasComplain
            // 
            this.buttonGasComplain.Location = new System.Drawing.Point(595, 165);
            this.buttonGasComplain.Name = "buttonGasComplain";
            this.buttonGasComplain.Size = new System.Drawing.Size(133, 58);
            this.buttonGasComplain.TabIndex = 2;
            this.buttonGasComplain.Text = "Complain";
            this.buttonGasComplain.UseVisualStyleBackColor = true;
            this.buttonGasComplain.Click += new System.EventHandler(this.buttonGasComplain_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(678, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "👮‍♂️";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(703, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 24);
            this.button7.TabIndex = 12;
            this.button7.Text = "Login";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Gas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonGasComplain);
            this.Controls.Add(this.buttonGasBill);
            this.Controls.Add(this.buttonGasNewCon);
            this.Name = "Gas";
            this.Text = "Gas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonGasNewCon;
        private Button buttonGasBill;
        private Button buttonGasComplain;
        private Button button1;
        private Label label3;
        private Button button7;
    }
}