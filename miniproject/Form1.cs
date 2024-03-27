using System.Diagnostics.Eventing.Reader;

namespace miniproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String username = txtusername.Text;
            string password = txtpassword.Text;

            if (username == "student" && password == "student")
            {
                menuStrip1.Visible = true;
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("invalid userid or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Admission na = new New_Admission();
            na.Show();
        }

        private void upgradeSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Upgradesemester us = new Upgradesemester();
            us.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fees fs = new Fees();
            fs.Show();



        }

        private void searchStudeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Searchstudent ss = new Searchstudent();
            ss.Show();

        }

        private void individualDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentindividualdetail sid = new studentindividualdetail();
            sid.Show();
        }

        private void addTeacherInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addteacher at = new Addteacher();
            at.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherSearch ts = new TeacherSearch();
            ts.Show();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveStudent rs = new RemoveStudent();
            rs.Show();

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            au.Show();
        }

        private void exitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure ? This Will Delete Your Unsaved Data", "Confirmation  Daialog!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) ;
            {
                Application.Exit();

            }
        }
    }
}
