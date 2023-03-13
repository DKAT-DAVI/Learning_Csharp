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
    public partial class Form1 : Form
    {
        private static Form1 instance;

        private Form1()
        {
            InitializeComponent();
        }

        public static Form1 GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Form1();
            }

            return instance;
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Quando fechar o Form1 pelo x, vai abrir a janela de login 
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.Cancel == false)
            {
                JanelaLogin.GetInstance().Show();                
            }
        }

        //Quando fechar o Form1 pelo "SAIR", vai abrir a janela de login 
        private void mnuArquivoSair_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
            JanelaLogin.GetInstance().Show();   
            
        }

        private void mnuCadastroEndereco_Click(object sender, EventArgs e)
        {
            //new CadastroEndereco().Show();
            CadastroEndereco.GetInstance().Show();            
        }

        private void mnuCadastroLivro_Click(object sender, EventArgs e)
        {
            //new CadastroLivro().Show();
            CadastroLivro.GetInstance().Show();
        }

        private void mnuCadastroUsuario_Click(object sender, EventArgs e)
        {
            //new CadastroUsuario().Show();
            CadastroUsuario.GetInstance().Show();   
        }
    }
}
