namespace Electronic_Accessories_Showroom
{
    partial class frm_Customer_Entry_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Customer_Entry_Form));
            this.pnl_Customer_Entry = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.lbl_Customer_Entry = new System.Windows.Forms.Label();
            this.btn_Add_New_Customer = new System.Windows.Forms.Button();
            this.btn_View_Customer_Details = new System.Windows.Forms.Button();
            this.pb_Add_New_Customer = new System.Windows.Forms.PictureBox();
            this.pb_View_Customer_Details = new System.Windows.Forms.PictureBox();
            this.pnl_Customer_Entry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Add_New_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_View_Customer_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Customer_Entry
            // 
            this.pnl_Customer_Entry.BackColor = System.Drawing.Color.LightCoral;
            this.pnl_Customer_Entry.Controls.Add(this.btn_Back);
            this.pnl_Customer_Entry.Controls.Add(this.btn_Log_Out);
            this.pnl_Customer_Entry.Controls.Add(this.lbl_Customer_Entry);
            this.pnl_Customer_Entry.Location = new System.Drawing.Point(2, 0);
            this.pnl_Customer_Entry.Name = "pnl_Customer_Entry";
            this.pnl_Customer_Entry.Size = new System.Drawing.Size(2133, 155);
            this.pnl_Customer_Entry.TabIndex = 0;
            this.pnl_Customer_Entry.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Customer_Entry_Paint);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Back.Location = new System.Drawing.Point(76, 29);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(186, 65);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Log_Out.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Log_Out.BackgroundImage")));
            this.btn_Log_Out.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Log_Out.Location = new System.Drawing.Point(1710, 29);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(211, 65);
            this.btn_Log_Out.TabIndex = 4;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // lbl_Customer_Entry
            // 
            this.lbl_Customer_Entry.AutoSize = true;
            this.lbl_Customer_Entry.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Entry.Location = new System.Drawing.Point(594, 29);
            this.lbl_Customer_Entry.Name = "lbl_Customer_Entry";
            this.lbl_Customer_Entry.Size = new System.Drawing.Size(738, 95);
            this.lbl_Customer_Entry.TabIndex = 0;
            this.lbl_Customer_Entry.Text = "Customer Entry";
            // 
            // btn_Add_New_Customer
            // 
            this.btn_Add_New_Customer.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Add_New_Customer.Font = new System.Drawing.Font("Modern No. 20", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Customer.Location = new System.Drawing.Point(468, 369);
            this.btn_Add_New_Customer.Name = "btn_Add_New_Customer";
            this.btn_Add_New_Customer.Size = new System.Drawing.Size(665, 72);
            this.btn_Add_New_Customer.TabIndex = 1;
            this.btn_Add_New_Customer.Text = "Add New Customer";
            this.btn_Add_New_Customer.UseVisualStyleBackColor = false;
            this.btn_Add_New_Customer.Click += new System.EventHandler(this.btn_Add_New_Customer_Click);
            // 
            // btn_View_Customer_Details
            // 
            this.btn_View_Customer_Details.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_View_Customer_Details.Font = new System.Drawing.Font("Modern No. 20", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Customer_Details.Location = new System.Drawing.Point(468, 611);
            this.btn_View_Customer_Details.Name = "btn_View_Customer_Details";
            this.btn_View_Customer_Details.Size = new System.Drawing.Size(665, 72);
            this.btn_View_Customer_Details.TabIndex = 2;
            this.btn_View_Customer_Details.Text = "View Customer Details";
            this.btn_View_Customer_Details.UseVisualStyleBackColor = false;
            this.btn_View_Customer_Details.Click += new System.EventHandler(this.btn_View_Customer_Details_Click);
            // 
            // pb_Add_New_Customer
            // 
            this.pb_Add_New_Customer.Image = ((System.Drawing.Image)(resources.GetObject("pb_Add_New_Customer.Image")));
            this.pb_Add_New_Customer.Location = new System.Drawing.Point(1129, 342);
            this.pb_Add_New_Customer.Name = "pb_Add_New_Customer";
            this.pb_Add_New_Customer.Size = new System.Drawing.Size(125, 113);
            this.pb_Add_New_Customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Add_New_Customer.TabIndex = 4;
            this.pb_Add_New_Customer.TabStop = false;
            // 
            // pb_View_Customer_Details
            // 
            this.pb_View_Customer_Details.Image = ((System.Drawing.Image)(resources.GetObject("pb_View_Customer_Details.Image")));
            this.pb_View_Customer_Details.Location = new System.Drawing.Point(1129, 590);
            this.pb_View_Customer_Details.Name = "pb_View_Customer_Details";
            this.pb_View_Customer_Details.Size = new System.Drawing.Size(125, 113);
            this.pb_View_Customer_Details.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_View_Customer_Details.TabIndex = 5;
            this.pb_View_Customer_Details.TabStop = false;
            // 
            // frm_Customer_Entry_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pb_View_Customer_Details);
            this.Controls.Add(this.pb_Add_New_Customer);
            this.Controls.Add(this.btn_View_Customer_Details);
            this.Controls.Add(this.btn_Add_New_Customer);
            this.Controls.Add(this.pnl_Customer_Entry);
            this.Name = "frm_Customer_Entry_Form";
            this.Text = "Customer Entry Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_Customer_Entry.ResumeLayout(false);
            this.pnl_Customer_Entry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Add_New_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_View_Customer_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Customer_Entry;
        private System.Windows.Forms.Label lbl_Customer_Entry;
        private System.Windows.Forms.Button btn_Add_New_Customer;
        private System.Windows.Forms.Button btn_View_Customer_Details;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.PictureBox pb_Add_New_Customer;
        private System.Windows.Forms.PictureBox pb_View_Customer_Details;
    }
}