using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF_EXERCISE_4
{

    public partial class Form1 : Form
    {
        private string username;
        private string password;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string newUsername = textBox1.Text;
            string newPassword = textBox2.Text;
            this.username = newUsername;
            this.password = newPassword;
            textBox1.Text = "";
            textBox2.Text = "";

            MessageBox.Show("Registration successful!");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string TheUsername = textBox1.Text;
            string ThePassword = textBox2.Text;


            if (TheUsername == this.username && ThePassword == this.password)
            {
                MessageBox.Show("Login successful!");
                Form2 mainform = new Form2();
                mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
