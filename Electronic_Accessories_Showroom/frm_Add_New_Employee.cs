using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Electronic_Accessories_Showroom
{
    public partial class frm_Add_New_Employee : Form
    {
        public frm_Add_New_Employee()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_Electronic_Accessories_Showroom;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        int Auto_Increment()
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count (Employee_ID) From Employee_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Employee_ID) from Employee_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 1;
            }

            Cmd.Dispose();

            return Cnt;
        }

        void Clear_Controls()
        {
            tb_Employee_ID.Text = Convert.ToString(Auto_Increment());
            tb_Employee_Name.Text = "";
            dtp_Date_Of_Birth.ResetText();
            tb_Address.Text = "";
            tb_Email_ID.Text = "";
            dtp_Joining_Date.ResetText();
            tb_Mobile_No_1.Text = "";
            tb_Alternate_Mobile_No.Text = "";
            tb_Aadhar_Card_No.Text = "";
            tb_Pan_Card_No.Text = "";
            tb_Salary.Text = "";
            rb_Male.Checked = false;
            rb_Female.Checked = false;
            tb_Employee_Name.Focus();
        }

        private void tb_Mobile_No_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Alternate_Mobile_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }

        }

        private void tb_Aadhar_Card_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void lbl_Mobile_No_2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Date_Of_Birth_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Employee_Entry_Form obj = new frm_Employee_Entry_Form();

            obj.WindowState = FormWindowState.Maximized;
            this.Hide();
            obj.Show();
        }

        private void frm_Add_New_Employee_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void gb_Gender_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Employee_ID.Text != "" && tb_Employee_Name.Text != "" && dtp_Date_Of_Birth.Text != "" && (rb_Male.Checked || rb_Female.Checked) && tb_Address.Text != "" && tb_Email_ID.Text != "" && dtp_Joining_Date.Text != "" && tb_Mobile_No_1.TextLength == 10 && tb_Mobile_No_1.Text != "" && tb_Alternate_Mobile_No.TextLength == 10 && tb_Alternate_Mobile_No.Text != "" && tb_Aadhar_Card_No.TextLength == 12 && tb_Aadhar_Card_No.Text != "" && tb_Pan_Card_No.TextLength == 10 && tb_Pan_Card_No.Text != "" && tb_Salary.Text != "")
            {
                Con_Open();

                string Gen = "";

                if (rb_Male.Checked)
                {
                    Gen = "Male";
                }

                if (rb_Female.Checked)
                {
                    Gen = "Female";
                }

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Employee_Details(Employee_ID,Employee_Name,E_DateOf_Birth,E_Gender,E_Address,E_Email,E_Joining_Date,E_MobNo,E_AlternateNo,E_AadharNo,E_PanCardNo,E_Salary) Values(@E_ID,@E_Name,@E_DOB,@E_Gender,@E_Address,@E_Email,@E_JoiningDate,@E_MobNo,@E_AlternateNo,@E_AadharNo,@E_PanNo,@E_Salary)";

                Cmd.Parameters.Add("E_ID", SqlDbType.Int).Value = tb_Employee_ID.Text;
                Cmd.Parameters.Add("E_Name", SqlDbType.NVarChar).Value = tb_Employee_Name.Text;
                Cmd.Parameters.Add("E_DOB", SqlDbType.Date).Value = dtp_Date_Of_Birth.Text;
                Cmd.Parameters.Add("E_Gender", SqlDbType.VarChar).Value = Gen;
                Cmd.Parameters.Add("E_Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("E_Email", SqlDbType.NVarChar).Value = tb_Email_ID.Text;
                Cmd.Parameters.Add("E_JoiningDate", SqlDbType.Date).Value = dtp_Joining_Date.Text;
                Cmd.Parameters.Add("E_MobNo", SqlDbType.Decimal).Value = tb_Mobile_No_1.Text;
                Cmd.Parameters.Add("E_AlternateNo", SqlDbType.Decimal).Value = tb_Alternate_Mobile_No.Text;
                Cmd.Parameters.Add("E_AadharNo", SqlDbType.Decimal).Value = tb_Aadhar_Card_No.Text;
                Cmd.Parameters.Add("E_PanNo", SqlDbType.NVarChar).Value = tb_Pan_Card_No.Text;
                Cmd.Parameters.Add("E_Salary", SqlDbType.Money).Value = tb_Salary.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Distributor Added Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                 MessageBox.Show("Incomplete Information", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            Con_Close();
     
            
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            btn_Back.Focus();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure??", "Logging Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                frm_Login obj = new frm_Login();
                this.Hide();
                obj.Show();
            }
            else
            {
                this.Show();
            }
        }
  
        
    }
}
