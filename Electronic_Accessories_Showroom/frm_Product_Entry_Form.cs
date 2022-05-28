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
    public partial class frm_Product_Entry_Form : Form
    {
        public frm_Product_Entry_Form()
        {
            InitializeComponent();
        }

        public int No = 0;

        public frm_Product_Entry_Form(string Role)
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

        private void btn_Add_New_Category_Click(object sender, EventArgs e)
        {
            frm_Add_New_Category obj = new frm_Add_New_Category();

            obj.WindowState = FormWindowState.Maximized;
            this.Hide();
            obj.Show();
        }

        private void btn_Add_New_Subcategory_Click(object sender, EventArgs e)
        {
            frm_Add_New_Brand obj = new frm_Add_New_Brand();

            obj.WindowState = FormWindowState.Maximized;
            this.Hide();
            obj.Show();
        }

        private void btn_Add_New_Product_Click(object sender, EventArgs e)
        {
            frm_Add_New_Product obj = new frm_Add_New_Product();

            obj.WindowState = FormWindowState.Maximized;
            this.Hide();
            obj.Show();
        }

        private void btn_Add_Stock_Click(object sender, EventArgs e)
        {
            frm_Add_Stock obj = new frm_Add_Stock();

            obj.WindowState = FormWindowState.Maximized;
            this.Hide();
            obj.Show();
        }

        private void btn_View_Stock_Details_Click(object sender, EventArgs e)
        {
            frm_View_Stock_Details obj = new frm_View_Stock_Details();

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
 