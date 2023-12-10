using ccms.Data;
using Microsoft.Data.SqlClient;
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
    public partial class addForm : MetroFramework.Forms.MetroForm
    {
        public addForm()
        {
            InitializeComponent();
        }

        private void addForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppDBContext db = new AppDBContext();
            In_students s1 = new In_students()
            {
                in_student_name = txt_name.Text,
                in_student_id = txt_id.Text,
                in_time = txt_time.Text,
                //std_level = (level)box_lvl.SelectedIndex
            };
            History h = new History()
            {
                student_id = txt_id.Text,
                time_in = txt_time.Text,
                date = DateTime.Now,
                cost = 0,
                time_out = "",
                employee_id = "E001"
            };


            db.Database.EnsureCreated();
                db.Students.Add(s1);
                db.History_table.Add(h);
                db.SaveChanges();
                MessageBox.Show("Student added successfully!");
                txt_id.Clear();
                txt_name.Clear();
                txt_time.Clear();
            
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
            this.Close();
        }
    }
}
