namespace Empresa
{
    public partial class Pessoa : Form
    {
        public Pessoa()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Funcionário f = new Funcionário();
            //f1.Codigo = 5;
            //f1.Nome = "DKAT";
            //f1.Nascimento = new DateTime(2005, 09, 05);
            //f1.Feminino = false;
            //f1.Ativo = true;
            //f1.Gerente = true;

            f.Codigo = Convert.ToUInt64(txtCodigo.Text);
            f.Nome = txtName.Text;
            f.Nascimento = dtpNascimento.Value;
            f.Feminino = radFeminino.Checked;
            f.Ativo = chkAtivo.Checked;
            f.Gerente = radGerente.Checked;

            Console.WriteLine(f);
        }
    }
}