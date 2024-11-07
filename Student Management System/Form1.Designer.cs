namespace Student_Management_System
{
    partial class Form1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.TxtCourse = new System.Windows.Forms.ComboBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.DGVliststudent = new System.Windows.Forms.DataGridView();
            this.BtnViewStudents = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTotalStudents = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAverageAge = new System.Windows.Forms.TextBox();
            this.BtnGenerateReport = new System.Windows.Forms.Button();
            this.TxtStudentId = new System.Windows.Forms.TextBox();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVliststudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 33);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(68, 16);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Student ID";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(16, 80);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(44, 16);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(16, 127);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 16);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(16, 178);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(50, 16);
            this.lblCourse.TabIndex = 4;
            this.lblCourse.Text = "Course";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(154, 79);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(116, 22);
            this.TxtName.TabIndex = 6;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(156, 127);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(113, 22);
            this.TxtAge.TabIndex = 7;
            this.TxtAge.TextChanged += new System.EventHandler(this.TxtAge_TextChanged);
            // 
            // TxtCourse
            // 
            this.TxtCourse.FormattingEnabled = true;
            this.TxtCourse.Location = new System.Drawing.Point(154, 176);
            this.TxtCourse.Name = "TxtCourse";
            this.TxtCourse.Size = new System.Drawing.Size(116, 24);
            this.TxtCourse.TabIndex = 8;
            this.TxtCourse.SelectedIndexChanged += new System.EventHandler(this.TxtCourse_SelectedIndexChanged);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(14, 240);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(111, 38);
            this.BtnUpdate.TabIndex = 9;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(173, 240);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(118, 37);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(15, 307);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(109, 31);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(173, 307);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(117, 30);
            this.BtnExit.TabIndex = 12;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // DGVliststudent
            // 
            this.DGVliststudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVliststudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName,
            this.Age,
            this.Course});
            this.DGVliststudent.Location = new System.Drawing.Point(348, 30);
            this.DGVliststudent.Name = "DGVliststudent";
            this.DGVliststudent.RowHeadersWidth = 51;
            this.DGVliststudent.RowTemplate.Height = 24;
            this.DGVliststudent.Size = new System.Drawing.Size(327, 307);
            this.DGVliststudent.TabIndex = 13;
            this.DGVliststudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVliststudent_CellContentClick);
            // 
            // BtnViewStudents
            // 
            this.BtnViewStudents.Location = new System.Drawing.Point(440, -1);
            this.BtnViewStudents.Name = "BtnViewStudents";
            this.BtnViewStudents.Size = new System.Drawing.Size(147, 29);
            this.BtnViewStudents.TabIndex = 14;
            this.BtnViewStudents.Text = "View Students";
            this.BtnViewStudents.UseVisualStyleBackColor = true;
            this.BtnViewStudents.Click += new System.EventHandler(this.BtnViewStudents_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(688, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total Students";
            // 
            // TxtTotalStudents
            // 
            this.TxtTotalStudents.Location = new System.Drawing.Point(808, 44);
            this.TxtTotalStudents.Name = "TxtTotalStudents";
            this.TxtTotalStudents.Size = new System.Drawing.Size(101, 22);
            this.TxtTotalStudents.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(693, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Average Age";
            // 
            // TxtAverageAge
            // 
            this.TxtAverageAge.Location = new System.Drawing.Point(808, 96);
            this.TxtAverageAge.Name = "TxtAverageAge";
            this.TxtAverageAge.Size = new System.Drawing.Size(100, 22);
            this.TxtAverageAge.TabIndex = 18;
            // 
            // BtnGenerateReport
            // 
            this.BtnGenerateReport.Location = new System.Drawing.Point(720, 204);
            this.BtnGenerateReport.Name = "BtnGenerateReport";
            this.BtnGenerateReport.Size = new System.Drawing.Size(161, 36);
            this.BtnGenerateReport.TabIndex = 19;
            this.BtnGenerateReport.Text = "Generate Report";
            this.BtnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // TxtStudentId
            // 
            this.TxtStudentId.Location = new System.Drawing.Point(156, 38);
            this.TxtStudentId.Name = "TxtStudentId";
            this.TxtStudentId.Size = new System.Drawing.Size(112, 22);
            this.TxtStudentId.TabIndex = 20;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            this.StudentID.Width = 125;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Name";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 125;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.Width = 125;
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.MinimumWidth = 6;
            this.Course.Name = "Course";
            this.Course.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 450);
            this.Controls.Add(this.TxtStudentId);
            this.Controls.Add(this.BtnGenerateReport);
            this.Controls.Add(this.TxtAverageAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTotalStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnViewStudents);
            this.Controls.Add(this.DGVliststudent);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.TxtCourse);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVliststudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.ComboBox TxtCourse;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.DataGridView DGVliststudent;
        private System.Windows.Forms.Button BtnViewStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTotalStudents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAverageAge;
        private System.Windows.Forms.Button BtnGenerateReport;
        private System.Windows.Forms.TextBox TxtStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
    }
}

