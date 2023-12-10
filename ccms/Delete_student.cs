using ccms.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccms
{
    public partial class Delete_student : MetroFramework.Forms.MetroForm
    {
        public Delete_student()
        {
            InitializeComponent();
        }

        private void Delete_student_Load(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string studentIdToDelete = txt_idd.Text.Trim();

            // Validate if the input is not empty
            if (!string.IsNullOrEmpty(studentIdToDelete))
            {
                // Open a new database context
                using (AppDBContext dbContext = new AppDBContext())
                {
                    // Find the student in the 'In_students' table based on 'in_student_id'
                    var studentToDelete = dbContext.Students.FirstOrDefault(student => student.in_student_id == studentIdToDelete);

                    // Check if the student exists
                    if (studentToDelete != null)
                    {
                        // Remove the student from the 'In_students' table
                        dbContext.Students.Remove(studentToDelete);

                        // Save changes to the database
                        dbContext.SaveChanges();

                        // Display a success message or perform any additional actions
                        MessageBox.Show("Student deleted successfully.", "Success");
                        txt_idd.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Student not found in the database.", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a student ID.", "Input Error");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            main mmm = new main();
            mmm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
