namespace Govt_Management
{
    partial class Utility_Service
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
            this.buttongGas = new System.Windows.Forms.Button();
            this.buttonWater = new System.Windows.Forms.Button();
            this.buttonElectricity = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttongGas
            // 
            this.buttongGas.Location = new System.Drawing.Point(58, 188);
            this.buttongGas.Name = "buttongGas";
            this.buttongGas.Size = new System.Drawing.Size(179, 65);
            this.buttongGas.TabIndex = 12;
            this.buttongGas.Text = "Gas";
            this.buttongGas.UseVisualStyleBackColor = true;
            this.buttongGas.Click += new System.EventHandler(this.buttongGas_Click);
            // 
            // buttonWater
            // 
            this.buttonWater.Location = new System.Drawing.Point(328, 194);
            this.buttonWater.Name = "buttonWater";
            this.buttonWater.Size = new System.Drawing.Size(130, 59);
            this.buttonWater.TabIndex = 13;
            this.buttonWater.Text = "Water and Sanitation";
            this.buttonWater.UseVisualStyleBackColor = true;
            this.buttonWater.Click += new System.EventHandler(this.buttonWater_Click);
            // 
            // buttonElectricity
            // 
            this.buttonElectricity.Location = new System.Drawing.Point(569, 188);
            this.buttonElectricity.Name = "buttonElectricity";
            this.buttonElectricity.Size = new System.Drawing.Size(130, 59);
            this.buttonElectricity.TabIndex = 14;
            this.buttonElectricity.Text = "Electricity";
            this.buttonElectricity.UseVisualStyleBackColor = true;
            this.buttonElectricity.Click += new System.EventHandler(this.buttonElectricity_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Utility_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonElectricity);
            this.Controls.Add(this.buttonWater);
            this.Controls.Add(this.buttongGas);
            this.DoubleBuffered = true;
            this.Name = "Utility_Service";
            this.Text = "Utility_Service";
            this.Load += new System.EventHandler(this.Utility_Service_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttongGas;
        private Button buttonWater;
        private Button buttonElectricity;
        private Button button1;
    }
}