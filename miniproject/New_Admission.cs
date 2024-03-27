using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Reflection;
using System.Xml.Linq;



namespace miniproject
{
    public partial class New_Admission : Form
    {
        public New_Admission()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string name = txtfullname.Text;
            string mname = txtmothername.Text;
            string gender = "";
            bool isChecked = radioButtonmale.Checked;
            if (isChecked)
            {
                gender = radioButtonmale.Text;
            }
            else
            {
                gender = radioButtonfemaie.Text;
            }
            string dob = dateTimePickerdob.Text;
            Int64 mobile = Int64.Parse(txtmobileno.Text);
            string email = txtemailid.Text;
            string semester = txtsem.Text;
            string program = txtprogram.Text;
            string sname = txtschoolname.Text;
            string duration = txtduration.Text;
            string add = txtaddress.Text;

            SqlConnection con = new SqlConnection();

            con.ConnectionString = "Data Source =  DESKTOP-S04APTF\\SQLEXPRESS;Initial Catalog=college;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewAdmission1 (fname,mname,gender,dob,mobile,email,semester,prog,sname,duration,addres) Values('" + name + "','" + mname + "','" + gender + "','" + dob + "'," + mobile + ",'" + email + "','" + semester + "','" + program + "','" + sname + "','" + duration + "','" + add + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();
            MessageBox.Show("Data Saved.Remeber the Registration ID", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);


        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtfullname.Clear();
            txtaddress.Clear();
            txtmothername.Clear();
            radioButtonfemaie.Checked = false;
            radioButtonmale.Checked = false;
            txtmobileno.Clear();
            txtemailid.Clear();
            txtprogram.ResetText();
            txtsem.ResetText();
            txtschoolname.Clear();
            txtduration.ResetText();
        }

        private void New_Admission_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "Data Source =  DESKTOP-S04APTF\\SQLEXPRESS;Initial Catalog=college;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select max(NAID) from NewAdmission1";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            Int64 abc = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
            label13.Text = (abc + 1).ToString(); //bodmas 


        }

       
    }

}
