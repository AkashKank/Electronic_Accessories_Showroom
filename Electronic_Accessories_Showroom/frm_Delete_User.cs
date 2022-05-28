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
    public partial class frm_Delete_User : Form
    {
        public frm_Delete_User()
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
            Cmd.Dispose();
            Con_Close();
        }

        void Clear_Controls()
        {
            cmb_Username.SelectedIndex = -1;
            cmb_UserRole.SelectedIndex = -1;
            tb_Confirm_Password.Clear();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (cmb_Username.Text != "" && cmb_UserRole.Text != "" && tb_Confirm_Password.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Select Username from User_Details Where UserRole = '" + cmb_UserRole.Text + "' And Password = '" + tb_Confirm_Password.Text + "'";

                SqlDataReader Dr = Cmd.ExecuteReader();

                if(Dr.Read())
                {
                    Cmd.Dispose();

                    Cmd.Connection = Con;

                    Cmd.CommandText = "Delete from User_Details where Username = '" + cmb_Username.Text + "'And UserRole = '" + cmb_UserRole.Text + "' And Password = '" + tb_Confirm_Password.Text + "'";

                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("User Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    Con_Close();
                    Clear_Controls();
                }
                else
                {
                    MessageBox.Show("Enter Valid Password", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                Cmd.Dispose();
                Dr.Dispose();
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_User_Management UM = new frm_User_Management();
            this.Hide();
            UM.Show();
        }
    }
}
