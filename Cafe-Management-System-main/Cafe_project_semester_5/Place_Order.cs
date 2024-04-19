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

    public partial class Place_Order : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=IM-SHAHAB\SQLEXPRESS;Initial Catalog=Cafe_Project;Integrated Security=True");
        String price;
        int total = 0;
        String cnic;
        void delete()
        {
            con.Open();
            string delete = "delete from cart";
            SqlCommand cmd = new SqlCommand(delete, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void loadgui()
        {
            String qury = "Select product_code as'Code',product_name as'Name',product_catagory as'Catagory', product_price as 'Price'from product";
            SqlCommand cmd = new SqlCommand(qury, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvproductlist.DataSource = dt;
            con.Close();
        }

        public Place_Order()
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
            dgvcart.DataSource = dt;
            con.Close();

        }
        void sum()
        {
            con.Open();
            string quey = "select sum(price) from cart";
            SqlCommand cmd = new SqlCommand(quey, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                lbltotal.Text = rdr[0].ToString();
            }
            rdr.Close();
            con.Close() ;
        }
        private void order_Load(object sender, EventArgs e)
        {
            loadgui();
            loadcart();
            
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvproductlist.CurrentRow.Selected = true;
            tbcode.Text = dgvproductlist.Rows[e.RowIndex].Cells["Code"].Value.ToString();
            tbcode.Enabled = false;
            tbname.Text = dgvproductlist.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            cbcatagory.Text = dgvproductlist.Rows[e.RowIndex].Cells["Catagory"].Value.ToString();
            price = dgvproductlist.Rows[e.RowIndex].Cells["Price"].Value.ToString();

            tbname.Enabled = false;
            cbcatagory.Enabled = false;
            tbid.Enabled = true;
            tbquantity.Enabled = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tbid.Text == "" || tbquantity.Text == "" )
            {
                MessageBox.Show("Please Fill all information !! ");
            }
            else
            {
                con.Open();
                SqlCommand cd = new SqlCommand("Select order_id from cart where order_id='" + tbid.Text + "'", con);
                SqlDataAdapter adp = new SqlDataAdapter(cd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    DialogResult answer = MessageBox.Show("Order Id already exists", "Notification", MessageBoxButtons.OKCancel);
                    if (answer == DialogResult.OK || answer == DialogResult.Cancel)
                    {
                        tbid.Clear();
                    }
                }
                else
                {
                    int totals = Convert.ToInt32(tbquantity.Text) * Convert.ToInt32(price);
                 

                    string qury = "insert into cart values('" + tbcode.Text + "','" + tbname.Text + "','" + cbcatagory.Text + "','" + tbquantity.Text + "','" + totals + "','" + tbid.Text + "')";
                    SqlCommand cmd = new SqlCommand(qury, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    loadcart();
                    tbcode.Clear();
                    tbname.Clear();
                    tbquantity.Clear();
                    tbid.Clear();
                    cbcatagory.SelectedItem = 0;

                }
                con.Close();
                sum();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You sure to remove item from cart?", "Confirmation", MessageBoxButtons.YesNo,
        MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                con.Open();
                String delete = "delete from cart where order_id='" + tbid.Text + "'";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                loadcart();
                con.Close();
                tbcode.Clear();
                tbname.Clear();
                tbquantity.Clear();
                tbid.Clear();
                cbcatagory.SelectedItem = -1;
                tbid.Enabled = true;
                tbquantity.Enabled = true;  
                sum();
            }
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvproductlist.CurrentRow.Selected = true;
            tbcode.Text = dgvcart.Rows[e.RowIndex].Cells["Code"].Value.ToString();
            tbcode.Enabled = false;
            tbname.Text = dgvcart.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            cbcatagory.Text = dgvcart.Rows[e.RowIndex].Cells["Catagory"].Value.ToString();
            tbquantity.Text = dgvcart.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            tbid.Text = dgvcart.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            tbname.Enabled = false;
            tbquantity.Enabled = false;
            tbid.Enabled = false;
            cbcatagory.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvcart.Rows.Count > 1)
            {
                DialogResult dr = MessageBox.Show("If you go back all your cart data will be removed", "Confirmation", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {


                    User_Dashboard home = new User_Dashboard();
                    delete();
                    sum();
                    this.Hide();
                    home.Show();
                }
            }
            else
            {
                User_Dashboard home = new User_Dashboard();
                delete();
                sum();
                this.Hide();
                home.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvcart.Rows.Count==1)
            {
                MessageBox.Show("Please Add items into cart!!!");
            }
            else
            {
                Delivery_Information orderuser = new Delivery_Information();
                this.Hide();
                orderuser.Show();
               
            }
        }
    }
}
