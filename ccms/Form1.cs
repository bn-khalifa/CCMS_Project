using ccms.Data;

namespace ccms
{
    public partial class main : MetroFramework.Forms.MetroForm
    {
        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_dbconn_Click(object sender, EventArgs e)
        {
            AppDBContext db = new AppDBContext();
            if (db.Database.EnsureCreated())
                MessageBox.Show("Database is created");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addForm a = new addForm();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dashboardForm d = new dashboardForm();
            d.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete_student dd = new Delete_student();
            dd.Show();
            this.Hide();
        }
    }
}
