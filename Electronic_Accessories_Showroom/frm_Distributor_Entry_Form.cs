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
    public partial class frm_Distributor_Entry_Form : Form
    {
        public frm_Distributor_Entry_Form()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Admin_Entry_Form obj = new frm_Admin_Entry_Form();

            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
            this.Hide();
        }

        private void btn_Add_New_Distributor_Click(object sender, EventArgs e)
        {
            frm_Add_New_Distributor obj = new frm_Add_New_Distributor();

            obj.WindowState = FormWindowState.Maximized;
            this.Hide();
            obj.Show();
        }

        private void btn_Search_Update_Distributor_Click(object sender, EventArgs e)
        {
            frm_Search_Or_Update_Distributor obj = new frm_Search_Or_Update_Distributor();

            obj.WindowState = FormWindowState.Maximized;
            this.Hide();
            obj.Show();
        }

        private void btn_View_Distributor_Details_Click(object sender, EventArgs e)
        {
            frm_View_All_Distributors obj = new frm_View_All_Distributors();

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
    }
}
 