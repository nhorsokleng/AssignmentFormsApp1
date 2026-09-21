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
    public partial class RegisterForm1 : Form
    {
        public RegisterForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string UserName = this.textBox1.Text;
            string Password = this.textBox2.Text;
            string confirmassword = this.textBox3.Text;

            if (UserName == "admin" && Password == "12345")
            {
                this.Hide();
                new Dashboard().Show();
            }
            else if (UserName == "sokleng")
                MessageBox.Show("Incorrect password.");
            else
                MessageBox.Show("Incorrect user name.");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
            textBox3.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
