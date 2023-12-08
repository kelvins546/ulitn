using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ulitboi
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          if(MainClass.IsValidUser(textBox1.Text, textBox2.Text)== false) 
            {
                MessageBox.Show("Invalid username or password " , "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;


            }
            else
            {
                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
