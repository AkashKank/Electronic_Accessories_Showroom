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
    public partial class frm_Search_Or_Update_Employee : Form
    {
        public frm_Search_Or_Update_Employee()
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

        void Clear_Controls()
        {
            tb_Employee_ID.Focus();
            tb_Employee_ID.Text = "";
            tb_Employee_Name.Text = "";
            dtp_Date_Of_Birth.ResetText();
            tb_Address.Text = "";
            tb_Mobile_No_1.Text = "";
            tb_Alternate_Mob_No.Text = "";
            tb_Email_ID.Text = "";
            dtp_Joining_Date.ResetText();
            tb_Salary.Text = "";
            tb_Aadhar_Card_No.Text = "";
            tb_Pan_Card_No.Text = "";
           
        }

        private void tb_Employee_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Employee_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Mobile_No_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Alternate_Mob_No_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_Employee_ID.Text != "")
            {
                lbl_Error.Visible = false;
                Con_Open();

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select * from Employee_Details where Employee_ID = " + tb_Employee_ID.Text + " ";

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Employee_Name.Text = Dr.GetString(Dr.GetOrdinal("Employee_Name"));
                    dtp_Date_Of_Birth.Text = (Dr["E_DateOf_Birth"].ToString());
                    tb_Address.Text = Dr.GetString(Dr.GetOrdinal("E_Address"));
                    tb_Mobile_No_1.Text = (Dr["E_MobNo"].ToString());
                    tb_Alternate_Mob_No.Text = (Dr["E_AlternateNo"].ToString());
                    tb_Pan_Card_No.Text = (Dr["E_PanCardNo"].ToString());
                    tb_Email_ID.Text = Dr.GetString(Dr.GetOrdinal("E_Email"));
                    dtp_Joining_Date.Text = (Dr["E_Joining_Date"].ToString());
                    tb_Aadhar_Card_No.Text = (Dr["E_AadharNo"].ToString());
                    tb_Salary.Text = (Dr["E_Salary"].ToString());
                }
                else
                {
                    MessageBox.Show("Employee Not Found", "NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_Employee_ID.Clear();
                    tb_Employee_ID.Focus();
                }

                Con_Close();
            }
            else
            {
                lbl_Error.Visible = true;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (tb_Employee_ID.Text != "" && tb_Employee_Name.Text != "" && dtp_Date_Of_Birth.Text != "" && tb_Address.Text != "" && tb_Email_ID.Text != "" && dtp_Joining_Date.Text != "" && tb_Mobile_No_1.TextLength == 10 && tb_Mobile_No_1.Text != "" && tb_Alternate_Mob_No.TextLength == 10 && tb_Alternate_Mob_No.Text != "" && tb_Aadhar_Card_No.TextLength == 12 && tb_Aadhar_Card_No.Text != "" && tb_Pan_Card_No.TextLength == 10 && tb_Pan_Card_No.Text != "" && tb_Salary.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Update Employee_Details Set Employee_Name = @E_Name,E_DateOf_Birth = @E_DOB,E_Address = @E_Address,E_Email = @E_Email,E_Joining_Date = @E_JoiningDate,E_MobNo = @E_MobNo,E_AlternateNo = @E_AlternateNo,E_AadharNo = @E_AadharNo,E_PanCardNo = @E_PanNo,E_Salary = @E_Salary";
                
                Cmd.Parameters.Add("E_Name", SqlDbType.NVarChar).Value = tb_Employee_Name.Text;
                Cmd.Parameters.Add("E_DOB", SqlDbType.Date).Value = dtp_Date_Of_Birth.Text;
                Cmd.Parameters.Add("E_Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("E_Email", SqlDbType.NVarChar).Value = tb_Email_ID.Text;
                Cmd.Parameters.Add("E_JoiningDate", SqlDbType.Date).Value = dtp_Joining_Date.Text;
                Cmd.Parameters.Add("E_MobNo", SqlDbType.Decimal).Value = tb_Mobile_No_1.Text;
                Cmd.Parameters.Add("E_AlternateNo", SqlDbType.Decimal).Value = tb_Alternate_Mob_No.Text;
                Cmd.Parameters.Add("E_AadharNo", SqlDbType.Decimal).Value = tb_Aadhar_Card_No.Text;
                Cmd.Parameters.Add("E_PanNo", SqlDbType.NVarChar).Value = tb_Pan_Card_No.Text;
                Cmd.Parameters.Add("E_Salary", SqlDbType.Money).Value = tb_Salary.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Employee Updated Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Incomplete Information", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            Con_Close();
     
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Joining_Date_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Employee_ID_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Employee_Entry_Form obj = new frm_Employee_Entry_Form();
            obj.Show();
            this.Hide();
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

        private void frm_Search_Or_Update_Employee_Load(object sender, EventArgs e)
        {
            tb_Employee_ID.Focus();
        }


       
    }
}
