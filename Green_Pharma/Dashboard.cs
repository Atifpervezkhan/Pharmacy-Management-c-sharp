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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            countmedicine();
            countseller();
            sumAmount();
            getSeller();
            SumAmountByseller();
            GetBestCustomer();
            getbestseller();
            //if (Login.User != null && Login.User != "Admin")
            //{
            //    btnManufacturer.Visible = false;
            //    btnCustomers.Visible = false;
            //    btnSellers.Visible = false;
            //}

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Atif xPanda\Documents\Green_Pharma\Green_Pharma\PharmacyDb.mdf;Integrated Security=True");

        


    private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void countmedicine()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) from MedicineTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblMedicines.Text = dt.Rows[0].ItemArray[0].ToString();
            Con.Close();


        }
        private void countcustomer()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) from CustomerTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblCustomers.Text = dt.Rows[0].ItemArray[0].ToString();
            Con.Close();

        }

        private void countseller()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from SellerTbl ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblSellers.Text = dt.Rows[0].ItemArray[0].ToString();
            Con.Close();


        }

        private void sumAmount()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(BillAmount)from BillTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblsellAmount.Text = "Rs" + dt.Rows[0][0].ToString();
            Con.Close();


        }


        private void SumAmountByseller()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(BillAmount) from BillTbl  where SellerName='" + txtSellsbyseller.SelectedValue.ToString() +"'" ,Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblsellsbyseller.Text = "Rs" + dt.Rows[0][0].ToString();
            Con.Close();

        }


        private void getSeller()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select SellerName from SellerTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SellerName", typeof(string));
            dt.Load(Rdr);
           txtSellsbyseller.ValueMember = "SellerName";
            txtSellsbyseller.DataSource = dt;
            Con.Close();


        }


        private void GetBestCustomer()
        {
            try

            {
                Con.Open();
                string InnerQuery = "select Max(BillAmount) from BillTbl";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
                sda1.Fill(dt1);
                string Query = "select CustomerName from BillTbl where BillAmount='" + dt1.Rows[0][0].ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                lblbestCustomer.Text = dt.Rows[0][0].ToString();
                Con.Close();






            }


            catch (Exception Ex) { }



        }
        private void getbestseller()
        {
            try
            {
                Con.Open();
                string InnerQuery = "select Max(BillAmount) from BillTbl";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
                sda1.Fill(dt1);
                string query = "select SellerName form BillTbl where BillAmount='" + dt1.Rows[0][0].ToString();
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                lblBestSeller.Text = dt.Rows[0][0].ToString();
                Con.Close();


            }
            catch (Exception Ex)
            {

                Con.Close();
            }


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

        public void txtSellsbyseller_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SumAmountByseller();
        }
    }
}
