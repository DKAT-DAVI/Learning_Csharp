namespace Empresa
{
    partial class Pessoa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFormulario = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.grpPerfil = new System.Windows.Forms.GroupBox();
            this.radGerente = new System.Windows.Forms.RadioButton();
            this.radOperador = new System.Windows.Forms.RadioButton();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.radMasculino = new System.Windows.Forms.RadioButton();
            this.radFeminino = new System.Windows.Forms.RadioButton();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpPerfil.SuspendLayout();
            this.grpSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFormulario);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.dtpNascimento);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.grpPerfil);
            this.panel1.Controls.Add(this.grpSexo);
            this.panel1.Controls.Add(this.chkAtivo);
            this.panel1.Controls.Add(this.lblIdade);
            this.panel1.Controls.Add(this.lblNascimento);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 400);
            this.panel1.TabIndex = 0;
            // 
            // lblFormulario
            // 
            this.lblFormulario.AutoSize = true;
            this.lblFormulario.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFormulario.Location = new System.Drawing.Point(91, 9);
            this.lblFormulario.Name = "lblFormulario";
            this.lblFormulario.Size = new System.Drawing.Size(182, 46);
            this.lblFormulario.TabIndex = 13;
            this.lblFormulario.Text = "Formulário";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(257, 364);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(90, 23);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(105, 134);
            this.dtpNascimento.MaximumSize = new System.Drawing.Size(200, 200);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(193, 23);
            this.dtpNascimento.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 99);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 23);
            this.txtName.TabIndex = 10;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(105, 63);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(193, 23);
            this.txtCodigo.TabIndex = 9;
            // 
            // grpPerfil
            // 
            this.grpPerfil.Controls.Add(this.radGerente);
            this.grpPerfil.Controls.Add(this.radOperador);
            this.grpPerfil.Location = new System.Drawing.Point(120, 272);
            this.grpPerfil.Name = "grpPerfil";
            this.grpPerfil.Size = new System.Drawing.Size(133, 81);
            this.grpPerfil.TabIndex = 8;
            this.grpPerfil.TabStop = false;
            this.grpPerfil.Text = "Perfil";
            // 
            // radGerente
            // 
            this.radGerente.AutoSize = true;
            this.radGerente.Checked = true;
            this.radGerente.Location = new System.Drawing.Point(17, 22);
            this.radGerente.Name = "radGerente";
            this.radGerente.Size = new System.Drawing.Size(66, 19);
            this.radGerente.TabIndex = 0;
            this.radGerente.TabStop = true;
            this.radGerente.Text = "Gerente";
            this.radGerente.UseVisualStyleBackColor = true;
            // 
            // radOperador
            // 
            this.radOperador.AutoSize = true;
            this.radOperador.Location = new System.Drawing.Point(17, 47);
            this.radOperador.Name = "radOperador";
            this.radOperador.Size = new System.Drawing.Size(75, 19);
            this.radOperador.TabIndex = 1;
            this.radOperador.Text = "Operador";
            this.radOperador.UseVisualStyleBackColor = true;
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.radMasculino);
            this.grpSexo.Controls.Add(this.radFeminino);
            this.grpSexo.Location = new System.Drawing.Point(120, 183);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(133, 81);
            this.grpSexo.TabIndex = 7;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // radMasculino
            // 
            this.radMasculino.AutoSize = true;
            this.radMasculino.Checked = true;
            this.radMasculino.Location = new System.Drawing.Point(17, 23);
            this.radMasculino.Name = "radMasculino";
            this.radMasculino.Size = new System.Drawing.Size(80, 19);
            this.radMasculino.TabIndex = 0;
            this.radMasculino.TabStop = true;
            this.radMasculino.Text = "Masculino";
            this.radMasculino.UseVisualStyleBackColor = true;
            // 
            // radFeminino
            // 
            this.radFeminino.AutoSize = true;
            this.radFeminino.Location = new System.Drawing.Point(17, 48);
            this.radFeminino.Name = "radFeminino";
            this.radFeminino.Size = new System.Drawing.Size(75, 19);
            this.radFeminino.TabIndex = 1;
            this.radFeminino.Text = "Feminino";
            this.radFeminino.UseVisualStyleBackColor = true;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(120, 359);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(54, 19);
            this.chkAtivo.TabIndex = 6;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(60, 167);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(39, 15);
            this.lblIdade.TabIndex = 3;
            this.lblIdade.Text = "Idade:";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(25, 138);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(74, 15);
            this.lblNascimento.TabIndex = 2;
            this.lblNascimento.Text = "Nascimento:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(56, 103);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(50, 67);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // Pessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 400);
            this.Controls.Add(this.panel1);
            this.Name = "Pessoa";
            this.Text = "Funcionário";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpPerfil.ResumeLayout(false);
            this.grpPerfil.PerformLayout();
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblIdade;
        private Label lblNascimento;
        private Label lblNome;
        private Label lblCodigo;
        private RadioButton radMasculino;
        private RadioButton radFeminino;
        private CheckBox chkAtivo;
        private GroupBox grpPerfil;
        private RadioButton radGerente;
        private RadioButton radOperador;
        private GroupBox grpSexo;
        private DateTimePicker dtpNascimento;
        private TextBox txtName;
        private TextBox txtCodigo;
        private Label lblFormulario;
        private Button btnCadastrar;
    }
}