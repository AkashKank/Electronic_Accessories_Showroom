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
    public partial class frm_Login : Form
    {
        public frm_Login()
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
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Distinct(Username) from User_Details where UserRole = '"+cmb_UserRole.Text+"'";

            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Username.Items.Add(obj.GetString(obj.GetOrdinal("Username")));
            }

            obj.Dispose();
            Con_Close();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (cmb_Username.Text != "" && cmb_UserRole.Text != "" && tb_Password.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Username from User_Details where Password = '" + tb_Password.Text + "' And UserRole = '" + cmb_UserRole.Text + "'";

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {

                    MessageBox.Show("Login Successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (cmb_UserRole.Text == "Admin")
                    {                       
                        frm_Admin_Entry_Form Obj = new frm_Admin_Entry_Form();
                        Obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        frm_Main_Entry_Form MEF = new frm_Main_Entry_Form();
                        this.Hide();
                        MEF.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Icorrect Username Or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                Dr.Dispose();
                Cmd.Dispose();
                Con_Close();
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
    }
}
