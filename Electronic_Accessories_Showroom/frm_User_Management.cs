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
    public partial class frm_User_Management : Form
    {
        public frm_User_Management()
        {
            InitializeComponent();
        }

        private void btn_Add_New_User_Click(object sender, EventArgs e)
        {
            frm_Add_New_User ANU = new frm_Add_New_User();
            this.Hide();
            ANU.Show();
        }

        private void btn_Update_User_Click(object sender, EventArgs e)
        {
            frm_Update_User UU = new frm_Update_User();
            this.Hide();
            UU.Show();
        }

        private void btn_Delete_User_Click(object sender, EventArgs e)
        {
            frm_Delete_User DU = new frm_Delete_User();
            this.Hide();
            DU.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Admin_Entry_Form obj = new frm_Admin_Entry_Form();

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
