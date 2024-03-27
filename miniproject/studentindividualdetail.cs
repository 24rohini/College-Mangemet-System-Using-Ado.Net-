using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniproject
{
    public partial class studentindividualdetail : Form
    {
        public studentindividualdetail()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelfname.Text = "___________";
            labelmname.Text = "___________";
            labelgender.Text = "___________";    //foreset all
            labeldob.Text = "___________";
            labelmobile.Text = "___________";
            labelemail.Text = "___________";
            labelstandard.Text = "___________";
            labelmedium.Text = "___________";
            labelschool.Text = "___________";
            labelyear.Text = "___________";
            labeladdress.Text = "___________";

            textBox1.Text = "";

        }

        private void btnshowdetails_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString= "Data Source =  DESKTOP-S04APTF\\SQLEXPRESS;Initial Catalog=college;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewAdmission1 where NAID=" + textBox1.Text + "";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0) //jar apn 100 takla tr exception yein karn data save nasel mg tya sathi condition lihli ahe
            {

                labelfname.Text = ds.Tables[0].Rows[0][1].ToString();
                labelmname.Text = ds.Tables[0].Rows[0][2].ToString();
                labelgender.Text = ds.Tables[0].Rows[0][3].ToString();
                labeldob.Text = ds.Tables[0].Rows[0][4].ToString();
                labelmobile.Text = ds.Tables[0].Rows[0][5].ToString();
                labelemail.Text = ds.Tables[0].Rows[0][6].ToString();
                labelstandard.Text = ds.Tables[0].Rows[0][7].ToString();
                labelmedium.Text = ds.Tables[0].Rows[0][8].ToString();
                labelschool.Text = ds.Tables[0].Rows[0][9].ToString();
                labelyear.Text = ds.Tables[0].Rows[0][10].ToString();
                labeladdress.Text = ds.Tables[0].Rows[0][11].ToString();

            }
            else
            {
                MessageBox.Show("No Record Found", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);

                labelfname.Text = "___________";
                labelmname.Text = "___________";
                labelgender.Text = "___________";    //foreset all
                labeldob.Text = "___________";
                labelmobile.Text = "___________";
                labelemail.Text = "___________";
                labelstandard.Text = "___________";
                labelmedium.Text = "___________";
                labelschool.Text = "___________";
                labelyear.Text = "___________";
                labeladdress.Text = "___________";

            }

        }
    }
}
