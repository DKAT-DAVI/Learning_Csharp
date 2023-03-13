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
    public partial class CadastroLivro : Form
    {

        private static CadastroLivro instance;

        private CadastroLivro()
        {
            InitializeComponent();
        }

        public static CadastroLivro GetInstance()
        {
            if (instance == null)
            {
                instance = new CadastroLivro();
            }
            if (instance.IsDisposed)
            {
                instance = new CadastroLivro();
            }

            return instance;
        }

        private void imgVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
