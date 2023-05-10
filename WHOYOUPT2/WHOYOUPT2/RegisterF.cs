using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WHOYOUPT2
{
    public partial class RegisterF : Form
    {
        public RegisterF()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.MintCream;
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            DashboardF form3 = new DashboardF();
            form3.Show();

            Visible = false;
        }

        private void signupBtn_MouseHover(object sender, EventArgs e)
        {
            signupBtn.BackColor = Color.DarkSeaGreen;
        }

        private void signupBtn_MouseLeave(object sender, EventArgs e)
        {
            signupBtn.BackColor = Color.MediumSeaGreen;
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginF form1 = new LoginF();
            form1.Show();

            Visible = false;
        }
    }
}
