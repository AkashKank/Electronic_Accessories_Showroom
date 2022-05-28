namespace Electronic_Accessories_Showroom
{
    partial class frm_Add_New_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_Product));
            this.pnl_Add_New_Product = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.lbl_Add_New_Product = new System.Windows.Forms.Label();
            this.pnl_Product_Details = new System.Windows.Forms.Panel();
            this.cmb_Brand = new System.Windows.Forms.ComboBox();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.tb_GST_Applied = new System.Windows.Forms.TextBox();
            this.tb_Stock_Quantity = new System.Windows.Forms.TextBox();
            this.tb_Purchase_Prize = new System.Windows.Forms.TextBox();
            this.tb_Sales_Rate = new System.Windows.Forms.TextBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_GST_Applied = new System.Windows.Forms.Label();
            this.lbl_Stock_Quantity = new System.Windows.Forms.Label();
            this.lbl_Purchase_Prize = new System.Windows.Forms.Label();
            this.lbl_Sales_Rate = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.cmb_Distributor_Name = new System.Windows.Forms.ComboBox();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Distributor_Name = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Brand = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Product_ID = new System.Windows.Forms.Label();
            this.lbl_Product_Details = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.pnl_Add_New_Product.SuspendLayout();
            this.pnl_Product_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Add_New_Product
            // 
            this.pnl_Add_New_Product.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnl_Add_New_Product.Controls.Add(this.btn_Back);
            this.pnl_Add_New_Product.Controls.Add(this.btn_Log_Out);
            this.pnl_Add_New_Product.Controls.Add(this.lbl_Add_New_Product);
            this.pnl_Add_New_Product.Location = new System.Drawing.Point(1, 1);
            this.pnl_Add_New_Product.Name = "pnl_Add_New_Product";
            this.pnl_Add_New_Product.Size = new System.Drawing.Size(2248, 123);
            this.pnl_Add_New_Product.TabIndex = 0;
            // 
            // btn_Back
            // 
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Back.Location = new System.Drawing.Point(75, 17);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(150, 55);
            this.btn_Back.TabIndex = 14;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Log_Out.BackgroundImage")));
            this.btn_Log_Out.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Log_Out.Location = new System.Drawing.Point(1725, 17);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(186, 55);
            this.btn_Log_Out.TabIndex = 15;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = true;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // lbl_Add_New_Product
            // 
            this.lbl_Add_New_Product.AutoSize = true;
            this.lbl_Add_New_Product.Font = new System.Drawing.Font("Stencil", 42F, System.Drawing.FontStyle.Bold);
            this.lbl_Add_New_Product.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Add_New_Product.Location = new System.Drawing.Point(680, 18);
            this.lbl_Add_New_Product.Name = "lbl_Add_New_Product";
            this.lbl_Add_New_Product.Size = new System.Drawing.Size(677, 83);
            this.lbl_Add_New_Product.TabIndex = 0;
            this.lbl_Add_New_Product.Text = "Add New Product";
            // 
            // pnl_Product_Details
            // 
            this.pnl_Product_Details.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_Product_Details.Controls.Add(this.cmb_Brand);
            this.pnl_Product_Details.Controls.Add(this.tb_Description);
            this.pnl_Product_Details.Controls.Add(this.tb_GST_Applied);
            this.pnl_Product_Details.Controls.Add(this.tb_Stock_Quantity);
            this.pnl_Product_Details.Controls.Add(this.tb_Purchase_Prize);
            this.pnl_Product_Details.Controls.Add(this.tb_Sales_Rate);
            this.pnl_Product_Details.Controls.Add(this.dtp_Date);
            this.pnl_Product_Details.Controls.Add(this.lbl_GST_Applied);
            this.pnl_Product_Details.Controls.Add(this.lbl_Stock_Quantity);
            this.pnl_Product_Details.Controls.Add(this.lbl_Purchase_Prize);
            this.pnl_Product_Details.Controls.Add(this.lbl_Sales_Rate);
            this.pnl_Product_Details.Controls.Add(this.lbl_Date);
            this.pnl_Product_Details.Controls.Add(this.tb_Product_Name);
            this.pnl_Product_Details.Controls.Add(this.cmb_Distributor_Name);
            this.pnl_Product_Details.Controls.Add(this.tb_Product_ID);
            this.pnl_Product_Details.Controls.Add(this.cmb_Category);
            this.pnl_Product_Details.Controls.Add(this.lbl_Description);
            this.pnl_Product_Details.Controls.Add(this.lbl_Distributor_Name);
            this.pnl_Product_Details.Controls.Add(this.lbl_Product_Name);
            this.pnl_Product_Details.Controls.Add(this.lbl_Brand);
            this.pnl_Product_Details.Controls.Add(this.lbl_Category);
            this.pnl_Product_Details.Controls.Add(this.lbl_Product_ID);
            this.pnl_Product_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Product_Details.Location = new System.Drawing.Point(90, 154);
            this.pnl_Product_Details.Name = "pnl_Product_Details";
            this.pnl_Product_Details.Size = new System.Drawing.Size(1891, 685);
            this.pnl_Product_Details.TabIndex = 1;
            // 
            // cmb_Brand
            // 
            this.cmb_Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Brand.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.cmb_Brand.FormattingEnabled = true;
            this.cmb_Brand.Location = new System.Drawing.Point(487, 272);
            this.cmb_Brand.MaxLength = 50;
            this.cmb_Brand.Name = "cmb_Brand";
            this.cmb_Brand.Size = new System.Drawing.Size(325, 34);
            this.cmb_Brand.TabIndex = 5;
            //this.cmb_Brand.SelectedIndexChanged += new System.EventHandler(this.cmb_Brand_SelectedIndexChanged);
            // 
            // tb_Description
            // 
            this.tb_Description.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Description.Location = new System.Drawing.Point(889, 559);
            this.tb_Description.MaxLength = 60;
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(361, 91);
            this.tb_Description.TabIndex = 11;
            // 
            // tb_GST_Applied
            // 
            this.tb_GST_Applied.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.tb_GST_Applied.Location = new System.Drawing.Point(1311, 464);
            this.tb_GST_Applied.MaxLength = 10;
            this.tb_GST_Applied.Name = "tb_GST_Applied";
            this.tb_GST_Applied.Size = new System.Drawing.Size(325, 33);
            this.tb_GST_Applied.TabIndex = 10;
            // 
            // tb_Stock_Quantity
            // 
            this.tb_Stock_Quantity.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Stock_Quantity.Location = new System.Drawing.Point(1311, 364);
            this.tb_Stock_Quantity.MaxLength = 10;
            this.tb_Stock_Quantity.Name = "tb_Stock_Quantity";
            this.tb_Stock_Quantity.Size = new System.Drawing.Size(325, 33);
            this.tb_Stock_Quantity.TabIndex = 9;
            this.tb_Stock_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Stock_Quantity_KeyPress);
            // 
            // tb_Purchase_Prize
            // 
            this.tb_Purchase_Prize.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Purchase_Prize.Location = new System.Drawing.Point(1311, 271);
            this.tb_Purchase_Prize.MaxLength = 10;
            this.tb_Purchase_Prize.Name = "tb_Purchase_Prize";
            this.tb_Purchase_Prize.Size = new System.Drawing.Size(325, 33);
            this.tb_Purchase_Prize.TabIndex = 8;
            this.tb_Purchase_Prize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Purchase_Prize_KeyPress);
            // 
            // tb_Sales_Rate
            // 
            this.tb_Sales_Rate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Sales_Rate.Location = new System.Drawing.Point(1311, 178);
            this.tb_Sales_Rate.MaxLength = 10;
            this.tb_Sales_Rate.Name = "tb_Sales_Rate";
            this.tb_Sales_Rate.Size = new System.Drawing.Size(325, 33);
            this.tb_Sales_Rate.TabIndex = 7;
            this.tb_Sales_Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Sales_Rate_KeyPress);
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.dtp_Date.Location = new System.Drawing.Point(1311, 80);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(325, 33);
            this.dtp_Date.TabIndex = 6;
            // 
            // lbl_GST_Applied
            // 
            this.lbl_GST_Applied.AutoSize = true;
            this.lbl_GST_Applied.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_GST_Applied.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GST_Applied.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_GST_Applied.Location = new System.Drawing.Point(1007, 465);
            this.lbl_GST_Applied.Name = "lbl_GST_Applied";
            this.lbl_GST_Applied.Size = new System.Drawing.Size(154, 31);
            this.lbl_GST_Applied.TabIndex = 15;
            this.lbl_GST_Applied.Text = "GST Applied";
            // 
            // lbl_Stock_Quantity
            // 
            this.lbl_Stock_Quantity.AutoSize = true;
            this.lbl_Stock_Quantity.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Stock_Quantity.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock_Quantity.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Stock_Quantity.Location = new System.Drawing.Point(1007, 365);
            this.lbl_Stock_Quantity.Name = "lbl_Stock_Quantity";
            this.lbl_Stock_Quantity.Size = new System.Drawing.Size(182, 31);
            this.lbl_Stock_Quantity.TabIndex = 14;
            this.lbl_Stock_Quantity.Text = "Stock Quantity";
            // 
            // lbl_Purchase_Prize
            // 
            this.lbl_Purchase_Prize.AutoSize = true;
            this.lbl_Purchase_Prize.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Purchase_Prize.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Prize.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Purchase_Prize.Location = new System.Drawing.Point(1007, 272);
            this.lbl_Purchase_Prize.Name = "lbl_Purchase_Prize";
            this.lbl_Purchase_Prize.Size = new System.Drawing.Size(181, 31);
            this.lbl_Purchase_Prize.TabIndex = 13;
            this.lbl_Purchase_Prize.Text = "Purchase Prize";
            // 
            // lbl_Sales_Rate
            // 
            this.lbl_Sales_Rate.AutoSize = true;
            this.lbl_Sales_Rate.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Sales_Rate.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sales_Rate.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Sales_Rate.Location = new System.Drawing.Point(1007, 179);
            this.lbl_Sales_Rate.Name = "lbl_Sales_Rate";
            this.lbl_Sales_Rate.Size = new System.Drawing.Size(129, 31);
            this.lbl_Sales_Rate.TabIndex = 12;
            this.lbl_Sales_Rate.Text = "Sales Rate";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Date.Location = new System.Drawing.Point(1007, 83);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(67, 31);
            this.lbl_Date.TabIndex = 11;
            this.lbl_Date.Text = "Date";
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Product_Name.Location = new System.Drawing.Point(487, 364);
            this.tb_Product_Name.MaxLength = 50;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(325, 33);
            this.tb_Product_Name.TabIndex = 4;
            this.tb_Product_Name.TextChanged += new System.EventHandler(this.tb_Product_Name_TextChanged);
            // 
            // cmb_Distributor_Name
            // 
            this.cmb_Distributor_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.cmb_Distributor_Name.FormattingEnabled = true;
            this.cmb_Distributor_Name.Location = new System.Drawing.Point(487, 464);
            this.cmb_Distributor_Name.MaxLength = 50;
            this.cmb_Distributor_Name.Name = "cmb_Distributor_Name";
            this.cmb_Distributor_Name.Size = new System.Drawing.Size(325, 34);
            this.cmb_Distributor_Name.TabIndex = 5;
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Enabled = false;
            this.tb_Product_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Product_ID.Location = new System.Drawing.Point(487, 79);
            this.tb_Product_ID.MaxLength = 10;
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(325, 33);
            this.tb_Product_ID.TabIndex = 1;
            this.tb_Product_ID.TextChanged += new System.EventHandler(this.tb_Product_ID_TextChanged);
            // 
            // cmb_Category
            // 
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(487, 178);
            this.cmb_Category.MaxLength = 50;
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(325, 34);
            this.cmb_Category.TabIndex = 2;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Description.Location = new System.Drawing.Point(684, 586);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(146, 31);
            this.lbl_Description.TabIndex = 5;
            this.lbl_Description.Text = "Description";
            // 
            // lbl_Distributor_Name
            // 
            this.lbl_Distributor_Name.AutoSize = true;
            this.lbl_Distributor_Name.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Distributor_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distributor_Name.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Distributor_Name.Location = new System.Drawing.Point(178, 465);
            this.lbl_Distributor_Name.Name = "lbl_Distributor_Name";
            this.lbl_Distributor_Name.Size = new System.Drawing.Size(214, 31);
            this.lbl_Distributor_Name.TabIndex = 4;
            this.lbl_Distributor_Name.Text = "Distributor Name";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Product_Name.Location = new System.Drawing.Point(178, 365);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(179, 31);
            this.lbl_Product_Name.TabIndex = 3;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_Brand
            // 
            this.lbl_Brand.AutoSize = true;
            this.lbl_Brand.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Brand.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Brand.Location = new System.Drawing.Point(178, 272);
            this.lbl_Brand.Name = "lbl_Brand";
            this.lbl_Brand.Size = new System.Drawing.Size(82, 31);
            this.lbl_Brand.TabIndex = 2;
            this.lbl_Brand.Text = "Brand";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Category.Location = new System.Drawing.Point(178, 179);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(117, 31);
            this.lbl_Category.TabIndex = 1;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_Product_ID
            // 
            this.lbl_Product_ID.AutoSize = true;
            this.lbl_Product_ID.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Product_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_ID.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Product_ID.Location = new System.Drawing.Point(178, 83);
            this.lbl_Product_ID.Name = "lbl_Product_ID";
            this.lbl_Product_ID.Size = new System.Drawing.Size(138, 31);
            this.lbl_Product_ID.TabIndex = 0;
            this.lbl_Product_ID.Text = "Product ID";
            // 
            // lbl_Product_Details
            // 
            this.lbl_Product_Details.AutoSize = true;
            this.lbl_Product_Details.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Product_Details.Location = new System.Drawing.Point(144, 141);
            this.lbl_Product_Details.Name = "lbl_Product_Details";
            this.lbl_Product_Details.Size = new System.Drawing.Size(173, 29);
            this.lbl_Product_Details.TabIndex = 2;
            this.lbl_Product_Details.Text = "Product Details";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(636, 876);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(141, 56);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Tomato;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(1271, 876);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(177, 56);
            this.btn_Refresh.TabIndex = 13;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Add_New_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_Product_Details);
            this.Controls.Add(this.pnl_Product_Details);
            this.Controls.Add(this.pnl_Add_New_Product);
            this.Name = "frm_Add_New_Product";
            this.Text = "Add New Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_New_Product_Load);
            this.pnl_Add_New_Product.ResumeLayout(false);
            this.pnl_Add_New_Product.PerformLayout();
            this.pnl_Product_Details.ResumeLayout(false);
            this.pnl_Product_Details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Add_New_Product;
        private System.Windows.Forms.Label lbl_Add_New_Product;
        private System.Windows.Forms.Panel pnl_Product_Details;
        private System.Windows.Forms.Label lbl_Product_Details;
        private System.Windows.Forms.Label lbl_Product_ID;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_Distributor_Name;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Brand;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_GST_Applied;
        private System.Windows.Forms.Label lbl_Stock_Quantity;
        private System.Windows.Forms.Label lbl_Purchase_Prize;
        private System.Windows.Forms.Label lbl_Sales_Rate;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.ComboBox cmb_Distributor_Name;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.TextBox tb_GST_Applied;
        private System.Windows.Forms.TextBox tb_Stock_Quantity;
        private System.Windows.Forms.TextBox tb_Purchase_Prize;
        private System.Windows.Forms.TextBox tb_Sales_Rate;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.ComboBox cmb_Brand;
    }
}