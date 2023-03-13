using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class pnlPrincipal : Form
    {
        public pnlPrincipal()
        {
            InitializeComponent();
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            try
            {
                calc.ValorA = Convert.ToDouble(txtValorA.Text);
                txtValorA.Text = Convert.ToString(txtValorA.Text);
            }
            catch (Exception)
            {
                txtValorA.Text = "Invalid";
            }

            try
            {
                calc.ValorA = Convert.ToDouble(txtValorA.Text);
                txtValorB.Text = Convert.ToString(txtValorB.Text);
            }
            catch (Exception)
            {

                txtValorA.Text = "Invalid"; 
            }

            if (txtValorA.Text == "Invalid")
            {
                lblResult.Text = "Resultado: ";
            }
            else
            {
                lblResult.Text = "Resultado: " + calc.Somar();
            }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            calc.ValorA = Convert.ToDouble(txtValorA.Text);
            calc.ValorB = Convert.ToDouble(txtValorB.Text);
            lblResult.Text = "Resultado: " + calc.Subtrair();
        }

        private void mult_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            calc.ValorA = Convert.ToDouble(txtValorA.Text);
            calc.ValorB = Convert.ToDouble(txtValorB.Text);
            lblResult.Text = "Resultado: " + calc.Multiplicar();
        }

        private void division_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            calc.ValorA = Convert.ToDouble(txtValorA.Text);
            calc.ValorB = Convert.ToDouble(txtValorB.Text);
            lblResult.Text = "Resultado: " + calc.Dividir();
        }
    }
}
