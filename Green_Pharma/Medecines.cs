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
    public partial class Medecines : Form
    {
        public Medecines()
        {
            InitializeComponent();
            ShowMedecines();
            GetManufacturer();
            //if (Login.User != null && Login.User != "Admin")
            //{
            //    btnManufacturer.Visible = false;
            //    btnCustomers.Visible = false;
            //    btnSellers.Visible = false;
            //}
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Atif xPanda\Documents\Green_Pharma\Green_Pharma\PharmacyDb.mdf;Integrated Security=True");

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            if (Login.User != null && Login.User != "Admin")
            {
                MessageBox.Show("You can't access this");
                return;
            }
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

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            if (Login.User != null && Login.User != "Admin")
            {
                MessageBox.Show("You can't access this");
                return;
            }
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
            if (Login.User != null && Login.User != "Admin")
            {
                MessageBox.Show("You can't access this");
                return;
            }
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

        private void btnManufacturer_Click(object sender, EventArgs e)
        {
            if (Login.User != null && Login.User != "Admin")
            {
                MessageBox.Show("You can't access this");
                return;
            }
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


        private void ShowMedecines()
        {
            Con.Open();
            string query = "select * from MedicineTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVmedicines.DataSource = ds.Tables[0];
            Con.Close();


        }

        private void Reset()
        {
            txtMedicineName.Text = "";
            txtMedicinetype.SelectedIndex = 0;
            txtQuantity.Text = "";
            txtRate.Text = "";
            txtManufacturerName.Text = "";
            Key = 0;






        }

        private void GetManufacturer()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select ManufacturerId from ManufacturerTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ManufacturerId", typeof(int));
            dt.Load(Rdr);
            txtManufacturerId.ValueMember = "ManufacturerId";
            txtManufacturerId.DataSource = dt;
            Con.Close();

        }

        private void GetManufacturerName()
        {
            Con.Open();
            String query = ("select * from ManufacturerTbl where ManufacturerId='" + txtManufacturerId.SelectedValue.ToString() + "'");
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable Dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(Dt);
            foreach (DataRow dr in Dt.Rows)
            {
                txtManufacturerName.Text = dr["ManufacturerName"].ToString();

            }
            Con.Close();



        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMedicineName.Text == "" || txtMedicinetype.Text == "" || txtQuantity.Text == "" || txtManufacturerId.SelectedIndex == -1 || txtManufacturerName.Text == "")
            {
                MessageBox.Show("Missing Information");

            }

            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("insert into MedicineTbl(MedicineName,MedicineType,MedicineQnty,MedicinePrice,MedicineManuId,MedicineManufacturer)values(@MN,@MT,@MQ,@MP,@MMI,@MM)",Con);
                    cmd.Parameters.AddWithValue("@MN", txtMedicineName.Text);
                    cmd.Parameters.AddWithValue("@MT", txtMedicinetype.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@MQ", txtQuantity.Text);
                    cmd.Parameters.AddWithValue("@MP", txtRate.Text);
                    cmd.Parameters.AddWithValue("@MMI", txtManufacturerId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@MM", txtManufacturerName.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medicine Added Successfully");
                    Con.Close();
                    ShowMedecines();
                    Reset();

                }

                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);

                }
            }

        }

        private void txtManufacturerId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetManufacturerName();
        }
        int Key = 0;
        private void DGVmedicines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMedicineName.Text = DGVmedicines.SelectedRows[0].Cells[1].Value.ToString();
            txtMedicinetype.Text = DGVmedicines.SelectedRows[0].Cells[2].Value.ToString();
            txtQuantity.Text = DGVmedicines.SelectedRows[0].Cells[3].Value.ToString();
            txtRate.Text = DGVmedicines.SelectedRows[0].Cells[4].Value.ToString();
            txtManufacturerId.Text = DGVmedicines.SelectedRows[0].Cells[5].Value.ToString();
            txtManufacturerName.Text = DGVmedicines.SelectedRows[0].Cells[6].Value.ToString();

            if (txtMedicineName.Text == "")
            {
                Key = 0;
            }

            else
            {
                Key = Convert.ToInt32(DGVmedicines.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {

                MessageBox.Show("select the Medicine");
            }

            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from MedicineTbl where MedicineId=@MKey",Con);
                    cmd.Parameters.AddWithValue("@Key", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medicine Deleted Successfully");
                    Con.Close();
                    ShowMedecines();
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
            if(txtMedicineName.Text==""||txtMedicinetype.SelectedIndex==-1||txtQuantity.Text==""||txtManufacturerId.SelectedIndex==-1 || txtManufacturerName.Text== "")
            {

                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                { Con.Open();
                    SqlCommand cmd = new SqlCommand("Update MedicineTbl Set MedicineName=@MN,MedicineType=@MT,MedicineQnty=@MQ,MedicinePrice=@MP,MedicineManuId=@MMI,MedicineManufacturer=@MM where MedicineId=@MKey ", Con);
                    cmd.Parameters.AddWithValue("@MN", txtMedicineName.Text);
                    cmd.Parameters.AddWithValue("@MT", txtMedicinetype.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@MQ", txtQuantity.Text);
                    cmd.Parameters.AddWithValue("@MP", txtRate.Text);
                    cmd.Parameters.AddWithValue("@MMI", txtManufacturerId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@MM", txtManufacturerName.Text);
                    cmd.Parameters.AddWithValue("@MKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medicine updated Successfully");
                    Con.Close();
                    ShowMedecines();
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