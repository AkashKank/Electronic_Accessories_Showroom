namespace Electronic_Accessories_Showroom
{
    partial class frm_Add_New_Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_Category));
            this.pnl_Add_New_Category = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Add_New_Category = new System.Windows.Forms.Label();
            this.pnl_Category_Details = new System.Windows.Forms.Panel();
            this.tb_Category_ID = new System.Windows.Forms.TextBox();
            this.tb_Category_Name = new System.Windows.Forms.TextBox();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.lbl_Category_ID = new System.Windows.Forms.Label();
            this.lbl_Category_Details = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.pnl_Add_New_Category.SuspendLayout();
            this.pnl_Category_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Add_New_Category
            // 
            this.pnl_Add_New_Category.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnl_Add_New_Category.Controls.Add(this.btn_Back);
            this.pnl_Add_New_Category.Controls.Add(this.lbl_Add_New_Category);
            this.pnl_Add_New_Category.Location = new System.Drawing.Point(0, 1);
            this.pnl_Add_New_Category.Name = "pnl_Add_New_Category";
            this.pnl_Add_New_Category.Size = new System.Drawing.Size(2035, 146);
            this.pnl_Add_New_Category.TabIndex = 0;
            // 
            // btn_Back
            // 
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Back.Location = new System.Drawing.Point(27, 23);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(139, 52);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_Add_New_Category
            // 
            this.lbl_Add_New_Category.AutoSize = true;
            this.lbl_Add_New_Category.Font = new System.Drawing.Font("Stencil", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Category.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Add_New_Category.Location = new System.Drawing.Point(643, 36);
            this.lbl_Add_New_Category.Name = "lbl_Add_New_Category";
            this.lbl_Add_New_Category.Size = new System.Drawing.Size(693, 81);
            this.lbl_Add_New_Category.TabIndex = 1;
            this.lbl_Add_New_Category.Text = "Add New Category";
            // 
            // pnl_Category_Details
            // 
            this.pnl_Category_Details.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_Category_Details.Controls.Add(this.tb_Category_ID);
            this.pnl_Category_Details.Controls.Add(this.tb_Category_Name);
            this.pnl_Category_Details.Controls.Add(this.lbl_Category_Name);
            this.pnl_Category_Details.Controls.Add(this.lbl_Category_ID);
            this.pnl_Category_Details.Location = new System.Drawing.Point(170, 195);
            this.pnl_Category_Details.Name = "pnl_Category_Details";
            this.pnl_Category_Details.Size = new System.Drawing.Size(1722, 593);
            this.pnl_Category_Details.TabIndex = 1;
            // 
            // tb_Category_ID
            // 
            this.tb_Category_ID.Enabled = false;
            this.tb_Category_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold);
            this.tb_Category_ID.Location = new System.Drawing.Point(887, 208);
            this.tb_Category_ID.MaxLength = 10;
            this.tb_Category_ID.Name = "tb_Category_ID";
            this.tb_Category_ID.Size = new System.Drawing.Size(356, 35);
            this.tb_Category_ID.TabIndex = 1;
            this.tb_Category_ID.TextChanged += new System.EventHandler(this.tb_Category_ID_TextChanged);
            // 
            // tb_Category_Name
            // 
            this.tb_Category_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold);
            this.tb_Category_Name.Location = new System.Drawing.Point(887, 385);
            this.tb_Category_Name.MaxLength = 50;
            this.tb_Category_Name.Name = "tb_Category_Name";
            this.tb_Category_Name.Size = new System.Drawing.Size(356, 35);
            this.tb_Category_Name.TabIndex = 2;
            this.tb_Category_Name.TextChanged += new System.EventHandler(this.tb_Category_Name_TextChanged);
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Name.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Category_Name.Location = new System.Drawing.Point(482, 382);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(219, 35);
            this.lbl_Category_Name.TabIndex = 2;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // lbl_Category_ID
            // 
            this.lbl_Category_ID.AutoSize = true;
            this.lbl_Category_ID.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Category_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_ID.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Category_ID.Location = new System.Drawing.Point(482, 205);
            this.lbl_Category_ID.Name = "lbl_Category_ID";
            this.lbl_Category_ID.Size = new System.Drawing.Size(171, 35);
            this.lbl_Category_ID.TabIndex = 1;
            this.lbl_Category_ID.Text = "Category ID";
            // 
            // lbl_Category_Details
            // 
            this.lbl_Category_Details.AutoSize = true;
            this.lbl_Category_Details.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Details.Location = new System.Drawing.Point(210, 182);
            this.lbl_Category_Details.Name = "lbl_Category_Details";
            this.lbl_Category_Details.Size = new System.Drawing.Size(202, 31);
            this.lbl_Category_Details.TabIndex = 3;
            this.lbl_Category_Details.Text = "Category Details";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(936, 816);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(157, 59);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Add_New_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_Category_Details);
            this.Controls.Add(this.pnl_Category_Details);
            this.Controls.Add(this.pnl_Add_New_Category);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Add_New_Category";
            this.Text = "Add New Category";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_New_Category_Load);
            this.pnl_Add_New_Category.ResumeLayout(false);
            this.pnl_Add_New_Category.PerformLayout();
            this.pnl_Category_Details.ResumeLayout(false);
            this.pnl_Category_Details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Add_New_Category;
        private System.Windows.Forms.Label lbl_Add_New_Category;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel pnl_Category_Details;
        private System.Windows.Forms.Label lbl_Category_Details;
        private System.Windows.Forms.Label lbl_Category_ID;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.TextBox tb_Category_ID;
        private System.Windows.Forms.TextBox tb_Category_Name;
        private System.Windows.Forms.Button btn_Save;
    }
}