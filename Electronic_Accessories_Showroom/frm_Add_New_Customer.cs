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
    public partial class frm_Add_New_Customer : Form
    {
        public frm_Add_New_Customer()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_Electronic_Accessories_Showroom;Integrated Security=True");

        int pCnt = 1, C_Stock = 0;

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

        int Auto_Increament_ID()
        {
            Con_Open();

            int Cnt = -1;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count(*) from Customer_Details";
            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;

                Cmd.CommandText = "Select Max(Customer_ID) from Customer_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }

            else
            {
                Cnt = 1;
            }

            Con_Close();

            return Cnt;

        }

        void Clear_Controls()
        {
            tb_Customer_ID.Text = Convert.ToString(Auto_Increament_ID());
            tb_Customer_Name.Clear();
            dtp_Date.ResetText();
            tb_Mob_No.Clear();
            cmb_Category.SelectedIndex = -1;
            cmb_Brand.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;
            tb_GST_Applied.Clear();
            tb_Quantity.Clear();
            tb_Price.Clear();
            tb_Total_Price.Text = "0";
            tb_Discount.Text = "0";
            tb_Total_Bill.Text = "0";
            dgv_Add_New_Customer.Rows.Clear();

            C_Stock = 0;
            pCnt = 1;

            tb_Customer_Name.Focus();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Customer_Entry_Form obj = new frm_Customer_Entry_Form();
            obj.Show();
            this.Hide();
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

            Cmd.Dispose();
            obj.Dispose();
            Con_Close();
        }

        void Bind_Product()
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Distinct(Product_Name) from Product_Details Where Brand = '" + cmb_Brand.Text + "'";

            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Product_Name.Items.Add(obj.GetString(obj.GetOrdinal("Product_Name")));
            }

            obj.Dispose();
            Cmd.Dispose();
            Con_Close();
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
            Cmd.Dispose();
            Con_Close();
        }

        private void frm_Add_New_Customer_Load(object sender, EventArgs e)
        {
            Clear_Controls();

            Bind_Category();
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_Brand();
        }

        private void cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Sales_Rate, GST , Stock_Quantity from Product_Details where Product_Name = '" + cmb_Product_Name.Text + "'";

            var Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                tb_Per_Price.Text = (Obj["Sales_Rate"].ToString());
                tb_GST_Applied.Text = (Obj["GST"].ToString());
                C_Stock = Convert.ToInt32(Obj["Stock_Quantity"]);
            }

            Obj.Dispose();
            Con_Close();
        }

        private void cmb_Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind_Product();
        }

        private void tb_Customer_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Customer_Name.Text != "" && tb_Mob_No.Text != "" && pCnt > 1 && tb_Total_Price.Text != "" && tb_Customer_ID.Text != "" && tb_Discount.Text != "" && tb_Total_Bill.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Customer_Details Values (@id, @CName, @Mob, @Dis,@Bill, @Date, @Finalb)";

                Cmd.Parameters.Add("id", SqlDbType.Int).Value = tb_Customer_ID.Text;
                Cmd.Parameters.Add("CName", SqlDbType.NVarChar).Value = tb_Customer_Name.Text;
                Cmd.Parameters.Add("Mob", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                Cmd.Parameters.Add("Dis", SqlDbType.Float).Value = tb_Discount.Text;
                Cmd.Parameters.Add("Bill", SqlDbType.Money).Value = tb_Total_Price.Text;
                Cmd.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Date.Value.Date;
                Cmd.Parameters.Add("Finalb", SqlDbType.Money).Value = tb_Total_Bill.Text;

                Cmd.ExecuteNonQuery();
                Cmd.Dispose();

                for (int i = 0; i <= dgv_Add_New_Customer.Rows.Count - 1; i++)
                {
                    SqlCommand Cmd1 = new SqlCommand("Insert Into Customer_Bill_Details (Customer_ID,Category,Brand,Product_Name,Quantity,Per_Price,GST,Price) Values(@cid,@Cat,@bName, @pName, @Qty, @pp, @GST, @Price)", Con);

                    Cmd1.Parameters.Add("cid", SqlDbType.Int).Value = tb_Customer_ID.Text;
                    Cmd1.Parameters.Add("Cat", SqlDbType.NVarChar).Value = dgv_Add_New_Customer.Rows[i].Cells[1].Value;
                    Cmd1.Parameters.Add("bName", SqlDbType.NVarChar).Value = dgv_Add_New_Customer.Rows[i].Cells[2].Value;
                    Cmd1.Parameters.Add("pName", SqlDbType.NVarChar).Value = dgv_Add_New_Customer.Rows[i].Cells[3].Value;
                    Cmd1.Parameters.Add("pp", SqlDbType.Money).Value = dgv_Add_New_Customer.Rows[i].Cells[4].Value;
                    Cmd1.Parameters.Add("Qty", SqlDbType.Int).Value = dgv_Add_New_Customer.Rows[i].Cells[5].Value;
                    Cmd1.Parameters.Add("GST", SqlDbType.Float).Value = dgv_Add_New_Customer.Rows[i].Cells[6].Value;
                    Cmd1.Parameters.Add("Price", SqlDbType.Money).Value = dgv_Add_New_Customer.Rows[i].Cells[7].Value;

                    Cmd1.ExecuteNonQuery();
                    Cmd1.Dispose();

                    int Saled_Qty = Convert.ToInt32(dgv_Add_New_Customer.Rows[i].Cells[5].Value);
                    int P_C_Stock = 0;
                    int P_ID = 0;
                    int New_Stock = 0;

                    Cmd1.CommandText = "Select Product_ID, Stock_Quantity From Product_Details where Brand = '" + dgv_Add_New_Customer.Rows[i].Cells[1].Value + "' And Product_Name = '" + dgv_Add_New_Customer.Rows[i].Cells[2].Value + "'";
                    Cmd1.Connection = Con;

                    SqlDataReader obj = Cmd1.ExecuteReader();

                    if (obj.Read())
                    {
                        P_ID = Convert.ToInt32((obj["Product_ID"].ToString()));
                        P_C_Stock = Convert.ToInt32((obj["Stock_Quantity"].ToString()));
                    }

                    New_Stock = P_C_Stock - Saled_Qty;

                    obj.Close();
                    Cmd1.Dispose();

                    SqlDataAdapter sda = new SqlDataAdapter("Update Product_Details Set Stock_Quantity = " + New_Stock + " where Product_ID = " + P_ID + "", Con);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                }

                MessageBox.Show("Customer Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
                Con_Close();
            }

            else
            {
                MessageBox.Show("Fill Customer & Purchase Details Properly", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tb_Quantity_TextChanged(object sender, EventArgs e)
        {
            double GST = 0;

            if (tb_Quantity.Text != "" && Convert.ToInt32(tb_Quantity.Text) > 0)
            {
                GST = (Convert.ToDouble(tb_Per_Price.Text) * Convert.ToDouble(tb_GST_Applied.Text)) / 100;

                tb_Price.Text = Convert.ToString((Convert.ToDouble(tb_Per_Price.Text) + GST) * (Convert.ToDouble(tb_Quantity.Text)));

                btn_Add.Enabled = true;
            }

            if (tb_Quantity.Text == "")
            {
                tb_Price.Text = "0";
            }
        }

        private void tb_Quantity_Leave(object sender, EventArgs e)
        {
            if(tb_Quantity.Text == "" && tb_Quantity.Text == "0")
            {
               MessageBox.Show("Invalid Quantity!!!");
               tb_Quantity.Text = "0";
               tb_Quantity.Focus();
               btn_Add.Enabled = false;
            
            }
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int flag = -1, Qty = Convert.ToInt32(tb_Quantity.Text);
            double Bill = 0.0;

            for (int i = 0; i <= dgv_Add_New_Customer.Rows.Count - 1; i++)
            {
                if (Convert.ToString(dgv_Add_New_Customer.Rows[i].Cells[2].Value) == cmb_Product_Name.Text)
                {
                    flag = 0;

                    Qty += Convert.ToInt32(dgv_Add_New_Customer.Rows[i].Cells[4].Value);

                    if (C_Stock >= Qty)
                    {
                        double Tot_Price = Convert.ToDouble(Qty) * Convert.ToDouble(tb_Price.Text);

                        dgv_Add_New_Customer.Rows[i].Cells[4].Value = Qty;
                        dgv_Add_New_Customer.Rows[i].Cells[6].Value = Tot_Price;
                    }
                    else
                    {
                        MessageBox.Show("Can't Add More Quantity", "Insufficiant Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        flag = 1;
                    }
                }
            }

            if (flag == -1)
            {
                if (C_Stock >= Qty)
                {
                    dgv_Add_New_Customer.Rows.Add(pCnt,cmb_Category.Text ,cmb_Brand.Text, cmb_Product_Name.Text, tb_Per_Price.Text, tb_Quantity.Text, tb_GST_Applied.Text, tb_Price.Text);

                    pCnt++;
                }
                else
                {
                    MessageBox.Show("No Enough Stock Available", "Insufficiant Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    flag = 1;
                    tb_Quantity.Clear();
                }
            }

            if (flag < 1)
            {
                Bill = Convert.ToDouble(tb_Total_Price.Text) + Convert.ToDouble(tb_Price.Text);

                tb_Total_Price.Text = Convert.ToString(Bill);
                tb_Total_Bill.Text = Convert.ToString(Bill);
            }

            cmb_Category.SelectedIndex = -1;
            cmb_Brand.SelectedIndex = -1;
            cmb_Product_Name.SelectedIndex = -1;
            tb_Per_Price.Clear();
            tb_Price.Clear();
            tb_Quantity.Text = "0";
            tb_GST_Applied.Clear();
            btn_Add.Enabled = false;

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DialogResult Res = System.Windows.Forms.DialogResult.Yes;

            if (tb_Customer_Name.Text != "" && tb_Mob_No.Text != "" && pCnt > 1 && tb_Total_Price.Text != "" && tb_Total_Bill.Text != "" &&  tb_Discount.Text != "")
            {
                Res = MessageBox.Show("Are You Sure Data Entered Will Be Lost?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (Res == System.Windows.Forms.DialogResult.Yes)
            {
                Clear_Controls();
            }
        }

        private void tb_Discount_TextChanged(object sender, EventArgs e)
        {
            if (tb_Discount.Text != "")
            {
                double Disc = Convert.ToDouble(tb_Total_Price.Text) * (Convert.ToDouble(tb_Discount.Text) / 100);

                double Tot_Bill = Convert.ToDouble(tb_Total_Bill.Text) - Disc;

                tb_Total_Bill.Text = Convert.ToString(Tot_Bill);
            }

            if (tb_Discount.Text == "")
            {
                tb_Total_Bill.Text = tb_Total_Price.Text;
            }
        }

        private void tb_Discount_Leave(object sender, EventArgs e)
        {
            if (tb_Discount.Text == "")
            {
                tb_Discount.Text = "0";
            }
        }

        private void dtp_Date_ValueChanged(object sender, EventArgs e)
        {
            dtp_Date.MinDate = dtp_Date.MaxDate = DateTime.Now;
        }

        private void Only_Number(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

    }
}
