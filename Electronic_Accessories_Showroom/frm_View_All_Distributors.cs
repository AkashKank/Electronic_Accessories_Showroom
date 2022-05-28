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
    public partial class frm_View_All_Distributors : Form
    {
        public frm_View_All_Distributors()
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

        private void lbl_Distributor_Details_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Employee_Entry_Form obj = new frm_Employee_Entry_Form();

            obj.WindowState = FormWindowState.Maximized;
            this.Hide();
            obj.Show();
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

            dgv_Distributor_Details.DataSource = "";

            SqlDataAdapter Sda = new SqlDataAdapter(Query, Con);

            DataTable Dt = new DataTable();

            Sda.Fill(Dt);

            dgv_Distributor_Details.DataSource = Dt;

            Con_Close();
        }

        private void frm_View_All_Distributors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_Electronic_Accessories_ShowroomDataSet.Distributor_Details' table. You can move, or remove it, as needed.
            this.distributor_DetailsTableAdapter.Fill(this.dB_Electronic_Accessories_ShowroomDataSet.Distributor_Details);
            Bind_Grid("Select * from Distributor_Details");

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            Bind_Grid("select * from Distributor_Details where Distributor_ID = '" + tb_Distributor_ID.Text + "'");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Distributor_ID.Clear();
            Bind_Grid("Select * from Distributor_Details");
        }
    }
}
