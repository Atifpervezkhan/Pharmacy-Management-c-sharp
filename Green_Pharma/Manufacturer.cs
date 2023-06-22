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
    public partial class Manufacturer : Form
    {
        public Manufacturer()
        {
            InitializeComponent();
            ShowManufacturer();

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
        private void ShowManufacturer()
        {
            Con.Open();
            string query = "select * from ManufacturerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVmanufacturer.DataSource = ds.Tables[0];
            Con.Close();





        }

        private void Reset()
        {
            txtManufacturerName.Text = "";
            txtAddress.Text = "";
            txtMobileNo.Text = "";
            Key = 0;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtManufacturerName.Text == "" || txtAddress.Text == "" || txtMobileNo.Text == "")
            {
                MessageBox.Show("Missing Information"); }


            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ManufacturerTbl(ManufacturerName,ManufacturerAddress,ManufacturerMobileNo,ManufacturerDate)values(@MN,@MA,@MMN,@MD)", Con);
                    cmd.Parameters.AddWithValue("@MN", txtManufacturerName.Text);
                    cmd.Parameters.AddWithValue("@MA", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@MMN", int.Parse(txtMobileNo.Text));
                    cmd.Parameters.AddWithValue("@MD", txt_joindate.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Manufacturer Added Successfully");
                    Con.Close();
                    ShowManufacturer();
                    Reset();
                }
                catch (Exception Ex)
                {
                    Con.Close();
                    MessageBox.Show(Ex.Message);

                }



                }}

        int Key = 0;
        private void DGVmanufacturer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DGVmanufacturer.Rows.Count)
            {
                DataGridViewRow selectedRow = DGVmanufacturer.Rows[e.RowIndex];

                txtManufacturerName.Text = selectedRow.Cells[1].Value?.ToString();
                txtAddress.Text = selectedRow.Cells[2].Value?.ToString();
                txtMobileNo.Text = selectedRow.Cells[3].Value?.ToString();
                txt_joindate.Text = selectedRow.Cells[4].Value?.ToString();
                

                if (string.IsNullOrEmpty(txtManufacturerName.Text))
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(selectedRow.Cells[0].Value?.ToString());
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Manufacturer");

            }

            else
            {
                try
                { Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from ManufacturerTbl where ManufacturerId=@MKey",Con);

                    cmd.Parameters.AddWithValue("@MKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Manufacturer Deleted Successfully");
                    Con.Close();
                    ShowManufacturer();
                    Reset();


                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtManufacturerName.Text=="" || txtAddress.Text == "" || txtMobileNo.Text == "")
            {

                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update ManufacturerTbl(ManufacturerName=@MN,ManufacturerAddress=@MA,ManufacturerMobileNo=@MMN,ManufacturerDate=@MD where ManufacturerId=@MKey)", Con);
                    cmd.Parameters.AddWithValue("@MN", txtManufacturerName.Text);
                    cmd.Parameters.AddWithValue("@MA", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@MMN", txtMobileNo.Text);
                    cmd.Parameters.AddWithValue("@MD", txt_joindate.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Manufacturer Added Successfully");
                    Con.Close();
                    ShowManufacturer();
                    Reset();


                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }


            }
        }
    }
    } 
