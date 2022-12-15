namespace Govt_Management
{
    partial class BoardAndInstitute
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
            this.labelBiName = new System.Windows.Forms.Label();
            this.labelBiArea = new System.Windows.Forms.Label();
            this.labelBiStudentSeat = new System.Windows.Forms.Label();
            this.labelBiDepartment = new System.Windows.Forms.Label();
            this.comboBoxBoardList = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Board : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Institution List : ";
            // 
            // labelBiName
            // 
            this.labelBiName.AutoSize = true;
            this.labelBiName.Location = new System.Drawing.Point(45, 125);
            this.labelBiName.Name = "labelBiName";
            this.labelBiName.Size = new System.Drawing.Size(48, 15);
            this.labelBiName.TabIndex = 2;
            this.labelBiName.Text = "Name : ";
            this.labelBiName.Visible = false;
            // 
            // labelBiArea
            // 
            this.labelBiArea.AutoSize = true;
            this.labelBiArea.Location = new System.Drawing.Point(213, 125);
            this.labelBiArea.Name = "labelBiArea";
            this.labelBiArea.Size = new System.Drawing.Size(40, 15);
            this.labelBiArea.TabIndex = 3;
            this.labelBiArea.Text = "Area : ";
            this.labelBiArea.Visible = false;
            // 
            // labelBiStudentSeat
            // 
            this.labelBiStudentSeat.AutoSize = true;
            this.labelBiStudentSeat.Location = new System.Drawing.Point(365, 125);
            this.labelBiStudentSeat.Name = "labelBiStudentSeat";
            this.labelBiStudentSeat.Size = new System.Drawing.Size(82, 15);
            this.labelBiStudentSeat.TabIndex = 4;
            this.labelBiStudentSeat.Text = "Student Seat : ";
            this.labelBiStudentSeat.Visible = false;
            // 
            // labelBiDepartment
            // 
            this.labelBiDepartment.AutoSize = true;
            this.labelBiDepartment.Location = new System.Drawing.Point(527, 125);
            this.labelBiDepartment.Name = "labelBiDepartment";
            this.labelBiDepartment.Size = new System.Drawing.Size(84, 15);
            this.labelBiDepartment.TabIndex = 5;
            this.labelBiDepartment.Text = "Departments : ";
            this.labelBiDepartment.Visible = false;
            // 
            // comboBoxBoardList
            // 
            this.comboBoxBoardList.FormattingEnabled = true;
            this.comboBoxBoardList.Items.AddRange(new object[] {
            "Barisal",
            "Chittagong",
            "Cumilla",
            "Dhaka",
            "Dinajpur",
            "Jessore",
            "Mymensingh",
            "Rajshahi",
            "Sylhet"});
            this.comboBoxBoardList.Location = new System.Drawing.Point(99, 31);
            this.comboBoxBoardList.Name = "comboBoxBoardList";
            this.comboBoxBoardList.Size = new System.Drawing.Size(121, 23);
            this.comboBoxBoardList.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Location = new System.Drawing.Point(12, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 282);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(690, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Status : ";
            this.label3.Visible = false;
            // 
            // BoardAndInstitute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxBoardList);
            this.Controls.Add(this.labelBiDepartment);
            this.Controls.Add(this.labelBiStudentSeat);
            this.Controls.Add(this.labelBiArea);
            this.Controls.Add(this.labelBiName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BoardAndInstitute";
            this.Text = "BoardAndInstitute";
            this.Load += new System.EventHandler(this.BoardAndInstitute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labelBiName;
        private Label labelBiArea;
        private Label labelBiStudentSeat;
        private Label labelBiDepartment;
        private ComboBox comboBoxBoardList;
        private Panel panel1;
        private Button button1;
        private Label label3;
    }
}