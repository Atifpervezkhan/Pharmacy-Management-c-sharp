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

namespace Green_Pharma
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Atif xPanda\Documents\Green_Pharma\Green_Pharma\PharmacyDb.mdf;Integrated Security=True");

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            Admin Obj = new Admin();
            this.Hide();
            Obj.Show();
        }

        public static string User;
        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="" && txtPassword.Text == "")
            {

                MessageBox.Show("Enter User name and Password to Login");
            }

            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from SellerTbl where SellerName='"+txtUsername.Text+"' and SellerPassword='"+txtPassword.Text+"'",Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    User = txtUsername.Text;
                    Selling Obj = new Selling();
                    SessionManager.UserName = User;
                    Obj.Show();
                    this.Hide();
                    Con.Close(); 
                }

                else
                {

                    MessageBox.Show("You have entered the wrong username and password");
                    

                  
                }
                Con.Close();

            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
