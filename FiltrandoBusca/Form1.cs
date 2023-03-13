using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiltrandoBusca
{
    public partial class Form1 : Form
    {
        private List<Pessoa> _pessoas;

        public Form1()
        {
            InitializeComponent();
            
            _pessoas = new List<Pessoa>();

            _pessoas.Add(new Pessoa("Badaró", 123));
            _pessoas.Add(new Pessoa("Kalel", 34567));
            _pessoas.Add(new Pessoa("Bruno", 109090));
            _pessoas.Add(new Pessoa("Ferreira", 44879));
            _pessoas.Add(new Pessoa("Davi", 56738));

        }

        private void txtBusca_KeyUp(object sender, KeyEventArgs e)
        {
                List<Pessoa> filtrados = new List<Pessoa>();

                foreach (Pessoa p in _pessoas)
                {
                    if (p.Nome.ToLower().Contains(txtBusca.Text.ToLower())
                        || p.Matricula.ToString().Contains(txtBusca.Text))
                    {
                        filtrados.Add(p);
                    }
                }

                lstResultado.DataSource = filtrados; 
        }
    }
}
