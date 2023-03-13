namespace Cadastro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroEndereco = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroLivro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mnuPrincipal);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 361);
            this.panel1.TabIndex = 1;
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArquivo,
            this.cadastrosToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(480, 24);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuArquivo
            // 
            this.mnuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArquivoSair});
            this.mnuArquivo.Name = "mnuArquivo";
            this.mnuArquivo.Size = new System.Drawing.Size(61, 20);
            this.mnuArquivo.Text = "Arquivo";
            // 
            // mnuArquivoSair
            // 
            this.mnuArquivoSair.Name = "mnuArquivoSair";
            this.mnuArquivoSair.Size = new System.Drawing.Size(180, 22);
            this.mnuArquivoSair.Text = "Sair";
            this.mnuArquivoSair.Click += new System.EventHandler(this.mnuArquivoSair_Click);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastroEndereco,
            this.mnuCadastroLivro,
            this.mnuCadastroUsuario});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastro";
            this.cadastrosToolStripMenuItem.Click += new System.EventHandler(this.cadastrosToolStripMenuItem_Click);
            // 
            // mnuCadastroEndereco
            // 
            this.mnuCadastroEndereco.Name = "mnuCadastroEndereco";
            this.mnuCadastroEndereco.Size = new System.Drawing.Size(123, 22);
            this.mnuCadastroEndereco.Text = "Endereço";
            this.mnuCadastroEndereco.Click += new System.EventHandler(this.mnuCadastroEndereco_Click);
            // 
            // mnuCadastroLivro
            // 
            this.mnuCadastroLivro.Name = "mnuCadastroLivro";
            this.mnuCadastroLivro.Size = new System.Drawing.Size(123, 22);
            this.mnuCadastroLivro.Text = "Livros";
            this.mnuCadastroLivro.Click += new System.EventHandler(this.mnuCadastroLivro_Click);
            // 
            // mnuCadastroUsuario
            // 
            this.mnuCadastroUsuario.Name = "mnuCadastroUsuario";
            this.mnuCadastroUsuario.Size = new System.Drawing.Size(123, 22);
            this.mnuCadastroUsuario.Text = "Usuários";
            this.mnuCadastroUsuario.Click += new System.EventHandler(this.mnuCadastroUsuario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 361);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Janelas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivo;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroEndereco;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroLivro;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivoSair;
    }
}

