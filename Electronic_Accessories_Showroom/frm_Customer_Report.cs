using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace Electronic_Accessories_Showroom
{
    public partial class frm_Customer_Report : Form
    {
        ReportDocument rd = new ReportDocument();
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_Electronic_Accessories_Showroom;Integrated Security=True");

        public frm_Customer_Report()
        {
            InitializeComponent();
        }



        private void frm_Customer_Report_Load(object sender, EventArgs e)
        {
            string str = "Select * from Customer_Bill_Details";
            SqlDataAdapter da = new SqlDataAdapter(str,con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Customer_Bill_Details");
            Customer_CrystalReport1 ccr = new Customer_CrystalReport1();
            ccr.SetDataSource(ds);

            crystalReportViewer1.ReportSource = ccr;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Reports_Entry_Form obj = new frm_Reports_Entry_Form();

            obj.WindowState = FormWindowState.Maximized;
            this.Hide();
            obj.Show();
        }
    }
}
