namespace WHOYOUPT2
{
    public partial class LoginF : Form
    {
        public LoginF()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.MintCream;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            DashboardF form3 = new DashboardF();
            form3.Show();

            Visible = false;
        }

        private void submitBtn_MouseHover(object sender, EventArgs e)
        {
            submitBtn.BackColor = Color.DarkSeaGreen;
        }

        private void submitBtn_MouseLeave(object sender, EventArgs e)
        {
            submitBtn.BackColor = Color.MediumSeaGreen;
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterF form2 = new RegisterF();
            form2.Show();

            Visible = false;
        }
    }
}