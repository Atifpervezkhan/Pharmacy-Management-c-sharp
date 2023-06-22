using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Pharma
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            this.Hide();
            Obj.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_adminPassword.Text == "")
            {
                MessageBox.Show("doesn't accept empty value");

            }

            else if(txt_adminPassword.Text=="Admin"){

                Dashboard obj = new Dashboard();
                Login.User = "Admin";
                this.Hide();
                obj.Show();
            }

            else
            {

                MessageBox.Show("You have entered the Wrong Admin Password");
                txt_adminPassword.Text = "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
