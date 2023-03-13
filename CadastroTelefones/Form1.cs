using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroTelefones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Tipos de telefones predefinidos
            List<TipoTelefone> tipos = new List<TipoTelefone>();
            tipos.Add(new TipoTelefone("Principal"));
            tipos.Add(new TipoTelefone("Celular"));
            tipos.Add(new TipoTelefone("Fazenda"));
            tipos.Add(new TipoTelefone("Empresarial"));
            tipos.Add(new TipoTelefone("Casa"));

            //Carga de tipos pela caixa de combinação
            //cboTipo.Items.AddRange(tipos.ToArray());
            cboTipo.DataSource = tipos;

            //Opção padrão
            cboTipo.SelectedIndex = 1;

            
        }

        private void txtTelefone_KeyUp(object sender, KeyEventArgs e)
        {
             if(e.KeyCode == Keys.Enter 
                && txtTelefone.Text != null
                && txtTelefone.Text.Length > 0)
                {
                    Telefone telefone = new Telefone(
                        txtTelefone.Text, 
                        (TipoTelefone) cboTipo.SelectedItem);

                    lstTelefones.Items.Add(telefone);
                    txtTelefone.SelectAll();
                }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa(txtNome.Text);

            pessoa.Telefones = (List<Telefone>)lstTelefones.Items.Cast<Telefone>().ToList();

            lstTelefones.Items.Clear();
            txtNome.Text = null;

            Console.WriteLine(pessoa);
        }

        private void lstTelefones_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lstTelefones.Items.Remove(lstTelefones.SelectedItem);
        }

        private void mnuExcluir_Click(object sender, EventArgs e)
        {
            lstTelefones.Items.Remove(lstTelefones.SelectedItem);
        }

        private void lstTelefones_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right 
                && lstTelefones.Items.Count > 0)
            {
                ctxMenu.Show(Cursor.Position);
                lstTelefones.SelectedIndex = lstTelefones.IndexFromPoint(e.Location);
                
            }
        }
    }
}
