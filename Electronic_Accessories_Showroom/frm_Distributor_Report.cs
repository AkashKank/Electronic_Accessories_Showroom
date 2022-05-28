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
    public partial class frm_Distributor_Report : Form
    {
        public frm_Distributor_Report()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_Electronic_Accessories_Showroom;Integrated Security=True");

        private void frm_Distributor_Report_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Distributor_ID,Distributor_Name,D_Address,D_TieUp_Date,D_Email,D_BrandDelivered from Distributor_Details", Con);

            DataSet ds = new DataSet();
            da.Fill(ds, "Distributor_Details");
            Distributor_CrystalReport dcr = new Distributor_CrystalReport();
            dcr.SetDataSource(ds);

            crystalReportViewer1.ReportSource = dcr;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
