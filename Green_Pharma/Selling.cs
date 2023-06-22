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
    public partial class Selling : Form
    {

        public Selling()
        {
            InitializeComponent();
            //GetCustomerName();
            GetCustomer();
          
            InsertBill();
            ShowBill();
            showMedicine();
            lblSellerName.Text = Login.User;
            DGVBill.Columns.Add("Column1", "Id");
            DGVBill.Columns.Add("Column2", "Medicine");
            DGVBill.Columns.Add("Column3", "Quantity");
            DGVBill.Columns.Add("Column4", "Price");
            DGVBill.Columns.Add("Column5", "Total");
            //if (Login.User != null&&Login.User!="Admin")
            //{
            //    btnManufacturer.Visible = false;
            //    btnCustomers.Visible = false;
            //    btnSellers.Visible = false;
            //}
        }
        // Add columns to the DGVBill control


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

        private void btnManufacturer_Click(object sender, EventArgs e)
        {
            if (Login.User != null && Login.User != "Admin")
            {
                MessageBox.Show("You can't access this");
            }
            else
            {
                Manufacturer obj = new Manufacturer();
                this.Hide();
                obj.Show();
            }
            
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


        public void GetCustomer()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CustomerId from CustomerTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustomerId", typeof(int));
            dt.Load(Rdr);
            txtCustomerId.ValueMember = "CustomerId";
            txtCustomerId.DataSource = dt;
            Con.Close();


        }

        private void GetCustomerName()
        {


            try
            {


                    Con.Open();
                    string query = "select * from CustomerTbl where CustomerId='" + txtCustomerId.SelectedValue.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtCustName.Text = dr["CustomerName"].ToString();


                    }
                    Con.Close();
               

             
            }
            catch (Exception ex)
            {
                Console.WriteLine("My Log for ${0}" + ex.Message);
                MessageBox.Show(ex.Message);
            }



    }



        private void UpdateQnty()
        {
            try
            {
                int newQnty = Stock - Convert.ToInt32(txtQuantity.Text);
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update MedicineTbl Set MedicineQnty=@MQ where MedicineId=@MKey", Con);
                cmd.Parameters.AddWithValue("@MQ", newQnty);
                cmd.Parameters.AddWithValue("@MKey", Key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Updated Successfully");
                Con.Close();
                showMedicine();

            }
            catch (Exception Ex)
            {
                Console.WriteLine("My Log for Medicine" + Ex.Message);

                MessageBox.Show(Ex.Message);

            }








        }

        private void InsertBill()
        {
            if (txtCustName.Text == "")
            {


            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into BillTbl(SellerName,CustomerId,CustomerName,BillDate,BillAmount)values(@SN,@CI,@CN,@BD,@BA)", Con);
                    cmd.Parameters.AddWithValue("@SN", lblSellerName.Text);
                    cmd.Parameters.AddWithValue("@CI", txtCustomerId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@CN", txtCustName.Text);
                    cmd.Parameters.AddWithValue("@BD", DateTime.Today.Date);
                    cmd.Parameters.AddWithValue("@BA", GrdTotal);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill saved Successfully");
                    Con.Close();
                    ShowBill();




                }

                catch (Exception Ex)
                {
                    Console.WriteLine("My Log forBIll ${0}" + Ex.Message);

                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void ShowBill()
        {

            Con.Open();
            string query = "select * from BillTbl where SellerName='" + lblSellerName.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Con.Close();



        }
        private void showMedicine()
        {
            Con.Open();
            string query = "select * from MedicineTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVMedicineLists.DataSource = ds.Tables[0];
            Con.Close();


        }
      ///



        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "" || Convert.ToInt32(txtQuantity.Text) > Stock) 
            {

                MessageBox.Show("Enter Correct Quantity");

            }
            else
            {
                int total = Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(txtPrice.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(DGVBill);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = txt_Medicine.Text;
                newRow.Cells[2].Value = txtQuantity.Text;
                newRow.Cells[3].Value = txtPrice.Text;
                newRow.Cells[4].Value = total;
                DGVBill.Rows.Add(newRow);
                GrdTotal = GrdTotal + total;
                lblTotal.Text = "Rs" + GrdTotal;
                n++;
                UpdateQnty();

            }

        }
      

        private void txtCustomerId_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        

        private void DGVMedicineLists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Medicine.Text = DGVMedicineLists.SelectedRows[0].Cells[1].Value.ToString();
            //txtMedicineType.SelectedItem = DGVMedicinestock.SelectedRows[0].Cells[2].Value.ToString();
            Stock = Convert.ToInt32(DGVMedicineLists.SelectedRows[0].Cells[3].Value.ToString());
            txtPrice.Text = DGVMedicineLists.SelectedRows[0].Cells[4].Value.ToString();
            txtQuantity.Text = DGVMedicineLists.SelectedRows[0].Cells[3].Value.ToString();
            //txtManufacturer.SelectedValue = DGVMedicinestock.SelectedRows[0].Cells[5].Value.ToString();
            //txtManufacturerName.Text = DGMedicineStock.SelectedRows[0].Cells[6].Value.ToString();

            if (txt_Medicine.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DGVMedicineLists.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument.Print();

            }
            InsertBill();
        }

        string MedName;
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Bahria Version 1.0", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID Medicine Price Quantity Total", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));

            foreach (DataGridViewRow row in DGVBill.Rows)
            {
                //yaha edit kiya hay
                int MedId = Convert.ToInt32(row.Cells["Column1"].Value);
                string MedName = "" + row.Cells["Column2"].Value;
                int MedPrice = Convert.ToInt32(row.Cells["Column3"].Value);
                int MedQty = Convert.ToInt32(row.Cells["Column4"].Value);
                int MedTot = Convert.ToInt32(row.Cells["Column5"].Value);


                e.Graphics.DrawString("" + MedId, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, Pos));
                e.Graphics.DrawString(MedName, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45, Pos));
                e.Graphics.DrawString("" + MedPrice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(128, Pos));
                e.Graphics.DrawString("" + MedQty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, Pos));
                e.Graphics.DrawString("" + MedTot, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, Pos));

                Pos += 20;
                GrdTotal += MedTot;
            }

            e.Graphics.DrawString("Grand Total: Rs " + GrdTotal, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(50, Pos + 50));
            e.Graphics.DrawString("****PandaBUKC****", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(10, Pos + 85));

            DGVBill.Rows.Clear();
            DGVBill.Refresh();

            Pos = 100;
            GrdTotal = 0;
            n = 0;



        }

        private void DGVMedicineLists_SelectionChanged(object sender, EventArgs e)
        {

        }
        int Key = 0, Stock; int n = 0, GrdTotal = 0;
        int MedId, MedPrice, MedQty, MedTot;

        private void btn_saved2_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "" || Convert.ToInt32(txtQuantity.Text) > Stock)
            {

                MessageBox.Show("Enter Correct Quantity");

            }
            else
            {
                int total = Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(txtPrice.Text);
                DataGridViewRow newRow = new DataGridViewRow();

                // Add cells to the new row directly
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = n + 1 });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = txt_Medicine.Text });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = txtQuantity.Text });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = txtPrice.Text });
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = total });

                DGVBill.Rows.Add(newRow);
                GrdTotal = GrdTotal + total;
                lblTotal.Text = "Rs" + GrdTotal;
                n++;



                UpdateQnty();

            }
        }

        private void txt_Medicine_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetCustomerName();
        }

        int Pos = 60;
    }

        
       


    }
