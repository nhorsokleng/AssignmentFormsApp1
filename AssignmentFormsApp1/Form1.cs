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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //សម្រាប់កំណត់ Username and password
        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = this.textBox1.Text;
            string Password = this.textBox2.Text;

            if (UserName == "sokleng" && Password == "Leng12345")
            {
                this.Hide();
                new Dashboard().Show();
            }
            else if (UserName == "sokleng")
                MessageBox.Show("Incorrect password.");
            else
                MessageBox.Show("Incorrect user name.");
        }
        //សម្រាប់បិទនិងបង្ហាញPassword
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegisterForm1().Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
