namespace ControleMatriculas
{
    partial class Matriculados
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
            this.pnl2 = new System.Windows.Forms.Panel();
            this.lstMatriculadosM = new System.Windows.Forms.ListBox();
            this.lstAlunosM = new System.Windows.Forms.ListBox();
            this.lblMatriculadosM = new System.Windows.Forms.Label();
            this.lblAlunosM = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(119)))), ((int)(((byte)(35)))));
            this.pnl2.Controls.Add(this.pictureBox1);
            this.pnl2.Controls.Add(this.lstMatriculadosM);
            this.pnl2.Controls.Add(this.lstAlunosM);
            this.pnl2.Controls.Add(this.lblMatriculadosM);
            this.pnl2.Controls.Add(this.lblAlunosM);
            this.pnl2.Location = new System.Drawing.Point(0, -1);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(380, 253);
            this.pnl2.TabIndex = 1;
            // 
            // lstMatriculadosM
            // 
            this.lstMatriculadosM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lstMatriculadosM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstMatriculadosM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(12)))));
            this.lstMatriculadosM.FormattingEnabled = true;
            this.lstMatriculadosM.ItemHeight = 20;
            this.lstMatriculadosM.Location = new System.Drawing.Point(205, 57);
            this.lstMatriculadosM.Name = "lstMatriculadosM";
            this.lstMatriculadosM.Size = new System.Drawing.Size(135, 164);
            this.lstMatriculadosM.TabIndex = 10;
            // 
            // lstAlunosM
            // 
            this.lstAlunosM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lstAlunosM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstAlunosM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(12)))));
            this.lstAlunosM.FormattingEnabled = true;
            this.lstAlunosM.ItemHeight = 20;
            this.lstAlunosM.Location = new System.Drawing.Point(29, 57);
            this.lstAlunosM.Name = "lstAlunosM";
            this.lstAlunosM.Size = new System.Drawing.Size(135, 164);
            this.lstAlunosM.TabIndex = 9;
            // 
            // lblMatriculadosM
            // 
            this.lblMatriculadosM.AutoSize = true;
            this.lblMatriculadosM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblMatriculadosM.ForeColor = System.Drawing.Color.White;
            this.lblMatriculadosM.Location = new System.Drawing.Point(205, 23);
            this.lblMatriculadosM.Name = "lblMatriculadosM";
            this.lblMatriculadosM.Size = new System.Drawing.Size(135, 25);
            this.lblMatriculadosM.TabIndex = 8;
            this.lblMatriculadosM.Text = "Matriculados";
            // 
            // lblAlunosM
            // 
            this.lblAlunosM.AutoSize = true;
            this.lblAlunosM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblAlunosM.ForeColor = System.Drawing.Color.White;
            this.lblAlunosM.Location = new System.Drawing.Point(57, 23);
            this.lblAlunosM.Name = "lblAlunosM";
            this.lblAlunosM.Size = new System.Drawing.Size(79, 25);
            this.lblAlunosM.TabIndex = 7;
            this.lblAlunosM.Text = "Alunos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControleMatriculas.Properties.Resources.go_back_btn2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Matriculados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 250);
            this.Controls.Add(this.pnl2);
            this.Name = "Matriculados";
            this.Text = "Matriculados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Matriculados_FormClosing);
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.ListBox lstMatriculadosM;
        private System.Windows.Forms.ListBox lstAlunosM;
        private System.Windows.Forms.Label lblMatriculadosM;
        private System.Windows.Forms.Label lblAlunosM;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}