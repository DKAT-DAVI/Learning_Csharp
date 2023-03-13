namespace WindowsFormsApp1
{
    partial class Usuarios
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
            this.pnlUsuarios = new System.Windows.Forms.Panel();
            this.imgUser1 = new System.Windows.Forms.PictureBox();
            this.imgUser2 = new System.Windows.Forms.PictureBox();
            this.imgUser4 = new System.Windows.Forms.PictureBox();
            this.imgUser3 = new System.Windows.Forms.PictureBox();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.listUser1 = new System.Windows.Forms.ListBox();
            this.listUser2 = new System.Windows.Forms.ListBox();
            this.listUser3 = new System.Windows.Forms.ListBox();
            this.listUser4 = new System.Windows.Forms.ListBox();
            this.pnlUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlUsuarios.Controls.Add(this.listUser4);
            this.pnlUsuarios.Controls.Add(this.listUser3);
            this.pnlUsuarios.Controls.Add(this.listUser2);
            this.pnlUsuarios.Controls.Add(this.listUser1);
            this.pnlUsuarios.Controls.Add(this.lblUsuarios);
            this.pnlUsuarios.Controls.Add(this.imgUser4);
            this.pnlUsuarios.Controls.Add(this.imgUser3);
            this.pnlUsuarios.Controls.Add(this.imgUser2);
            this.pnlUsuarios.Controls.Add(this.imgUser1);
            this.pnlUsuarios.Location = new System.Drawing.Point(1, 0);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(272, 369);
            this.pnlUsuarios.TabIndex = 0;
            this.pnlUsuarios.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // imgUser1
            // 
            this.imgUser1.Image = global::WindowsFormsApp1.Properties.Resources.user;
            this.imgUser1.Location = new System.Drawing.Point(40, 77);
            this.imgUser1.Name = "imgUser1";
            this.imgUser1.Size = new System.Drawing.Size(50, 50);
            this.imgUser1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUser1.TabIndex = 0;
            this.imgUser1.TabStop = false;
            // 
            // imgUser2
            // 
            this.imgUser2.Image = global::WindowsFormsApp1.Properties.Resources.user;
            this.imgUser2.Location = new System.Drawing.Point(40, 153);
            this.imgUser2.Name = "imgUser2";
            this.imgUser2.Size = new System.Drawing.Size(50, 50);
            this.imgUser2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUser2.TabIndex = 1;
            this.imgUser2.TabStop = false;
            // 
            // imgUser4
            // 
            this.imgUser4.Image = global::WindowsFormsApp1.Properties.Resources.user;
            this.imgUser4.Location = new System.Drawing.Point(40, 296);
            this.imgUser4.Name = "imgUser4";
            this.imgUser4.Size = new System.Drawing.Size(50, 50);
            this.imgUser4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUser4.TabIndex = 3;
            this.imgUser4.TabStop = false;
            // 
            // imgUser3
            // 
            this.imgUser3.Image = global::WindowsFormsApp1.Properties.Resources.user;
            this.imgUser3.Location = new System.Drawing.Point(40, 225);
            this.imgUser3.Name = "imgUser3";
            this.imgUser3.Size = new System.Drawing.Size(50, 50);
            this.imgUser3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUser3.TabIndex = 2;
            this.imgUser3.TabStop = false;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.Location = new System.Drawing.Point(71, 25);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(132, 32);
            this.lblUsuarios.TabIndex = 4;
            this.lblUsuarios.Text = "Usuários";
            // 
            // listUser1
            // 
            this.listUser1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUser1.FormattingEnabled = true;
            this.listUser1.ItemHeight = 18;
            this.listUser1.Items.AddRange(new object[] {
            "User: dkat",
            "Senha: 55555",
            "ADM"});
            this.listUser1.Location = new System.Drawing.Point(113, 73);
            this.listUser1.Name = "listUser1";
            this.listUser1.Size = new System.Drawing.Size(113, 58);
            this.listUser1.TabIndex = 5;
            // 
            // listUser2
            // 
            this.listUser2.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUser2.FormattingEnabled = true;
            this.listUser2.ItemHeight = 18;
            this.listUser2.Items.AddRange(new object[] {
            "User: ",
            "Senha: ",
            "Common"});
            this.listUser2.Location = new System.Drawing.Point(113, 149);
            this.listUser2.Name = "listUser2";
            this.listUser2.Size = new System.Drawing.Size(113, 58);
            this.listUser2.TabIndex = 6;
            // 
            // listUser3
            // 
            this.listUser3.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUser3.FormattingEnabled = true;
            this.listUser3.ItemHeight = 18;
            this.listUser3.Items.AddRange(new object[] {
            "User: ",
            "Senha: ",
            "Common"});
            this.listUser3.Location = new System.Drawing.Point(113, 221);
            this.listUser3.Name = "listUser3";
            this.listUser3.Size = new System.Drawing.Size(113, 58);
            this.listUser3.TabIndex = 7;
            // 
            // listUser4
            // 
            this.listUser4.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUser4.FormattingEnabled = true;
            this.listUser4.ItemHeight = 18;
            this.listUser4.Items.AddRange(new object[] {
            "User: ",
            "Senha: ",
            "Common"});
            this.listUser4.Location = new System.Drawing.Point(113, 292);
            this.listUser4.Name = "listUser4";
            this.listUser4.Size = new System.Drawing.Size(113, 58);
            this.listUser4.TabIndex = 8;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 369);
            this.Controls.Add(this.pnlUsuarios);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.pnlUsuarios.ResumeLayout(false);
            this.pnlUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUsuarios;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.PictureBox imgUser4;
        private System.Windows.Forms.PictureBox imgUser3;
        private System.Windows.Forms.PictureBox imgUser2;
        private System.Windows.Forms.PictureBox imgUser1;
        private System.Windows.Forms.ListBox listUser1;
        private System.Windows.Forms.ListBox listUser4;
        private System.Windows.Forms.ListBox listUser3;
        private System.Windows.Forms.ListBox listUser2;
    }
}