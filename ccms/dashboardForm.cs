using ccms.Data;
using Microsoft.EntityFrameworkCore;
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
    public partial class dashboardForm : MetroFramework.Forms.MetroForm
    {
        DataGridView dataGridViewStudents = new DataGridView();
        public dashboardForm()
        {
            InitializeComponent();
        }

        private void LoadStudents()
        {
            using (AppDBContext dbContext = new AppDBContext())
            {
                // Assuming Students is a DbSet or property in AppDBContext
                var students = dbContext.Students.ToList();

                // Bind the students list to the DataGridView control
                dataGridViewStudents.DataSource = students;

                // Add the DataGridView control to the form or a container (e.g., panel1)
                Controls.Add(dataGridViewStudents);
                dataGridViewStudents.Columns["in_student_id"].Width = 100;
                dataGridViewStudents.Columns["in_time"].Width = 100;
                dataGridViewStudents.Columns["in_student_name"].Width = 300;
                /*
                foreach (DataGridViewColumn column in dataGridViewStudents.Columns)
                {
                  column.Width = 200;
                }
                */
                dataGridViewStudents.Location = new Point(20, 65);
                dataGridViewStudents.Width = 540;  // Set the desired width in pixels
                dataGridViewStudents.Height = 300; // Set the desired height in pixels
            }
        }
        private void dashboardForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main mm = new main();
            mm.Show();
            this.Close();
        }

    }
}
