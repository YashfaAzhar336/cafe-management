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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cafe_project_semester_5
{
    public partial class Update_Account : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=IM-SHAHAB\SQLEXPRESS;Initial Catalog=Cafe_Project;Integrated Security=True");
        string value;
        string value2;
        login  lgin = new login();
        public Update_Account()
        {
            InitializeComponent();
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            Delete_Account delete = new Delete_Account();
            this.Hide();
            delete.Show();

        }
        void loadcnic()
        {
            con.Open();
            string quer = "select Top(1) cnic from login order by id desc";
            SqlCommand cmd = new SqlCommand(quer, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                tbcnic.Text = rdr.GetValue(0).ToString();
            }
            con.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_history_order his = new User_history_order();
            this.Hide();
            his.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Place_Order order = new Place_Order();
            this.Hide();
            order.Show();

        }
        void alldatafromdatabase()
        {
            string qry = "Select *from signup_table where signup_cnic='" +tbcnic.Text + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader readerfromdatabase = cmd.ExecuteReader();
            if (readerfromdatabase.HasRows)
            {
                while (readerfromdatabase.Read())
                {
                    tbname.Text = readerfromdatabase["signup_name"].ToString();
                    tccontact.Text = readerfromdatabase["sigup_contact"].ToString();
                    tbpassword.Text =readerfromdatabase["signup_password"].ToString();
                    tbconfirmpassword.Text = readerfromdatabase["signup_password"].ToString();
                    tbusername.Text = readerfromdatabase["signup_username"].ToString();
                    dtpdob.Text = readerfromdatabase["signup_dob"].ToString();
                   value2 = readerfromdatabase["signup_gender"].ToString();
                    if (value2 == "Male")
                    {
                        rdmale.Checked = true;
                    }
                    else
                    {
                        rdfemale.Checked = true;
                    }




                }
            }
            else
            {
                MessageBox.Show("No Data");
            }
        con.Close();

    }

    private void User_dashboard_Load(object sender, EventArgs e)
        {
            loadcnic();
            tbcnic.Enabled = false;
            alldatafromdatabase();
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            User_Dashboard home = new User_Dashboard();
            this.Hide();
            home.Show();
        }

        private void btnupdateuser_Click(object sender, EventArgs e)
        {
           
           

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                if (tbpassword.Text == tbconfirmpassword.Text)
                {
                DialogResult dr = MessageBox.Show("Are you sure to update your record?", "Confirmation", MessageBoxButtons.YesNo,
       MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    string qry = "Update signup_table set signup_name = '" + tbname.Text +
                "',sigup_contact = '" + tccontact.Text +
                "',signup_password = '" + tbpassword.Text + "',signup_username = '" +
                tbusername.Text + "',signup_gender = '" + value + "',signup_dob = '" +
                 dtpdob.Text +
                "' where signup_cnic ='" + tbcnic.Text + "'";

                    SqlCommand cmd = new SqlCommand(qry, con);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Updated Successfully");
                        tbcnic.Clear();
                        tbname.Clear();
                        tbconfirmpassword.Clear();
                        tbpassword.Clear();
                        tbusername.Clear();
                        rdfemale.Checked = false;
                        rdmale.Checked = false;
                        dtpdob.CustomFormat=null; 
                        tccontact.Clear();
                        
                    }
                    else
                    {
                        MessageBox.Show("No Account Found");
                    }
                }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Password and confirm password does not matched");
                    tbconfirmpassword.Clear();
                }
            
        }
        private void rdmale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdmale.Checked){
                value = "Male";
            }
            if(rdfemale.Checked){
                value = "Female";
            }
        }

        private void rdfemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdmale.Checked)
            {
                value = "Male";
            }
            if (rdfemale.Checked)
            {
                value = "Female";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            login home = new login();
            this.Hide();
            home.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            {
                tbpassword.UseSystemPasswordChar= false;
            }
            else
            {
                tbpassword.UseSystemPasswordChar= true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbconfirmpassword.UseSystemPasswordChar= false;
            }
            else
            {
                tbconfirmpassword.UseSystemPasswordChar= true;
            }
        }
    }
}
