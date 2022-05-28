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
    public partial class frm_Update_User : Form
    {
        public frm_Update_User()
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


        void Bind_UserName()
        {
            cmb_Username.Items.Clear();

            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Distinct(Username) from User_Details where UserRole = '" + cmb_UserRole.Text + "'";

            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Username.Items.Add(obj.GetString(obj.GetOrdinal("Username")));
            }

            obj.Dispose();
            Con_Close();
        }

        void Bind_Password()
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Distinct(Password) from User_Details where UserRole = '" + cmb_UserRole.Text + "' And Username = '"+cmb_Username.Text+"'";

            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                tb_Confirm_Password.Text = (obj.GetString(obj.GetOrdinal("Password")));
                tb_New_Password.Text = (obj.GetString(obj.GetOrdinal("Password")));
            }

            obj.Dispose();
            Con_Close();
        }

        void Clear_Controls()
        {
            tb_Confirm_Password.Clear();
            tb_New_Password.Clear();
            cmb_Username.SelectedIndex = -1;
            cmb_UserRole.SelectedIndex = -1;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (cmb_UserRole.Text != "" && cmb_Username.Text != "" && tb_Confirm_Password.Text != "" && tb_New_Password.Text != "")
            {
                Con_Open();

                if (tb_New_Password.Text == tb_Confirm_Password.Text)
                {
                    SqlCommand Cmd = new SqlCommand();
                    Cmd.Connection = Con;
                    Cmd.CommandText = "Update User_Details Set Password = @Pass where UserRole = '"+cmb_UserRole.Text+"' AND Username = '"+cmb_Username.Text+"'";

                    Cmd.Parameters.Add("Pass", SqlDbType.NVarChar).Value = tb_New_Password.Text;

                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("User Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con_Close();
                    Clear_Controls();
                }
                else
                {
                    MessageBox.Show("New Password & Confirm Password Are Not Same", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Incomplete Information", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmb_UserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_UserName();
        }

        private void cmb_Username_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_Password();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_User_Management UM = new frm_User_Management();
            this.Hide();
            UM.Show();
        }
    }
}
