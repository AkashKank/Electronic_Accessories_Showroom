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
    public partial class frm_Add_New_User : Form
    {
        public frm_Add_New_User()
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
            tb_Confirm_Password.Clear();
            tb_New_Password.Clear();
            tb_User_Name.Clear();
            cmb_UserRole.SelectedIndex = -1;

            tb_User_Name.Focus();
        }

      
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (cmb_UserRole.Text != "" && tb_User_Name.Text != "" && tb_Confirm_Password.Text != "" && tb_New_Password.Text != "")
            {
                Con_Open();

                if (tb_New_Password.Text == tb_Confirm_Password.Text)
                {
                    SqlCommand Cmd = new SqlCommand();
                    Cmd.Connection = Con;
                    Cmd.CommandText = "Insert into User_Details (UserRole,Username,Password) values(@UserRole,@Username,@Pass)";

                    Cmd.Parameters.Add("UserRole", SqlDbType.VarChar).Value = cmb_UserRole.Text;
                    Cmd.Parameters.Add("Username", SqlDbType.VarChar).Value = tb_User_Name.Text;
                    Cmd.Parameters.Add("Pass", SqlDbType.NVarChar).Value = tb_New_Password.Text;

                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("User Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_User_Management UM = new frm_User_Management();
            this.Hide();
            UM.Show();
        }
    }
}
