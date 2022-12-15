namespace Govt_Management
{
    partial class NewInstitute
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelOwnerName = new System.Windows.Forms.Label();
            this.radioButtonSinOwner = new System.Windows.Forms.RadioButton();
            this.radioButtonMulOwner = new System.Windows.Forms.RadioButton();
            this.textBoxOwnerName = new System.Windows.Forms.TextBox();
            this.labelOwnerNID = new System.Windows.Forms.Label();
            this.textBoxOwnerNID = new System.Windows.Forms.TextBox();
            this.textBoxRoadNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxBoard = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Institution Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Institution Name:";
            // 
            // labelOwnerName
            // 
            this.labelOwnerName.AutoSize = true;
            this.labelOwnerName.Location = new System.Drawing.Point(148, 110);
            this.labelOwnerName.Name = "labelOwnerName";
            this.labelOwnerName.Size = new System.Drawing.Size(80, 15);
            this.labelOwnerName.TabIndex = 2;
            this.labelOwnerName.Text = "Owner Name:";
            this.labelOwnerName.Visible = false;
            // 
            // radioButtonSinOwner
            // 
            this.radioButtonSinOwner.AutoSize = true;
            this.radioButtonSinOwner.Location = new System.Drawing.Point(17, 106);
            this.radioButtonSinOwner.Name = "radioButtonSinOwner";
            this.radioButtonSinOwner.Size = new System.Drawing.Size(95, 19);
            this.radioButtonSinOwner.TabIndex = 3;
            this.radioButtonSinOwner.TabStop = true;
            this.radioButtonSinOwner.Text = "Single Owner";
            this.radioButtonSinOwner.UseVisualStyleBackColor = true;
            this.radioButtonSinOwner.CheckedChanged += new System.EventHandler(this.radioButtonSinOwner_CheckedChanged);
            // 
            // radioButtonMulOwner
            // 
            this.radioButtonMulOwner.AutoSize = true;
            this.radioButtonMulOwner.Location = new System.Drawing.Point(17, 142);
            this.radioButtonMulOwner.Name = "radioButtonMulOwner";
            this.radioButtonMulOwner.Size = new System.Drawing.Size(107, 19);
            this.radioButtonMulOwner.TabIndex = 4;
            this.radioButtonMulOwner.TabStop = true;
            this.radioButtonMulOwner.Text = "Multiple Owner";
            this.radioButtonMulOwner.UseVisualStyleBackColor = true;
            this.radioButtonMulOwner.CheckedChanged += new System.EventHandler(this.radioButtonMulOwner_CheckedChanged);
            // 
            // textBoxOwnerName
            // 
            this.textBoxOwnerName.Location = new System.Drawing.Point(234, 106);
            this.textBoxOwnerName.Name = "textBoxOwnerName";
            this.textBoxOwnerName.Size = new System.Drawing.Size(185, 23);
            this.textBoxOwnerName.TabIndex = 5;
            this.textBoxOwnerName.Visible = false;
            // 
            // labelOwnerNID
            // 
            this.labelOwnerNID.AutoSize = true;
            this.labelOwnerNID.Location = new System.Drawing.Point(425, 108);
            this.labelOwnerNID.Name = "labelOwnerNID";
            this.labelOwnerNID.Size = new System.Drawing.Size(71, 15);
            this.labelOwnerNID.TabIndex = 6;
            this.labelOwnerNID.Text = "Owner NID :";
            this.labelOwnerNID.Visible = false;
            // 
            // textBoxOwnerNID
            // 
            this.textBoxOwnerNID.Location = new System.Drawing.Point(502, 105);
            this.textBoxOwnerNID.Name = "textBoxOwnerNID";
            this.textBoxOwnerNID.Size = new System.Drawing.Size(185, 23);
            this.textBoxOwnerNID.TabIndex = 7;
            this.textBoxOwnerNID.Visible = false;
            // 
            // textBoxRoadNo
            // 
            this.textBoxRoadNo.Location = new System.Drawing.Point(118, 211);
            this.textBoxRoadNo.Name = "textBoxRoadNo";
            this.textBoxRoadNo.Size = new System.Drawing.Size(185, 23);
            this.textBoxRoadNo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Institute Address :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Road No :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Area :";
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(118, 240);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(185, 23);
            this.textBoxArea.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "City :";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(118, 269);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(185, 23);
            this.textBoxCity.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Board :";
            // 
            // textBoxBoard
            // 
            this.textBoxBoard.Location = new System.Drawing.Point(118, 298);
            this.textBoxBoard.Name = "textBoxBoard";
            this.textBoxBoard.Size = new System.Drawing.Size(185, 23);
            this.textBoxBoard.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NewInstitute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxBoard);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxRoadNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxOwnerNID);
            this.Controls.Add(this.labelOwnerNID);
            this.Controls.Add(this.textBoxOwnerName);
            this.Controls.Add(this.radioButtonMulOwner);
            this.Controls.Add(this.radioButtonSinOwner);
            this.Controls.Add(this.labelOwnerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewInstitute";
            this.Text = "NewInstitute";
            this.Load += new System.EventHandler(this.NewInstitute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labelOwnerName;
        private RadioButton radioButtonSinOwner;
        private RadioButton radioButtonMulOwner;
        private TextBox textBoxOwnerName;
        private Label labelOwnerNID;
        private TextBox textBoxOwnerNID;
        private TextBox textBoxRoadNo;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxArea;
        private Label label8;
        private TextBox textBoxCity;
        private Label label9;
        private TextBox textBoxBoard;
        private Button button1;
        private Button button2;
    }
}