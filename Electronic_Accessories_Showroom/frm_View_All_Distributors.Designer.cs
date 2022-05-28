namespace Electronic_Accessories_Showroom
{
    partial class frm_View_All_Distributors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_View_All_Distributors));
            this.pnl_View_All_Distributors = new System.Windows.Forms.Panel();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_View_All_Distributors = new System.Windows.Forms.Label();
            this.pnl_Distributor_Details = new System.Windows.Forms.Panel();
            this.dgv_Distributor_Details = new System.Windows.Forms.DataGridView();
            this.pnl_Distributor_ID = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Distributor_ID = new System.Windows.Forms.TextBox();
            this.lbl_Distributor_ID = new System.Windows.Forms.Label();
            this.lbl_Distributor_Details = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dB_Electronic_Accessories_ShowroomDataSet = new Electronic_Accessories_Showroom.DB_Electronic_Accessories_ShowroomDataSet();
            this.distributorDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distributor_DetailsTableAdapter = new Electronic_Accessories_Showroom.DB_Electronic_Accessories_ShowroomDataSetTableAdapters.Distributor_DetailsTableAdapter();
            this.distributorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distributorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMobNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAlternateNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTieUpDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRegNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAadharNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPanCardNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBrandDeliveredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_View_All_Distributors.SuspendLayout();
            this.pnl_Distributor_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Distributor_Details)).BeginInit();
            this.pnl_Distributor_ID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Electronic_Accessories_ShowroomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distributorDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_View_All_Distributors
            // 
            this.pnl_View_All_Distributors.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnl_View_All_Distributors.Controls.Add(this.btn_Log_Out);
            this.pnl_View_All_Distributors.Controls.Add(this.btn_Back);
            this.pnl_View_All_Distributors.Controls.Add(this.lbl_View_All_Distributors);
            this.pnl_View_All_Distributors.Location = new System.Drawing.Point(1, 0);
            this.pnl_View_All_Distributors.Name = "pnl_View_All_Distributors";
            this.pnl_View_All_Distributors.Size = new System.Drawing.Size(2128, 136);
            this.pnl_View_All_Distributors.TabIndex = 0;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Log_Out.BackgroundImage")));
            this.btn_Log_Out.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Log_Out.Location = new System.Drawing.Point(1798, 26);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(189, 55);
            this.btn_Log_Out.TabIndex = 5;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = true;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Back.Location = new System.Drawing.Point(83, 26);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(147, 55);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_View_All_Distributors
            // 
            this.lbl_View_All_Distributors.AutoSize = true;
            this.lbl_View_All_Distributors.Font = new System.Drawing.Font("Stencil", 42F, System.Drawing.FontStyle.Bold);
            this.lbl_View_All_Distributors.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_View_All_Distributors.Location = new System.Drawing.Point(624, 26);
            this.lbl_View_All_Distributors.Name = "lbl_View_All_Distributors";
            this.lbl_View_All_Distributors.Size = new System.Drawing.Size(876, 83);
            this.lbl_View_All_Distributors.TabIndex = 0;
            this.lbl_View_All_Distributors.Text = "View All Distributors";
            // 
            // pnl_Distributor_Details
            // 
            this.pnl_Distributor_Details.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_Distributor_Details.Controls.Add(this.dgv_Distributor_Details);
            this.pnl_Distributor_Details.Controls.Add(this.pnl_Distributor_ID);
            this.pnl_Distributor_Details.Location = new System.Drawing.Point(57, 157);
            this.pnl_Distributor_Details.Name = "pnl_Distributor_Details";
            this.pnl_Distributor_Details.Size = new System.Drawing.Size(1920, 731);
            this.pnl_Distributor_Details.TabIndex = 1;
            // 
            // dgv_Distributor_Details
            // 
            this.dgv_Distributor_Details.AutoGenerateColumns = false;
            this.dgv_Distributor_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Distributor_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Distributor_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.distributorIDDataGridViewTextBoxColumn,
            this.distributorNameDataGridViewTextBoxColumn,
            this.dAddressDataGridViewTextBoxColumn,
            this.dGenderDataGridViewTextBoxColumn,
            this.dMobNoDataGridViewTextBoxColumn,
            this.dAlternateNoDataGridViewTextBoxColumn,
            this.dTieUpDateDataGridViewTextBoxColumn,
            this.dRegNoDataGridViewTextBoxColumn,
            this.dAadharNoDataGridViewTextBoxColumn,
            this.dPanCardNoDataGridViewTextBoxColumn,
            this.dEmailDataGridViewTextBoxColumn,
            this.dBrandDeliveredDataGridViewTextBoxColumn});
            this.dgv_Distributor_Details.DataSource = this.distributorDetailsBindingSource;
            this.dgv_Distributor_Details.Location = new System.Drawing.Point(76, 174);
            this.dgv_Distributor_Details.Name = "dgv_Distributor_Details";
            this.dgv_Distributor_Details.RowHeadersVisible = false;
            this.dgv_Distributor_Details.RowTemplate.Height = 24;
            this.dgv_Distributor_Details.Size = new System.Drawing.Size(1765, 531);
            this.dgv_Distributor_Details.TabIndex = 1;
            // 
            // pnl_Distributor_ID
            // 
            this.pnl_Distributor_ID.BackColor = System.Drawing.Color.Silver;
            this.pnl_Distributor_ID.Controls.Add(this.btn_Search);
            this.pnl_Distributor_ID.Controls.Add(this.tb_Distributor_ID);
            this.pnl_Distributor_ID.Controls.Add(this.lbl_Distributor_ID);
            this.pnl_Distributor_ID.Location = new System.Drawing.Point(154, 35);
            this.pnl_Distributor_ID.Name = "pnl_Distributor_ID";
            this.pnl_Distributor_ID.Size = new System.Drawing.Size(1634, 102);
            this.pnl_Distributor_ID.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Coral;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Location = new System.Drawing.Point(1269, 20);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(163, 54);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Distributor_ID
            // 
            this.tb_Distributor_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold);
            this.tb_Distributor_ID.Location = new System.Drawing.Point(500, 35);
            this.tb_Distributor_ID.MaxLength = 10;
            this.tb_Distributor_ID.Name = "tb_Distributor_ID";
            this.tb_Distributor_ID.Size = new System.Drawing.Size(398, 35);
            this.tb_Distributor_ID.TabIndex = 1;
            // 
            // lbl_Distributor_ID
            // 
            this.lbl_Distributor_ID.AutoSize = true;
            this.lbl_Distributor_ID.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Distributor_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distributor_ID.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Distributor_ID.Location = new System.Drawing.Point(120, 31);
            this.lbl_Distributor_ID.Name = "lbl_Distributor_ID";
            this.lbl_Distributor_ID.Size = new System.Drawing.Size(197, 35);
            this.lbl_Distributor_ID.TabIndex = 1;
            this.lbl_Distributor_ID.Text = "Distributor ID";
            // 
            // lbl_Distributor_Details
            // 
            this.lbl_Distributor_Details.AutoSize = true;
            this.lbl_Distributor_Details.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Distributor_Details.Location = new System.Drawing.Point(141, 146);
            this.lbl_Distributor_Details.Name = "lbl_Distributor_Details";
            this.lbl_Distributor_Details.Size = new System.Drawing.Size(204, 29);
            this.lbl_Distributor_Details.TabIndex = 1;
            this.lbl_Distributor_Details.Text = "Distributor Details";
            this.lbl_Distributor_Details.Click += new System.EventHandler(this.lbl_Distributor_Details_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Tomato;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh.Location = new System.Drawing.Point(912, 904);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(208, 57);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // dB_Electronic_Accessories_ShowroomDataSet
            // 
            this.dB_Electronic_Accessories_ShowroomDataSet.DataSetName = "DB_Electronic_Accessories_ShowroomDataSet";
            this.dB_Electronic_Accessories_ShowroomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // distributorDetailsBindingSource
            // 
            this.distributorDetailsBindingSource.DataMember = "Distributor_Details";
            this.distributorDetailsBindingSource.DataSource = this.dB_Electronic_Accessories_ShowroomDataSet;
            // 
            // distributor_DetailsTableAdapter
            // 
            this.distributor_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // distributorIDDataGridViewTextBoxColumn
            // 
            this.distributorIDDataGridViewTextBoxColumn.DataPropertyName = "Distributor_ID";
            this.distributorIDDataGridViewTextBoxColumn.HeaderText = "Distributor_ID";
            this.distributorIDDataGridViewTextBoxColumn.Name = "distributorIDDataGridViewTextBoxColumn";
            // 
            // distributorNameDataGridViewTextBoxColumn
            // 
            this.distributorNameDataGridViewTextBoxColumn.DataPropertyName = "Distributor_Name";
            this.distributorNameDataGridViewTextBoxColumn.HeaderText = "Distributor_Name";
            this.distributorNameDataGridViewTextBoxColumn.Name = "distributorNameDataGridViewTextBoxColumn";
            // 
            // dAddressDataGridViewTextBoxColumn
            // 
            this.dAddressDataGridViewTextBoxColumn.DataPropertyName = "D_Address";
            this.dAddressDataGridViewTextBoxColumn.HeaderText = "D_Address";
            this.dAddressDataGridViewTextBoxColumn.Name = "dAddressDataGridViewTextBoxColumn";
            // 
            // dGenderDataGridViewTextBoxColumn
            // 
            this.dGenderDataGridViewTextBoxColumn.DataPropertyName = "D_Gender";
            this.dGenderDataGridViewTextBoxColumn.HeaderText = "D_Gender";
            this.dGenderDataGridViewTextBoxColumn.Name = "dGenderDataGridViewTextBoxColumn";
            // 
            // dMobNoDataGridViewTextBoxColumn
            // 
            this.dMobNoDataGridViewTextBoxColumn.DataPropertyName = "D_MobNo";
            this.dMobNoDataGridViewTextBoxColumn.HeaderText = "D_MobNo";
            this.dMobNoDataGridViewTextBoxColumn.Name = "dMobNoDataGridViewTextBoxColumn";
            // 
            // dAlternateNoDataGridViewTextBoxColumn
            // 
            this.dAlternateNoDataGridViewTextBoxColumn.DataPropertyName = "D_AlternateNo";
            this.dAlternateNoDataGridViewTextBoxColumn.HeaderText = "D_AlternateNo";
            this.dAlternateNoDataGridViewTextBoxColumn.Name = "dAlternateNoDataGridViewTextBoxColumn";
            // 
            // dTieUpDateDataGridViewTextBoxColumn
            // 
            this.dTieUpDateDataGridViewTextBoxColumn.DataPropertyName = "D_TieUp_Date";
            this.dTieUpDateDataGridViewTextBoxColumn.HeaderText = "D_TieUp_Date";
            this.dTieUpDateDataGridViewTextBoxColumn.Name = "dTieUpDateDataGridViewTextBoxColumn";
            // 
            // dRegNoDataGridViewTextBoxColumn
            // 
            this.dRegNoDataGridViewTextBoxColumn.DataPropertyName = "D_RegNo";
            this.dRegNoDataGridViewTextBoxColumn.HeaderText = "D_RegNo";
            this.dRegNoDataGridViewTextBoxColumn.Name = "dRegNoDataGridViewTextBoxColumn";
            // 
            // dAadharNoDataGridViewTextBoxColumn
            // 
            this.dAadharNoDataGridViewTextBoxColumn.DataPropertyName = "D_AadharNo";
            this.dAadharNoDataGridViewTextBoxColumn.HeaderText = "D_AadharNo";
            this.dAadharNoDataGridViewTextBoxColumn.Name = "dAadharNoDataGridViewTextBoxColumn";
            // 
            // dPanCardNoDataGridViewTextBoxColumn
            // 
            this.dPanCardNoDataGridViewTextBoxColumn.DataPropertyName = "D_PanCardNo";
            this.dPanCardNoDataGridViewTextBoxColumn.HeaderText = "D_PanCardNo";
            this.dPanCardNoDataGridViewTextBoxColumn.Name = "dPanCardNoDataGridViewTextBoxColumn";
            // 
            // dEmailDataGridViewTextBoxColumn
            // 
            this.dEmailDataGridViewTextBoxColumn.DataPropertyName = "D_Email";
            this.dEmailDataGridViewTextBoxColumn.HeaderText = "D_Email";
            this.dEmailDataGridViewTextBoxColumn.Name = "dEmailDataGridViewTextBoxColumn";
            // 
            // dBrandDeliveredDataGridViewTextBoxColumn
            // 
            this.dBrandDeliveredDataGridViewTextBoxColumn.DataPropertyName = "D_BrandDelivered";
            this.dBrandDeliveredDataGridViewTextBoxColumn.HeaderText = "D_BrandDelivered";
            this.dBrandDeliveredDataGridViewTextBoxColumn.Name = "dBrandDeliveredDataGridViewTextBoxColumn";
            // 
            // frm_View_All_Distributors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.lbl_Distributor_Details);
            this.Controls.Add(this.pnl_Distributor_Details);
            this.Controls.Add(this.pnl_View_All_Distributors);
            this.Name = "frm_View_All_Distributors";
            this.Text = "View All Distributors";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_View_All_Distributors_Load);
            this.pnl_View_All_Distributors.ResumeLayout(false);
            this.pnl_View_All_Distributors.PerformLayout();
            this.pnl_Distributor_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Distributor_Details)).EndInit();
            this.pnl_Distributor_ID.ResumeLayout(false);
            this.pnl_Distributor_ID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Electronic_Accessories_ShowroomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distributorDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_View_All_Distributors;
        private System.Windows.Forms.Panel pnl_Distributor_Details;
        private System.Windows.Forms.Label lbl_View_All_Distributors;
        private System.Windows.Forms.Label lbl_Distributor_Details;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Panel pnl_Distributor_ID;
        private System.Windows.Forms.Label lbl_Distributor_ID;
        private System.Windows.Forms.TextBox tb_Distributor_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_Distributor_Details;
        private System.Windows.Forms.Button btn_Refresh;
        private DB_Electronic_Accessories_ShowroomDataSet dB_Electronic_Accessories_ShowroomDataSet;
        private System.Windows.Forms.BindingSource distributorDetailsBindingSource;
        private DB_Electronic_Accessories_ShowroomDataSetTableAdapters.Distributor_DetailsTableAdapter distributor_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn distributorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distributorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dMobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAlternateNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTieUpDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRegNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAadharNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPanCardNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dBrandDeliveredDataGridViewTextBoxColumn;
    }
}