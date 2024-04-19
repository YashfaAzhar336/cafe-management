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
    public partial class User_history_order : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=IM-SHAHAB\SQLEXPRESS;Initial Catalog=Cafe_Project;Integrated Security=True");

        public User_history_order()
        {
            InitializeComponent();
        }
        String cnic;
        void loadcnic()
        {
            con.Open();
            string quer = "select Top(1) cnic from login order by id desc";
            SqlCommand cmd = new SqlCommand(quer, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                cnic= rdr.GetValue(0).ToString();
                

            }
            con.Close();
        }
        void loadhistory()
        {
            con.Open();
            
            String qury = "Select Name as 'Name',contact as'Contact',fname as'Food Name', quantity as 'Quantity',price as 'Product Price',date as 'Date' from orders_table where cnic = '"+cnic+"'";
            SqlCommand cmd = new SqlCommand(qury, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();

        }
        private void User_history_order_Load(object sender, EventArgs e)
        {
            loadcnic();
            loadhistory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Place_Order or = new Place_Order();
            this.Hide();
            or.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Update_Account up = new Update_Account    ();
            this.Hide();
            up.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Delete_Account del = new Delete_Account();
            this.Hide();
            del.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            login lg = new login();
            this.Hide();
            lg.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            User_Dashboard home = new User_Dashboard();
            this.Hide();
            home.Show();
        }
    }
}
