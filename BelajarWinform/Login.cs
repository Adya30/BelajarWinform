namespace BelajarWinform
{
    public partial class Form1 : Form
    {
        private string username;
        private string password;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            username = "Adya";
            password = "Adya123";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usernameInput = TbUsername.Text;
            string passwordInput = TbPassword.Text;

            if (usernameInput == username && passwordInput == password)
            {
                MessageBox.Show("Login Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Dashboard dashboard = new Dashboard(usernameInput);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password Salah", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
