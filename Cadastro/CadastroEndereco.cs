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
    public partial class CadastroEndereco : Form
    {
        private static CadastroEndereco instance;

        private CadastroEndereco()
        {
            InitializeComponent();
        }

        public static CadastroEndereco GetInstance()
        {
            if (instance == null)
            {
                instance = new CadastroEndereco();
            }

            if (instance.IsDisposed)
            {
                instance = new CadastroEndereco();
            }

            return instance;
        }
    }
}
