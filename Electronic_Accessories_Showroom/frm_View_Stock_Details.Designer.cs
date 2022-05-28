namespace Electronic_Accessories_Showroom
{
    partial class frm_View_Stock_Details
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_View_Stock_Details));
            this.pnl_View_Stock_Details = new System.Windows.Forms.Panel();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_View_Stock_Details = new System.Windows.Forms.Label();
            this.pnl_Category = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.cmb_Category_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.pnl_Stock_Details = new System.Windows.Forms.Panel();
            this.dgv_Stock_Details = new System.Windows.Forms.DataGridView();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentStockQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newStockQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Electronic_Accessories_ShowroomDataSet3 = new Electronic_Accessories_Showroom.DB_Electronic_Accessories_ShowroomDataSet3();
            this.lbl_Stock_Details = new System.Windows.Forms.Label();
            this.stock_DetailsTableAdapter = new Electronic_Accessories_Showroom.DB_Electronic_Accessories_ShowroomDataSet3TableAdapters.Stock_DetailsTableAdapter();
            this.pnl_View_Stock_Details.SuspendLayout();
            this.pnl_Category.SuspendLayout();
            this.pnl_Stock_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stock_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Electronic_Accessories_ShowroomDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_View_Stock_Details
            // 
            this.pnl_View_Stock_Details.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnl_View_Stock_Details.Controls.Add(this.btn_Log_Out);
            this.pnl_View_Stock_Details.Controls.Add(this.btn_Back);
            this.pnl_View_Stock_Details.Controls.Add(this.lbl_View_Stock_Details);
            this.pnl_View_Stock_Details.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_View_Stock_Details.Location = new System.Drawing.Point(1, 0);
            this.pnl_View_Stock_Details.Name = "pnl_View_Stock_Details";
            this.pnl_View_Stock_Details.Size = new System.Drawing.Size(2131, 122);
            this.pnl_View_Stock_Details.TabIndex = 2;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.Orange;
            this.btn_Log_Out.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Log_Out.BackgroundImage")));
            this.btn_Log_Out.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Log_Out.Location = new System.Drawing.Point(1786, 18);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(189, 55);
            this.btn_Log_Out.TabIndex = 6;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Back.Location = new System.Drawing.Point(85, 18);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(147, 55);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_View_Stock_Details
            // 
            this.lbl_View_Stock_Details.AutoSize = true;
            this.lbl_View_Stock_Details.Font = new System.Drawing.Font("Stencil", 42F, System.Drawing.FontStyle.Bold);
            this.lbl_View_Stock_Details.Location = new System.Drawing.Point(715, 18);
            this.lbl_View_Stock_Details.Name = "lbl_View_Stock_Details";
            this.lbl_View_Stock_Details.Size = new System.Drawing.Size(749, 83);
            this.lbl_View_Stock_Details.TabIndex = 0;
            this.lbl_View_Stock_Details.Text = "View Stock Details";
            // 
            // pnl_Category
            // 
            this.pnl_Category.BackColor = System.Drawing.Color.Silver;
            this.pnl_Category.Controls.Add(this.btn_Search);
            this.pnl_Category.Controls.Add(this.btn_Refresh);
            this.pnl_Category.Controls.Add(this.cmb_Category_Name);
            this.pnl_Category.Controls.Add(this.lbl_Category_Name);
            this.pnl_Category.Location = new System.Drawing.Point(121, 143);
            this.pnl_Category.Name = "pnl_Category";
            this.pnl_Category.Size = new System.Drawing.Size(1761, 181);
            this.pnl_Category.TabIndex = 3;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(1180, 49);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(188, 60);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Tomato;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(1476, 49);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(206, 60);
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // cmb_Category_Name
            // 
            this.cmb_Category_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold);
            this.cmb_Category_Name.FormattingEnabled = true;
            this.cmb_Category_Name.Location = new System.Drawing.Point(576, 68);
            this.cmb_Category_Name.MaxLength = 50;
            this.cmb_Category_Name.Name = "cmb_Category_Name";
            this.cmb_Category_Name.Size = new System.Drawing.Size(406, 37);
            this.cmb_Category_Name.TabIndex = 1;
            this.cmb_Category_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_Name_SelectedIndexChanged);
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Name.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Category_Name.Location = new System.Drawing.Point(180, 68);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(198, 33);
            this.lbl_Category_Name.TabIndex = 3;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // pnl_Stock_Details
            // 
            this.pnl_Stock_Details.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_Stock_Details.Controls.Add(this.dgv_Stock_Details);
            this.pnl_Stock_Details.Location = new System.Drawing.Point(41, 407);
            this.pnl_Stock_Details.Name = "pnl_Stock_Details";
            this.pnl_Stock_Details.Size = new System.Drawing.Size(1918, 553);
            this.pnl_Stock_Details.TabIndex = 4;
            // 
            // dgv_Stock_Details
            // 
            this.dgv_Stock_Details.AutoGenerateColumns = false;
            this.dgv_Stock_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Stock_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Stock_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.currentStockQuantityDataGridViewTextBoxColumn,
            this.newStockQuantityDataGridViewTextBoxColumn});
            this.dgv_Stock_Details.DataSource = this.stockDetailsBindingSource;
            this.dgv_Stock_Details.Location = new System.Drawing.Point(25, 18);
            this.dgv_Stock_Details.Name = "dgv_Stock_Details";
            this.dgv_Stock_Details.RowTemplate.Height = 24;
            this.dgv_Stock_Details.Size = new System.Drawing.Size(1864, 510);
            this.dgv_Stock_Details.TabIndex = 0;
            this.dgv_Stock_Details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Stock_Details_CellContentClick);
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // currentStockQuantityDataGridViewTextBoxColumn
            // 
            this.currentStockQuantityDataGridViewTextBoxColumn.DataPropertyName = "Current_Stock_Quantity";
            this.currentStockQuantityDataGridViewTextBoxColumn.HeaderText = "Current_Stock_Quantity";
            this.currentStockQuantityDataGridViewTextBoxColumn.Name = "currentStockQuantityDataGridViewTextBoxColumn";
            // 
            // newStockQuantityDataGridViewTextBoxColumn
            // 
            this.newStockQuantityDataGridViewTextBoxColumn.DataPropertyName = "New_Stock_Quantity";
            this.newStockQuantityDataGridViewTextBoxColumn.HeaderText = "New_Stock_Quantity";
            this.newStockQuantityDataGridViewTextBoxColumn.Name = "newStockQuantityDataGridViewTextBoxColumn";
            // 
            // stockDetailsBindingSource
            // 
            this.stockDetailsBindingSource.DataMember = "Stock_Details";
            this.stockDetailsBindingSource.DataSource = this.dB_Electronic_Accessories_ShowroomDataSet3;
            // 
            // dB_Electronic_Accessories_ShowroomDataSet3
            // 
            this.dB_Electronic_Accessories_ShowroomDataSet3.DataSetName = "DB_Electronic_Accessories_ShowroomDataSet3";
            this.dB_Electronic_Accessories_ShowroomDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_Stock_Details
            // 
            this.lbl_Stock_Details.AutoSize = true;
            this.lbl_Stock_Details.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Stock_Details.Location = new System.Drawing.Point(86, 393);
            this.lbl_Stock_Details.Name = "lbl_Stock_Details";
            this.lbl_Stock_Details.Size = new System.Drawing.Size(147, 29);
            this.lbl_Stock_Details.TabIndex = 3;
            this.lbl_Stock_Details.Text = "Stock Details";
            // 
            // stock_DetailsTableAdapter
            // 
            this.stock_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_View_Stock_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Stock_Details);
            this.Controls.Add(this.pnl_Stock_Details);
            this.Controls.Add(this.pnl_Category);
            this.Controls.Add(this.pnl_View_Stock_Details);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_View_Stock_Details";
            this.Text = "View Stock Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_View_Stock_Details_Load);
            this.pnl_View_Stock_Details.ResumeLayout(false);
            this.pnl_View_Stock_Details.PerformLayout();
            this.pnl_Category.ResumeLayout(false);
            this.pnl_Category.PerformLayout();
            this.pnl_Stock_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stock_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Electronic_Accessories_ShowroomDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_View_Stock_Details;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_View_Stock_Details;
        private System.Windows.Forms.Panel pnl_Category;
        private System.Windows.Forms.ComboBox cmb_Category_Name;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Panel pnl_Stock_Details;
        private System.Windows.Forms.Label lbl_Stock_Details;
        private System.Windows.Forms.DataGridView dgv_Stock_Details;
        private System.Windows.Forms.Button btn_Search;
        private DB_Electronic_Accessories_ShowroomDataSet3 dB_Electronic_Accessories_ShowroomDataSet3;
        private System.Windows.Forms.BindingSource stockDetailsBindingSource;
        private DB_Electronic_Accessories_ShowroomDataSet3TableAdapters.Stock_DetailsTableAdapter stock_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentStockQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newStockQuantityDataGridViewTextBoxColumn;
    }
}