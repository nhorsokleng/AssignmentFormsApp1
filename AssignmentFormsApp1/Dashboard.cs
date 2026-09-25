using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentFormsApp1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label49_Click(object sender, EventArgs e)
        {
          

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }
        //ការតlinkទៅmenu
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Order().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Inventory().Show();
        }
    }
}
