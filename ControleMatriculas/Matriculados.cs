using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleMatriculas
{
    public partial class Matriculados : Form
    {
        private static Matriculados instance;

        private Matriculados()
        {
            InitializeComponent();
        }

        public static Matriculados GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Matriculados();
            }

            return instance;
        }

        private void Matriculados_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form1.GetInstance().Show();
        }
    }
}
