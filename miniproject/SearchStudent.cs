using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniproject
{
    public partial class Searchstudent : Form
    {
        public Searchstudent()
        {
            InitializeComponent();
        }

        private void Searchstudent_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source =  DESKTOP-S04APTF\\SQLEXPRESS;Initial Catalog=college;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select NewAdmission1.NAID as Student_ID,NewAdmission1.fname as Full_Name,NewAdmission1.mname as Mother_Name,NewAdmission1.gender as Gender,NewAdmission1.dob as Date_Of_Birth,NewAdmission1.mobile as Mobile,NewAdmission1.email as Email_ID,NewAdmission1.semester as Semester,NewAdmission1.prog as Programming_Language,NewAdmission1.sname asSchool_Name,NewAdmission1.duration as Course_Duration,NewAdmission1.addres as Address,fees.fees as Fees from NewAdmission1 inner join fees on NewAdmission1.NAID=fees.NAID";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source =  DESKTOP-S04APTF\\SQLEXPRESS;Initial Catalog=college;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select *from NewAdmission1 where NAID=" + textBox1.Text + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
