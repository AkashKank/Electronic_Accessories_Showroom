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
    public partial class frm_Customer_Entry_Form : Form
    {
        public frm_Customer_Entry_Form()
        {
            InitializeComponent();
        }

        public int No = 0;

        public frm_Customer_Entry_Form(string Role)
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

        private void btn_Add_New_Customer_Click(object sender, EventArgs e)
        {
            frm_Add_New_Customer obj = new frm_Add_New_Customer();

            obj.WindowState = FormWindowState.Maximized;
            this.Hide();
            obj.Show();
        }

        private void btn_View_Customer_Details_Click(object sender, EventArgs e)
        {
            frm_View_Customer_Details obj = new frm_View_Customer_Details();

            obj.Show();
            this.Hide();
        }

        private void pnl_Customer_Entry_Paint(object sender, PaintEventArgs e)
        {

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
