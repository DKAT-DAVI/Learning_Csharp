using System;
using System.Windows.Forms;

namespace user_authentication
{
    public partial class FrmLogin : Form
    {
        #region Singleton in the window
        private static FrmLogin _instance;

        public static FrmLogin GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmLogin();
            }

            return _instance;
        }
        #endregion

        //-- FrmLogin
        private FrmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Repository repository = new Repository();
            EnableButtonAuthenticate();
        }
        //--//

        //-- txbEmail
        /// /// Switch field by pressing Enter
        private void txbEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbPassword.Focus();
            }
        }
        private void txbEmail_TextChanged(object sender, EventArgs e)
        {
            EnableButtonAuthenticate();
        }
        //--//

        //-- txbPassword
        /// Click Authenticate by pressing Enter
        private void txbPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAutheticate.PerformClick();
            }
        }
        //--//


        //-- btnAuthenticate
        /// Click btnAuthenticate
        private void btnAutheticate_Click(object sender, EventArgs e)
        {
            if (Credential.AuthenticateUser(txbEmail.Text, txbPassword.Text))
            {
                this.Hide();
                FrmMain.GetInstance().Show();

                txbEmail.Text = "";
                txbPassword.Text = "";
            }
        }
        //--//

        //-- Methods()
        private void EnableButtonAuthenticate()
        {
            if (txbEmail.Text == "")
            {
                btnAutheticate.Enabled = false;
            }
            else
            {
                btnAutheticate.Enabled = true;
            }
        }
        //--//
    }
}
