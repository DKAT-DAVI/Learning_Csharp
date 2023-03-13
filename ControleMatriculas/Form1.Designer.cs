namespace ControleMatriculas
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
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnMatricula = new System.Windows.Forms.Button();
            this.lstMatriculados = new System.Windows.Forms.ListBox();
            this.lstAlunos = new System.Windows.Forms.ListBox();
            this.lblMatriculados = new System.Windows.Forms.Label();
            this.lblAlunos = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(119)))), ((int)(((byte)(35)))));
            this.pnl1.Controls.Add(this.btnSalvar);
            this.pnl1.Controls.Add(this.btnAluno);
            this.pnl1.Controls.Add(this.btnMatricula);
            this.pnl1.Controls.Add(this.lstMatriculados);
            this.pnl1.Controls.Add(this.lstAlunos);
            this.pnl1.Controls.Add(this.lblMatriculados);
            this.pnl1.Controls.Add(this.lblAlunos);
            this.pnl1.Controls.Add(this.lblTitle);
            this.pnl1.Location = new System.Drawing.Point(1, 1);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(504, 362);
            this.pnl1.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(98)))), ((int)(((byte)(24)))));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(379, 315);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(94, 35);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAluno
            // 
            this.btnAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(12)))));
            this.btnAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluno.ForeColor = System.Drawing.Color.White;
            this.btnAluno.Location = new System.Drawing.Point(184, 220);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(126, 38);
            this.btnAluno.TabIndex = 6;
            this.btnAluno.Text = "DESMATRICULAR";
            this.btnAluno.UseVisualStyleBackColor = false;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // btnMatricula
            // 
            this.btnMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(12)))));
            this.btnMatricula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatricula.ForeColor = System.Drawing.Color.White;
            this.btnMatricula.Location = new System.Drawing.Point(184, 163);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Size = new System.Drawing.Size(126, 38);
            this.btnMatricula.TabIndex = 5;
            this.btnMatricula.Text = "MATRICULAR";
            this.btnMatricula.UseVisualStyleBackColor = false;
            this.btnMatricula.Click += new System.EventHandler(this.btnMatricula_Click);
            // 
            // lstMatriculados
            // 
            this.lstMatriculados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lstMatriculados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstMatriculados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(12)))));
            this.lstMatriculados.FormattingEnabled = true;
            this.lstMatriculados.ItemHeight = 20;
            this.lstMatriculados.Location = new System.Drawing.Point(336, 127);
            this.lstMatriculados.Name = "lstMatriculados";
            this.lstMatriculados.Size = new System.Drawing.Size(135, 164);
            this.lstMatriculados.TabIndex = 4;
            // 
            // lstAlunos
            // 
            this.lstAlunos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lstAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstAlunos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(12)))));
            this.lstAlunos.FormattingEnabled = true;
            this.lstAlunos.ItemHeight = 20;
            this.lstAlunos.Location = new System.Drawing.Point(28, 127);
            this.lstAlunos.Name = "lstAlunos";
            this.lstAlunos.Size = new System.Drawing.Size(135, 164);
            this.lstAlunos.TabIndex = 3;
            // 
            // lblMatriculados
            // 
            this.lblMatriculados.AutoSize = true;
            this.lblMatriculados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblMatriculados.ForeColor = System.Drawing.Color.White;
            this.lblMatriculados.Location = new System.Drawing.Point(336, 93);
            this.lblMatriculados.Name = "lblMatriculados";
            this.lblMatriculados.Size = new System.Drawing.Size(135, 25);
            this.lblMatriculados.TabIndex = 2;
            this.lblMatriculados.Text = "Matriculados";
            // 
            // lblAlunos
            // 
            this.lblAlunos.AutoSize = true;
            this.lblAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblAlunos.ForeColor = System.Drawing.Color.White;
            this.lblAlunos.Location = new System.Drawing.Point(56, 93);
            this.lblAlunos.Name = "lblAlunos";
            this.lblAlunos.Size = new System.Drawing.Size(79, 25);
            this.lblAlunos.TabIndex = 1;
            this.lblAlunos.Text = "Alunos";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(68, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(379, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Controle de Matrículas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 363);
            this.Controls.Add(this.pnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Matrículas";
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnMatricula;
        private System.Windows.Forms.ListBox lstMatriculados;
        private System.Windows.Forms.ListBox lstAlunos;
        private System.Windows.Forms.Label lblMatriculados;
        private System.Windows.Forms.Label lblAlunos;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSalvar;
    }
}

