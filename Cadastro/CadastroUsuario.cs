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
    public partial class CadastroUsuario : Form
    {
        private static CadastroUsuario instance;

        private CadastroUsuario()
        {
            InitializeComponent();
        }

        public static CadastroUsuario GetInstance()
        {
            if (instance == null)
            {
                instance = new CadastroUsuario();
            }
            if (instance.IsDisposed)
            {
                instance = new CadastroUsuario();
            }
            return instance;
        }
    }
}
