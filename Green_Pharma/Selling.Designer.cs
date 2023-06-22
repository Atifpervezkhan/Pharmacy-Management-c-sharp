
using System;

namespace Green_Pharma
{
    partial class Selling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selling));
            this.GoLogout = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GoSelling = new System.Windows.Forms.PictureBox();
            this.btnSelling = new System.Windows.Forms.Button();
            this.GoSellers = new System.Windows.Forms.PictureBox();
            this.btnSellers = new System.Windows.Forms.Button();
            this.GoCustomers = new System.Windows.Forms.PictureBox();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.GoMedicines = new System.Windows.Forms.PictureBox();
            this.btnMedicines = new System.Windows.Forms.Button();
            this.GoManufacturer = new System.Windows.Forms.PictureBox();
            this.btnManufacturer = new System.Windows.Forms.Button();
            this.GoDashboard = new System.Windows.Forms.PictureBox();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_saved2 = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.DGVTransactions = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.DGVBill = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.DGVMedicineLists = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.ComboBox();
            this.txt_Medicine = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btn_Saves = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSellerName = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.GoLogout)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoSelling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoSellers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoMedicines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoManufacturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedicineLists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // GoLogout
            // 
            this.GoLogout.Image = ((System.Drawing.Image)(resources.GetObject("GoLogout.Image")));
            this.GoLogout.Location = new System.Drawing.Point(-2, 509);
            this.GoLogout.Name = "GoLogout";
            this.GoLogout.Size = new System.Drawing.Size(50, 50);
            this.GoLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoLogout.TabIndex = 30;
            this.GoLogout.TabStop = false;
            this.GoLogout.Click += new System.EventHandler(this.GoLogout_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnLogout.Location = new System.Drawing.Point(54, 519);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(151, 29);
            this.btnLogout.TabIndex = 29;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.GoLogout);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.GoSelling);
            this.panel1.Controls.Add(this.btnSelling);
            this.panel1.Controls.Add(this.GoSellers);
            this.panel1.Controls.Add(this.btnSellers);
            this.panel1.Controls.Add(this.GoCustomers);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.GoMedicines);
            this.panel1.Controls.Add(this.btnMedicines);
            this.panel1.Controls.Add(this.GoManufacturer);
            this.panel1.Controls.Add(this.btnManufacturer);
            this.panel1.Controls.Add(this.GoDashboard);
            this.panel1.Controls.Add(this.btn_Dashboard);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 646);
            this.panel1.TabIndex = 35;
            // 
            // GoSelling
            // 
            this.GoSelling.Image = ((System.Drawing.Image)(resources.GetObject("GoSelling.Image")));
            this.GoSelling.Location = new System.Drawing.Point(-2, 414);
            this.GoSelling.Name = "GoSelling";
            this.GoSelling.Size = new System.Drawing.Size(50, 50);
            this.GoSelling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoSelling.TabIndex = 28;
            this.GoSelling.TabStop = false;
            // 
            // btnSelling
            // 
            this.btnSelling.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelling.ForeColor = System.Drawing.Color.White;
            this.btnSelling.Location = new System.Drawing.Point(54, 424);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(151, 29);
            this.btnSelling.TabIndex = 27;
            this.btnSelling.Text = "Selling";
            this.btnSelling.UseVisualStyleBackColor = false;
            // 
            // GoSellers
            // 
            this.GoSellers.Image = ((System.Drawing.Image)(resources.GetObject("GoSellers.Image")));
            this.GoSellers.Location = new System.Drawing.Point(-2, 358);
            this.GoSellers.Name = "GoSellers";
            this.GoSellers.Size = new System.Drawing.Size(50, 50);
            this.GoSellers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoSellers.TabIndex = 24;
            this.GoSellers.TabStop = false;
            this.GoSellers.Click += new System.EventHandler(this.GoSellers_Click);
            // 
            // btnSellers
            // 
            this.btnSellers.BackColor = System.Drawing.Color.White;
            this.btnSellers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellers.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSellers.Location = new System.Drawing.Point(54, 369);
            this.btnSellers.Name = "btnSellers";
            this.btnSellers.Size = new System.Drawing.Size(151, 29);
            this.btnSellers.TabIndex = 23;
            this.btnSellers.Text = "Sellers";
            this.btnSellers.UseVisualStyleBackColor = false;
            this.btnSellers.Click += new System.EventHandler(this.btnSellers_Click);
            // 
            // GoCustomers
            // 
            this.GoCustomers.Image = ((System.Drawing.Image)(resources.GetObject("GoCustomers.Image")));
            this.GoCustomers.Location = new System.Drawing.Point(-2, 305);
            this.GoCustomers.Name = "GoCustomers";
            this.GoCustomers.Size = new System.Drawing.Size(50, 50);
            this.GoCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoCustomers.TabIndex = 22;
            this.GoCustomers.TabStop = false;
            this.GoCustomers.Click += new System.EventHandler(this.GoCustomers_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.White;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnCustomers.Location = new System.Drawing.Point(54, 314);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(151, 29);
            this.btnCustomers.TabIndex = 21;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // GoMedicines
            // 
            this.GoMedicines.Image = ((System.Drawing.Image)(resources.GetObject("GoMedicines.Image")));
            this.GoMedicines.Location = new System.Drawing.Point(-2, 246);
            this.GoMedicines.Name = "GoMedicines";
            this.GoMedicines.Size = new System.Drawing.Size(50, 50);
            this.GoMedicines.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoMedicines.TabIndex = 20;
            this.GoMedicines.TabStop = false;
            this.GoMedicines.Click += new System.EventHandler(this.GoMedicines_Click);
            // 
            // btnMedicines
            // 
            this.btnMedicines.BackColor = System.Drawing.Color.White;
            this.btnMedicines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicines.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnMedicines.Location = new System.Drawing.Point(54, 257);
            this.btnMedicines.Name = "btnMedicines";
            this.btnMedicines.Size = new System.Drawing.Size(151, 28);
            this.btnMedicines.TabIndex = 19;
            this.btnMedicines.Text = "Medicines";
            this.btnMedicines.UseVisualStyleBackColor = false;
            this.btnMedicines.Click += new System.EventHandler(this.btnMedicines_Click);
            // 
            // GoManufacturer
            // 
            this.GoManufacturer.Image = ((System.Drawing.Image)(resources.GetObject("GoManufacturer.Image")));
            this.GoManufacturer.Location = new System.Drawing.Point(-2, 189);
            this.GoManufacturer.Name = "GoManufacturer";
            this.GoManufacturer.Size = new System.Drawing.Size(50, 50);
            this.GoManufacturer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoManufacturer.TabIndex = 18;
            this.GoManufacturer.TabStop = false;
            this.GoManufacturer.Click += new System.EventHandler(this.GoManufacturer_Click);
            // 
            // btnManufacturer
            // 
            this.btnManufacturer.BackColor = System.Drawing.Color.White;
            this.btnManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManufacturer.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnManufacturer.Location = new System.Drawing.Point(54, 199);
            this.btnManufacturer.Name = "btnManufacturer";
            this.btnManufacturer.Size = new System.Drawing.Size(151, 29);
            this.btnManufacturer.TabIndex = 17;
            this.btnManufacturer.Text = "Manufacturer";
            this.btnManufacturer.UseVisualStyleBackColor = false;
            this.btnManufacturer.Click += new System.EventHandler(this.btnManufacturer_Click);
            // 
            // GoDashboard
            // 
            this.GoDashboard.Image = ((System.Drawing.Image)(resources.GetObject("GoDashboard.Image")));
            this.GoDashboard.Location = new System.Drawing.Point(-2, 131);
            this.GoDashboard.Name = "GoDashboard";
            this.GoDashboard.Size = new System.Drawing.Size(50, 50);
            this.GoDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoDashboard.TabIndex = 16;
            this.GoDashboard.TabStop = false;
            this.GoDashboard.Click += new System.EventHandler(this.GoDashboard_Click);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.White;
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_Dashboard.Location = new System.Drawing.Point(54, 142);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(151, 29);
            this.btn_Dashboard.TabIndex = 15;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(104, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Health Care";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_saved2);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.DGVTransactions);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.DGVBill);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.DGVMedicineLists);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtCustomerId);
            this.panel2.Controls.Add(this.txt_Medicine);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtCustName);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btn_Saves);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(230, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 580);
            this.panel2.TabIndex = 36;
            // 
            // btn_saved2
            // 
            this.btn_saved2.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_saved2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saved2.ForeColor = System.Drawing.Color.White;
            this.btn_saved2.Location = new System.Drawing.Point(302, 213);
            this.btn_saved2.Name = "btn_saved2";
            this.btn_saved2.Size = new System.Drawing.Size(147, 29);
            this.btn_saved2.TabIndex = 26;
            this.btn_saved2.Text = "Add to Bill New";
            this.btn_saved2.UseVisualStyleBackColor = false;
            this.btn_saved2.Click += new System.EventHandler(this.btn_saved2_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotal.Location = new System.Drawing.Point(562, 251);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(110, 25);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "Total in Rs";
            // 
            // DGVTransactions
            // 
            this.DGVTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVTransactions.BackgroundColor = System.Drawing.Color.White;
            this.DGVTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTransactions.GridColor = System.Drawing.Color.Black;
            this.DGVTransactions.Location = new System.Drawing.Point(509, 319);
            this.DGVTransactions.Name = "DGVTransactions";
            this.DGVTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVTransactions.Size = new System.Drawing.Size(397, 249);
            this.DGVTransactions.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LimeGreen;
            this.label13.Location = new System.Drawing.Point(607, 291);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 25);
            this.label13.TabIndex = 23;
            this.label13.Text = "Transactions";
            // 
            // DGVBill
            // 
            this.DGVBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVBill.BackgroundColor = System.Drawing.Color.White;
            this.DGVBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBill.GridColor = System.Drawing.Color.Black;
            this.DGVBill.Location = new System.Drawing.Point(517, 27);
            this.DGVBill.Name = "DGVBill";
            this.DGVBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVBill.Size = new System.Drawing.Size(389, 219);
            this.DGVBill.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LimeGreen;
            this.label9.Location = new System.Drawing.Point(684, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Bill";
            // 
            // DGVMedicineLists
            // 
            this.DGVMedicineLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVMedicineLists.BackgroundColor = System.Drawing.Color.White;
            this.DGVMedicineLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMedicineLists.GridColor = System.Drawing.Color.Black;
            this.DGVMedicineLists.Location = new System.Drawing.Point(7, 319);
            this.DGVMedicineLists.Name = "DGVMedicineLists";
            this.DGVMedicineLists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMedicineLists.Size = new System.Drawing.Size(387, 249);
            this.DGVMedicineLists.TabIndex = 24;
            this.DGVMedicineLists.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMedicineLists_CellContentClick);
            this.DGVMedicineLists.SelectionChanged += new System.EventHandler(this.DGVMedicineLists_SelectionChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LimeGreen;
            this.label11.Location = new System.Drawing.Point(79, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Medicine List";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.FormattingEnabled = true;
            this.txtCustomerId.Location = new System.Drawing.Point(7, 58);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(166, 27);
            this.txtCustomerId.TabIndex = 22;
            this.txtCustomerId.SelectedIndexChanged += new System.EventHandler(this.txtCustomerId_SelectedIndexChanged);
            this.txtCustomerId.SelectionChangeCommitted += new System.EventHandler(this.txtCustomerId_SelectionChangeCommitted);
            // 
            // txt_Medicine
            // 
            this.txt_Medicine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Medicine.Location = new System.Drawing.Point(8, 178);
            this.txt_Medicine.Name = "txt_Medicine";
            this.txt_Medicine.Size = new System.Drawing.Size(166, 27);
            this.txt_Medicine.TabIndex = 20;
            this.txt_Medicine.TextChanged += new System.EventHandler(this.txt_Medicine_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Location = new System.Drawing.Point(257, 121);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(167, 27);
            this.txtPrice.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.LimeGreen;
            this.label7.Location = new System.Drawing.Point(4, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Medicine";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Location = new System.Drawing.Point(257, 62);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(167, 27);
            this.txtQuantity.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.ForeColor = System.Drawing.Color.LimeGreen;
            this.label12.Location = new System.Drawing.Point(253, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "Price";
            // 
            // txtCustName
            // 
            this.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustName.Location = new System.Drawing.Point(7, 121);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(167, 27);
            this.txtCustName.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.ForeColor = System.Drawing.Color.LimeGreen;
            this.label10.Location = new System.Drawing.Point(3, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Customer Name";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(782, 250);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(124, 29);
            this.btnPrint.TabIndex = 18;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btn_Saves
            // 
            this.btn_Saves.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Saves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Saves.ForeColor = System.Drawing.Color.White;
            this.btn_Saves.Location = new System.Drawing.Point(257, 178);
            this.btn_Saves.Name = "btn_Saves";
            this.btn_Saves.Size = new System.Drawing.Size(124, 29);
            this.btn_Saves.TabIndex = 18;
            this.btn_Saves.Text = "Add to Bill";
            this.btn_Saves.UseVisualStyleBackColor = false;
            this.btn_Saves.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.ForeColor = System.Drawing.Color.LimeGreen;
            this.label8.Location = new System.Drawing.Point(253, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.LimeGreen;
            this.label6.Location = new System.Drawing.Point(3, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Customer Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Billing Module";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1105, -3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 45);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 39;
            this.btnClose.TabStop = false;
            this.btnClose.UseWaitCursor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(225, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Selling";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(443, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Pharmacy Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(527, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Bahrian Version 1.0";
            // 
            // lblSellerName
            // 
            this.lblSellerName.AutoSize = true;
            this.lblSellerName.BackColor = System.Drawing.Color.Transparent;
            this.lblSellerName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerName.ForeColor = System.Drawing.Color.White;
            this.lblSellerName.Location = new System.Drawing.Point(938, 7);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.Size = new System.Drawing.Size(135, 25);
            this.lblSellerName.TabIndex = 41;
            this.lblSellerName.Text = "Seller Name";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // Selling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1148, 629);
            this.Controls.Add(this.lblSellerName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Selling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selling";
            ((System.ComponentModel.ISupportInitialize)(this.GoLogout)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoSelling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoSellers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoMedicines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoManufacturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedicineLists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.PictureBox GoLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox GoSelling;
        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.PictureBox GoSellers;
        private System.Windows.Forms.Button btnSellers;
        private System.Windows.Forms.PictureBox GoCustomers;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.PictureBox GoMedicines;
        private System.Windows.Forms.Button btnMedicines;
        private System.Windows.Forms.PictureBox GoManufacturer;
        private System.Windows.Forms.Button btnManufacturer;
        private System.Windows.Forms.PictureBox GoDashboard;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGVMedicineLists;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btn_Saves;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtCustomerId;
        private System.Windows.Forms.DataGridView DGVBill;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Medicine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView DGVTransactions;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSellerName;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Button btn_saved2;
    }
}