namespace Electronic_Accessories_Showroom
{
    partial class frm_User_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_User_Management));
            this.lbl_Distributor_Entry = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_View_Customer_Details = new System.Windows.Forms.PictureBox();
            this.pb_Add_New_Customer = new System.Windows.Forms.PictureBox();
            this.btn_Update_User = new System.Windows.Forms.Button();
            this.btn_Add_New_User = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Delete_User = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_View_Customer_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Add_New_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Distributor_Entry
            // 
            this.lbl_Distributor_Entry.AutoSize = true;
            this.lbl_Distributor_Entry.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distributor_Entry.Location = new System.Drawing.Point(553, 39);
            this.lbl_Distributor_Entry.Name = "lbl_Distributor_Entry";
            this.lbl_Distributor_Entry.Size = new System.Drawing.Size(803, 95);
            this.lbl_Distributor_Entry.TabIndex = 3;
            this.lbl_Distributor_Entry.Text = "User Management";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Back.Location = new System.Drawing.Point(32, 39);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(186, 65);
            this.btn_Back.TabIndex = 4;
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
            this.btn_Log_Out.Location = new System.Drawing.Point(1679, 39);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(210, 65);
            this.btn_Log_Out.TabIndex = 5;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.lbl_Distributor_Entry);
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.btn_Log_Out);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2133, 157);
            this.panel1.TabIndex = 6;
            // 
            // pb_View_Customer_Details
            // 
            this.pb_View_Customer_Details.Image = ((System.Drawing.Image)(resources.GetObject("pb_View_Customer_Details.Image")));
            this.pb_View_Customer_Details.Location = new System.Drawing.Point(1230, 541);
            this.pb_View_Customer_Details.Name = "pb_View_Customer_Details";
            this.pb_View_Customer_Details.Size = new System.Drawing.Size(125, 113);
            this.pb_View_Customer_Details.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_View_Customer_Details.TabIndex = 10;
            this.pb_View_Customer_Details.TabStop = false;
            // 
            // pb_Add_New_Customer
            // 
            this.pb_Add_New_Customer.Image = ((System.Drawing.Image)(resources.GetObject("pb_Add_New_Customer.Image")));
            this.pb_Add_New_Customer.Location = new System.Drawing.Point(1230, 347);
            this.pb_Add_New_Customer.Name = "pb_Add_New_Customer";
            this.pb_Add_New_Customer.Size = new System.Drawing.Size(125, 113);
            this.pb_Add_New_Customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Add_New_Customer.TabIndex = 9;
            this.pb_Add_New_Customer.TabStop = false;
            // 
            // btn_Update_User
            // 
            this.btn_Update_User.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Update_User.Font = new System.Drawing.Font("Modern No. 20", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_User.Location = new System.Drawing.Point(569, 562);
            this.btn_Update_User.Name = "btn_Update_User";
            this.btn_Update_User.Size = new System.Drawing.Size(665, 72);
            this.btn_Update_User.TabIndex = 8;
            this.btn_Update_User.Text = "Update User";
            this.btn_Update_User.UseVisualStyleBackColor = false;
            this.btn_Update_User.Click += new System.EventHandler(this.btn_Update_User_Click);
            // 
            // btn_Add_New_User
            // 
            this.btn_Add_New_User.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Add_New_User.Font = new System.Drawing.Font("Modern No. 20", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_User.Location = new System.Drawing.Point(569, 374);
            this.btn_Add_New_User.Name = "btn_Add_New_User";
            this.btn_Add_New_User.Size = new System.Drawing.Size(665, 72);
            this.btn_Add_New_User.TabIndex = 7;
            this.btn_Add_New_User.Text = "Add New User";
            this.btn_Add_New_User.UseVisualStyleBackColor = false;
            this.btn_Add_New_User.Click += new System.EventHandler(this.btn_Add_New_User_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1230, 707);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Delete_User
            // 
            this.btn_Delete_User.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Delete_User.Font = new System.Drawing.Font("Modern No. 20", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_User.Location = new System.Drawing.Point(569, 728);
            this.btn_Delete_User.Name = "btn_Delete_User";
            this.btn_Delete_User.Size = new System.Drawing.Size(665, 72);
            this.btn_Delete_User.TabIndex = 13;
            this.btn_Delete_User.Text = "Delete User";
            this.btn_Delete_User.UseVisualStyleBackColor = false;
            this.btn_Delete_User.Click += new System.EventHandler(this.btn_Delete_User_Click);
            // 
            // frm_User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Delete_User);
            this.Controls.Add(this.pb_View_Customer_Details);
            this.Controls.Add(this.pb_Add_New_Customer);
            this.Controls.Add(this.btn_Update_User);
            this.Controls.Add(this.btn_Add_New_User);
            this.Controls.Add(this.panel1);
            this.Name = "frm_User_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_View_Customer_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Add_New_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Distributor_Entry;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_View_Customer_Details;
        private System.Windows.Forms.PictureBox pb_Add_New_Customer;
        private System.Windows.Forms.Button btn_Update_User;
        private System.Windows.Forms.Button btn_Add_New_User;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Delete_User;

    }
}