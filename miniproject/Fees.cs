using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniproject
{
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }

        private void txtregnumber_TextChanged(object sender, EventArgs e)
        {
            


            if (txtregnumber.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source =  DESKTOP-S04APTF\\SQLEXPRESS;Initial Catalog=college;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select fname,mname,duration from NewAdmission1 where NAID = " + txtregnumber.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                if (DS.Tables[0].Rows.Count != 0)   //if ragistr no is not avilble its not shown exception
                {

                    fnamelabel.Text = DS.Tables[0].Rows[0][0].ToString();  //for fill values in label when we enter ragister number
                    mnamelabel.Text = DS.Tables[0].Rows[0][1].ToString();
                    durationlabel.Text = DS.Tables[0].Rows[0][2].ToString();

                }
                else
                {
                    fnamelabel.Text = "___________";   //these clears value
                    mnamelabel.Text = "___________";
                    durationlabel.Text = "___________";
                }

            }
            else
            {
                txtregnumber.Text = "";
                txtregnumber.Text = "";
                fnamelabel.Text = "___________";   //these clears value
                mnamelabel.Text = "___________";
                durationlabel.Text = "___________";

            }
            

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source =  DESKTOP-S04APTF\\SQLEXPRESS;Initial Catalog=college;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select *from fees where NAID =" + txtregnumber.Text + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            if (DS.Tables[0].Rows.Count == 0)
            {
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "Data Source =  DESKTOP-S04APTF\\SQLEXPRESS;Initial Catalog=college;Integrated Security=True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;

                cmd1.CommandText = "insert into fees (NAID,fees)values(" + txtregnumber.Text + "," + txtfees.Text + ")";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd1);
                DataSet DS1 = new DataSet();
                DA1.Fill(DS1);

                if (MessageBox.Show("Fees Sumbition Successfull.", "success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    txtregnumber.Text = "";
                    txtfees.Text = "";
                    fnamelabel.Text = "___________";   //these clears value
                    mnamelabel.Text = "___________";
                    durationlabel.Text = "___________";
                }
            }
            else
            {
                MessageBox.Show("Fees is Allready Sumbitted.");
                txtregnumber.Text = "";
                txtfees.Text = "";
                fnamelabel.Text = "___________";   //these clears value
                mnamelabel.Text = "___________";
                durationlabel.Text = "___________";

            }
           
        }
    }
}
