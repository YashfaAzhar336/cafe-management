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
    public partial class Delete_Account : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=IM-SHAHAB\SQLEXPRESS;Initial Catalog=Cafe_Project;Integrated Security = True");
        public Delete_Account()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Update_Account update = new Update_Account();
            this.Hide();
            update.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            User_Dashboard home = new User_Dashboard();
            this.Hide();
            home.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        void loadcnic()
        {
            con.Open();
            string quer = "select Top(1) cnic from login order by id desc";
            SqlCommand cmd = new SqlCommand(quer,con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                tbcnic.Text=rdr.GetValue(0).ToString();
            }
            con.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete account?", "Confirmation", MessageBoxButtons.YesNo,
        MessageBoxIcon.Information);
            if (tbcnic.Text == "")
            {
                MessageBox.Show("Please Enter CNIC");
            }
            else
            {
                if (dr == DialogResult.Yes)
                {

                    con.Open();
                    String query = "Delete from signup_table where signup_cnic = '" + tbcnic.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    int Result = cmd.ExecuteNonQuery();
                    if (Result > 0)
                    {
                        MessageBox.Show("Account Deleted Successfully");
                        login lg = new login();
                        this.Hide();
                        lg.Show();
                        tbcnic.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No Account Found");
                        tbcnic.Clear();
                    }
                    con.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Place_Order order= new Place_Order();
            this.Hide();
            order.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            login lgin = new login();
            this.Hide();
            lgin.Show();
        }

        private void delete_user_account_Load(object sender, EventArgs e)
        {
            loadcnic();
            tbcnic.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_history_order his = new User_history_order();
            this.Hide();
            his.Show();
        }
    }
}
