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
    public partial class frm_Add_Stock : Form
    {
        public frm_Add_Stock()
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
            cmb_Category.Text = "";
            cmb_Brand.Text = "";
            cmb_Product_Name.Text = "";
            cmb_Brand.Items.Clear();
            cmb_Product_Name.Items.Clear();
            cmb_Category.Enabled = true;
            cmb_Brand.Enabled = true;
            cmb_Product_Name.Enabled = true;
            dtp_Date.ResetText();
            tb_Current_Stock_Quantity.Text = "";
            tb_New_Stock_Quantity.Text = "";
            cmb_Category.Focus();
            cmb_Category.Items.Clear();
            Bind_Category();

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
                cmb_Category.Items.Add(obj.GetString(obj.GetOrdinal("Category_Name")));
            }

            obj.Dispose();
            Cmd.Dispose();
            Con_Close();
        }

        void Bind_Brand()
        {
          Con_Open();
        
          SqlCommand Cmd = new SqlCommand();
        
          Cmd.Connection = Con;

          Cmd.CommandText = "Select Distinct(Brand_Name) from Brand_Details where Category_Name = '"+cmb_Category.Text+"'";

          var obj = Cmd.ExecuteReader();

          while (obj.Read())
          {
               cmb_Brand.Items.Add(obj.GetString(obj.GetOrdinal("Brand_Name")));
          }

          obj.Dispose();
          Cmd.Dispose();
          Con_Close();
        }

        void Bind_Product()
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Distinct(Product_Name) from Product_Details where Brand = '" + cmb_Brand.Text + "'";

            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Product_Name.Items.Add(obj.GetString(obj.GetOrdinal("Product_Name")));
            }

            obj.Dispose();
            Con_Close();
        }


        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Brand.Text = "";
            cmb_Brand.Items.Clear();
            cmb_Brand.Enabled = true;
            cmb_Product_Name.Items.Clear();

            Bind_Brand();
          
        }

        private void cmb_Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Product_Name.Text = "";
            cmb_Product_Name.Items.Clear();
            cmb_Product_Name.Enabled = true;

            Bind_Product();
        }

        private void cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Product_Name.Enabled = false;
            cmb_Category.Enabled = false;
            cmb_Brand.Enabled = false;
            Con_Open();
            SqlCommand Cmd = new SqlCommand("Select Stock_Quantity from Product_Details where Product_Name = '"+cmb_Product_Name.Text+"'",Con);

            SqlDataReader Dr = Cmd.ExecuteReader();

            while (Dr.Read())
            {
                tb_Current_Stock_Quantity.Text = Dr["Stock_Quantity"].ToString();
            }

            Dr.Dispose();
            Cmd.Dispose();
            Con_Close();
        }

        private void tb_New_Stock_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (cmb_Category.Text != "" && cmb_Brand.Text != "" && cmb_Product_Name.Text != "" && dtp_Date.Text != "" && tb_Current_Stock_Quantity.Text != "" && tb_New_Stock_Quantity.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Stock_Details(Category,Brand,Product_Name,Date,Current_Stock_Quantity,New_Stock_Quantity) Values(@Category,@Brand,@P_Name,@Date,@Current_Stock,@New_Stock)";

                Cmd.Parameters.Add("Category", SqlDbType.NVarChar).Value = cmb_Category.Text;
                Cmd.Parameters.Add("Brand", SqlDbType.NVarChar).Value = cmb_Brand.Text;
                Cmd.Parameters.Add("P_Name", SqlDbType.NVarChar).Value = cmb_Product_Name.Text;
                Cmd.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Date.Text;
                Cmd.Parameters.Add("Current_Stock", SqlDbType.Int).Value = tb_Current_Stock_Quantity.Text;
                Cmd.Parameters.Add("New_Stock", SqlDbType.Int).Value = tb_New_Stock_Quantity.Text;

                Cmd.ExecuteNonQuery();


                MessageBox.Show("Stock Added Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con_Close();
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Incomplete Information", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void tb_Current_Stock_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Product_Entry_Form obj = new frm_Product_Entry_Form();

            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
            this.Hide();
        }

        private void lbl_Stock_Details_Click(object sender, EventArgs e)
        {

        }

        private void frm_Add_Stock_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void pnl_Category_Paint(object sender, PaintEventArgs e)
        {

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
