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
    public partial class SignUp : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=IM-SHAHAB\SQLEXPRESS;Initial Catalog=Cafe_Project;Integrated Security=True");
        string value="";

        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbname.Text == "" || tccontact.Text == "" || tbcnic.Text == "" || tbpassword.Text == "" || tbconfirmpassword.Text == "" || tbusername.Text == "" || value == "")
            {
                MessageBox.Show("Please fill all Information");
            }
            else
            {
                con.Open();
                SqlCommand cd = new SqlCommand("Select signup_cnic from signup_table where signup_cnic='" + tbcnic.Text + "'", con);
                SqlDataAdapter adp = new SqlDataAdapter(cd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    DialogResult answer = MessageBox.Show("CNIC already registered", "Notification", MessageBoxButtons.OKCancel);
                    if (answer == DialogResult.OK)
                    {
                        tbcnic.Clear();
                    }
                }
                else
                {
                    if (tbpassword.Text == tbconfirmpassword.Text)
                    {
                        String query = "insert into signup_table values ('" + tbusername.Text + "','" + tbpassword.Text + "','" + tbname.Text + "','" + tccontact.Text + "','" + tbcnic.Text + "','" + value + "','" + dtpdob.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        int result = cmd.ExecuteNonQuery();



                        if (result > 0)
                        {
                            MessageBox.Show("Your Account is created successfully!!! Now ypu can login ");
                            tbname.Clear();
                            tbusername.Clear();
                            tbpassword.Clear();
                            tbconfirmpassword.Clear();
                            tccontact.Clear();
                            tbcnic.Clear();
                            rdfemale.Checked = false;
                            rdmale.Checked = false;
                            
                        }
                        else
                        {
                            MessageBox.Show("Not Inserted");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password & Confirm Password not matched");
                       
                        tbconfirmpassword.Clear();
                    }
                    con.Close();
                }
              

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void rdmale_CheckedChanged(object sender, EventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login lgin = new login();
            this.Hide();
            lgin.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbpassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbpassword.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                tbconfirmpassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbconfirmpassword.UseSystemPasswordChar = true;
            }
        } }
    }
    

