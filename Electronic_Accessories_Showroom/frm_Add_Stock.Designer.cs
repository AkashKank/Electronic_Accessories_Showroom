namespace Electronic_Accessories_Showroom
{
    partial class frm_Add_Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_Stock));
            this.pnl_Add_Stock = new System.Windows.Forms.Panel();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Add_Stock = new System.Windows.Forms.Label();
            this.pnl_Stock_Details = new System.Windows.Forms.Panel();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Current_Stock_Quantity = new System.Windows.Forms.TextBox();
            this.tb_New_Stock_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_New_Stock_Quantity = new System.Windows.Forms.Label();
            this.lbl_Current_Stock_Quantity = new System.Windows.Forms.Label();
            this.pnl_Category = new System.Windows.Forms.Panel();
            this.cmb_Brand = new System.Windows.Forms.ComboBox();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Brand = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Stock_Details = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.pnl_Add_Stock.SuspendLayout();
            this.pnl_Stock_Details.SuspendLayout();
            this.pnl_Category.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Add_Stock
            // 
            this.pnl_Add_Stock.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnl_Add_Stock.Controls.Add(this.btn_Log_Out);
            this.pnl_Add_Stock.Controls.Add(this.btn_Back);
            this.pnl_Add_Stock.Controls.Add(this.lbl_Add_Stock);
            this.pnl_Add_Stock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_Add_Stock.Location = new System.Drawing.Point(1, 0);
            this.pnl_Add_Stock.Name = "pnl_Add_Stock";
            this.pnl_Add_Stock.Size = new System.Drawing.Size(2146, 127);
            this.pnl_Add_Stock.TabIndex = 1;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.Orange;
            this.btn_Log_Out.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Log_Out.BackgroundImage")));
            this.btn_Log_Out.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Log_Out.Location = new System.Drawing.Point(1726, 18);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(185, 55);
            this.btn_Log_Out.TabIndex = 10;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Back.Location = new System.Drawing.Point(67, 18);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(150, 55);
            this.btn_Back.TabIndex = 9;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_Add_Stock
            // 
            this.lbl_Add_Stock.AutoSize = true;
            this.lbl_Add_Stock.Font = new System.Drawing.Font("Stencil", 42F, System.Drawing.FontStyle.Bold);
            this.lbl_Add_Stock.Location = new System.Drawing.Point(858, 27);
            this.lbl_Add_Stock.Name = "lbl_Add_Stock";
            this.lbl_Add_Stock.Size = new System.Drawing.Size(412, 83);
            this.lbl_Add_Stock.TabIndex = 0;
            this.lbl_Add_Stock.Text = "Add Stock";
            // 
            // pnl_Stock_Details
            // 
            this.pnl_Stock_Details.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_Stock_Details.Controls.Add(this.dtp_Date);
            this.pnl_Stock_Details.Controls.Add(this.tb_Current_Stock_Quantity);
            this.pnl_Stock_Details.Controls.Add(this.tb_New_Stock_Quantity);
            this.pnl_Stock_Details.Controls.Add(this.lbl_Date);
            this.pnl_Stock_Details.Controls.Add(this.lbl_New_Stock_Quantity);
            this.pnl_Stock_Details.Controls.Add(this.lbl_Current_Stock_Quantity);
            this.pnl_Stock_Details.Controls.Add(this.pnl_Category);
            this.pnl_Stock_Details.Location = new System.Drawing.Point(68, 173);
            this.pnl_Stock_Details.Name = "pnl_Stock_Details";
            this.pnl_Stock_Details.Size = new System.Drawing.Size(1915, 702);
            this.pnl_Stock_Details.TabIndex = 2;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(1436, 166);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(373, 33);
            this.dtp_Date.TabIndex = 4;
            // 
            // tb_Current_Stock_Quantity
            // 
            this.tb_Current_Stock_Quantity.Enabled = false;
            this.tb_Current_Stock_Quantity.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Current_Stock_Quantity.Location = new System.Drawing.Point(1436, 320);
            this.tb_Current_Stock_Quantity.MaxLength = 10;
            this.tb_Current_Stock_Quantity.Name = "tb_Current_Stock_Quantity";
            this.tb_Current_Stock_Quantity.Size = new System.Drawing.Size(373, 33);
            this.tb_Current_Stock_Quantity.TabIndex = 5;
            this.tb_Current_Stock_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Current_Stock_Quantity_KeyPress);
            // 
            // tb_New_Stock_Quantity
            // 
            this.tb_New_Stock_Quantity.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_New_Stock_Quantity.Location = new System.Drawing.Point(1436, 480);
            this.tb_New_Stock_Quantity.MaxLength = 10;
            this.tb_New_Stock_Quantity.Name = "tb_New_Stock_Quantity";
            this.tb_New_Stock_Quantity.Size = new System.Drawing.Size(373, 33);
            this.tb_New_Stock_Quantity.TabIndex = 6;
            this.tb_New_Stock_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_New_Stock_Quantity_KeyPress);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Date.Location = new System.Drawing.Point(1058, 163);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(70, 33);
            this.lbl_Date.TabIndex = 17;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_New_Stock_Quantity
            // 
            this.lbl_New_Stock_Quantity.AutoSize = true;
            this.lbl_New_Stock_Quantity.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_New_Stock_Quantity.Font = new System.Drawing.Font("Microsoft Tai Le", 15.8F, System.Drawing.FontStyle.Bold);
            this.lbl_New_Stock_Quantity.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_New_Stock_Quantity.Location = new System.Drawing.Point(1058, 475);
            this.lbl_New_Stock_Quantity.Name = "lbl_New_Stock_Quantity";
            this.lbl_New_Stock_Quantity.Size = new System.Drawing.Size(270, 34);
            this.lbl_New_Stock_Quantity.TabIndex = 16;
            this.lbl_New_Stock_Quantity.Text = "New Stock Quantity";
            // 
            // lbl_Current_Stock_Quantity
            // 
            this.lbl_Current_Stock_Quantity.AutoSize = true;
            this.lbl_Current_Stock_Quantity.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Current_Stock_Quantity.Font = new System.Drawing.Font("Microsoft Tai Le", 15.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Current_Stock_Quantity.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Current_Stock_Quantity.Location = new System.Drawing.Point(1058, 315);
            this.lbl_Current_Stock_Quantity.Name = "lbl_Current_Stock_Quantity";
            this.lbl_Current_Stock_Quantity.Size = new System.Drawing.Size(309, 34);
            this.lbl_Current_Stock_Quantity.TabIndex = 15;
            this.lbl_Current_Stock_Quantity.Text = "Current Stock Quantity";
            // 
            // pnl_Category
            // 
            this.pnl_Category.BackColor = System.Drawing.Color.Silver;
            this.pnl_Category.Controls.Add(this.cmb_Brand);
            this.pnl_Category.Controls.Add(this.cmb_Product_Name);
            this.pnl_Category.Controls.Add(this.cmb_Category);
            this.pnl_Category.Controls.Add(this.lbl_Product_Name);
            this.pnl_Category.Controls.Add(this.lbl_Brand);
            this.pnl_Category.Controls.Add(this.lbl_Category);
            this.pnl_Category.Location = new System.Drawing.Point(86, 64);
            this.pnl_Category.Name = "pnl_Category";
            this.pnl_Category.Size = new System.Drawing.Size(849, 569);
            this.pnl_Category.TabIndex = 0;
            this.pnl_Category.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Category_Paint);
            // 
            // cmb_Brand
            // 
            this.cmb_Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Brand.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Brand.FormattingEnabled = true;
            this.cmb_Brand.Location = new System.Drawing.Point(367, 255);
            this.cmb_Brand.MaxLength = 50;
            this.cmb_Brand.Name = "cmb_Brand";
            this.cmb_Brand.Size = new System.Drawing.Size(373, 34);
            this.cmb_Brand.TabIndex = 2;
            this.cmb_Brand.SelectedIndexChanged += new System.EventHandler(this.cmb_Brand_SelectedIndexChanged);
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(367, 415);
            this.cmb_Product_Name.MaxLength = 50;
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(373, 34);
            this.cmb_Product_Name.TabIndex = 3;
            this.cmb_Product_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_Name_SelectedIndexChanged);
            // 
            // cmb_Category
            // 
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(367, 103);
            this.cmb_Category.MaxLength = 50;
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(373, 34);
            this.cmb_Category.TabIndex = 1;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 15.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Product_Name.Location = new System.Drawing.Point(75, 411);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(200, 34);
            this.lbl_Product_Name.TabIndex = 5;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_Brand
            // 
            this.lbl_Brand.AutoSize = true;
            this.lbl_Brand.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Brand.Font = new System.Drawing.Font("Microsoft Tai Le", 15.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Brand.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Brand.Location = new System.Drawing.Point(75, 251);
            this.lbl_Brand.Name = "lbl_Brand";
            this.lbl_Brand.Size = new System.Drawing.Size(91, 34);
            this.lbl_Brand.TabIndex = 4;
            this.lbl_Brand.Text = "Brand";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Tai Le", 15.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Category.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Category.Location = new System.Drawing.Point(75, 99);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(140, 34);
            this.lbl_Category.TabIndex = 3;
            this.lbl_Category.Text = "Category ";
            // 
            // lbl_Stock_Details
            // 
            this.lbl_Stock_Details.AutoSize = true;
            this.lbl_Stock_Details.BackColor = System.Drawing.Color.LightGray;
            this.lbl_Stock_Details.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Stock_Details.Location = new System.Drawing.Point(100, 155);
            this.lbl_Stock_Details.Name = "lbl_Stock_Details";
            this.lbl_Stock_Details.Size = new System.Drawing.Size(147, 29);
            this.lbl_Stock_Details.TabIndex = 10;
            this.lbl_Stock_Details.Text = "Stock Details";
            this.lbl_Stock_Details.Click += new System.EventHandler(this.lbl_Stock_Details_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(576, 894);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(183, 55);
            this.btn_Submit.TabIndex = 7;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Tomato;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(1301, 894);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(189, 55);
            this.btn_Refresh.TabIndex = 8;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Add_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.lbl_Stock_Details);
            this.Controls.Add(this.pnl_Stock_Details);
            this.Controls.Add(this.pnl_Add_Stock);
            this.Name = "frm_Add_Stock";
            this.Text = "Add Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_Stock_Load);
            this.pnl_Add_Stock.ResumeLayout(false);
            this.pnl_Add_Stock.PerformLayout();
            this.pnl_Stock_Details.ResumeLayout(false);
            this.pnl_Stock_Details.PerformLayout();
            this.pnl_Category.ResumeLayout(false);
            this.pnl_Category.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Add_Stock;
        private System.Windows.Forms.Label lbl_Add_Stock;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Panel pnl_Stock_Details;
        private System.Windows.Forms.Label lbl_Stock_Details;
        private System.Windows.Forms.Panel pnl_Category;
        private System.Windows.Forms.Label lbl_Brand;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.ComboBox cmb_Brand;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.TextBox tb_Current_Stock_Quantity;
        private System.Windows.Forms.TextBox tb_New_Stock_Quantity;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_New_Stock_Quantity;
        private System.Windows.Forms.Label lbl_Current_Stock_Quantity;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Refresh;
    }
}