namespace Electronic_Accessories_Showroom
{
    partial class frm_Add_New_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_User));
            this.pnl_User_Management = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.pnl_AddUser = new System.Windows.Forms.Panel();
            this.cmb_UserRole = new System.Windows.Forms.ComboBox();
            this.lbl_User_Role = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tb_Confirm_Password = new System.Windows.Forms.TextBox();
            this.tb_New_Password = new System.Windows.Forms.TextBox();
            this.tb_User_Name = new System.Windows.Forms.TextBox();
            this.lbl_Confirm_Password = new System.Windows.Forms.Label();
            this.lbl_New_Password = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.pnl_User_Management.SuspendLayout();
            this.pnl_AddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_User_Management
            // 
            this.pnl_User_Management.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnl_User_Management.Controls.Add(this.btn_Back);
            this.pnl_User_Management.Controls.Add(this.lbl_Header);
            this.pnl_User_Management.Location = new System.Drawing.Point(1, 1);
            this.pnl_User_Management.Name = "pnl_User_Management";
            this.pnl_User_Management.Size = new System.Drawing.Size(2133, 157);
            this.pnl_User_Management.TabIndex = 0;
            // 
            // btn_Back
            // 
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Back.Location = new System.Drawing.Point(50, 47);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(140, 53);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Stencil", 46.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Header.Location = new System.Drawing.Point(654, 28);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(602, 93);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Add New User";
            // 
            // pnl_AddUser
            // 
            this.pnl_AddUser.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_AddUser.Controls.Add(this.cmb_UserRole);
            this.pnl_AddUser.Controls.Add(this.lbl_User_Role);
            this.pnl_AddUser.Controls.Add(this.btn_Add);
            this.pnl_AddUser.Controls.Add(this.tb_Confirm_Password);
            this.pnl_AddUser.Controls.Add(this.tb_New_Password);
            this.pnl_AddUser.Controls.Add(this.tb_User_Name);
            this.pnl_AddUser.Controls.Add(this.lbl_Confirm_Password);
            this.pnl_AddUser.Controls.Add(this.lbl_New_Password);
            this.pnl_AddUser.Controls.Add(this.lbl_UserName);
            this.pnl_AddUser.Location = new System.Drawing.Point(370, 284);
            this.pnl_AddUser.Name = "pnl_AddUser";
            this.pnl_AddUser.Size = new System.Drawing.Size(1212, 607);
            this.pnl_AddUser.TabIndex = 1;
            // 
            // cmb_UserRole
            // 
            this.cmb_UserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_UserRole.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_UserRole.FormattingEnabled = true;
            this.cmb_UserRole.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cmb_UserRole.Location = new System.Drawing.Point(661, 66);
            this.cmb_UserRole.Name = "cmb_UserRole";
            this.cmb_UserRole.Size = new System.Drawing.Size(400, 37);
            this.cmb_UserRole.TabIndex = 1;
            // 
            // lbl_User_Role
            // 
            this.lbl_User_Role.AutoSize = true;
            this.lbl_User_Role.BackColor = System.Drawing.Color.Thistle;
            this.lbl_User_Role.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Role.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_User_Role.Location = new System.Drawing.Point(196, 66);
            this.lbl_User_Role.Name = "lbl_User_Role";
            this.lbl_User_Role.Size = new System.Drawing.Size(151, 39);
            this.lbl_User_Role.TabIndex = 24;
            this.lbl_User_Role.Text = "User Role";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(492, 491);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(176, 61);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_Confirm_Password
            // 
            this.tb_Confirm_Password.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Confirm_Password.Location = new System.Drawing.Point(661, 371);
            this.tb_Confirm_Password.MaxLength = 10;
            this.tb_Confirm_Password.Name = "tb_Confirm_Password";
            this.tb_Confirm_Password.Size = new System.Drawing.Size(400, 37);
            this.tb_Confirm_Password.TabIndex = 4;
            // 
            // tb_New_Password
            // 
            this.tb_New_Password.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_New_Password.Location = new System.Drawing.Point(661, 269);
            this.tb_New_Password.MaxLength = 10;
            this.tb_New_Password.Name = "tb_New_Password";
            this.tb_New_Password.Size = new System.Drawing.Size(400, 37);
            this.tb_New_Password.TabIndex = 3;
            // 
            // tb_User_Name
            // 
            this.tb_User_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_User_Name.Location = new System.Drawing.Point(661, 162);
            this.tb_User_Name.MaxLength = 20;
            this.tb_User_Name.Name = "tb_User_Name";
            this.tb_User_Name.Size = new System.Drawing.Size(400, 37);
            this.tb_User_Name.TabIndex = 2;
            // 
            // lbl_Confirm_Password
            // 
            this.lbl_Confirm_Password.AutoSize = true;
            this.lbl_Confirm_Password.BackColor = System.Drawing.Color.Thistle;
            this.lbl_Confirm_Password.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirm_Password.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Confirm_Password.Location = new System.Drawing.Point(196, 366);
            this.lbl_Confirm_Password.Name = "lbl_Confirm_Password";
            this.lbl_Confirm_Password.Size = new System.Drawing.Size(273, 39);
            this.lbl_Confirm_Password.TabIndex = 22;
            this.lbl_Confirm_Password.Text = "Confirm Password";
            // 
            // lbl_New_Password
            // 
            this.lbl_New_Password.AutoSize = true;
            this.lbl_New_Password.BackColor = System.Drawing.Color.Thistle;
            this.lbl_New_Password.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_New_Password.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_New_Password.Location = new System.Drawing.Point(196, 264);
            this.lbl_New_Password.Name = "lbl_New_Password";
            this.lbl_New_Password.Size = new System.Drawing.Size(222, 39);
            this.lbl_New_Password.TabIndex = 21;
            this.lbl_New_Password.Text = "New Password";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.BackColor = System.Drawing.Color.Thistle;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_UserName.Location = new System.Drawing.Point(196, 157);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(163, 39);
            this.lbl_UserName.TabIndex = 20;
            this.lbl_UserName.Text = "UserName";
            // 
            // frm_Add_New_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_AddUser);
            this.Controls.Add(this.pnl_User_Management);
            this.Name = "frm_Add_New_User";
            this.Text = "Add New User";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_User_Management.ResumeLayout(false);
            this.pnl_User_Management.PerformLayout();
            this.pnl_AddUser.ResumeLayout(false);
            this.pnl_AddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_User_Management;
        private System.Windows.Forms.Panel pnl_AddUser;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Confirm_Password;
        private System.Windows.Forms.Label lbl_New_Password;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox tb_Confirm_Password;
        private System.Windows.Forms.TextBox tb_New_Password;
        private System.Windows.Forms.TextBox tb_User_Name;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ComboBox cmb_UserRole;
        private System.Windows.Forms.Label lbl_User_Role;
    }
}