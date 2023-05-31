using CompanyUserSetup.SubForms.CreateNewUser;

namespace CompanyUserSetup
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void CreateNewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateNewUserMain window = new CreateNewUserMain();
            window.ShowDialog();
        }
    }
}