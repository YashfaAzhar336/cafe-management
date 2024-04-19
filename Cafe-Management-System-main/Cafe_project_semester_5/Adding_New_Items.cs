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
    public partial class Adding_New_Items : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=IM-SHAHAB\SQLEXPRESS;Initial Catalog=Cafe_Project;Integrated Security=True");
        
        public Adding_New_Items()
        {
            InitializeComponent();
        }
        void check()
        {
            if(textBox1.Text=="" || textBox2.Text=="" || textBox3.Text=="" || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Information missing please fill all boxes");
            }
        }

        void loadgridview()
        {
          
            String qury = "Select product_code as'Code',product_name as'Name',product_catagory as'Catagory', product_price as 'Price'from product";
            SqlCommand cmd = new SqlCommand(qury, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void btnupdateuser_Click(object sender, EventArgs e)
        {

            con.Open();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Information missing please fill all boxes");
            }
            else
            {
                SqlCommand cd = new SqlCommand("Select product_code from product where product_code='" + textBox1.Text + "'", con);
                SqlDataAdapter adp = new SqlDataAdapter(cd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    DialogResult answer = MessageBox.Show("Item with this code already exists? ", "Notification", MessageBoxButtons.OKCancel);
                    if (answer == DialogResult.OK)
                    {
                        textBox1.Clear();
                    }
                }
                else
                {
                    String qury = "insert into product values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + Convert.ToDouble(textBox3.Text) + "')";
                    SqlCommand cmd = new SqlCommand(qury, con);
                    cmd.ExecuteNonQuery();
                    loadgridview();

                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = -1;
            }
        
            con.Close();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete item?", "Confirmation", MessageBoxButtons.YesNo,
        MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {


                con.Open();
                String delete = "delete from product where product_code='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                loadgridview();
                con.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = -1;
                textBox1.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Add_items_Load(object sender, EventArgs e)
        {
            loadgridview();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected= true;
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Code"].Value.ToString();
            textBox1.Enabled = false;
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Catagory"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            String qury = "Update product set product_name = '"+textBox2.Text+"',product_catagory='"+comboBox1.Text+"',product_price='"+textBox3.Text+"' where product_code='"+textBox1.Text+"'";
            SqlCommand cmd = new SqlCommand(qury,con);
            cmd.ExecuteNonQuery();
            con.Close();
            loadgridview();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            textBox1.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Manager_Dashboard home = new Manager_Dashboard();
            this.Hide();
            home.Show();
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
            login lgin = new login();
            this.Hide();
            lgin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_Order_History allhis = new View_Order_History();
            this.Hide();
            allhis.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            textBox1.Enabled = true;
        }
    }
}
