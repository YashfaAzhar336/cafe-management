using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_project_semester_5
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel3.Width += 3;
            if(panel3.Width > 800)
            {
                timer1.Stop();
                login lgin = new login();
                this.Hide();
                lgin.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Startup_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
