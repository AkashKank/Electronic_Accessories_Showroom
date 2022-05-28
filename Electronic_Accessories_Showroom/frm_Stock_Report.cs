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
    public partial class frm_Stock_Report : Form
    {
        public frm_Stock_Report()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_Electronic_Accessories_Showroom;Integrated Security=True");

        private void frm_Stock_Report_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Category,Brand,Product_Name,Current_Stock_Quantity,New_Stock_Quantity from Stock_Details", Con);

            DataSet ds = new DataSet();
            da.Fill(ds, "Stock_Details");
            Stock_Report_Details dcr = new Stock_Report_Details();
            dcr.SetDataSource(ds);

            crystalReportViewer1.ReportSource = dcr;
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
