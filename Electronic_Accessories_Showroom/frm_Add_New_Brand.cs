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
    public partial class frm_Add_New_Brand : Form
    {
        public frm_Add_New_Brand()
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
            Cmd.CommandText = "Select Count (Brand_ID) From Brand_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Brand_ID) from Brand_Details";

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
            tb_Brand_ID.Text = Convert.ToString(Auto_Increment());
            tb_Brand_Name.Text = "";
            cmb_Category_Name.Text = "";
            cmb_Category_Name.Focus();
        }

        void Bind_Category()
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Category_Name from Category_Details";

            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Category_Name.Items.Add(obj.GetString(obj.GetOrdinal("Category_Name")));
            }

            obj.Dispose();
            Con_Close();
        }

        private void cmb_Category_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_Brand_Name.Focus();
        }

        private void tb_Brand_ID_TextChanged(object sender, EventArgs e)
        {
            tb_Brand_Name.Focus();
        }

        private void tb_Brand_Name_TextChanged(object sender, EventArgs e)
        {
            btn_Save.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (cmb_Category_Name.Text != "" && tb_Brand_ID.Text != "" && tb_Brand_Name.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Brand_Details(Brand_ID,Category_Name,Brand_Name) Values(@B_ID,@Category_Name,@B_Name)";

                Cmd.Parameters.Add("B_ID", SqlDbType.Int).Value = tb_Brand_ID.Text;
                Cmd.Parameters.Add("Category_Name", SqlDbType.NVarChar).Value = cmb_Category_Name.Text;
                Cmd.Parameters.Add("B_Name", SqlDbType.NVarChar).Value = tb_Brand_Name.Text;

                Cmd.ExecuteNonQuery();


                MessageBox.Show("Brand Added Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con_Close();
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Incomplete Information", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
            

        private void pnl_Add_New_Subcategory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Product_Entry_Form obj = new frm_Product_Entry_Form();

            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
            this.Hide();
        }

        private void frm_Add_New_Brand_Load(object sender, EventArgs e)
        {
            Clear_Controls();

            Bind_Category();
        }
        
    }
}
