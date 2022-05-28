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
    public partial class frm_View_Stock_Details : Form
    {
        public frm_View_Stock_Details()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Product_Entry_Form obj = new frm_Product_Entry_Form();

            obj.Show();
            this.Hide();
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

        void Bind_Grid(string Query)
        {
            Con_Open();

            dgv_Stock_Details.DataSource = "";

            SqlDataAdapter Sda = new SqlDataAdapter(Query, Con);

            DataTable Dt = new DataTable();

            Sda.Fill(Dt);

            dgv_Stock_Details.DataSource = Dt;

            Con_Close();
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
                cmb_Category_Name.Items.Add(obj.GetString(obj.GetOrdinal("Category_Name")));
            }

            Cmd.Dispose();
            obj.Dispose();
            Con_Close();
        }

        //void Bind_Product()
        //{
        //    Con_Open();

        //    SqlCommand Cmd = new SqlCommand();

        //    Cmd.Connection = Con;

        //    Cmd.CommandText = "Select Distinct(Product_Name) from Product_Details Where Brand = '" + cmb_Brand_Name.Text + "'";

        //    var obj = Cmd.ExecuteReader();

        //    while (obj.Read())
        //    {
        //        cmb_Product_Name.Items.Add(obj.GetString(obj.GetOrdinal("Product_Name")));
        //    }

        //    obj.Dispose();
        //    Cmd.Dispose();
        //    Con_Close();
        //}

        //void Bind_Brand()
        //{
        //    cmb_Brand_Name.Items.Clear();
        //    cmb_Brand_Name.Enabled = true;
        //    Con_Open();

        //    SqlCommand Cmd = new SqlCommand();

        //    Cmd.Connection = Con;

        //    Cmd.CommandText = "Select Distinct(Brand_Name) from Brand_Details Where Category_Name = '" + cmb_Category_Name.Text + "'";

        //    var obj = Cmd.ExecuteReader();

        //    while (obj.Read())
        //    {
        //        cmb_Brand_Name.Items.Add(obj.GetString(obj.GetOrdinal("Brand_Name")));
        //    }

        //    obj.Dispose();
        //    Cmd.Dispose();
        //    Con_Close();
        //}

        private void frm_View_Stock_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_Electronic_Accessories_ShowroomDataSet3.Stock_Details' table. You can move, or remove it, as needed.
            this.stock_DetailsTableAdapter.Fill(this.dB_Electronic_Accessories_ShowroomDataSet3.Stock_Details);
            Bind_Category();
            Bind_Grid("select * from Stock_Details");
        }

        private void dgv_Stock_Details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Bind_Grid("Select * from Stock_Details where Category = '"+cmb_Category_Name.Text+"'");
        }

        private void cmb_Category_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Bind_Brand();
   
        }

        private void cmb_Brand_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Bind_Product();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Bind_Grid("select * from Stock_Details");
            cmb_Category_Name.SelectedIndex = -1;
        }
    }
}
