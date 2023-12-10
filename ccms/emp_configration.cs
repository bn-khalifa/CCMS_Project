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
    public partial class emp_configration : MetroFramework.Forms.MetroForm
    {
        public emp_configration()
        {
            InitializeComponent();
        }

        private void emp_configration_Load(object sender, EventArgs e)
        {
            //EmployeesData.SeedEmployees();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pic_emp_photo.ImageLocation = dialog.FileName;
            }
        }

        private void btn_sign_in_Click(object sender, EventArgs e)
        {
            AppDBContext db = new AppDBContext();
            string email = txt_emp_email.Text, pass = txt_emp_pass.Text;
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(pass))
            {
                var emp = db.Employees.Where(e => e.emp_email == email && e.emp_password == pass).FirstOrDefault();
                if (emp != null)
                {
                    main m = new main();
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password or Email are incorrect.");
                }
            }
            else
            {
                MessageBox.Show("Empty Cell!");
            }

        }
    }
}
