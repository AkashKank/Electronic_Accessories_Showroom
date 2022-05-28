namespace Electronic_Accessories_Showroom
{
    partial class frm_View_Customer_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_View_Customer_Details));
            this.pnl_View_Customer_Details = new System.Windows.Forms.Panel();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_View_Customer_Details = new System.Windows.Forms.Label();
            this.pnl_Customer_Details = new System.Windows.Forms.Panel();
            this.dgv_Customer_Details = new System.Windows.Forms.DataGridView();
            this.pnl_From_Date = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtp_From_Date = new System.Windows.Forms.DateTimePicker();
            this.dtp_To_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_To_Date = new System.Windows.Forms.Label();
            this.lbl_From_Date = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_Customer_Details = new System.Windows.Forms.Label();
            this.pnl_View_Customer_Details.SuspendLayout();
            this.pnl_Customer_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Details)).BeginInit();
            this.pnl_From_Date.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_View_Customer_Details
            // 
            this.pnl_View_Customer_Details.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnl_View_Customer_Details.Controls.Add(this.btn_Log_Out);
            this.pnl_View_Customer_Details.Controls.Add(this.btn_Back);
            this.pnl_View_Customer_Details.Controls.Add(this.lbl_View_Customer_Details);
            this.pnl_View_Customer_Details.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_View_Customer_Details.Location = new System.Drawing.Point(1, 2);
            this.pnl_View_Customer_Details.Name = "pnl_View_Customer_Details";
            this.pnl_View_Customer_Details.Size = new System.Drawing.Size(2126, 139);
            this.pnl_View_Customer_Details.TabIndex = 3;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.Orange;
            this.btn_Log_Out.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Log_Out.BackgroundImage")));
            this.btn_Log_Out.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Log_Out.Location = new System.Drawing.Point(1810, 30);
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
            this.btn_Back.Location = new System.Drawing.Point(66, 30);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(147, 55);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_View_Customer_Details
            // 
            this.lbl_View_Customer_Details.AutoSize = true;
            this.lbl_View_Customer_Details.Font = new System.Drawing.Font("Stencil", 42F, System.Drawing.FontStyle.Bold);
            this.lbl_View_Customer_Details.Location = new System.Drawing.Point(569, 30);
            this.lbl_View_Customer_Details.Name = "lbl_View_Customer_Details";
            this.lbl_View_Customer_Details.Size = new System.Drawing.Size(893, 83);
            this.lbl_View_Customer_Details.TabIndex = 0;
            this.lbl_View_Customer_Details.Text = "View Customer Details";
            // 
            // pnl_Customer_Details
            // 
            this.pnl_Customer_Details.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_Customer_Details.Controls.Add(this.dgv_Customer_Details);
            this.pnl_Customer_Details.Controls.Add(this.pnl_From_Date);
            this.pnl_Customer_Details.Location = new System.Drawing.Point(86, 175);
            this.pnl_Customer_Details.Name = "pnl_Customer_Details";
            this.pnl_Customer_Details.Size = new System.Drawing.Size(1855, 711);
            this.pnl_Customer_Details.TabIndex = 4;
            // 
            // dgv_Customer_Details
            // 
            this.dgv_Customer_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Customer_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer_Details.Location = new System.Drawing.Point(62, 165);
            this.dgv_Customer_Details.Name = "dgv_Customer_Details";
            this.dgv_Customer_Details.RowTemplate.Height = 24;
            this.dgv_Customer_Details.Size = new System.Drawing.Size(1748, 515);
            this.dgv_Customer_Details.TabIndex = 1;
            // 
            // pnl_From_Date
            // 
            this.pnl_From_Date.BackColor = System.Drawing.Color.Silver;
            this.pnl_From_Date.Controls.Add(this.btn_Search);
            this.pnl_From_Date.Controls.Add(this.dtp_From_Date);
            this.pnl_From_Date.Controls.Add(this.dtp_To_Date);
            this.pnl_From_Date.Controls.Add(this.lbl_To_Date);
            this.pnl_From_Date.Controls.Add(this.lbl_From_Date);
            this.pnl_From_Date.Location = new System.Drawing.Point(90, 35);
            this.pnl_From_Date.Name = "pnl_From_Date";
            this.pnl_From_Date.Size = new System.Drawing.Size(1668, 103);
            this.pnl_From_Date.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Coral;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Location = new System.Drawing.Point(1435, 24);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(168, 53);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dtp_From_Date
            // 
            this.dtp_From_Date.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold);
            this.dtp_From_Date.Location = new System.Drawing.Point(363, 35);
            this.dtp_From_Date.Name = "dtp_From_Date";
            this.dtp_From_Date.Size = new System.Drawing.Size(303, 35);
            this.dtp_From_Date.TabIndex = 1;
            // 
            // dtp_To_Date
            // 
            this.dtp_To_Date.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold);
            this.dtp_To_Date.Location = new System.Drawing.Point(1024, 35);
            this.dtp_To_Date.Name = "dtp_To_Date";
            this.dtp_To_Date.Size = new System.Drawing.Size(303, 35);
            this.dtp_To_Date.TabIndex = 2;
            this.dtp_To_Date.ValueChanged += new System.EventHandler(this.dtp_To_Date_ValueChanged);
            // 
            // lbl_To_Date
            // 
            this.lbl_To_Date.AutoSize = true;
            this.lbl_To_Date.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_To_Date.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_To_Date.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_To_Date.Location = new System.Drawing.Point(807, 38);
            this.lbl_To_Date.Name = "lbl_To_Date";
            this.lbl_To_Date.Size = new System.Drawing.Size(107, 33);
            this.lbl_To_Date.TabIndex = 20;
            this.lbl_To_Date.Text = "To Date";
            // 
            // lbl_From_Date
            // 
            this.lbl_From_Date.AutoSize = true;
            this.lbl_From_Date.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_From_Date.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_From_Date.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_From_Date.Location = new System.Drawing.Point(91, 35);
            this.lbl_From_Date.Name = "lbl_From_Date";
            this.lbl_From_Date.Size = new System.Drawing.Size(138, 33);
            this.lbl_From_Date.TabIndex = 19;
            this.lbl_From_Date.Text = "From Date";
            this.lbl_From_Date.Click += new System.EventHandler(this.lbl_From_Date_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Tomato;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(910, 901);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(204, 58);
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_Customer_Details
            // 
            this.lbl_Customer_Details.AutoSize = true;
            this.lbl_Customer_Details.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Details.Location = new System.Drawing.Point(112, 161);
            this.lbl_Customer_Details.Name = "lbl_Customer_Details";
            this.lbl_Customer_Details.Size = new System.Drawing.Size(190, 29);
            this.lbl_Customer_Details.TabIndex = 0;
            this.lbl_Customer_Details.Text = "Customer Details";
            // 
            // frm_View_Customer_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Customer_Details);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.pnl_Customer_Details);
            this.Controls.Add(this.pnl_View_Customer_Details);
            this.Name = "frm_View_Customer_Details";
            this.Text = "View Customer Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_View_Customer_Details_Load);
            this.pnl_View_Customer_Details.ResumeLayout(false);
            this.pnl_View_Customer_Details.PerformLayout();
            this.pnl_Customer_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Details)).EndInit();
            this.pnl_From_Date.ResumeLayout(false);
            this.pnl_From_Date.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_View_Customer_Details;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_View_Customer_Details;
        private System.Windows.Forms.Panel pnl_Customer_Details;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Panel pnl_From_Date;
        private System.Windows.Forms.Label lbl_Customer_Details;
        private System.Windows.Forms.Label lbl_To_Date;
        private System.Windows.Forms.Label lbl_From_Date;
        private System.Windows.Forms.DateTimePicker dtp_To_Date;
        private System.Windows.Forms.DateTimePicker dtp_From_Date;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_Customer_Details;
    }
}