using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using System.Data;

namespace Student_Management_System
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Glory Binkatabana\Documents\PRG 282 Project\Student Management System\Student Details.txt";


            // Check if the file is empty or does not exist, then add headers
            bool isFileEmpty = new FileInfo(path).Length == 0;

            using (FileStream mystream = new FileStream(path, FileMode.Append))
            using (StreamWriter sw = new StreamWriter(mystream))
            {
                // Add headers if the file is empty
                if (isFileEmpty)
                {
                    
                    sw.WriteLine("Student ID, Name, Age, Course");
                }

                // Append student data in a new line
                sw.WriteLine($"{TxtStudentId.Text}, {TxtName.Text}, {TxtAge.Text}, {TxtCourse.Text}");
            }

            MessageBox.Show("Task completed");
        }

       

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

         private void BtnViewStudents_Click(object sender, EventArgs e)
         {
             string path = @"C:\Users\Glory Binkatabana\Documents\PRG 282 Project\Student Management System\Student Details.txt";

             // Clear existing rows in the DataGridView
             DGVliststudent.Rows.Clear();

             // Ensure file exists before attempting to read
             if (File.Exists(path))
             {
                 using (StreamReader sr = new StreamReader(path))
                 {
                     string line; 

                     sr.ReadLine(); // so it can skip the first line in the txt file

                     while ((line = sr.ReadLine()) != null)
                     {
                         // Split the line by commas to get individual fields
                         string[] values = line.Split(',');

                         // Add the values as a new row in the DataGridView
                         DGVliststudent.Rows.Add(values);
                       
                     }
                 }
             }
             else
             {
                 MessageBox.Show("The file does not exist.");
             }
         }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DGVliststudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DGVliststudent.Rows[e.RowIndex];
            TxtStudentId.Text = row.Cells[0].Value.ToString();
            TxtName.Text = row.Cells[1].Value.ToString();
            TxtAge.Text = row.Cells[2].Value.ToString();
            TxtCourse.Text = row.Cells[3].Value.ToString();
        }

        private void TxtTotalStudents_TextChanged(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Glory Binkatabana\Documents\PRG 282 Project\Student Management System\Student Details.txt";
            int lineCount = File.ReadAllLines(filePath).Length - 1;
            TxtTotalStudents.Text = lineCount.ToString();
            
        }



        private void BtnCount_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Glory Binkatabana\Documents\PRG 282 Project\Student Management System\Student Details.txt";
            int lineCount = File.ReadAllLines(filePath).Length - 1;
            TxtTotalStudents.Text = lineCount.ToString();

        }
    }
}
