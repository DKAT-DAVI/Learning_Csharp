using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class JanelaLogin : Form
    {
        private static JanelaLogin instance;
        
        private JanelaLogin()
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

        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.User = "dkat";
            u.Senha = "55555";
            u.Administrador = true;

            if (u.IsValido(txtUser.Text, txtSenha.Text))
            {
                JanelaPrincipal.GetInstance(); 

                this.Hide();
                JanelaPrincipal.GetInstance().Show();
                txtSenha.Text = null;

                JanelaPrincipal.GetInstance().Usuario = u;
                JanelaPrincipal.GetInstance().HabilitarMenus();
                JanelaPrincipal.GetInstance().EsconderMenus();
            }
            else
            {
                MessageBox.Show("User e/ou Senha errados");
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }
    }
}
