namespace Cadastro
{
    partial class CadastroLivro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroLivro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgVoltar = new System.Windows.Forms.PictureBox();
            this.gpbLivros = new System.Windows.Forms.GroupBox();
            this.btnSalvarLivro = new System.Windows.Forms.Button();
            this.btnCancelarLivro = new System.Windows.Forms.Button();
            this.txtEditoraLivro = new System.Windows.Forms.TextBox();
            this.txtAnoLivro = new System.Windows.Forms.TextBox();
            this.txtSubtituloLivro = new System.Windows.Forms.TextBox();
            this.txtEdicaoLivro = new System.Windows.Forms.TextBox();
            this.lblAnoLivro = new System.Windows.Forms.Label();
            this.lblEditoraLivro = new System.Windows.Forms.Label();
            this.lblEdicaoLivro = new System.Windows.Forms.Label();
            this.lblSutituloLivro = new System.Windows.Forms.Label();
            this.txtAutorLivro = new System.Windows.Forms.TextBox();
            this.textTituloLivro = new System.Windows.Forms.TextBox();
            this.lblAutorLivro = new System.Windows.Forms.Label();
            this.lblTitleLivro = new System.Windows.Forms.Label();
            this.btnCadastroLivro = new System.Windows.Forms.Button();
            this.btnLoginLivro = new System.Windows.Forms.Button();
            this.lblTitleLivros = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVoltar)).BeginInit();
            this.gpbLivros.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imgVoltar);
            this.panel1.Controls.Add(this.gpbLivros);
            this.panel1.Controls.Add(this.btnCadastroLivro);
            this.panel1.Controls.Add(this.btnLoginLivro);
            this.panel1.Controls.Add(this.lblTitleLivros);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 303);
            this.panel1.TabIndex = 0;
            // 
            // imgVoltar
            // 
            this.imgVoltar.Image = global::Cadastro.Properties.Resources.back;
            this.imgVoltar.Location = new System.Drawing.Point(9, 10);
            this.imgVoltar.Name = "imgVoltar";
            this.imgVoltar.Size = new System.Drawing.Size(42, 35);
            this.imgVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgVoltar.TabIndex = 7;
            this.imgVoltar.TabStop = false;
            this.imgVoltar.Click += new System.EventHandler(this.imgVoltar_Click);
            // 
            // gpbLivros
            // 
            this.gpbLivros.Controls.Add(this.btnSalvarLivro);
            this.gpbLivros.Controls.Add(this.btnCancelarLivro);
            this.gpbLivros.Controls.Add(this.txtEditoraLivro);
            this.gpbLivros.Controls.Add(this.txtAnoLivro);
            this.gpbLivros.Controls.Add(this.txtSubtituloLivro);
            this.gpbLivros.Controls.Add(this.txtEdicaoLivro);
            this.gpbLivros.Controls.Add(this.lblAnoLivro);
            this.gpbLivros.Controls.Add(this.lblEditoraLivro);
            this.gpbLivros.Controls.Add(this.lblEdicaoLivro);
            this.gpbLivros.Controls.Add(this.lblSutituloLivro);
            this.gpbLivros.Controls.Add(this.txtAutorLivro);
            this.gpbLivros.Controls.Add(this.textTituloLivro);
            this.gpbLivros.Controls.Add(this.lblAutorLivro);
            this.gpbLivros.Controls.Add(this.lblTitleLivro);
            this.gpbLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbLivros.Location = new System.Drawing.Point(9, 84);
            this.gpbLivros.Name = "gpbLivros";
            this.gpbLivros.Size = new System.Drawing.Size(613, 218);
            this.gpbLivros.TabIndex = 6;
            this.gpbLivros.TabStop = false;
            this.gpbLivros.Text = "Cadastrar Livros";
            // 
            // btnSalvarLivro
            // 
            this.btnSalvarLivro.Location = new System.Drawing.Point(316, 164);
            this.btnSalvarLivro.Name = "btnSalvarLivro";
            this.btnSalvarLivro.Size = new System.Drawing.Size(122, 33);
            this.btnSalvarLivro.TabIndex = 12;
            this.btnSalvarLivro.Text = "Salvar";
            this.btnSalvarLivro.UseVisualStyleBackColor = true;
            // 
            // btnCancelarLivro
            // 
            this.btnCancelarLivro.Location = new System.Drawing.Point(169, 164);
            this.btnCancelarLivro.Name = "btnCancelarLivro";
            this.btnCancelarLivro.Size = new System.Drawing.Size(122, 33);
            this.btnCancelarLivro.TabIndex = 11;
            this.btnCancelarLivro.Text = "Cancelar";
            this.btnCancelarLivro.UseVisualStyleBackColor = true;
            // 
            // txtEditoraLivro
            // 
            this.txtEditoraLivro.Location = new System.Drawing.Point(374, 105);
            this.txtEditoraLivro.Multiline = true;
            this.txtEditoraLivro.Name = "txtEditoraLivro";
            this.txtEditoraLivro.Size = new System.Drawing.Size(181, 30);
            this.txtEditoraLivro.TabIndex = 10;
            // 
            // txtAnoLivro
            // 
            this.txtAnoLivro.Location = new System.Drawing.Point(374, 69);
            this.txtAnoLivro.Multiline = true;
            this.txtAnoLivro.Name = "txtAnoLivro";
            this.txtAnoLivro.Size = new System.Drawing.Size(180, 30);
            this.txtAnoLivro.TabIndex = 9;
            // 
            // txtSubtituloLivro
            // 
            this.txtSubtituloLivro.Location = new System.Drawing.Point(373, 33);
            this.txtSubtituloLivro.Multiline = true;
            this.txtSubtituloLivro.Name = "txtSubtituloLivro";
            this.txtSubtituloLivro.Size = new System.Drawing.Size(181, 30);
            this.txtSubtituloLivro.TabIndex = 8;
            // 
            // txtEdicaoLivro
            // 
            this.txtEdicaoLivro.Location = new System.Drawing.Point(78, 105);
            this.txtEdicaoLivro.Multiline = true;
            this.txtEdicaoLivro.Name = "txtEdicaoLivro";
            this.txtEdicaoLivro.Size = new System.Drawing.Size(181, 30);
            this.txtEdicaoLivro.TabIndex = 7;
            // 
            // lblAnoLivro
            // 
            this.lblAnoLivro.AutoSize = true;
            this.lblAnoLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAnoLivro.Location = new System.Drawing.Point(319, 72);
            this.lblAnoLivro.Name = "lblAnoLivro";
            this.lblAnoLivro.Size = new System.Drawing.Size(48, 25);
            this.lblAnoLivro.TabIndex = 6;
            this.lblAnoLivro.Text = "Ano";
            // 
            // lblEditoraLivro
            // 
            this.lblEditoraLivro.AutoSize = true;
            this.lblEditoraLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditoraLivro.Location = new System.Drawing.Point(294, 108);
            this.lblEditoraLivro.Name = "lblEditoraLivro";
            this.lblEditoraLivro.Size = new System.Drawing.Size(73, 25);
            this.lblEditoraLivro.TabIndex = 5;
            this.lblEditoraLivro.Text = "Editora";
            // 
            // lblEdicaoLivro
            // 
            this.lblEdicaoLivro.AutoSize = true;
            this.lblEdicaoLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdicaoLivro.Location = new System.Drawing.Point(2, 107);
            this.lblEdicaoLivro.Name = "lblEdicaoLivro";
            this.lblEdicaoLivro.Size = new System.Drawing.Size(72, 25);
            this.lblEdicaoLivro.TabIndex = 4;
            this.lblEdicaoLivro.Text = "Edição";
            // 
            // lblSutituloLivro
            // 
            this.lblSutituloLivro.AutoSize = true;
            this.lblSutituloLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSutituloLivro.Location = new System.Drawing.Point(272, 36);
            this.lblSutituloLivro.Name = "lblSutituloLivro";
            this.lblSutituloLivro.Size = new System.Drawing.Size(95, 25);
            this.lblSutituloLivro.TabIndex = 3;
            this.lblSutituloLivro.Text = "Sub-título";
            // 
            // txtAutorLivro
            // 
            this.txtAutorLivro.Location = new System.Drawing.Point(78, 69);
            this.txtAutorLivro.Multiline = true;
            this.txtAutorLivro.Name = "txtAutorLivro";
            this.txtAutorLivro.Size = new System.Drawing.Size(181, 30);
            this.txtAutorLivro.TabIndex = 2;
            // 
            // textTituloLivro
            // 
            this.textTituloLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTituloLivro.Location = new System.Drawing.Point(78, 33);
            this.textTituloLivro.Multiline = true;
            this.textTituloLivro.Name = "textTituloLivro";
            this.textTituloLivro.Size = new System.Drawing.Size(181, 30);
            this.textTituloLivro.TabIndex = 1;
            // 
            // lblAutorLivro
            // 
            this.lblAutorLivro.AutoSize = true;
            this.lblAutorLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAutorLivro.Location = new System.Drawing.Point(15, 71);
            this.lblAutorLivro.Name = "lblAutorLivro";
            this.lblAutorLivro.Size = new System.Drawing.Size(59, 25);
            this.lblAutorLivro.TabIndex = 0;
            this.lblAutorLivro.Text = "Autor";
            // 
            // lblTitleLivro
            // 
            this.lblTitleLivro.AutoSize = true;
            this.lblTitleLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitleLivro.Location = new System.Drawing.Point(14, 35);
            this.lblTitleLivro.Name = "lblTitleLivro";
            this.lblTitleLivro.Size = new System.Drawing.Size(60, 25);
            this.lblTitleLivro.TabIndex = 0;
            this.lblTitleLivro.Text = "Título";
            // 
            // btnCadastroLivro
            // 
            this.btnCadastroLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroLivro.Location = new System.Drawing.Point(427, 51);
            this.btnCadastroLivro.Name = "btnCadastroLivro";
            this.btnCadastroLivro.Size = new System.Drawing.Size(90, 29);
            this.btnCadastroLivro.TabIndex = 5;
            this.btnCadastroLivro.Text = "CADASTRO";
            this.btnCadastroLivro.UseVisualStyleBackColor = true;
            // 
            // btnLoginLivro
            // 
            this.btnLoginLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginLivro.Location = new System.Drawing.Point(523, 51);
            this.btnLoginLivro.Name = "btnLoginLivro";
            this.btnLoginLivro.Size = new System.Drawing.Size(90, 29);
            this.btnLoginLivro.TabIndex = 4;
            this.btnLoginLivro.Text = "LOGIN";
            this.btnLoginLivro.UseVisualStyleBackColor = true;
            // 
            // lblTitleLivros
            // 
            this.lblTitleLivros.AutoSize = true;
            this.lblTitleLivros.Font = new System.Drawing.Font("Rubik", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleLivros.Location = new System.Drawing.Point(151, 6);
            this.lblTitleLivros.Name = "lblTitleLivros";
            this.lblTitleLivros.Size = new System.Drawing.Size(329, 39);
            this.lblTitleLivros.TabIndex = 3;
            this.lblTitleLivros.Text = "Cadastro de Livros";
            this.lblTitleLivros.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CadastroLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 304);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastroLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro  de Livros";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVoltar)).EndInit();
            this.gpbLivros.ResumeLayout(false);
            this.gpbLivros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastroLivro;
        private System.Windows.Forms.Button btnLoginLivro;
        private System.Windows.Forms.Label lblTitleLivros;
        private System.Windows.Forms.GroupBox gpbLivros;
        private System.Windows.Forms.Button btnSalvarLivro;
        private System.Windows.Forms.Button btnCancelarLivro;
        private System.Windows.Forms.TextBox txtEditoraLivro;
        private System.Windows.Forms.TextBox txtAnoLivro;
        private System.Windows.Forms.TextBox txtSubtituloLivro;
        private System.Windows.Forms.TextBox txtEdicaoLivro;
        private System.Windows.Forms.Label lblAnoLivro;
        private System.Windows.Forms.Label lblEditoraLivro;
        private System.Windows.Forms.Label lblEdicaoLivro;
        private System.Windows.Forms.Label lblSutituloLivro;
        private System.Windows.Forms.TextBox txtAutorLivro;
        private System.Windows.Forms.TextBox textTituloLivro;
        private System.Windows.Forms.Label lblAutorLivro;
        private System.Windows.Forms.Label lblTitleLivro;
        private System.Windows.Forms.PictureBox imgVoltar;
    }
}