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
    public partial class View_Order_History : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=IM-SHAHAB\SQLEXPRESS;Initial Catalog=Cafe_Project;Integrated Security=True");

        public View_Order_History()
        {
            InitializeComponent();
        }
        void loadhistory()
        {
            con.Open();
            String qury = "Select Name as 'Client Name', contact as 'Client Contact',address as'Client Address',fname as'Food Name', quantity as 'Food Quantity',price as 'Product Price', date as 'Ordered Date' from orders_table";
            SqlCommand cmd = new SqlCommand(qury, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvhistory.DataSource = dt;
            con.Close();


        }
        private void all_record_history_Load(object sender, EventArgs e)
        {
            loadhistory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adding_New_Items add = new Adding_New_Items();
            this.Hide();
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View_Users alluser = new View_Users();
            this.Hide();
            alluser.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            login lg = new login();
            this.Hide();
            lg.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Manager_Dashboard home = new Manager_Dashboard();
            this.Hide();
            home.Show();
        }
    }
}
