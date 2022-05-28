namespace Electronic_Accessories_Showroom
{
    partial class frm_Add_New_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_Employee));
            this.pnl_Add_New_Employee = new System.Windows.Forms.Panel();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Add_New_Employee = new System.Windows.Forms.Label();
            this.pnl_Distributor_Details = new System.Windows.Forms.Panel();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.dtp_Date_Of_Birth = new System.Windows.Forms.DateTimePicker();
            this.tb_Salary = new System.Windows.Forms.TextBox();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.dtp_Joining_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Email_ID = new System.Windows.Forms.TextBox();
            this.tb_Pan_Card_No = new System.Windows.Forms.TextBox();
            this.tb_Aadhar_Card_No = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No_1 = new System.Windows.Forms.TextBox();
            this.lbl_Email_ID = new System.Windows.Forms.Label();
            this.lbl_Pan_Card_No = new System.Windows.Forms.Label();
            this.lbl_Aadhar_Card_No = new System.Windows.Forms.Label();
            this.lbl_Mobile_No_1 = new System.Windows.Forms.Label();
            this.lbl_Joining_Date = new System.Windows.Forms.Label();
            this.tb_Alternate_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Employee_Name = new System.Windows.Forms.TextBox();
            this.tb_Employee_ID = new System.Windows.Forms.TextBox();
            this.lbl_Alternate_Mobile_No_2 = new System.Windows.Forms.Label();
            this.lbl_Date_Of_Birth = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Employee_Name = new System.Windows.Forms.Label();
            this.lbl_Employee_ID = new System.Windows.Forms.Label();
            this.lbl_Employee_Details = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.pnl_Add_New_Employee.SuspendLayout();
            this.pnl_Distributor_Details.SuspendLayout();
            this.gb_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Add_New_Employee
            // 
            this.pnl_Add_New_Employee.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnl_Add_New_Employee.Controls.Add(this.btn_Log_Out);
            this.pnl_Add_New_Employee.Controls.Add(this.btn_Back);
            this.pnl_Add_New_Employee.Controls.Add(this.lbl_Add_New_Employee);
            this.pnl_Add_New_Employee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_Add_New_Employee.Location = new System.Drawing.Point(1, 1);
            this.pnl_Add_New_Employee.Name = "pnl_Add_New_Employee";
            this.pnl_Add_New_Employee.Size = new System.Drawing.Size(2035, 126);
            this.pnl_Add_New_Employee.TabIndex = 1;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Log_Out.BackgroundImage")));
            this.btn_Log_Out.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Log_Out.Location = new System.Drawing.Point(1738, 18);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(183, 56);
            this.btn_Log_Out.TabIndex = 16;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = true;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Back.Location = new System.Drawing.Point(91, 18);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(141, 56);
            this.btn_Back.TabIndex = 15;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_Add_New_Employee
            // 
            this.lbl_Add_New_Employee.AutoSize = true;
            this.lbl_Add_New_Employee.Font = new System.Drawing.Font("Stencil", 42F, System.Drawing.FontStyle.Bold);
            this.lbl_Add_New_Employee.Location = new System.Drawing.Point(675, 18);
            this.lbl_Add_New_Employee.Name = "lbl_Add_New_Employee";
            this.lbl_Add_New_Employee.Size = new System.Drawing.Size(711, 83);
            this.lbl_Add_New_Employee.TabIndex = 0;
            this.lbl_Add_New_Employee.Text = "Add New Employee";
            // 
            // pnl_Distributor_Details
            // 
            this.pnl_Distributor_Details.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_Distributor_Details.Controls.Add(this.gb_Gender);
            this.pnl_Distributor_Details.Controls.Add(this.dtp_Date_Of_Birth);
            this.pnl_Distributor_Details.Controls.Add(this.tb_Salary);
            this.pnl_Distributor_Details.Controls.Add(this.lbl_Salary);
            this.pnl_Distributor_Details.Controls.Add(this.dtp_Joining_Date);
            this.pnl_Distributor_Details.Controls.Add(this.tb_Email_ID);
            this.pnl_Distributor_Details.Controls.Add(this.tb_Pan_Card_No);
            this.pnl_Distributor_Details.Controls.Add(this.tb_Aadhar_Card_No);
            this.pnl_Distributor_Details.Controls.Add(this.tb_Mobile_No_1);
            this.pnl_Distributor_Details.Controls.Add(this.lbl_Email_ID);
            this.pnl_Distributor_Details.Controls.Add(this.lbl_Pan_Card_No);
            this.pnl_Distributor_Details.Controls.Add(this.lbl_Aadhar_Card_No);
            this.pnl_Distributor_Details.Controls.Add(this.lbl_Mobile_No_1);
            this.pnl_Distributor_Details.Controls.Add(this.lbl_Joining_Date);
            this.pnl_Distributor_Details.Controls.Add(this.tb_Alternate_Mobile_No);
            this.pnl_Distributor_Details.Controls.Add(this.tb_Address);
            this.pnl_Distributor_Details.Controls.Add(this.tb_Employee_Name);
            this.pnl_Distributor_Details.Controls.Add(this.tb_Employee_ID);
            this.pnl_Distributor_Details.Controls.Add(this.lbl_Alternate_Mobile_No_2);
            this.pnl_Distributor_Details.Controls.Add(this.lbl_Date_Of_Birth);
            this.pnl_Distributor_Details.Controls.Add(this.lbl_Gender);
            this.pnl_Distributor_Details.Controls.Add(this.lbl_Address);
            this.pnl_Distributor_Details.Controls.Add(this.lbl_Employee_Name);
            this.pnl_Distributor_Details.Controls.Add(this.lbl_Employee_ID);
            this.pnl_Distributor_Details.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Distributor_Details.Location = new System.Drawing.Point(92, 164);
            this.pnl_Distributor_Details.Name = "pnl_Distributor_Details";
            this.pnl_Distributor_Details.Size = new System.Drawing.Size(1863, 681);
            this.pnl_Distributor_Details.TabIndex = 2;
            // 
            // gb_Gender
            // 
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Location = new System.Drawing.Point(481, 343);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(323, 70);
            this.gb_Gender.TabIndex = 4;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Enter += new System.EventHandler(this.gb_Gender_Enter);
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rb_Female.Location = new System.Drawing.Point(176, 18);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(115, 35);
            this.rb_Female.TabIndex = 26;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rb_Male.Location = new System.Drawing.Point(18, 18);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(91, 35);
            this.rb_Male.TabIndex = 25;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // dtp_Date_Of_Birth
            // 
            this.dtp_Date_Of_Birth.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.dtp_Date_Of_Birth.Location = new System.Drawing.Point(481, 274);
            this.dtp_Date_Of_Birth.Name = "dtp_Date_Of_Birth";
            this.dtp_Date_Of_Birth.Size = new System.Drawing.Size(323, 33);
            this.dtp_Date_Of_Birth.TabIndex = 3;
            // 
            // tb_Salary
            // 
            this.tb_Salary.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Salary.Location = new System.Drawing.Point(1329, 564);
            this.tb_Salary.MaxLength = 10;
            this.tb_Salary.Name = "tb_Salary";
            this.tb_Salary.Size = new System.Drawing.Size(323, 33);
            this.tb_Salary.TabIndex = 12;
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Salary.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Salary.Location = new System.Drawing.Point(1001, 565);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(83, 31);
            this.lbl_Salary.TabIndex = 22;
            this.lbl_Salary.Text = "Salary";
            // 
            // dtp_Joining_Date
            // 
            this.dtp_Joining_Date.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.dtp_Joining_Date.Location = new System.Drawing.Point(1329, 73);
            this.dtp_Joining_Date.Name = "dtp_Joining_Date";
            this.dtp_Joining_Date.Size = new System.Drawing.Size(323, 33);
            this.dtp_Joining_Date.TabIndex = 7;
            // 
            // tb_Email_ID
            // 
            this.tb_Email_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Email_ID.Location = new System.Drawing.Point(481, 564);
            this.tb_Email_ID.MaxLength = 40;
            this.tb_Email_ID.Name = "tb_Email_ID";
            this.tb_Email_ID.Size = new System.Drawing.Size(323, 33);
            this.tb_Email_ID.TabIndex = 6;
            // 
            // tb_Pan_Card_No
            // 
            this.tb_Pan_Card_No.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Pan_Card_No.Location = new System.Drawing.Point(1329, 470);
            this.tb_Pan_Card_No.MaxLength = 10;
            this.tb_Pan_Card_No.Name = "tb_Pan_Card_No";
            this.tb_Pan_Card_No.Size = new System.Drawing.Size(323, 33);
            this.tb_Pan_Card_No.TabIndex = 11;
            // 
            // tb_Aadhar_Card_No
            // 
            this.tb_Aadhar_Card_No.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Aadhar_Card_No.Location = new System.Drawing.Point(1329, 364);
            this.tb_Aadhar_Card_No.MaxLength = 12;
            this.tb_Aadhar_Card_No.Name = "tb_Aadhar_Card_No";
            this.tb_Aadhar_Card_No.Size = new System.Drawing.Size(323, 33);
            this.tb_Aadhar_Card_No.TabIndex = 10;
            this.tb_Aadhar_Card_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Aadhar_Card_No_KeyPress);
            // 
            // tb_Mobile_No_1
            // 
            this.tb_Mobile_No_1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Mobile_No_1.Location = new System.Drawing.Point(1329, 179);
            this.tb_Mobile_No_1.MaxLength = 10;
            this.tb_Mobile_No_1.Name = "tb_Mobile_No_1";
            this.tb_Mobile_No_1.Size = new System.Drawing.Size(323, 33);
            this.tb_Mobile_No_1.TabIndex = 8;
            this.tb_Mobile_No_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Mobile_No_1_KeyPress);
            // 
            // lbl_Email_ID
            // 
            this.lbl_Email_ID.AutoSize = true;
            this.lbl_Email_ID.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Email_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email_ID.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Email_ID.Location = new System.Drawing.Point(169, 562);
            this.lbl_Email_ID.Name = "lbl_Email_ID";
            this.lbl_Email_ID.Size = new System.Drawing.Size(109, 31);
            this.lbl_Email_ID.TabIndex = 16;
            this.lbl_Email_ID.Text = "Email ID";
            // 
            // lbl_Pan_Card_No
            // 
            this.lbl_Pan_Card_No.AutoSize = true;
            this.lbl_Pan_Card_No.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Pan_Card_No.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pan_Card_No.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Pan_Card_No.Location = new System.Drawing.Point(1001, 471);
            this.lbl_Pan_Card_No.Name = "lbl_Pan_Card_No";
            this.lbl_Pan_Card_No.Size = new System.Drawing.Size(158, 31);
            this.lbl_Pan_Card_No.TabIndex = 15;
            this.lbl_Pan_Card_No.Text = "Pan Card No";
            // 
            // lbl_Aadhar_Card_No
            // 
            this.lbl_Aadhar_Card_No.AutoSize = true;
            this.lbl_Aadhar_Card_No.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Aadhar_Card_No.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aadhar_Card_No.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Aadhar_Card_No.Location = new System.Drawing.Point(1001, 365);
            this.lbl_Aadhar_Card_No.Name = "lbl_Aadhar_Card_No";
            this.lbl_Aadhar_Card_No.Size = new System.Drawing.Size(197, 31);
            this.lbl_Aadhar_Card_No.TabIndex = 14;
            this.lbl_Aadhar_Card_No.Text = "Aadhar Card No";
            // 
            // lbl_Mobile_No_1
            // 
            this.lbl_Mobile_No_1.AutoSize = true;
            this.lbl_Mobile_No_1.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Mobile_No_1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No_1.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Mobile_No_1.Location = new System.Drawing.Point(1001, 177);
            this.lbl_Mobile_No_1.Name = "lbl_Mobile_No_1";
            this.lbl_Mobile_No_1.Size = new System.Drawing.Size(156, 31);
            this.lbl_Mobile_No_1.TabIndex = 13;
            this.lbl_Mobile_No_1.Text = "Mobile No 1";
            // 
            // lbl_Joining_Date
            // 
            this.lbl_Joining_Date.AutoSize = true;
            this.lbl_Joining_Date.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Joining_Date.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Joining_Date.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Joining_Date.Location = new System.Drawing.Point(1001, 79);
            this.lbl_Joining_Date.Name = "lbl_Joining_Date";
            this.lbl_Joining_Date.Size = new System.Drawing.Size(159, 31);
            this.lbl_Joining_Date.TabIndex = 12;
            this.lbl_Joining_Date.Text = "Joining Date";
            // 
            // tb_Alternate_Mobile_No
            // 
            this.tb_Alternate_Mobile_No.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Alternate_Mobile_No.Location = new System.Drawing.Point(1329, 271);
            this.tb_Alternate_Mobile_No.MaxLength = 10;
            this.tb_Alternate_Mobile_No.Name = "tb_Alternate_Mobile_No";
            this.tb_Alternate_Mobile_No.Size = new System.Drawing.Size(323, 33);
            this.tb_Alternate_Mobile_No.TabIndex = 9;
            this.tb_Alternate_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Alternate_Mobile_No_KeyPress);
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Address.Location = new System.Drawing.Point(481, 470);
            this.tb_Address.MaxLength = 60;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(323, 33);
            this.tb_Address.TabIndex = 5;
            // 
            // tb_Employee_Name
            // 
            this.tb_Employee_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Employee_Name.Location = new System.Drawing.Point(481, 179);
            this.tb_Employee_Name.MaxLength = 50;
            this.tb_Employee_Name.Name = "tb_Employee_Name";
            this.tb_Employee_Name.Size = new System.Drawing.Size(323, 33);
            this.tb_Employee_Name.TabIndex = 2;
            // 
            // tb_Employee_ID
            // 
            this.tb_Employee_ID.Enabled = false;
            this.tb_Employee_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Employee_ID.Location = new System.Drawing.Point(481, 78);
            this.tb_Employee_ID.MaxLength = 10;
            this.tb_Employee_ID.Name = "tb_Employee_ID";
            this.tb_Employee_ID.Size = new System.Drawing.Size(323, 33);
            this.tb_Employee_ID.TabIndex = 1;
            // 
            // lbl_Alternate_Mobile_No_2
            // 
            this.lbl_Alternate_Mobile_No_2.AutoSize = true;
            this.lbl_Alternate_Mobile_No_2.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Alternate_Mobile_No_2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alternate_Mobile_No_2.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Alternate_Mobile_No_2.Location = new System.Drawing.Point(1001, 272);
            this.lbl_Alternate_Mobile_No_2.Name = "lbl_Alternate_Mobile_No_2";
            this.lbl_Alternate_Mobile_No_2.Size = new System.Drawing.Size(255, 31);
            this.lbl_Alternate_Mobile_No_2.TabIndex = 5;
            this.lbl_Alternate_Mobile_No_2.Text = "Alternate Mobile No ";
            this.lbl_Alternate_Mobile_No_2.Click += new System.EventHandler(this.lbl_Mobile_No_2_Click);
            // 
            // lbl_Date_Of_Birth
            // 
            this.lbl_Date_Of_Birth.AutoSize = true;
            this.lbl_Date_Of_Birth.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Date_Of_Birth.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date_Of_Birth.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Date_Of_Birth.Location = new System.Drawing.Point(169, 272);
            this.lbl_Date_Of_Birth.Name = "lbl_Date_Of_Birth";
            this.lbl_Date_Of_Birth.Size = new System.Drawing.Size(163, 31);
            this.lbl_Date_Of_Birth.TabIndex = 4;
            this.lbl_Date_Of_Birth.Text = "Date Of Birth";
            this.lbl_Date_Of_Birth.Click += new System.EventHandler(this.lbl_Date_Of_Birth_Click);
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Gender.Location = new System.Drawing.Point(169, 363);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(97, 31);
            this.lbl_Gender.TabIndex = 3;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Address.Location = new System.Drawing.Point(169, 468);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(106, 31);
            this.lbl_Address.TabIndex = 2;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_Employee_Name
            // 
            this.lbl_Employee_Name.AutoSize = true;
            this.lbl_Employee_Name.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Employee_Name.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Employee_Name.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Employee_Name.Location = new System.Drawing.Point(169, 177);
            this.lbl_Employee_Name.Name = "lbl_Employee_Name";
            this.lbl_Employee_Name.Size = new System.Drawing.Size(199, 31);
            this.lbl_Employee_Name.TabIndex = 1;
            this.lbl_Employee_Name.Text = "Employee Name";
            // 
            // lbl_Employee_ID
            // 
            this.lbl_Employee_ID.AutoSize = true;
            this.lbl_Employee_ID.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Employee_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_ID.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Employee_ID.Location = new System.Drawing.Point(169, 76);
            this.lbl_Employee_ID.Name = "lbl_Employee_ID";
            this.lbl_Employee_ID.Size = new System.Drawing.Size(158, 31);
            this.lbl_Employee_ID.TabIndex = 0;
            this.lbl_Employee_ID.Text = "Employee ID";
            // 
            // lbl_Employee_Details
            // 
            this.lbl_Employee_Details.AutoSize = true;
            this.lbl_Employee_Details.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Employee_Details.Location = new System.Drawing.Point(144, 147);
            this.lbl_Employee_Details.Name = "lbl_Employee_Details";
            this.lbl_Employee_Details.Size = new System.Drawing.Size(191, 29);
            this.lbl_Employee_Details.TabIndex = 23;
            this.lbl_Employee_Details.Text = "Employee Details";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(543, 877);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(152, 56);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Tomato;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(1281, 877);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(182, 56);
            this.btn_Refresh.TabIndex = 14;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Add_New_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.lbl_Employee_Details);
            this.Controls.Add(this.pnl_Distributor_Details);
            this.Controls.Add(this.pnl_Add_New_Employee);
            this.Name = "frm_Add_New_Employee";
            this.Text = "Add New Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_New_Employee_Load);
            this.pnl_Add_New_Employee.ResumeLayout(false);
            this.pnl_Add_New_Employee.PerformLayout();
            this.pnl_Distributor_Details.ResumeLayout(false);
            this.pnl_Distributor_Details.PerformLayout();
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Add_New_Employee;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_Add_New_Employee;
        private System.Windows.Forms.Panel pnl_Distributor_Details;
        private System.Windows.Forms.DateTimePicker dtp_Joining_Date;
        private System.Windows.Forms.TextBox tb_Email_ID;
        private System.Windows.Forms.TextBox tb_Pan_Card_No;
        private System.Windows.Forms.TextBox tb_Aadhar_Card_No;
        private System.Windows.Forms.TextBox tb_Mobile_No_1;
        private System.Windows.Forms.Label lbl_Email_ID;
        private System.Windows.Forms.Label lbl_Pan_Card_No;
        private System.Windows.Forms.Label lbl_Aadhar_Card_No;
        private System.Windows.Forms.Label lbl_Mobile_No_1;
        private System.Windows.Forms.Label lbl_Joining_Date;
        private System.Windows.Forms.TextBox tb_Alternate_Mobile_No;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_Employee_Name;
        private System.Windows.Forms.TextBox tb_Employee_ID;
        private System.Windows.Forms.Label lbl_Alternate_Mobile_No_2;
        private System.Windows.Forms.Label lbl_Date_Of_Birth;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Employee_Name;
        private System.Windows.Forms.Label lbl_Employee_ID;
        private System.Windows.Forms.Label lbl_Employee_Details;
        private System.Windows.Forms.TextBox tb_Salary;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.DateTimePicker dtp_Date_Of_Birth;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.GroupBox gb_Gender;
    }
}