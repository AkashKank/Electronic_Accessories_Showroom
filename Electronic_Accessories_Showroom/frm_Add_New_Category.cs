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
    public partial class frm_Add_New_Category : Form
    {
        public frm_Add_New_Category()
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

        int Auto_Incr()
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count (Category_ID) From Category_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Category_ID) from Category_Details";

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
            tb_Category_ID.Text = Convert.ToString(Auto_Incr());
            tb_Category_Name.Text = " ";
            tb_Category_Name.Focus();
        }

        private void tb_Category_ID_TextChanged(object sender, EventArgs e)
        {
            tb_Category_Name.Enabled = true;
        }

        private void tb_Category_Name_TextChanged(object sender, EventArgs e)
        {
            btn_Save.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Category_ID.Text != " " && tb_Category_Name.Text != " ")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Category_Details(Category_ID,Category_Name) Values(@C_ID,@C_Name)";

                Cmd.Parameters.Add("C_ID", SqlDbType.Int).Value = tb_Category_ID.Text;
                Cmd.Parameters.Add("C_Name", SqlDbType.NVarChar).Value = tb_Category_Name.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Category Added Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
                    
            }
            else
            {
                MessageBox.Show("Incomplete Information", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            Con_Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Product_Entry_Form obj = new frm_Product_Entry_Form();

            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
            this.Hide();
        }

        private void frm_Add_New_Category_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

    }
}
