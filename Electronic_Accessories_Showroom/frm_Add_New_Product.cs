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
    public partial class frm_Add_New_Product : Form
    {
        public frm_Add_New_Product()
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
            Cmd.CommandText = "Select Count (Product_ID) From Product_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Product_ID) from Product_Details";

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
            tb_Product_ID.Text = Convert.ToString(Auto_Increment());
            cmb_Category.Text = "";
            cmb_Brand.Text = "";
            tb_Product_Name.Text = "";
            cmb_Distributor_Name.Text = "";
            cmb_Brand.Items.Clear();
            cmb_Category.Items.Clear();
            cmb_Distributor_Name.Items.Clear();
            dtp_Date.ResetText();
            tb_Sales_Rate.Text = "";
            tb_Purchase_Prize.Text = "";
            tb_Stock_Quantity.Text = "";
            tb_GST_Applied.Text = "";
            tb_Description.Text = "";
            cmb_Category.Enabled = true;
            cmb_Category.Focus();
            Bind_Category();
        }

        void Bind_Category()
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Distinct(Category_Name) from Category_Details";

            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Category.Items.Add(obj.GetString(obj.GetOrdinal("Category_Name")));
            }

            obj.Dispose();
            Con_Close();
        }

        private void tb_Product_ID_TextChanged(object sender, EventArgs e)
        {
            cmb_Category.Focus();
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Brand.Items.Clear();
            cmb_Brand.Enabled = true;
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Distinct(Brand_Name) from Brand_Details Where Category_Name = '" + cmb_Category.Text + "'";

            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Brand.Items.Add(obj.GetString(obj.GetOrdinal("Brand_Name")));
            }

            obj.Dispose();

            Con_Close();
            Bind_Brand();
        }

        void Bind_Brand()
        {
            cmb_Brand.Items.Clear();
            cmb_Brand.Enabled = true;
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Distinct(Brand_Name) from Brand_Details Where Category_Name = '" + cmb_Category.Text + "'";

            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Brand.Items.Add(obj.GetString(obj.GetOrdinal("Brand_Name")));
            }

            obj.Dispose();

            Con_Close();
        }

        void Bind_Distributor()
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Distinct(Distributor_Name) from Distributor_Details";

            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Distributor_Name.Items.Add(obj.GetString(obj.GetOrdinal("Distributor_Name")));
            }

            obj.Dispose();
            Con_Close();
        }

        private void tb_Product_Name_TextChanged(object sender, EventArgs e)
        {
            cmb_Distributor_Name.Items.Clear();
            cmb_Distributor_Name.Text = "";

            Bind_Distributor();

            cmb_Category.Enabled = false;
            cmb_Brand.Enabled = false;
        }

        private void tb_Sales_Rate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Purchase_Prize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Stock_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
           
            if (tb_Product_ID.Text != "" && cmb_Category.Text != "" && cmb_Brand.Text != "" && tb_Product_Name.Text != "" && cmb_Distributor_Name.Text != "" && tb_Sales_Rate.Text != "" && tb_Purchase_Prize.Text != "" && tb_GST_Applied.Text != "")
            {
                Con_Open();
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Product_Details(Product_ID,Category,Brand,Product_Name,Distributor_Name,Date,Sales_Rate,Purchase_Prize,Stock_Quantity,GST,Description) Values(@P_ID,@Category,@Brand,@P_Name,@D_Name,@Date,@Sales_Rate,@Purchase_Prize,@Stock_Quantity,@GST,@Description)";

                Cmd.Parameters.Add("P_ID", SqlDbType.Int).Value = tb_Product_ID.Text;
                Cmd.Parameters.Add("Category", SqlDbType.NVarChar).Value = cmb_Category.Text;
                Cmd.Parameters.Add("Brand", SqlDbType.NVarChar).Value = cmb_Brand.Text;
                Cmd.Parameters.Add("P_Name", SqlDbType.NVarChar).Value = tb_Product_Name.Text;
                Cmd.Parameters.Add("D_Name", SqlDbType.NVarChar).Value = cmb_Distributor_Name.Text;
                Cmd.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Date.Text;
                Cmd.Parameters.Add("Sales_Rate", SqlDbType.Money).Value = tb_Sales_Rate.Text;
                Cmd.Parameters.Add("Purchase_Prize", SqlDbType.Money).Value = tb_Purchase_Prize.Text;
                Cmd.Parameters.Add("Stock_Quantity", SqlDbType.Int).Value = tb_Stock_Quantity.Text;
                Cmd.Parameters.Add("GST", SqlDbType.Float).Value = tb_GST_Applied.Text;
                Cmd.Parameters.Add("Description", SqlDbType.NVarChar).Value = tb_Description.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Product Added Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Clear_Controls();
                Con_Close();
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


        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Product_Entry_Form obj = new frm_Product_Entry_Form();

            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
            this.Hide();
        }

        private void frm_Add_New_Product_Load(object sender, EventArgs e)
        {
            
            Bind_Category();
            Clear_Controls();

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
