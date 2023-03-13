using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAcesso
{
    public partial class pnlWindow : Form
    {
        private static Credencial c1 = new Credencial();
        
        public pnlWindow()
        {
            InitializeComponent();
        }

        private void pnlBackground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1.Usuario = "dkat";
            c1.Senha = "12345";
            c1.Ativo = true;

            MessageBox.Show($"{txtSenha.Text} == {c1.Senha}");

            if (c1.Autenticar(txtUser.Text, txtSenha.Text))
            {
                MessageBox.Show("User autenticado!");
            }
            else
            {
                MessageBox.Show("User não autenticado!");
            }
        }

        private void txtUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAutenticar.PerformClick();
            }
        }

        private void btnAutenticar_KeyUp(object sender, KeyEventArgs e)
        {

            Console.WriteLine("botão pressionado");
            //Validar Usuário
            Credencial c1 = new Credencial();
            c1.Usuario = "dkat";
            c1.Senha = "12345";
            c1.Ativo = true;

            if (c1.Autenticar(txtUser.Text, txtSenha.Text))
            {
                MessageBox.Show("User autenticado!");
            }
            else
            {
                //Se não for válido
                //1. limpar senha
                txtSenha.Clear();
                
                //2. foco em usuário
                txtUser.Focus();

                //3. selecionar o conteúdo
                txtUser.SelectAll();
            }
        }
    }
}
