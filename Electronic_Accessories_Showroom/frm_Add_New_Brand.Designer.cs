namespace Electronic_Accessories_Showroom
{
    partial class frm_Add_New_Brand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_Brand));
            this.pnl_Add_New_Brand = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Add_New_Brand = new System.Windows.Forms.Label();
            this.pnl_Brand_Details = new System.Windows.Forms.Panel();
            this.cmb_Category_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.lbl_Brand_Name = new System.Windows.Forms.Label();
            this.tb_Brand_ID = new System.Windows.Forms.TextBox();
            this.tb_Brand_Name = new System.Windows.Forms.TextBox();
            this.lbl_Brand_ID = new System.Windows.Forms.Label();
            this.lbl_Brand_Details = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.pnl_Add_New_Brand.SuspendLayout();
            this.pnl_Brand_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Add_New_Brand
            // 
            this.pnl_Add_New_Brand.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnl_Add_New_Brand.Controls.Add(this.btn_Back);
            this.pnl_Add_New_Brand.Controls.Add(this.lbl_Add_New_Brand);
            this.pnl_Add_New_Brand.Location = new System.Drawing.Point(1, 1);
            this.pnl_Add_New_Brand.Name = "pnl_Add_New_Brand";
            this.pnl_Add_New_Brand.Size = new System.Drawing.Size(2144, 134);
            this.pnl_Add_New_Brand.TabIndex = 1;
            this.pnl_Add_New_Brand.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Add_New_Subcategory_Paint);
            // 
            // btn_Back
            // 
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Back.Location = new System.Drawing.Point(139, 33);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(150, 55);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_Add_New_Brand
            // 
            this.lbl_Add_New_Brand.AutoSize = true;
            this.lbl_Add_New_Brand.Font = new System.Drawing.Font("Stencil", 42F, System.Drawing.FontStyle.Bold);
            this.lbl_Add_New_Brand.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Add_New_Brand.Location = new System.Drawing.Point(784, 23);
            this.lbl_Add_New_Brand.Name = "lbl_Add_New_Brand";
            this.lbl_Add_New_Brand.Size = new System.Drawing.Size(593, 83);
            this.lbl_Add_New_Brand.TabIndex = 1;
            this.lbl_Add_New_Brand.Text = "Add New Brand";
            // 
            // pnl_Brand_Details
            // 
            this.pnl_Brand_Details.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_Brand_Details.Controls.Add(this.cmb_Category_Name);
            this.pnl_Brand_Details.Controls.Add(this.lbl_Category_Name);
            this.pnl_Brand_Details.Controls.Add(this.lbl_Brand_Name);
            this.pnl_Brand_Details.Controls.Add(this.tb_Brand_ID);
            this.pnl_Brand_Details.Controls.Add(this.tb_Brand_Name);
            this.pnl_Brand_Details.Controls.Add(this.lbl_Brand_ID);
            this.pnl_Brand_Details.Location = new System.Drawing.Point(115, 183);
            this.pnl_Brand_Details.Name = "pnl_Brand_Details";
            this.pnl_Brand_Details.Size = new System.Drawing.Size(1806, 644);
            this.pnl_Brand_Details.TabIndex = 2;
            // 
            // cmb_Category_Name
            // 
            this.cmb_Category_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.cmb_Category_Name.FormattingEnabled = true;
            this.cmb_Category_Name.Location = new System.Drawing.Point(1037, 171);
            this.cmb_Category_Name.MaxLength = 70;
            this.cmb_Category_Name.Name = "cmb_Category_Name";
            this.cmb_Category_Name.Size = new System.Drawing.Size(436, 34);
            this.cmb_Category_Name.TabIndex = 1;
            this.cmb_Category_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_Name_SelectedIndexChanged);
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Name.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Category_Name.Location = new System.Drawing.Point(467, 168);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(219, 35);
            this.lbl_Category_Name.TabIndex = 10;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // lbl_Brand_Name
            // 
            this.lbl_Brand_Name.AutoSize = true;
            this.lbl_Brand_Name.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Brand_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand_Name.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Brand_Name.Location = new System.Drawing.Point(467, 434);
            this.lbl_Brand_Name.Name = "lbl_Brand_Name";
            this.lbl_Brand_Name.Size = new System.Drawing.Size(179, 35);
            this.lbl_Brand_Name.TabIndex = 9;
            this.lbl_Brand_Name.Text = "Brand Name";
            // 
            // tb_Brand_ID
            // 
            this.tb_Brand_ID.Enabled = false;
            this.tb_Brand_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Brand_ID.Location = new System.Drawing.Point(1037, 312);
            this.tb_Brand_ID.MaxLength = 10;
            this.tb_Brand_ID.Name = "tb_Brand_ID";
            this.tb_Brand_ID.Size = new System.Drawing.Size(436, 33);
            this.tb_Brand_ID.TabIndex = 2;
            this.tb_Brand_ID.TextChanged += new System.EventHandler(this.tb_Brand_ID_TextChanged);
            // 
            // tb_Brand_Name
            // 
            this.tb_Brand_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Brand_Name.Location = new System.Drawing.Point(1037, 437);
            this.tb_Brand_Name.MaxLength = 50;
            this.tb_Brand_Name.Name = "tb_Brand_Name";
            this.tb_Brand_Name.Size = new System.Drawing.Size(436, 33);
            this.tb_Brand_Name.TabIndex = 3;
            this.tb_Brand_Name.TextChanged += new System.EventHandler(this.tb_Brand_Name_TextChanged);
            // 
            // lbl_Brand_ID
            // 
            this.lbl_Brand_ID.AutoSize = true;
            this.lbl_Brand_ID.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Brand_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand_ID.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Brand_ID.Location = new System.Drawing.Point(467, 309);
            this.lbl_Brand_ID.Name = "lbl_Brand_ID";
            this.lbl_Brand_ID.Size = new System.Drawing.Size(131, 35);
            this.lbl_Brand_ID.TabIndex = 1;
            this.lbl_Brand_ID.Text = "Brand ID";
            // 
            // lbl_Brand_Details
            // 
            this.lbl_Brand_Details.AutoSize = true;
            this.lbl_Brand_Details.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand_Details.Location = new System.Drawing.Point(175, 168);
            this.lbl_Brand_Details.Name = "lbl_Brand_Details";
            this.lbl_Brand_Details.Size = new System.Drawing.Size(152, 29);
            this.lbl_Brand_Details.TabIndex = 9;
            this.lbl_Brand_Details.Text = "Brand Details";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(885, 858);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(157, 59);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Add_New_Brand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_Brand_Details);
            this.Controls.Add(this.pnl_Brand_Details);
            this.Controls.Add(this.pnl_Add_New_Brand);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Add_New_Brand";
            this.Text = "Add New Brand";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_New_Brand_Load);
            this.pnl_Add_New_Brand.ResumeLayout(false);
            this.pnl_Add_New_Brand.PerformLayout();
            this.pnl_Brand_Details.ResumeLayout(false);
            this.pnl_Brand_Details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Add_New_Brand;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_Add_New_Brand;
        private System.Windows.Forms.Panel pnl_Brand_Details;
        private System.Windows.Forms.TextBox tb_Brand_ID;
        private System.Windows.Forms.TextBox tb_Brand_Name;
        private System.Windows.Forms.Label lbl_Brand_ID;
        private System.Windows.Forms.Label lbl_Brand_Details;
        private System.Windows.Forms.Label lbl_Brand_Name;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cmb_Category_Name;
        private System.Windows.Forms.Label lbl_Category_Name;
    }
}