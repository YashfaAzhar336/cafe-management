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
    public partial class View_Users : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=IM-SHAHAB\SQLEXPRESS;Initial Catalog=Cafe_Project;Integrated Security=True");

        public View_Users()
        {
            InitializeComponent();
        }
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void All_user_manager_Load(object sender, EventArgs e)
        {
         
            con.Open();
            String qury = "Select signup_name as 'Name',signup_cnic as'CNIC',sigup_contact as'Contact', signup_dob as 'DOB', signup_gender as 'Gender', signup_username as 'UserName'from signup_table";
            SqlCommand cmd = new SqlCommand(qury, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            login lgin = new login();
            this.Hide();
            lgin.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            String searcbyname = "select signup_name as 'Name',signup_cnic as'CNIC',sigup_contact as'Contact', signup_dob as 'DOB', signup_gender as 'Gender', signup_username as 'UserName' from signup_table where signup_name like '%" + textBox1.Text + "%'";
            SqlCommand cmd = new SqlCommand(searcbyname, con);
              SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dataTable= new DataTable();
            adp.Fill(dataTable);
            dataGridView1.DataSource=dataTable;
            con.Close();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adding_New_Items add = new Adding_New_Items();
            this.Hide();
            add.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Manager_Dashboard home = new Manager_Dashboard();
            this.Hide();
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_Order_History allhis = new View_Order_History();
            this.Hide();
            allhis.Show();
        }
    }
}
