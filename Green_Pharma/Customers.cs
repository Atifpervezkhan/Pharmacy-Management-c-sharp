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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            ShowCustomer();
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

        private void btnSellers_Click(object sender, EventArgs e)
        {
            Sellers obj = new Sellers();
            this.Hide();
            obj.Show();
        }

        private void GoSellers_Click(object sender, EventArgs e)
        {
            Sellers obj = new Sellers();
            this.Hide();
            obj.Show();
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


        private void ShowCustomer()
        {
            Con.Open();
            string query = "select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVCustomer.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void Reset()
        {
            txtCustName.Text = "";
            txtAddress.Text = "";
            txtMobileNo.Text = "";
            txtgender.SelectedIndex = 0;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustName.Text == "" || txtAddress.Text == "" || txtMobileNo.Text == "" || txtgender.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");

            }

            else
            {
                try {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CustomerTbl(CustomerName,CustomerAddress,CustomerMobileNo,CustomerDOB,CustomerGender)values(@CN,@CA,@CMN,@CD,@CG)", Con);
                    cmd.Parameters.AddWithValue("@CN", txtCustName.Text);
                    cmd.Parameters.AddWithValue("@CA", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@CMN", txtMobileNo.Text);
                    cmd.Parameters.AddWithValue("@CD", txtDob.Value.Date);
                    cmd.Parameters.AddWithValue("@CG", txtgender.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Added Successfully");
                    Con.Close();
                    ShowCustomer();
                    Reset();


                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);

                }
            }


        }
        int Key = 0;
        private void DGVCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustName.Text = DGVCustomer.SelectedRows[0].Cells[1].Value.ToString();
            txtAddress.Text = DGVCustomer.SelectedRows[0].Cells[2].Value.ToString();
            txtMobileNo.Text = DGVCustomer.SelectedRows[0].Cells[3].Value.ToString();
            txtDob.Text = DGVCustomer.SelectedRows[0].Cells[4].Value.ToString();
            txtgender.SelectedItem = DGVCustomer.SelectedRows[0].Cells[5].Value.ToString();
            if (txtCustName.Text == "")
            {
                {
                    Key = 0;

                }
            }


            else
            {
                Key = Convert.ToInt32(DGVCustomer.SelectedRows[0].Cells[0].Value.ToString());
            }



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {

                MessageBox.Show("Select the customer");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from CustomerTbl where CustomerId=@CKey", Con);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted Successfully");
                    Con.Close();
                    ShowCustomer();
                    Reset();

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCustName.Text == "" || txtAddress.Text == "" || txtMobileNo.Text=="" || txtgender.SelectedIndex==-1){

                MessageBox.Show("Missing Information");

            }
            else
            {
                //try
                //{
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update CustomerTbl Set CustomerName=@CN,CustomerAddress=@CA,CustomerMobileNo=@CMN,CustomerDOB=@CD,CustomerGender=@CG where CustomerId=@CKey",Con);
                    cmd.Parameters.AddWithValue("@CN", txtCustName.Text);
                    cmd.Parameters.AddWithValue("@CA", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@CMN", txtMobileNo.Text);
                    cmd.Parameters.AddWithValue("@CD", txtDob.Value.Date);
                    cmd.Parameters.AddWithValue("@CG", txtgender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Added Success Fully");
                    Con.Close();
                    ShowCustomer();
                    Reset();

                //}
                //catch(Exception Ex)
                //{
                //    MessageBox.Show(Ex.Message);

                //}
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
