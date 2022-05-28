namespace Electronic_Accessories_Showroom
{
    partial class frm_Add_New_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_Customer));
            this.pnl_Add_New_Customer = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.lbl_Add_New_Customer = new System.Windows.Forms.Label();
            this.pnl_Customer_Details = new System.Windows.Forms.Panel();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.tb_Customer_Name = new System.Windows.Forms.TextBox();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tb_Customer_ID = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Customer_ID = new System.Windows.Forms.Label();
            this.pnl_Purchase_Details = new System.Windows.Forms.Panel();
            this.tb_Per_Price = new System.Windows.Forms.TextBox();
            this.lbl_Per_Price = new System.Windows.Forms.Label();
            this.dgv_Add_New_Customer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Brand = new System.Windows.Forms.ComboBox();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.tb_GST_Applied = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_GST_Applied = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Brand = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Customer_Details = new System.Windows.Forms.Label();
            this.lbl_Purchase_Details = new System.Windows.Forms.Label();
            this.pnl_Bill_Details = new System.Windows.Forms.Panel();
            this.tb_Total_Bill = new System.Windows.Forms.TextBox();
            this.tb_Discount = new System.Windows.Forms.TextBox();
            this.tb_Total_Price = new System.Windows.Forms.TextBox();
            this.lbl_Total_Bill = new System.Windows.Forms.Label();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.lbl_Total_Price = new System.Windows.Forms.Label();
            this.lbl_Bill_Details = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.pnl_Add_New_Customer.SuspendLayout();
            this.pnl_Customer_Details.SuspendLayout();
            this.pnl_Purchase_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Add_New_Customer)).BeginInit();
            this.pnl_Bill_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Add_New_Customer
            // 
            this.pnl_Add_New_Customer.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnl_Add_New_Customer.Controls.Add(this.btn_Back);
            this.pnl_Add_New_Customer.Controls.Add(this.btn_Log_Out);
            this.pnl_Add_New_Customer.Controls.Add(this.lbl_Add_New_Customer);
            this.pnl_Add_New_Customer.Location = new System.Drawing.Point(1, 1);
            this.pnl_Add_New_Customer.Name = "pnl_Add_New_Customer";
            this.pnl_Add_New_Customer.Size = new System.Drawing.Size(1923, 96);
            this.pnl_Add_New_Customer.TabIndex = 0;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Back.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Back.Location = new System.Drawing.Point(50, 23);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(147, 53);
            this.btn_Back.TabIndex = 18;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Log_Out.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Log_Out.BackgroundImage")));
            this.btn_Log_Out.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Log_Out.Location = new System.Drawing.Point(1351, 23);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(178, 53);
            this.btn_Log_Out.TabIndex = 19;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // lbl_Add_New_Customer
            // 
            this.lbl_Add_New_Customer.AutoSize = true;
            this.lbl_Add_New_Customer.Font = new System.Drawing.Font("Stencil", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Customer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Add_New_Customer.Location = new System.Drawing.Point(471, 8);
            this.lbl_Add_New_Customer.Name = "lbl_Add_New_Customer";
            this.lbl_Add_New_Customer.Size = new System.Drawing.Size(707, 83);
            this.lbl_Add_New_Customer.TabIndex = 0;
            this.lbl_Add_New_Customer.Text = "Add New Customer";
            // 
            // pnl_Customer_Details
            // 
            this.pnl_Customer_Details.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_Customer_Details.Controls.Add(this.dtp_Date);
            this.pnl_Customer_Details.Controls.Add(this.tb_Mob_No);
            this.pnl_Customer_Details.Controls.Add(this.tb_Customer_Name);
            this.pnl_Customer_Details.Controls.Add(this.lbl_Customer_Name);
            this.pnl_Customer_Details.Controls.Add(this.lbl_Date);
            this.pnl_Customer_Details.Controls.Add(this.tb_Customer_ID);
            this.pnl_Customer_Details.Controls.Add(this.lbl_Mobile_No);
            this.pnl_Customer_Details.Controls.Add(this.lbl_Customer_ID);
            this.pnl_Customer_Details.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Customer_Details.Location = new System.Drawing.Point(12, 131);
            this.pnl_Customer_Details.Name = "pnl_Customer_Details";
            this.pnl_Customer_Details.Size = new System.Drawing.Size(1900, 112);
            this.pnl_Customer_Details.TabIndex = 1;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(1090, 63);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(315, 37);
            this.dtp_Date.TabIndex = 4;
            this.dtp_Date.ValueChanged += new System.EventHandler(this.dtp_Date_ValueChanged);
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(1090, 22);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(315, 29);
            this.tb_Mob_No.TabIndex = 3;
            // 
            // tb_Customer_Name
            // 
            this.tb_Customer_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_Name.Location = new System.Drawing.Point(276, 66);
            this.tb_Customer_Name.Name = "tb_Customer_Name";
            this.tb_Customer_Name.Size = new System.Drawing.Size(315, 29);
            this.tb_Customer_Name.TabIndex = 2;
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Name.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Customer_Name.Location = new System.Drawing.Point(45, 66);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(180, 29);
            this.lbl_Customer_Name.TabIndex = 1;
            this.lbl_Customer_Name.Text = "Customer Name";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Date.Location = new System.Drawing.Point(833, 66);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(62, 29);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "Date";
            // 
            // tb_Customer_ID
            // 
            this.tb_Customer_ID.Enabled = false;
            this.tb_Customer_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_ID.Location = new System.Drawing.Point(276, 22);
            this.tb_Customer_ID.Name = "tb_Customer_ID";
            this.tb_Customer_ID.Size = new System.Drawing.Size(315, 29);
            this.tb_Customer_ID.TabIndex = 1;
            this.tb_Customer_ID.TextChanged += new System.EventHandler(this.tb_Customer_ID_TextChanged);
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(833, 22);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(121, 29);
            this.lbl_Mobile_No.TabIndex = 0;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_Customer_ID
            // 
            this.lbl_Customer_ID.AutoSize = true;
            this.lbl_Customer_ID.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Customer_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_ID.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Customer_ID.Location = new System.Drawing.Point(45, 22);
            this.lbl_Customer_ID.Name = "lbl_Customer_ID";
            this.lbl_Customer_ID.Size = new System.Drawing.Size(142, 29);
            this.lbl_Customer_ID.TabIndex = 0;
            this.lbl_Customer_ID.Text = "Customer ID";
            // 
            // pnl_Purchase_Details
            // 
            this.pnl_Purchase_Details.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_Purchase_Details.Controls.Add(this.tb_Per_Price);
            this.pnl_Purchase_Details.Controls.Add(this.lbl_Per_Price);
            this.pnl_Purchase_Details.Controls.Add(this.dgv_Add_New_Customer);
            this.pnl_Purchase_Details.Controls.Add(this.btn_Add);
            this.pnl_Purchase_Details.Controls.Add(this.cmb_Product_Name);
            this.pnl_Purchase_Details.Controls.Add(this.cmb_Brand);
            this.pnl_Purchase_Details.Controls.Add(this.cmb_Category);
            this.pnl_Purchase_Details.Controls.Add(this.tb_Price);
            this.pnl_Purchase_Details.Controls.Add(this.tb_Quantity);
            this.pnl_Purchase_Details.Controls.Add(this.tb_GST_Applied);
            this.pnl_Purchase_Details.Controls.Add(this.lbl_Price);
            this.pnl_Purchase_Details.Controls.Add(this.lbl_Quantity);
            this.pnl_Purchase_Details.Controls.Add(this.lbl_GST_Applied);
            this.pnl_Purchase_Details.Controls.Add(this.lbl_Product_Name);
            this.pnl_Purchase_Details.Controls.Add(this.lbl_Brand);
            this.pnl_Purchase_Details.Controls.Add(this.lbl_Category);
            this.pnl_Purchase_Details.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Purchase_Details.Location = new System.Drawing.Point(12, 258);
            this.pnl_Purchase_Details.Name = "pnl_Purchase_Details";
            this.pnl_Purchase_Details.Size = new System.Drawing.Size(1900, 354);
            this.pnl_Purchase_Details.TabIndex = 2;
            // 
            // tb_Per_Price
            // 
            this.tb_Per_Price.Enabled = false;
            this.tb_Per_Price.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Per_Price.Location = new System.Drawing.Point(276, 162);
            this.tb_Per_Price.Name = "tb_Per_Price";
            this.tb_Per_Price.Size = new System.Drawing.Size(225, 29);
            this.tb_Per_Price.TabIndex = 19;
            // 
            // lbl_Per_Price
            // 
            this.lbl_Per_Price.AutoSize = true;
            this.lbl_Per_Price.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Per_Price.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Per_Price.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Per_Price.Location = new System.Drawing.Point(45, 162);
            this.lbl_Per_Price.Name = "lbl_Per_Price";
            this.lbl_Per_Price.Size = new System.Drawing.Size(106, 29);
            this.lbl_Per_Price.TabIndex = 18;
            this.lbl_Per_Price.Text = "Per Price";
            // 
            // dgv_Add_New_Customer
            // 
            this.dgv_Add_New_Customer.AllowUserToAddRows = false;
            this.dgv_Add_New_Customer.AllowUserToDeleteRows = false;
            this.dgv_Add_New_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Add_New_Customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgv_Add_New_Customer.Location = new System.Drawing.Point(633, 24);
            this.dgv_Add_New_Customer.Name = "dgv_Add_New_Customer";
            this.dgv_Add_New_Customer.ReadOnly = true;
            this.dgv_Add_New_Customer.RowTemplate.Height = 24;
            this.dgv_Add_New_Customer.Size = new System.Drawing.Size(841, 311);
            this.dgv_Add_New_Customer.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Sr.No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Category";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Brand";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Product Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Per Price";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Quantity";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "GST Applied";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Price";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Add.Location = new System.Drawing.Point(519, 293);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(104, 42);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(276, 118);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(225, 30);
            this.cmb_Product_Name.TabIndex = 7;
            this.cmb_Product_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_Name_SelectedIndexChanged);
            // 
            // cmb_Brand
            // 
            this.cmb_Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Brand.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Brand.FormattingEnabled = true;
            this.cmb_Brand.Location = new System.Drawing.Point(276, 73);
            this.cmb_Brand.Name = "cmb_Brand";
            this.cmb_Brand.Size = new System.Drawing.Size(225, 30);
            this.cmb_Brand.TabIndex = 6;
            this.cmb_Brand.SelectedIndexChanged += new System.EventHandler(this.cmb_Brand_SelectedIndexChanged);
            // 
            // cmb_Category
            // 
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(276, 24);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(225, 30);
            this.cmb_Category.TabIndex = 5;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            // 
            // tb_Price
            // 
            this.tb_Price.Enabled = false;
            this.tb_Price.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(276, 306);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(225, 29);
            this.tb_Price.TabIndex = 10;
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(276, 208);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(225, 29);
            this.tb_Quantity.TabIndex = 9;
            this.tb_Quantity.TextChanged += new System.EventHandler(this.tb_Quantity_TextChanged);
            this.tb_Quantity.Leave += new System.EventHandler(this.tb_Quantity_Leave);
            // 
            // tb_GST_Applied
            // 
            this.tb_GST_Applied.Enabled = false;
            this.tb_GST_Applied.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GST_Applied.Location = new System.Drawing.Point(276, 259);
            this.tb_GST_Applied.Name = "tb_GST_Applied";
            this.tb_GST_Applied.Size = new System.Drawing.Size(225, 29);
            this.tb_GST_Applied.TabIndex = 8;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Price.Location = new System.Drawing.Point(45, 306);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(65, 29);
            this.lbl_Price.TabIndex = 5;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Quantity.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Quantity.Location = new System.Drawing.Point(45, 206);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(104, 29);
            this.lbl_Quantity.TabIndex = 4;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // lbl_GST_Applied
            // 
            this.lbl_GST_Applied.AutoSize = true;
            this.lbl_GST_Applied.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_GST_Applied.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GST_Applied.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_GST_Applied.Location = new System.Drawing.Point(45, 257);
            this.lbl_GST_Applied.Name = "lbl_GST_Applied";
            this.lbl_GST_Applied.Size = new System.Drawing.Size(141, 29);
            this.lbl_GST_Applied.TabIndex = 3;
            this.lbl_GST_Applied.Text = "GST Applied";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Product_Name.Location = new System.Drawing.Point(45, 122);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(163, 29);
            this.lbl_Product_Name.TabIndex = 2;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_Brand
            // 
            this.lbl_Brand.AutoSize = true;
            this.lbl_Brand.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Brand.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Brand.Location = new System.Drawing.Point(45, 73);
            this.lbl_Brand.Name = "lbl_Brand";
            this.lbl_Brand.Size = new System.Drawing.Size(75, 29);
            this.lbl_Brand.TabIndex = 1;
            this.lbl_Brand.Text = "Brand";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Category.Location = new System.Drawing.Point(45, 24);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(108, 29);
            this.lbl_Category.TabIndex = 0;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_Customer_Details
            // 
            this.lbl_Customer_Details.AutoSize = true;
            this.lbl_Customer_Details.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Details.Location = new System.Drawing.Point(26, 118);
            this.lbl_Customer_Details.Name = "lbl_Customer_Details";
            this.lbl_Customer_Details.Size = new System.Drawing.Size(174, 26);
            this.lbl_Customer_Details.TabIndex = 0;
            this.lbl_Customer_Details.Text = "Customer Details";
            // 
            // lbl_Purchase_Details
            // 
            this.lbl_Purchase_Details.AutoSize = true;
            this.lbl_Purchase_Details.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Purchase_Details.Location = new System.Drawing.Point(26, 246);
            this.lbl_Purchase_Details.Name = "lbl_Purchase_Details";
            this.lbl_Purchase_Details.Size = new System.Drawing.Size(169, 26);
            this.lbl_Purchase_Details.TabIndex = 1;
            this.lbl_Purchase_Details.Text = "Purchase Details";
            // 
            // pnl_Bill_Details
            // 
            this.pnl_Bill_Details.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_Bill_Details.Controls.Add(this.tb_Total_Bill);
            this.pnl_Bill_Details.Controls.Add(this.tb_Discount);
            this.pnl_Bill_Details.Controls.Add(this.tb_Total_Price);
            this.pnl_Bill_Details.Controls.Add(this.lbl_Total_Bill);
            this.pnl_Bill_Details.Controls.Add(this.lbl_Discount);
            this.pnl_Bill_Details.Controls.Add(this.lbl_Total_Price);
            this.pnl_Bill_Details.Location = new System.Drawing.Point(3, 642);
            this.pnl_Bill_Details.Name = "pnl_Bill_Details";
            this.pnl_Bill_Details.Size = new System.Drawing.Size(1900, 76);
            this.pnl_Bill_Details.TabIndex = 3;
            // 
            // tb_Total_Bill
            // 
            this.tb_Total_Bill.Enabled = false;
            this.tb_Total_Bill.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Bill.Location = new System.Drawing.Point(1196, 21);
            this.tb_Total_Bill.Name = "tb_Total_Bill";
            this.tb_Total_Bill.Size = new System.Drawing.Size(206, 29);
            this.tb_Total_Bill.TabIndex = 15;
            // 
            // tb_Discount
            // 
            this.tb_Discount.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Discount.Location = new System.Drawing.Point(713, 24);
            this.tb_Discount.Name = "tb_Discount";
            this.tb_Discount.Size = new System.Drawing.Size(206, 29);
            this.tb_Discount.TabIndex = 14;
            this.tb_Discount.Text = "0";
            this.tb_Discount.TextChanged += new System.EventHandler(this.tb_Discount_TextChanged);
            this.tb_Discount.Leave += new System.EventHandler(this.tb_Discount_Leave);
            // 
            // tb_Total_Price
            // 
            this.tb_Total_Price.Enabled = false;
            this.tb_Total_Price.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Price.Location = new System.Drawing.Point(219, 24);
            this.tb_Total_Price.Name = "tb_Total_Price";
            this.tb_Total_Price.Size = new System.Drawing.Size(204, 29);
            this.tb_Total_Price.TabIndex = 13;
            // 
            // lbl_Total_Bill
            // 
            this.lbl_Total_Bill.AutoSize = true;
            this.lbl_Total_Bill.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Total_Bill.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Bill.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Total_Bill.Location = new System.Drawing.Point(1044, 21);
            this.lbl_Total_Bill.Name = "lbl_Total_Bill";
            this.lbl_Total_Bill.Size = new System.Drawing.Size(104, 29);
            this.lbl_Total_Bill.TabIndex = 2;
            this.lbl_Total_Bill.Text = "Total Bill";
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Discount.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Discount.Location = new System.Drawing.Point(564, 27);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(104, 29);
            this.lbl_Discount.TabIndex = 1;
            this.lbl_Discount.Text = "Discount";
            // 
            // lbl_Total_Price
            // 
            this.lbl_Total_Price.AutoSize = true;
            this.lbl_Total_Price.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Total_Price.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Price.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Total_Price.Location = new System.Drawing.Point(60, 27);
            this.lbl_Total_Price.Name = "lbl_Total_Price";
            this.lbl_Total_Price.Size = new System.Drawing.Size(124, 29);
            this.lbl_Total_Price.TabIndex = 0;
            this.lbl_Total_Price.Text = "Total Price";
            // 
            // lbl_Bill_Details
            // 
            this.lbl_Bill_Details.AutoSize = true;
            this.lbl_Bill_Details.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Bill_Details.Location = new System.Drawing.Point(26, 627);
            this.lbl_Bill_Details.Name = "lbl_Bill_Details";
            this.lbl_Bill_Details.Size = new System.Drawing.Size(115, 26);
            this.lbl_Bill_Details.TabIndex = 0;
            this.lbl_Bill_Details.Text = "Bill Details";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(403, 738);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(133, 46);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Tomato;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.Location = new System.Drawing.Point(957, 738);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(166, 46);
            this.btn_Refresh.TabIndex = 17;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Add_New_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.lbl_Bill_Details);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_Purchase_Details);
            this.Controls.Add(this.pnl_Bill_Details);
            this.Controls.Add(this.lbl_Customer_Details);
            this.Controls.Add(this.pnl_Purchase_Details);
            this.Controls.Add(this.pnl_Customer_Details);
            this.Controls.Add(this.pnl_Add_New_Customer);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Add_New_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_New_Customer_Load);
            this.pnl_Add_New_Customer.ResumeLayout(false);
            this.pnl_Add_New_Customer.PerformLayout();
            this.pnl_Customer_Details.ResumeLayout(false);
            this.pnl_Customer_Details.PerformLayout();
            this.pnl_Purchase_Details.ResumeLayout(false);
            this.pnl_Purchase_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Add_New_Customer)).EndInit();
            this.pnl_Bill_Details.ResumeLayout(false);
            this.pnl_Bill_Details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Add_New_Customer;
        private System.Windows.Forms.Label lbl_Add_New_Customer;
        private System.Windows.Forms.Panel pnl_Customer_Details;
        private System.Windows.Forms.TextBox tb_Customer_Name;
        private System.Windows.Forms.Label lbl_Customer_Name;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_Customer_ID;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Customer_ID;
        private System.Windows.Forms.Panel pnl_Purchase_Details;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.Label lbl_Customer_Details;
        private System.Windows.Forms.Label lbl_Purchase_Details;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.TextBox tb_GST_Applied;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_GST_Applied;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Brand;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.ComboBox cmb_Brand;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Panel pnl_Bill_Details;
        private System.Windows.Forms.TextBox tb_Total_Bill;
        private System.Windows.Forms.TextBox tb_Discount;
        private System.Windows.Forms.TextBox tb_Total_Price;
        private System.Windows.Forms.Label lbl_Total_Bill;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.Label lbl_Total_Price;
        private System.Windows.Forms.Label lbl_Bill_Details;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.DataGridView dgv_Add_New_Customer;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox tb_Per_Price;
        private System.Windows.Forms.Label lbl_Per_Price;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}