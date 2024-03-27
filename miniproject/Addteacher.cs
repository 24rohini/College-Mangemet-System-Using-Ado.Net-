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
    public partial class Addteacher : Form
    {
        public Addteacher()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            string gender = "";
            bool isChecked = radioButtonmale.Checked;

            if(isChecked)
            {
                gender = radioButtonmale.Text;
            }
            else
            {
                gender = radioButtonfemale.Text;
            }


            SqlConnection con = new SqlConnection();
            con.ConnectionString= "Data Source =  DESKTOP-S04APTF\\SQLEXPRESS;Initial Catalog=college;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into teacher (fname,gender,dob,mobile,email,semester,prog,yer,adr)values ('"+txtfname.Text+ "','"+gender+ "','"+dob.Text+"',"+txtmobile.Text+ ",'"+txtemail.Text+ "','"+txtsem.Text+"','"+txtprogram.Text+ "','"+txtduration.Text+ "','"+txtaddress.Text+"')";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            MessageBox.Show("Data Saved.","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
