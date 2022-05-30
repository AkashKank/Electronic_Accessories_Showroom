using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Electronic_Accessories_Showroom
{
    public partial class frm_Reports_Entry_Form : Form
    {
        public frm_Reports_Entry_Form()
        {
            InitializeComponent();
        }

        private void lbl_Product_Entry_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_New_Category_Click(object sender, EventArgs e)
        {
            frm_Customer_Report obj = new frm_Customer_Report();

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

        private void btn_Distributor_Report_Click(object sender, EventArgs e)
        {
            frm_Distributor_Report obj = new frm_Distributor_Report();

            obj.WindowState = FormWindowState.Maximized;
            this.Hide();
            obj.Show();
        }

        private void btn_Employee_Report_Click(object sender, EventArgs e)
        {
            frm_Employee_Report obj = new frm_Employee_Report();

            obj.WindowState = FormWindowState.Maximized;
            this.Hide();
            obj.Show();
        }

        private void btn_Stock_Details_Click(object sender, EventArgs e)
        {
            frm_Stock_Report obj = new frm_Stock_Report();

            obj.WindowState = FormWindowState.Maximized;
            this.Hide();
            obj.Show();
        }

        public int No = 0;

        public frm_Reports_Entry_Form (string Role)
        {
            InitializeComponent();

            No = 1;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (No == 0)
            {
                frm_Admin_Entry_Form obj = new frm_Admin_Entry_Form();
                obj.WindowState = FormWindowState.Maximized;
                this.Hide();
                obj.Show();
            }
            else
            {
                frm_Main_Entry_Form MEF = new frm_Main_Entry_Form();
                this.Hide();
                MEF.Show();
            }
        }
    }
}
