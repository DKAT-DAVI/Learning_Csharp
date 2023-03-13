namespace Calculadora
{
    partial class pnlPrincipal
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
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.Sum = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.pnlFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.BackColor = System.Drawing.SystemColors.MenuText;
            this.pnlFundo.Controls.Add(this.title);
            this.pnlFundo.Controls.Add(this.lblResult);
            this.pnlFundo.Controls.Add(this.txtValorB);
            this.pnlFundo.Controls.Add(this.txtValorA);
            this.pnlFundo.Controls.Add(this.division);
            this.pnlFundo.Controls.Add(this.mult);
            this.pnlFundo.Controls.Add(this.sub);
            this.pnlFundo.Controls.Add(this.Sum);
            this.pnlFundo.Location = new System.Drawing.Point(2, 0);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(355, 274);
            this.pnlFundo.TabIndex = 0;
            // 
            // Sum
            // 
            this.Sum.BackColor = System.Drawing.SystemColors.WindowText;
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Sum.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Sum.Location = new System.Drawing.Point(20, 134);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(73, 60);
            this.Sum.TabIndex = 2;
            this.Sum.Text = "+";
            this.Sum.UseVisualStyleBackColor = false;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.SystemColors.WindowText;
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.sub.ForeColor = System.Drawing.SystemColors.Desktop;
            this.sub.Location = new System.Drawing.Point(99, 134);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(73, 60);
            this.sub.TabIndex = 3;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // mult
            // 
            this.mult.BackColor = System.Drawing.SystemColors.WindowText;
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.mult.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.mult.Location = new System.Drawing.Point(178, 134);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(73, 60);
            this.mult.TabIndex = 4;
            this.mult.Text = "X";
            this.mult.UseVisualStyleBackColor = false;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.SystemColors.WindowText;
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.division.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.division.Location = new System.Drawing.Point(257, 134);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(73, 60);
            this.division.TabIndex = 5;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // txtValorA
            // 
            this.txtValorA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtValorA.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtValorA.Location = new System.Drawing.Point(20, 66);
            this.txtValorA.Multiline = true;
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(152, 62);
            this.txtValorA.TabIndex = 0;
            this.txtValorA.Tag = "";
            // 
            // txtValorB
            // 
            this.txtValorB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtValorB.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtValorB.Location = new System.Drawing.Point(178, 66);
            this.txtValorB.Multiline = true;
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(152, 62);
            this.txtValorB.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblResult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResult.Location = new System.Drawing.Point(23, 211);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(189, 39);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Resultado: ";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.title.ForeColor = System.Drawing.SystemColors.Desktop;
            this.title.Location = new System.Drawing.Point(57, 17);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(234, 46);
            this.title.TabIndex = 7;
            this.title.Text = "Calculadora";
            // 
            // pnlPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 276);
            this.Controls.Add(this.pnlFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "pnlPrincipal";
            this.Text = "Calculadora";
            this.pnlFundo.ResumeLayout(false);
            this.pnlFundo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.TextBox txtValorA;
    }
}

