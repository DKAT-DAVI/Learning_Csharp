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
    public partial class Form1 : Form
    {
        private static Form1 instance;
        public Form1()
        {
            InitializeComponent();

            Aluno a = new Aluno("Ana");
            Aluno b = new Aluno("Bruno");
            Aluno c = new Aluno("Cézar");
            Aluno d = new Aluno("Davi");
            Aluno e = new Aluno("Esther");
            Aluno f = new Aluno("Fabrício");
            Aluno g = new Aluno("Gabriel");
            Aluno h = new Aluno("Henrique");

            AdicionarAluno(a);
            AdicionarAluno(b);
            AdicionarAluno(c);
            AdicionarAluno(d); 
            AdicionarAluno(e);
            AdicionarAluno(f);
            AdicionarAluno(g);
            AdicionarAluno(h);
        }

        public static Form1 GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Form1();
            }
            return instance;
        }

        private void AdicionarAluno(Aluno aluno)
        {
            lstAlunos.Items.Add(aluno);
        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            if (lstAlunos.Items.Count == 0)
            {
            }
            else 
            { 
                if (lstAlunos.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Selecione algum aluno");
                }
                else
                {
                    lstMatriculados.Items.Add(lstAlunos.SelectedItem);
                    lstAlunos.Items.RemoveAt(lstAlunos.SelectedIndex);
                }
            }
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            if (lstMatriculados.Items.Count == 0)
            {
                MessageBox.Show("Nenhum aluno matriculado");
            }
            else
            {
                if (lstMatriculados.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Selecione algum aluno MATRICULADO");
                }
                else 
                {
                    lstAlunos.Items.Add(lstMatriculados.SelectedItem);
                    lstMatriculados.Items.RemoveAt(lstMatriculados.SelectedIndex);
                }
            }
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Matriculados.GetInstance().Show();
            this.Hide();
        }
    }
}
