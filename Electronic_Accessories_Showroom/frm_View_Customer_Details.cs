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
    public partial class frm_View_Customer_Details : Form
    {
        public frm_View_Customer_Details()
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

        private void dtp_To_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_From_Date_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Customer_Entry_Form obj = new frm_Customer_Entry_Form();
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

        void Bind_Grid(string Query)
        {
            Con_Open();

            dgv_Customer_Details.DataSource = "";

            SqlDataAdapter sda = new SqlDataAdapter(Query,Con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgv_Customer_Details.DataSource = dt;

            Con_Close();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Bind_Grid("Select * from Customer_Details where Date between '"+dtp_From_Date.Value.ToString("MM/dd/yyyy")+"' And '"+dtp_To_Date.Value.ToString("MM/dd/yyyy")+"'");
        }

        private void frm_View_Customer_Details_Load(object sender, EventArgs e)
        {
            Bind_Grid("select * from Customer_Details");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Bind_Grid("select * from Customer_Details");
        }
    }
}
