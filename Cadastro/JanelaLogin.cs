using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class JanelaLogin : Form
    {
        private static JanelaLogin instance;

        public JanelaLogin()
        {
            InitializeComponent();
        }

        public static JanelaLogin GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new JanelaLogin();
            }
            return instance;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.Cancel == false)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Credencial credencial = new Credencial();
            credencial.User = "dkat";
            credencial.Senha = "12345";
            if (credencial.AutenticarUser(txtUser.Text, TxtSenha.Text))
            {
                Form1.GetInstance().Show();
                this.Hide();
                txtUser.Text = null;
                TxtSenha.Text = null;
            }
            else
            {
                MessageBox.Show("User e/ou senha estão incorretos");
                txtUser.Text = null;
                TxtSenha.Text = null;
            }
        }
    }
}
