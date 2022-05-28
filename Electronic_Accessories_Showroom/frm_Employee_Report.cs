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
    public partial class frm_Employee_Report : Form
    {
        public frm_Employee_Report()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DB_Electronic_Accessories_Showroom;Integrated Security=True");

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frm_Employee_Report_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Distinct (Employee_ID),Employee_Name,E_DateOf_Birth,E_Gender,E_Address,E_MobNo,E_AadharNo,E_Salary from Employee_Details", Con);

            DataSet ds = new DataSet();
            da.Fill(ds, "Employee_Details");
            Employee_Report_Details dcr = new Employee_Report_Details();
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
