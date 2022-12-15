namespace Govt_Management
{
    partial class WeatherForecast
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
            this.button1 = new System.Windows.Forms.Button();
            this.satelitegif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.satelitegif)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(356, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Satellite Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // satelitegif
            // 
            this.satelitegif.Image = global::Govt_Management.Properties.Resources.sat_infrared;
            this.satelitegif.Location = new System.Drawing.Point(-173, 73);
            this.satelitegif.Name = "satelitegif";
            this.satelitegif.Size = new System.Drawing.Size(801, 377);
            this.satelitegif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.satelitegif.TabIndex = 1;
            this.satelitegif.TabStop = false;
            this.satelitegif.Visible = false;
            // 
            // WeatherForecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.satelitegif);
            this.Controls.Add(this.button1);
            this.Name = "WeatherForecast";
            this.Text = "WeatherForecast";
            ((System.ComponentModel.ISupportInitialize)(this.satelitegif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private PictureBox satelitegif;
    }
}