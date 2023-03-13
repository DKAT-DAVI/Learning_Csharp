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
    public partial class JanelaPrincipal : Form
    {
        private static JanelaPrincipal instance;
        public Usuario Usuario { get; set; }
        private JanelaPrincipal()
        {
            InitializeComponent();
        }

        public static JanelaPrincipal GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new JanelaPrincipal();
            }

            return instance;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            JanelaLogin.GetInstance().Show();
        }

        private void JanelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            JanelaLogin.GetInstance().Show();
        }

        private void temasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.GetInstance().Show();            
        }

        public void HabilitarMenus()
        {
            mnuUsuarios.Enabled = Usuario.Administrador;
        }

        public void EsconderMenus()
        {
            
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios.GetInstance().Show();
        }
    }
}
