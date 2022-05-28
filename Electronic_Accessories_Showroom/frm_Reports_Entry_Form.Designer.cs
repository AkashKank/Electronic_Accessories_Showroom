namespace Electronic_Accessories_Showroom
{
    partial class frm_Reports_Entry_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Reports_Entry_Form));
            this.pnl_Report = new System.Windows.Forms.Panel();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Reports = new System.Windows.Forms.Label();
            this.btn_Stock_Details = new System.Windows.Forms.Button();
            this.btn_Employee_Report = new System.Windows.Forms.Button();
            this.btn_Distributor_Report = new System.Windows.Forms.Button();
            this.btn_Customer_Report = new System.Windows.Forms.Button();
            this.pnl_Report.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Report
            // 
            this.pnl_Report.BackColor = System.Drawing.Color.LightCoral;
            this.pnl_Report.Controls.Add(this.btn_Log_Out);
            this.pnl_Report.Controls.Add(this.btn_Back);
            this.pnl_Report.Controls.Add(this.lbl_Reports);
            this.pnl_Report.Location = new System.Drawing.Point(-1, 0);
            this.pnl_Report.Name = "pnl_Report";
            this.pnl_Report.Size = new System.Drawing.Size(2168, 154);
            this.pnl_Report.TabIndex = 0;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Log_Out.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Log_Out.BackgroundImage")));
            this.btn_Log_Out.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Log_Out.Location = new System.Drawing.Point(1736, 43);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(210, 65);
            this.btn_Log_Out.TabIndex = 8;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Back.Location = new System.Drawing.Point(93, 43);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(186, 65);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_Reports
            // 
            this.lbl_Reports.AutoSize = true;
            this.lbl_Reports.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reports.Location = new System.Drawing.Point(776, 27);
            this.lbl_Reports.Name = "lbl_Reports";
            this.lbl_Reports.Size = new System.Drawing.Size(422, 95);
            this.lbl_Reports.TabIndex = 3;
            this.lbl_Reports.Text = "Reports ";
            this.lbl_Reports.Click += new System.EventHandler(this.lbl_Product_Entry_Click);
            // 
            // btn_Stock_Details
            // 
            this.btn_Stock_Details.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Stock_Details.Font = new System.Drawing.Font("Modern No. 20", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stock_Details.Location = new System.Drawing.Point(615, 692);
            this.btn_Stock_Details.Name = "btn_Stock_Details";
            this.btn_Stock_Details.Size = new System.Drawing.Size(786, 72);
            this.btn_Stock_Details.TabIndex = 8;
            this.btn_Stock_Details.Text = "Stock Report";
            this.btn_Stock_Details.UseVisualStyleBackColor = false;
            this.btn_Stock_Details.Click += new System.EventHandler(this.btn_Stock_Details_Click);
            // 
            // btn_Employee_Report
            // 
            this.btn_Employee_Report.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Employee_Report.Font = new System.Drawing.Font("Modern No. 20", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employee_Report.Location = new System.Drawing.Point(615, 559);
            this.btn_Employee_Report.Name = "btn_Employee_Report";
            this.btn_Employee_Report.Size = new System.Drawing.Size(786, 72);
            this.btn_Employee_Report.TabIndex = 7;
            this.btn_Employee_Report.Text = "Employee Report";
            this.btn_Employee_Report.UseVisualStyleBackColor = false;
            this.btn_Employee_Report.Click += new System.EventHandler(this.btn_Employee_Report_Click);
            // 
            // btn_Distributor_Report
            // 
            this.btn_Distributor_Report.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Distributor_Report.Font = new System.Drawing.Font("Modern No. 20", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Distributor_Report.Location = new System.Drawing.Point(615, 431);
            this.btn_Distributor_Report.Name = "btn_Distributor_Report";
            this.btn_Distributor_Report.Size = new System.Drawing.Size(786, 72);
            this.btn_Distributor_Report.TabIndex = 6;
            this.btn_Distributor_Report.Text = "Distributor Report";
            this.btn_Distributor_Report.UseVisualStyleBackColor = false;
            this.btn_Distributor_Report.Click += new System.EventHandler(this.btn_Distributor_Report_Click);
            // 
            // btn_Customer_Report
            // 
            this.btn_Customer_Report.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Customer_Report.Font = new System.Drawing.Font("Modern No. 20", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer_Report.Location = new System.Drawing.Point(615, 304);
            this.btn_Customer_Report.Name = "btn_Customer_Report";
            this.btn_Customer_Report.Size = new System.Drawing.Size(786, 72);
            this.btn_Customer_Report.TabIndex = 5;
            this.btn_Customer_Report.Text = "Customer Report";
            this.btn_Customer_Report.UseVisualStyleBackColor = false;
            this.btn_Customer_Report.Click += new System.EventHandler(this.btn_Add_New_Category_Click);
            // 
            // frm_Reports_Entry_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btn_Stock_Details);
            this.Controls.Add(this.btn_Employee_Report);
            this.Controls.Add(this.btn_Distributor_Report);
            this.Controls.Add(this.btn_Customer_Report);
            this.Controls.Add(this.pnl_Report);
            this.Name = "frm_Reports_Entry_Form";
            this.Text = "Reports Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_Report.ResumeLayout(false);
            this.pnl_Report.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Report;
        private System.Windows.Forms.Label lbl_Reports;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Stock_Details;
        private System.Windows.Forms.Button btn_Employee_Report;
        private System.Windows.Forms.Button btn_Distributor_Report;
        private System.Windows.Forms.Button btn_Customer_Report;

    }
}