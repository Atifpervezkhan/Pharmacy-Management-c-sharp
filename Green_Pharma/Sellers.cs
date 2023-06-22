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
    public partial class Sellers : Form
    {
        public Sellers()
        {
            InitializeComponent();
            ShowSeller();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Atif xPanda\Documents\Green_Pharma\Green_Pharma\PharmacyDb.mdf;Integrated Security=True");

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            this.Hide();
            obj.Show();
        }

        private void GoDashboard_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            this.Hide();
            obj.Show();
        }

        private void btnManufacturer_Click(object sender, EventArgs e)
        {
            Manufacturer obj = new Manufacturer();
            this.Hide();
            obj.Show();
        }

        private void GoManufacturer_Click(object sender, EventArgs e)
        {
            Manufacturer obj = new Manufacturer();
            this.Hide();
            obj.Show();
        }

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            Medecines obj = new Medecines();
            this.Hide();
            obj.Show();
        }

        private void GoMedicines_Click(object sender, EventArgs e)
        {
            Medecines obj = new Medecines();
            this.Hide();
            obj.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            this.Hide();
            obj.Show();
        }

        private void GoCustomers_Click(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            this.Hide();
            obj.Show();
        }

        private void btnSellers_Click(object sender, EventArgs e)
        {

        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            Selling obj = new Selling();
            this.Hide();
            obj.Show();
        }

        private void GoSelling_Click(object sender, EventArgs e)
        {
            Selling obj = new Selling();
            this.Hide();
            obj.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }

        private void GoLogout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ShowSeller()
        {
            Con.Open();
            string query = "select * from SellerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            DGVSellers.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void Reset()
        {

            txtSellerName.Text = "";
            txtAddress.Text = "";
            txtMobileNo.Text = "";
            txtgender.SelectedIndex = 0;
            txtPassword.Text = "";
            Key = 0;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (txtSellerName.Text == "" || txtAddress.Text == "" || txtMobileNo.Text == "" || txtgender.SelectedIndex == -1 || txtPassword.Text == "")
            {

                MessageBox.Show("Missing Information");

            }
            else {

                

                //try
                //{
                Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into SellerTbl (SellerName, SellerAddress,SellerMobileNo, SellerDOB, SellerGender, SellerPassword) values (@SN,@SA, @SMN, @SD, @SG, @SP)",Con);

                    cmd.Parameters.AddWithValue("@SN", txtSellerName.Text);
                    cmd.Parameters.AddWithValue("@SA", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@SMN", txtMobileNo.Text);
                    cmd.Parameters.AddWithValue("@SD", txtDob.Value.Date);
                    cmd.Parameters.AddWithValue("@SG", txtgender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SP", txtPassword.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Added Successfully");
                    Con.Close();
                    ShowSeller();
                    Reset();
                //}
                //catch (Exception Ex) {
                //    MessageBox.Show(Ex.Message);
                //}

                
            }
        }
        int Key = 0;
        private void DGVSellers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtSellerName.Text = DGVSellers.SelectedRows[0].Cells[1].Value.ToString();
            txtAddress.Text = DGVSellers.SelectedRows[0].Cells[2].Value.ToString();
            txtMobileNo.Text = DGVSellers.SelectedRows[0].Cells[3].Value.ToString();
            txtDob.Text = DGVSellers.SelectedRows[0].Cells[4].Value.ToString();
            txtgender.SelectedItem= DGVSellers.SelectedRows[0].Cells[5].Value.ToString();
            txtPassword.Text = DGVSellers.SelectedRows[0].Cells[2].Value.ToString();
            if (txtSellerName.Text == "")
            {
                Key = 0;

            }
            else
            {
                Key = Convert.ToInt32(DGVSellers.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("select the seller");
            }

            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from SellerTbl where SellerId=@SKey",Con);
                    cmd.Parameters.AddWithValue("@SKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully");
                    Con.Close();
                    ShowSeller();
                    Reset();




                }
                catch(Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
        } }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSellerName.Text == "" || txtAddress.Text == "" || txtMobileNo.Text == "" || txtgender.SelectedIndex == -1 || txtPassword.Text == "")
            {

                MessageBox.Show("Missing Information");

            }

            else
            {
                try
                {
                  
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update  SellerTbl Set SellerName=@SN ,SellerAddress=@SA,SellerMobileNo=@SMN,SellerDOB=@SD,SellerGender=@SG,SellerPassword=@SP where SellerId=@SKey)",Con);




                    cmd.Parameters.AddWithValue("@SN", txtSellerName.Text);
                    cmd.Parameters.AddWithValue("@SA", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@SMN", txtMobileNo.Text);
                    cmd.Parameters.AddWithValue("@SD", txtDob.Value.Date);
                    cmd.Parameters.AddWithValue("@SG", txtgender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SP", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@SKey", Key); 
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Updated Successfully");
                    Con.Close();
                    ShowSeller();
                    Reset();



                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }


            }


        }
    } }
    
    