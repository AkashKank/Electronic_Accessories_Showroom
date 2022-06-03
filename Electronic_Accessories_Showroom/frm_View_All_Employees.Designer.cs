namespace Electronic_Accessories_Showroom
{
    partial class frm_View_All_Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_View_All_Employees));
            this.pnl_View_All_Employees = new System.Windows.Forms.Panel();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_View_All_Employees = new System.Windows.Forms.Label();
            this.pnl_Employee_Details = new System.Windows.Forms.Panel();
            this.dgv_View_All_Employees = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eJoiningDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMobNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eAlternateNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eAadharNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ePanCardNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Electronic_Accessories_ShowroomDataSet2 = new Electronic_Accessories_Showroom.DB_Electronic_Accessories_ShowroomDataSet2();
            this.pnl_Employee_ID = new System.Windows.Forms.Panel();
            this.tb_Employee_ID = new System.Windows.Forms.TextBox();
            this.lbl_Employee_ID = new System.Windows.Forms.Label();
            this.lbl_Employee_Details = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.employee_DetailsTableAdapter = new Electronic_Accessories_Showroom.DB_Electronic_Accessories_ShowroomDataSet2TableAdapters.Employee_DetailsTableAdapter();
            this.pnl_View_All_Employees.SuspendLayout();
            this.pnl_Employee_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Employees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Electronic_Accessories_ShowroomDataSet2)).BeginInit();
            this.pnl_Employee_ID.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_View_All_Employees
            // 
            this.pnl_View_All_Employees.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnl_View_All_Employees.Controls.Add(this.btn_Log_Out);
            this.pnl_View_All_Employees.Controls.Add(this.btn_Back);
            this.pnl_View_All_Employees.Controls.Add(this.lbl_View_All_Employees);
            this.pnl_View_All_Employees.Location = new System.Drawing.Point(0, 0);
            this.pnl_View_All_Employees.Name = "pnl_View_All_Employees";
            this.pnl_View_All_Employees.Size = new System.Drawing.Size(2162, 131);
            this.pnl_View_All_Employees.TabIndex = 0;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.Orange;
            this.btn_Log_Out.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Log_Out.BackgroundImage")));
            this.btn_Log_Out.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Log_Out.Location = new System.Drawing.Point(1798, 31);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(189, 55);
            this.btn_Log_Out.TabIndex = 5;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Back.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Back.Location = new System.Drawing.Point(77, 31);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(147, 55);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_View_All_Employees
            // 
            this.lbl_View_All_Employees.AutoSize = true;
            this.lbl_View_All_Employees.Font = new System.Drawing.Font("Stencil", 42F, System.Drawing.FontStyle.Bold);
            this.lbl_View_All_Employees.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_View_All_Employees.Location = new System.Drawing.Point(618, 21);
            this.lbl_View_All_Employees.Name = "lbl_View_All_Employees";
            this.lbl_View_All_Employees.Size = new System.Drawing.Size(759, 83);
            this.lbl_View_All_Employees.TabIndex = 1;
            this.lbl_View_All_Employees.Text = "View All Employees";
            // 
            // pnl_Employee_Details
            // 
            this.pnl_Employee_Details.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_Employee_Details.Controls.Add(this.dgv_View_All_Employees);
            this.pnl_Employee_Details.Controls.Add(this.pnl_Employee_ID);
            this.pnl_Employee_Details.Location = new System.Drawing.Point(26, 163);
            this.pnl_Employee_Details.Name = "pnl_Employee_Details";
            this.pnl_Employee_Details.Size = new System.Drawing.Size(2000, 747);
            this.pnl_Employee_Details.TabIndex = 1;
            // 
            // dgv_View_All_Employees
            // 
            this.dgv_View_All_Employees.AutoGenerateColumns = false;
            this.dgv_View_All_Employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_All_Employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_All_Employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.eDateOfBirthDataGridViewTextBoxColumn,
            this.eGenderDataGridViewTextBoxColumn,
            this.eAddressDataGridViewTextBoxColumn,
            this.eEmailDataGridViewTextBoxColumn,
            this.eJoiningDateDataGridViewTextBoxColumn,
            this.eMobNoDataGridViewTextBoxColumn,
            this.eAlternateNoDataGridViewTextBoxColumn,
            this.eAadharNoDataGridViewTextBoxColumn,
            this.ePanCardNoDataGridViewTextBoxColumn,
            this.eSalaryDataGridViewTextBoxColumn});
            this.dgv_View_All_Employees.DataSource = this.employeeDetailsBindingSource;
            this.dgv_View_All_Employees.Location = new System.Drawing.Point(3, 170);
            this.dgv_View_All_Employees.Name = "dgv_View_All_Employees";
            this.dgv_View_All_Employees.RowHeadersVisible = false;
            this.dgv_View_All_Employees.RowTemplate.Height = 24;
            this.dgv_View_All_Employees.Size = new System.Drawing.Size(1920, 551);
            this.dgv_View_All_Employees.TabIndex = 1;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "Employee_Name";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "Employee_Name";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            // 
            // eDateOfBirthDataGridViewTextBoxColumn
            // 
            this.eDateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "E_DateOf_Birth";
            this.eDateOfBirthDataGridViewTextBoxColumn.HeaderText = "E_DateOf_Birth";
            this.eDateOfBirthDataGridViewTextBoxColumn.Name = "eDateOfBirthDataGridViewTextBoxColumn";
            // 
            // eGenderDataGridViewTextBoxColumn
            // 
            this.eGenderDataGridViewTextBoxColumn.DataPropertyName = "E_Gender";
            this.eGenderDataGridViewTextBoxColumn.HeaderText = "E_Gender";
            this.eGenderDataGridViewTextBoxColumn.Name = "eGenderDataGridViewTextBoxColumn";
            // 
            // eAddressDataGridViewTextBoxColumn
            // 
            this.eAddressDataGridViewTextBoxColumn.DataPropertyName = "E_Address";
            this.eAddressDataGridViewTextBoxColumn.HeaderText = "E_Address";
            this.eAddressDataGridViewTextBoxColumn.Name = "eAddressDataGridViewTextBoxColumn";
            // 
            // eEmailDataGridViewTextBoxColumn
            // 
            this.eEmailDataGridViewTextBoxColumn.DataPropertyName = "E_Email";
            this.eEmailDataGridViewTextBoxColumn.HeaderText = "E_Email";
            this.eEmailDataGridViewTextBoxColumn.Name = "eEmailDataGridViewTextBoxColumn";
            // 
            // eJoiningDateDataGridViewTextBoxColumn
            // 
            this.eJoiningDateDataGridViewTextBoxColumn.DataPropertyName = "E_Joining_Date";
            this.eJoiningDateDataGridViewTextBoxColumn.HeaderText = "E_Joining_Date";
            this.eJoiningDateDataGridViewTextBoxColumn.Name = "eJoiningDateDataGridViewTextBoxColumn";
            // 
            // eMobNoDataGridViewTextBoxColumn
            // 
            this.eMobNoDataGridViewTextBoxColumn.DataPropertyName = "E_MobNo";
            this.eMobNoDataGridViewTextBoxColumn.HeaderText = "E_MobNo";
            this.eMobNoDataGridViewTextBoxColumn.Name = "eMobNoDataGridViewTextBoxColumn";
            // 
            // eAlternateNoDataGridViewTextBoxColumn
            // 
            this.eAlternateNoDataGridViewTextBoxColumn.DataPropertyName = "E_AlternateNo";
            this.eAlternateNoDataGridViewTextBoxColumn.HeaderText = "E_AlternateNo";
            this.eAlternateNoDataGridViewTextBoxColumn.Name = "eAlternateNoDataGridViewTextBoxColumn";
            // 
            // eAadharNoDataGridViewTextBoxColumn
            // 
            this.eAadharNoDataGridViewTextBoxColumn.DataPropertyName = "E_AadharNo";
            this.eAadharNoDataGridViewTextBoxColumn.HeaderText = "E_AadharNo";
            this.eAadharNoDataGridViewTextBoxColumn.Name = "eAadharNoDataGridViewTextBoxColumn";
            // 
            // ePanCardNoDataGridViewTextBoxColumn
            // 
            this.ePanCardNoDataGridViewTextBoxColumn.DataPropertyName = "E_PanCardNo";
            this.ePanCardNoDataGridViewTextBoxColumn.HeaderText = "E_PanCardNo";
            this.ePanCardNoDataGridViewTextBoxColumn.Name = "ePanCardNoDataGridViewTextBoxColumn";
            // 
            // eSalaryDataGridViewTextBoxColumn
            // 
            this.eSalaryDataGridViewTextBoxColumn.DataPropertyName = "E_Salary";
            this.eSalaryDataGridViewTextBoxColumn.HeaderText = "E_Salary";
            this.eSalaryDataGridViewTextBoxColumn.Name = "eSalaryDataGridViewTextBoxColumn";
            // 
            // employeeDetailsBindingSource
            // 
            this.employeeDetailsBindingSource.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource.DataSource = this.dB_Electronic_Accessories_ShowroomDataSet2;
            // 
            // dB_Electronic_Accessories_ShowroomDataSet2
            // 
            this.dB_Electronic_Accessories_ShowroomDataSet2.DataSetName = "DB_Electronic_Accessories_ShowroomDataSet2";
            this.dB_Electronic_Accessories_ShowroomDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnl_Employee_ID
            // 
            this.pnl_Employee_ID.BackColor = System.Drawing.Color.Silver;
            this.pnl_Employee_ID.Controls.Add(this.tb_Employee_ID);
            this.pnl_Employee_ID.Controls.Add(this.lbl_Employee_ID);
            this.pnl_Employee_ID.Location = new System.Drawing.Point(269, 37);
            this.pnl_Employee_ID.Name = "pnl_Employee_ID";
            this.pnl_Employee_ID.Size = new System.Drawing.Size(1464, 99);
            this.pnl_Employee_ID.TabIndex = 0;
            // 
            // tb_Employee_ID
            // 
            this.tb_Employee_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold);
            this.tb_Employee_ID.Location = new System.Drawing.Point(694, 36);
            this.tb_Employee_ID.MaxLength = 10;
            this.tb_Employee_ID.Name = "tb_Employee_ID";
            this.tb_Employee_ID.Size = new System.Drawing.Size(398, 35);
            this.tb_Employee_ID.TabIndex = 1;
            this.tb_Employee_ID.TextChanged += new System.EventHandler(this.tb_Employee_ID_TextChanged);
            // 
            // lbl_Employee_ID
            // 
            this.lbl_Employee_ID.AutoSize = true;
            this.lbl_Employee_ID.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Employee_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_ID.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Employee_ID.Location = new System.Drawing.Point(380, 36);
            this.lbl_Employee_ID.Name = "lbl_Employee_ID";
            this.lbl_Employee_ID.Size = new System.Drawing.Size(163, 33);
            this.lbl_Employee_ID.TabIndex = 4;
            this.lbl_Employee_ID.Text = "Employee ID";
            // 
            // lbl_Employee_Details
            // 
            this.lbl_Employee_Details.AutoSize = true;
            this.lbl_Employee_Details.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Details.Location = new System.Drawing.Point(71, 145);
            this.lbl_Employee_Details.Name = "lbl_Employee_Details";
            this.lbl_Employee_Details.Size = new System.Drawing.Size(210, 31);
            this.lbl_Employee_Details.TabIndex = 4;
            this.lbl_Employee_Details.Text = "Employee Details";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Tomato;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(927, 925);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(208, 59);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // employee_DetailsTableAdapter
            // 
            this.employee_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_View_All_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.lbl_Employee_Details);
            this.Controls.Add(this.pnl_Employee_Details);
            this.Controls.Add(this.pnl_View_All_Employees);
            this.Name = "frm_View_All_Employees";
            this.Text = "View All Employees";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_View_All_Employees_Load);
            this.pnl_View_All_Employees.ResumeLayout(false);
            this.pnl_View_All_Employees.PerformLayout();
            this.pnl_Employee_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Employees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Electronic_Accessories_ShowroomDataSet2)).EndInit();
            this.pnl_Employee_ID.ResumeLayout(false);
            this.pnl_Employee_ID.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_View_All_Employees;
        private System.Windows.Forms.Panel pnl_Employee_Details;
        private System.Windows.Forms.Label lbl_View_All_Employees;
        private System.Windows.Forms.Label lbl_Employee_Details;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridView dgv_View_All_Employees;
        private System.Windows.Forms.Panel pnl_Employee_ID;
        private System.Windows.Forms.Label lbl_Employee_ID;
        private System.Windows.Forms.TextBox tb_Employee_ID;
        private DB_Electronic_Accessories_ShowroomDataSet2 dB_Electronic_Accessories_ShowroomDataSet2;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource;
        private DB_Electronic_Accessories_ShowroomDataSet2TableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eJoiningDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eAlternateNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eAadharNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ePanCardNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSalaryDataGridViewTextBoxColumn;
    }
}