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
    public partial class frm_Search_Or_Update_Distributor : Form
    {
        public frm_Search_Or_Update_Distributor()
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


        private void lbl_Search_Or_Update_Distributor_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Registration_No_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Distributor_Entry_Form obj = new frm_Distributor_Entry_Form();

            obj.WindowState = FormWindowState.Maximized;
            this.Hide();
            obj.Show();
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

        void Clear_Controls()
        {
            tb_Aadhar_Card_No.Clear();
            tb_Address.Clear();
            tb_Alternate_Mobile_No.Clear();
            tb_Distributor_ID.Clear();
            tb_Distributor_Name.Clear();
            tb_Email_ID.Clear();
            tb_Mobile_No_1.Clear();
            tb_Pan_Card_No.Clear();
            tb_Registration_No.Clear();
            dtp_Tie_Up_Date.Text = "";
            cmb_Brand_Delivered.Text = "";
            tb_Distributor_ID.Focus();

        }

        private void tb_Distributor_ID_KeyPress(object sender, KeyPressEventArgs e)
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



        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_Distributor_ID.Text != "")
            {
                lbl_Error.Visible = false;
                Con_Open();

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select * from Distributor_Details where Distributor_ID = " + tb_Distributor_ID.Text + " ";

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Distributor_Name.Text = Dr.GetString(Dr.GetOrdinal("Distributor_Name"));
                    tb_Address.Text = Dr.GetString(Dr.GetOrdinal("D_Address"));
                    tb_Mobile_No_1.Text = (Dr["D_MobNo"].ToString());
                    tb_Registration_No.Text = (Dr["D_RegNo"].ToString());
                    tb_Pan_Card_No.Text = (Dr["D_PanCardNo"].ToString());
                    tb_Email_ID.Text = Dr.GetString(Dr.GetOrdinal("D_Email"));
                    dtp_Tie_Up_Date.Text = (Dr["D_TieUp_Date"].ToString());
                    tb_Aadhar_Card_No.Text = (Dr["D_AadharNo"].ToString());
                    tb_Alternate_Mobile_No.Text = (Dr["D_AlternateNo"].ToString());
                    cmb_Brand_Delivered.Text = Dr.GetString(Dr.GetOrdinal("D_BrandDelivered"));
                }
                else
                {
                    MessageBox.Show("Distributor Not Found", "NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_Distributor_ID.Clear();
                    tb_Distributor_ID.Focus();
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
            if (tb_Distributor_ID.Text != "" && tb_Distributor_Name.Text != "" && tb_Address.Text != "" && tb_Mobile_No_1.Text != "" && tb_Mobile_No_1.TextLength == 10 && tb_Alternate_Mobile_No.Text != "" && tb_Alternate_Mobile_No.TextLength == 10 && dtp_Tie_Up_Date.Text != "" && tb_Registration_No.Text != "" && tb_Pan_Card_No.Text != "" && tb_Pan_Card_No.TextLength == 10 && tb_Aadhar_Card_No.Text != "" && tb_Aadhar_Card_No.TextLength == 12 && tb_Email_ID.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Update Distributor_Details set Distributor_Name = @D_Name,D_Address = @Address,D_MobNo = @MobNo,D_AlternateNo = @AlternateNo,D_TieUp_Date = @TieUp_Date,D_AadharNo = @AadharNo,D_PanCardNo = @PanNo,D_Email = @Email where Distributor_ID = " + tb_Distributor_ID.Text + " ";

           
                Cmd.Parameters.Add("D_Name", SqlDbType.NVarChar).Value = tb_Distributor_Name.Text;
                Cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mobile_No_1.Text;
                Cmd.Parameters.Add("AlternateNo", SqlDbType.Decimal).Value = tb_Alternate_Mobile_No.Text;
                Cmd.Parameters.Add("TieUp_Date", SqlDbType.Date).Value = dtp_Tie_Up_Date.Text;
                Cmd.Parameters.Add("AadharNo", SqlDbType.Decimal).Value = tb_Aadhar_Card_No.Text;
                Cmd.Parameters.Add("PanNo", SqlDbType.NVarChar).Value = tb_Pan_Card_No.Text;
                Cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = tb_Email_ID.Text;

                Cmd.ExecuteNonQuery();


                MessageBox.Show("Distributor Updated Succesfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con_Close();
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Incomplete Information", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
      
        }
         

        private void frm_Search_Or_Update_Distributor_Load(object sender, EventArgs e)
        {
            tb_Distributor_ID.Focus();
        }

      
    }
}
