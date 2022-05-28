namespace Electronic_Accessories_Showroom
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.pb_Login = new System.Windows.Forms.PictureBox();
            this.pnl_Welcome = new System.Windows.Forms.Panel();
            this.Lbl_Welcome = new System.Windows.Forms.Label();
            this.pb_Login_Icon = new System.Windows.Forms.PictureBox();
            this.cmb_Username = new System.Windows.Forms.ComboBox();
            this.cmb_UserRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login)).BeginInit();
            this.pnl_Welcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.Chocolate;
            this.lbl_Login.Location = new System.Drawing.Point(720, 131);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(213, 97);
            this.lbl_Login.TabIndex = 1;
            this.lbl_Login.Text = "Login";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.White;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(650, 343);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(176, 38);
            this.lbl_Username.TabIndex = 2;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(656, 425);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(170, 38);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password";
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(863, 433);
            this.tb_Password.MaxLength = 10;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(211, 30);
            this.tb_Password.TabIndex = 2;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Submit.Location = new System.Drawing.Point(773, 520);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(177, 53);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // pb_Login
            // 
            this.pb_Login.Image = ((System.Drawing.Image)(resources.GetObject("pb_Login.Image")));
            this.pb_Login.Location = new System.Drawing.Point(2, 0);
            this.pb_Login.Name = "pb_Login";
            this.pb_Login.Size = new System.Drawing.Size(627, 613);
            this.pb_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Login.TabIndex = 7;
            this.pb_Login.TabStop = false;
            // 
            // pnl_Welcome
            // 
            this.pnl_Welcome.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnl_Welcome.Controls.Add(this.Lbl_Welcome);
            this.pnl_Welcome.Location = new System.Drawing.Point(628, 0);
            this.pnl_Welcome.Name = "pnl_Welcome";
            this.pnl_Welcome.Size = new System.Drawing.Size(493, 112);
            this.pnl_Welcome.TabIndex = 8;
            // 
            // Lbl_Welcome
            // 
            this.Lbl_Welcome.AutoSize = true;
            this.Lbl_Welcome.Font = new System.Drawing.Font("Stencil", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Welcome.Location = new System.Drawing.Point(81, 26);
            this.Lbl_Welcome.Name = "Lbl_Welcome";
            this.Lbl_Welcome.Size = new System.Drawing.Size(343, 81);
            this.Lbl_Welcome.TabIndex = 0;
            this.Lbl_Welcome.Text = "Welcome";
            // 
            // pb_Login_Icon
            // 
            this.pb_Login_Icon.Image = ((System.Drawing.Image)(resources.GetObject("pb_Login_Icon.Image")));
            this.pb_Login_Icon.Location = new System.Drawing.Point(928, 148);
            this.pb_Login_Icon.Name = "pb_Login_Icon";
            this.pb_Login_Icon.Size = new System.Drawing.Size(80, 67);
            this.pb_Login_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Login_Icon.TabIndex = 9;
            this.pb_Login_Icon.TabStop = false;
            // 
            // cmb_Username
            // 
            this.cmb_Username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Username.FormattingEnabled = true;
            this.cmb_Username.Location = new System.Drawing.Point(863, 348);
            this.cmb_Username.Name = "cmb_Username";
            this.cmb_Username.Size = new System.Drawing.Size(211, 33);
            this.cmb_Username.TabIndex = 10;
            // 
            // cmb_UserRole
            // 
            this.cmb_UserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_UserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_UserRole.FormattingEnabled = true;
            this.cmb_UserRole.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cmb_UserRole.Location = new System.Drawing.Point(863, 278);
            this.cmb_UserRole.Name = "cmb_UserRole";
            this.cmb_UserRole.Size = new System.Drawing.Size(211, 33);
            this.cmb_UserRole.TabIndex = 12;
            this.cmb_UserRole.SelectedIndexChanged += new System.EventHandler(this.cmb_UserRole_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(650, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "User Role";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1122, 613);
            this.Controls.Add(this.cmb_UserRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Username);
            this.Controls.Add(this.pb_Login_Icon);
            this.Controls.Add(this.pnl_Welcome);
            this.Controls.Add(this.pb_Login);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login)).EndInit();
            this.pnl_Welcome.ResumeLayout(false);
            this.pnl_Welcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.PictureBox pb_Login;
        private System.Windows.Forms.Panel pnl_Welcome;
        private System.Windows.Forms.Label Lbl_Welcome;
        private System.Windows.Forms.PictureBox pb_Login_Icon;
        private System.Windows.Forms.ComboBox cmb_Username;
        private System.Windows.Forms.ComboBox cmb_UserRole;
        private System.Windows.Forms.Label label1;

    }
}

