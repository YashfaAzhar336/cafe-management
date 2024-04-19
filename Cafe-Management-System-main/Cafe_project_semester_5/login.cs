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

namespace Cafe_project_semester_5
{
    public partial class login : Form
    {
        
        String username = "Admin";
        String password = "cafe133";
        public String cnic;
        SqlConnection con = new SqlConnection(@"Data Source=IM-SHAHAB\SQLEXPRESS;Initial Catalog=Cafe_Project;Integrated Security=True");
        public login()
        {
            InitializeComponent();
        }
        void user()
        {
            if (tbcnic.Text == "" || tbpassword.Text =="")
            {
                MessageBox.Show("Please fill all information !!! ");
            }
            else
            {
                con.Open();
                String query = "select signup_cnic, signup_password from signup_table where signup_cnic= '" + tbcnic.Text + "' AND signup_password = '" + tbpassword.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    rd.Close();
                    string quer = "insert into login (cnic) values ('"+tbcnic.Text+"')";
                    SqlCommand dm= new SqlCommand(quer, con);
                    dm.ExecuteNonQuery();
                    User_Dashboard userdashboard = new User_Dashboard();
                    this.Hide();
                    userdashboard.Show();

                }
                else
                {
                    MessageBox.Show("Invalid CNIC & password");
                }

                con.Close();
            }
        }
        void Manager()
        {
            if (tbusername.Text == "" || tbpassword.Text == "")
            {
                MessageBox.Show("Please fill all information !!! ");
            }
            else
            {
                if (tbusername.Text == username && tbpassword.Text == password)
                {
                    Manager_Dashboard home_manager = new Manager_Dashboard();
                    this.Hide();
                    home_manager.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
        }
        void delete()
        {
            con.Open();
            string qry = "delete from cart";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            con.Close() ;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            delete();
            if (cbselectuser.SelectedIndex == 1)
            {
                tbcnic.Visible= true;
                label5.Visible= true;
                tbusername.Visible= false;
                label1.Visible= false;
                user();
            }
            else if(cbselectuser.SelectedIndex == 0)
            {
                label1.Visible= true;
                tbusername.Visible=true;
                Manager();
            }
            else
            {
                MessageBox.Show("Please Select User");
            }

        
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbselectuser.SelectedIndex == 1)
            {
                tbcnic.Visible = true;
                label5.Visible = true;
                tbusername.Visible = false;
                label1.Visible = false; 
            }
            if (cbselectuser.SelectedIndex == 0)
            {
                tbcnic.Visible = false;
                label5.Visible = false;
                tbusername.Visible = true;
                label1.Visible = true;
            }

        }

        private void login_Load(object sender, EventArgs e)
        {
            cbselectuser.Items.Add("Manager");
            cbselectuser.Items.Add("User");
            label1.BackColor=Color.Transparent;
            label2.BackColor=Color.Transparent;
            label3.BackColor = Color.Transparent;
            linkLabel1.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            tbusername.Visible = false;
            label1.Visible = false;
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signup = new SignUp();
            this.Hide();
            signup.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                tbpassword.UseSystemPasswordChar= false;
            }
            else
            {
                tbpassword.UseSystemPasswordChar= true;
            }
        }

        private void fgpasslink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
