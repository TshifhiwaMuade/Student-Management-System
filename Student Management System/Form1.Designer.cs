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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtStudentId = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.Label();
            this.TxtAge = new System.Windows.Forms.Label();
            this.TxtCourse = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnViewStudents = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTotalStudents = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAverageAge = new System.Windows.Forms.TextBox();
            this.BtnGenerateReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 22);
            this.textBox1.TabIndex = 0;
            // 
            // TxtStudentId
            // 
            this.TxtStudentId.AutoSize = true;
            this.TxtStudentId.Location = new System.Drawing.Point(12, 33);
            this.TxtStudentId.Name = "TxtStudentId";
            this.TxtStudentId.Size = new System.Drawing.Size(68, 16);
            this.TxtStudentId.TabIndex = 1;
            this.TxtStudentId.Text = "Student ID";
            // 
            // TxtName
            // 
            this.TxtName.AutoSize = true;
            this.TxtName.Location = new System.Drawing.Point(16, 80);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(44, 16);
            this.TxtName.TabIndex = 2;
            this.TxtName.Text = "Name";
            // 
            // TxtAge
            // 
            this.TxtAge.AutoSize = true;
            this.TxtAge.Location = new System.Drawing.Point(16, 127);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(32, 16);
            this.TxtAge.TabIndex = 3;
            this.TxtAge.Text = "Age";
            // 
            // TxtCourse
            // 
            this.TxtCourse.AutoSize = true;
            this.TxtCourse.Location = new System.Drawing.Point(16, 178);
            this.TxtCourse.Name = "TxtCourse";
            this.TxtCourse.Size = new System.Drawing.Size(50, 16);
            this.TxtCourse.TabIndex = 4;
            this.TxtCourse.Text = "Course";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(154, 79);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(156, 127);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(113, 22);
            this.textBox4.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(154, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 24);
            this.comboBox1.TabIndex = 8;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(348, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(327, 307);
            this.dataGridView1.TabIndex = 13;
            // 
            // BtnViewStudents
            // 
            this.BtnViewStudents.Location = new System.Drawing.Point(440, -1);
            this.BtnViewStudents.Name = "BtnViewStudents";
            this.BtnViewStudents.Size = new System.Drawing.Size(147, 29);
            this.BtnViewStudents.TabIndex = 14;
            this.BtnViewStudents.Text = "View Students";
            this.BtnViewStudents.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 450);
            this.Controls.Add(this.BtnGenerateReport);
            this.Controls.Add(this.TxtAverageAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTotalStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnViewStudents);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.TxtCourse);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtStudentId);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TxtStudentId;
        private System.Windows.Forms.Label TxtName;
        private System.Windows.Forms.Label TxtAge;
        private System.Windows.Forms.Label TxtCourse;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnViewStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTotalStudents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAverageAge;
        private System.Windows.Forms.Button BtnGenerateReport;
    }
}

