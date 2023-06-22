
namespace Green_Pharma
{
    partial class Medecines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medecines));
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.DGVmedicines = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GoCustomers = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GoLogout = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.GoSelling = new System.Windows.Forms.PictureBox();
            this.btnSelling = new System.Windows.Forms.Button();
            this.GoSellers = new System.Windows.Forms.PictureBox();
            this.btnSellers = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.GoMedicines = new System.Windows.Forms.PictureBox();
            this.btnMedicines = new System.Windows.Forms.Button();
            this.GoManufacturer = new System.Windows.Forms.PictureBox();
            this.btnManufacturer = new System.Windows.Forms.Button();
            this.GoDashboard = new System.Windows.Forms.PictureBox();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtManufacturerId = new System.Windows.Forms.ComboBox();
            this.txtMedicinetype = new System.Windows.Forms.ComboBox();
            this.txtManufacturerName = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVmedicines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoCustomers)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoSelling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoSellers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoMedicines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoManufacturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(207, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Medicines";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1081, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 45);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 27;
            this.btnClose.TabStop = false;
            this.btnClose.UseWaitCursor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DGVmedicines
            // 
            this.DGVmedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVmedicines.BackgroundColor = System.Drawing.Color.White;
            this.DGVmedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVmedicines.GridColor = System.Drawing.Color.Black;
            this.DGVmedicines.Location = new System.Drawing.Point(7, 308);
            this.DGVmedicines.Name = "DGVmedicines";
            this.DGVmedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVmedicines.Size = new System.Drawing.Size(903, 223);
            this.DGVmedicines.TabIndex = 24;
            this.DGVmedicines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVmedicines_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LimeGreen;
            this.label11.Location = new System.Drawing.Point(319, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Medicines List";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMedicineName.Location = new System.Drawing.Point(4, 84);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(167, 27);
            this.txtMedicineName.TabIndex = 20;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(524, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 29);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(346, 179);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 29);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(171, 179);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 29);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.ForeColor = System.Drawing.Color.LimeGreen;
            this.label9.Location = new System.Drawing.Point(739, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Manufacturer Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.ForeColor = System.Drawing.Color.LimeGreen;
            this.label8.Location = new System.Drawing.Point(365, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.LimeGreen;
            this.label7.Location = new System.Drawing.Point(200, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Medicine Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.LimeGreen;
            this.label6.Location = new System.Drawing.Point(4, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Medicine Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Medicines Detail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(548, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Bahrian Version 1.0";
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
            this.panel1.Location = new System.Drawing.Point(-19, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 606);
            this.panel1.TabIndex = 23;
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
            // GoSelling
            // 
            this.GoSelling.Image = ((System.Drawing.Image)(resources.GetObject("GoSelling.Image")));
            this.GoSelling.Location = new System.Drawing.Point(-2, 414);
            this.GoSelling.Name = "GoSelling";
            this.GoSelling.Size = new System.Drawing.Size(50, 50);
            this.GoSelling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoSelling.TabIndex = 28;
            this.GoSelling.TabStop = false;
            this.GoSelling.Click += new System.EventHandler(this.GoSelling_Click);
            // 
            // btnSelling
            // 
            this.btnSelling.BackColor = System.Drawing.Color.White;
            this.btnSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelling.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSelling.Location = new System.Drawing.Point(54, 424);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(151, 29);
            this.btnSelling.TabIndex = 27;
            this.btnSelling.Text = "Selling";
            this.btnSelling.UseVisualStyleBackColor = false;
            this.btnSelling.Click += new System.EventHandler(this.btnSelling_Click);
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
            // 
            // btnMedicines
            // 
            this.btnMedicines.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMedicines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicines.ForeColor = System.Drawing.Color.White;
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
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(464, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Pharmacy Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtManufacturerId);
            this.panel2.Controls.Add(this.txtMedicinetype);
            this.panel2.Controls.Add(this.DGVmedicines);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtManufacturerName);
            this.panel2.Controls.Add(this.txtRate);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.txtMedicineName);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(207, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 544);
            this.panel2.TabIndex = 24;
            // 
            // txtManufacturerId
            // 
            this.txtManufacturerId.FormattingEnabled = true;
            this.txtManufacturerId.Location = new System.Drawing.Point(591, 85);
            this.txtManufacturerId.Name = "txtManufacturerId";
            this.txtManufacturerId.Size = new System.Drawing.Size(121, 27);
            this.txtManufacturerId.TabIndex = 25;
            this.txtManufacturerId.SelectionChangeCommitted += new System.EventHandler(this.txtManufacturerId_SelectionChangeCommitted);
            // 
            // txtMedicinetype
            // 
            this.txtMedicinetype.FormattingEnabled = true;
            this.txtMedicinetype.Items.AddRange(new object[] {
            "Capsules",
            "PainKillers",
            "Tablets"});
            this.txtMedicinetype.Location = new System.Drawing.Point(202, 84);
            this.txtMedicinetype.Name = "txtMedicinetype";
            this.txtMedicinetype.Size = new System.Drawing.Size(121, 27);
            this.txtMedicinetype.TabIndex = 25;
            // 
            // txtManufacturerName
            // 
            this.txtManufacturerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtManufacturerName.Enabled = false;
            this.txtManufacturerName.Location = new System.Drawing.Point(757, 84);
            this.txtManufacturerName.Name = "txtManufacturerName";
            this.txtManufacturerName.Size = new System.Drawing.Size(148, 27);
            this.txtManufacturerName.TabIndex = 20;
            // 
            // txtRate
            // 
            this.txtRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRate.Location = new System.Drawing.Point(464, 85);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(102, 27);
            this.txtRate.TabIndex = 20;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Location = new System.Drawing.Point(356, 85);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(102, 27);
            this.txtQuantity.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.ForeColor = System.Drawing.Color.LimeGreen;
            this.label12.Location = new System.Drawing.Point(587, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 19);
            this.label12.TabIndex = 13;
            this.label12.Text = "Manufacturer Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.ForeColor = System.Drawing.Color.LimeGreen;
            this.label10.Location = new System.Drawing.Point(473, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "Rate";
            // 
            // Medecines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1123, 610);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Medecines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medecines";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVmedicines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoCustomers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoSelling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoSellers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoMedicines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoManufacturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.DataGridView DGVmedicines;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox GoCustomers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox GoLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox GoSelling;
        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.PictureBox GoSellers;
        private System.Windows.Forms.Button btnSellers;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.PictureBox GoMedicines;
        private System.Windows.Forms.Button btnMedicines;
        private System.Windows.Forms.PictureBox GoManufacturer;
        private System.Windows.Forms.Button btnManufacturer;
        private System.Windows.Forms.PictureBox GoDashboard;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox txtManufacturerId;
        private System.Windows.Forms.ComboBox txtMedicinetype;
        private System.Windows.Forms.TextBox txtManufacturerName;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
    }
}