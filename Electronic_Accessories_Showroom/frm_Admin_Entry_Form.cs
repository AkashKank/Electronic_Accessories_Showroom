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
    public partial class frm_Admin_Entry_Form : Form
    {
        public frm_Admin_Entry_Form()
        {
            InitializeComponent();
        }

        private void frm_Admin_Entry_Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_Employees_Click(object sender, EventArgs e)
        {
            frm_Employee_Entry_Form obj = new frm_Employee_Entry_Form();

            obj.WindowState = FormWindowState.Maximized;
            this.Hide();
            obj.Show();

        }

        private void btn_Distributor_Click(object sender, EventArgs e)
        {
            frm_Distributor_Entry_Form obj = new frm_Distributor_Entry_Form();

            obj.WindowState = FormWindowState.Maximized;
            this.Hide();
            obj.Show();
        }

        private void btn_Customers_Click(object sender, EventArgs e)
        {
            frm_Customer_Entry_Form obj = new frm_Customer_Entry_Form();

            obj.WindowState = FormWindowState.Maximized;
            this.Hide();
            obj.Show();
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            frm_Product_Entry_Form obj = new frm_Product_Entry_Form();

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

        private void button1_Click(object sender, EventArgs e)
        {
            frm_User_Management obj = new frm_User_Management();

            this.Hide();
            obj.Show();
        }
    }
}
