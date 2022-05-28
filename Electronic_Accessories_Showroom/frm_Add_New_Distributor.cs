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
    public partial class frm_Add_New_Distributor : Form
    {
        public frm_Add_New_Distributor()
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
            Cmd.CommandText = "Select Count (Distributor_ID) From Distributor_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Distributor_ID) from Distributor_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 1;
            }

            Cmd.Dispose();

            return Cnt;
        }

        int Auto_Incr()
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count (D_RegNo) From Distributor_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(D_RegNo) from Distributor_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 101;
            }

            Cmd.Dispose();

            return Cnt;
        }

        void Clear_Controls()
        {
            tb_Distributor_ID.Text = Convert.ToString(Auto_Increment());
            tb_Distributor_Name.Text = "";
            tb_Address.Text = "";
            tb_Mobile_No_1.Text = "";
            tb_Alternate_Mobile_No.Text = "";
            dtp_Tie_Up_Date.ResetText();
            tb_Registration_No.Text = Convert.ToString(Auto_Incr());
            tb_Aadhar_Card_No.Text = "";
            tb_Pan_Card_No.Text = "";
            tb_Pan_Card_No.Text = "";
            tb_Email_ID.Text = "";
            rb_Female.Checked = false;
            rb_Male.Checked = false;
            tb_Distributor_Name.Focus();
            cb_Fridge.Checked = false;
            cb_AC.Checked = false;
            cb_Washing_Machine.Checked = false;
            cb_Other_Accessories.Checked = false;
            
        }

        private void tb_Mobile_No_1_TextChanged(object sender, EventArgs e)
        {
            tb_Alternate_Mobile_No.Enabled = true;
        }

        private void tb_Alternate_Mobile_No_TextChanged(object sender, EventArgs e)
        {
            dtp_Tie_Up_Date.Enabled = true;
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

        private void tb_Registration_No_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Distributor_Entry_Form obj = new frm_Distributor_Entry_Form();

            obj.WindowState = FormWindowState.Maximized;
            this.Hide();
            obj.Show();
        }

        private void pnl_Distributor_Details_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Distributor_ID.Text != "" && tb_Distributor_Name.Text != "" && tb_Address.Text != "" && (rb_Male.Checked || rb_Female.Checked) && tb_Mobile_No_1.Text != "" && tb_Mobile_No_1.TextLength == 10 && tb_Alternate_Mobile_No.Text != "" && tb_Alternate_Mobile_No.TextLength == 10 && dtp_Tie_Up_Date.Text != "" && tb_Registration_No.Text != "" && tb_Pan_Card_No.Text != "" && tb_Pan_Card_No.TextLength == 10 && tb_Aadhar_Card_No.Text != "" && tb_Aadhar_Card_No.TextLength == 12 && tb_Email_ID.Text != "")
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

                string Brand = "";

                if (cb_Fridge.Checked)
                {
                    Brand = "Fridge";
                }
                if (cb_AC.Checked)
                {
                    Brand += "AC";
                }
                if (cb_Washing_Machine.Checked)
                {
                    Brand += "Washing_Machine";
                }
                if (cb_Other_Accessories.Checked)
                {
                    Brand += "Other_Accessories";
                }

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Distributor_Details(Distributor_ID,Distributor_Name,D_Address,D_Gender,D_MobNo,D_AlternateNo,D_TieUp_Date,D_RegNo,D_AadharNo,D_PanCardNo,D_Email,D_BrandDelivered) Values(@D_ID,@D_Name,@Address,@Gender,@MobNo,@AlternateNo,@TieUp_Date,@RegNo,@AadharNo,@PanNo,@Email,@D_BrandDelivered)";

                Cmd.Parameters.Add("D_ID", SqlDbType.Int).Value = tb_Distributor_ID.Text;
                Cmd.Parameters.Add("D_Name", SqlDbType.NVarChar).Value = tb_Distributor_Name.Text;
                Cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("Gender", SqlDbType.VarChar).Value = Gen;
                Cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mobile_No_1.Text;
                Cmd.Parameters.Add("AlternateNo", SqlDbType.Decimal).Value = tb_Alternate_Mobile_No.Text;
                Cmd.Parameters.Add("TieUp_Date", SqlDbType.Date).Value = dtp_Tie_Up_Date.Text;
                Cmd.Parameters.Add("RegNo", SqlDbType.Int).Value = tb_Registration_No.Text;
                Cmd.Parameters.Add("AadharNo", SqlDbType.Decimal).Value = tb_Aadhar_Card_No.Text;
                Cmd.Parameters.Add("PanNo", SqlDbType.NVarChar).Value = tb_Pan_Card_No.Text;
                Cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = tb_Email_ID.Text;
                Cmd.Parameters.Add("D_BrandDelivered", SqlDbType.NVarChar).Value = Brand;

                Cmd.ExecuteNonQuery();
              

                MessageBox.Show("Distributor Added Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con_Close();
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Incomplete Information", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }

        private void frm_Add_New_Distributor_Load(object sender, EventArgs e)
        {

            Clear_Controls();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            btn_Back.Focus();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
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

        private void cb_Fridge_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
