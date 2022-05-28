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
    public partial class frm_Loading : Form
    {
        public frm_Loading()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(10);

            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                frm_Login obj = new frm_Login();
                obj.Show();
            }
        }
    }
}
