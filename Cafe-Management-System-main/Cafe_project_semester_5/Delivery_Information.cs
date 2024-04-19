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
    public partial class Delivery_Information : Form
    {
  
        SqlConnection con = new SqlConnection(@"Data Source=IM-SHAHAB\SQLEXPRESS;Initial Catalog=Cafe_Project;Integrated Security=True");
        int res ;
        public Delivery_Information()
        {
            InitializeComponent();
        }

      
        void loadcart()
        {
            String qury = "Select order_id as 'ID', cart_food_code as 'Code',cart_food_name as'Name',cart_food_catagory as'Catagory', cart_quantity as 'Quantity',price as 'Product Price' from cart";
            SqlCommand cmd = new SqlCommand(qury, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }
        private void label4_Click(object sender, EventArgs e)
        {

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
                tbcnic.Enabled = false;
            }
            con.Close();
        }

        private void user_detail_order_Load(object sender, EventArgs e)
        {
            loadcart();
            loadcnic();

        }
        void alldata()
        {
            if (tbname.Text == "" || tbcontact.Text == "" || tbcnic.Text == "" || tbaddress.Text == "")
            {
                MessageBox.Show("Please fill all information !!! ");
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close() ;
                    }
                    con.Open();
                    string addres = "Insert into orders_table values('" + tbname.Text + "','" + tbcnic.Text + "','" + tbcontact.Text + "','" + tbaddress.Text + "','" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + DateTime.Now + "')";
                    SqlCommand cmd = new SqlCommand(addres, con);
                   res = cmd.ExecuteNonQuery();
                  
                    
                }
                
                if (res > 0)
                {
                    MessageBox.Show("Order is Done!!!!");
                    tbname.Text = "";
                    tbcnic.Text = "";
                    tbaddress.Text = "";
                    tbcontact.Text = "";
                   
                }
                else
                {
                    MessageBox.Show("Unknown Error occure!!! ");
                }
                con.Close();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            alldata();
           

        }
        void delete()
        {
            con.Open();
            string query = "delete from cart";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("All data will be remove from cart!!!", "Warning", MessageBoxButtons.YesNo,
        MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                con.Open();
                string qry = "delete from cart";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                con.Close() ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Place_Order order = new Place_Order ();
            this.Hide();
            order.Show();
        }
    }
}
