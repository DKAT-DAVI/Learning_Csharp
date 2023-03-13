namespace user_authentication
{
    partial class FrmMain
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
            this.mnuFrmMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.tmnuRemoveUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFrmMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuFrmMain
            // 
            this.mnuFrmMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.mnuFrmMain.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuFrmMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuRegister});
            this.mnuFrmMain.Location = new System.Drawing.Point(0, 0);
            this.mnuFrmMain.Name = "mnuFrmMain";
            this.mnuFrmMain.Size = new System.Drawing.Size(800, 31);
            this.mnuFrmMain.TabIndex = 1;
            this.mnuFrmMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(66, 27);
            this.mnuFile.Text = "File";
            // 
            // tmnuExit
            // 
            this.tmnuExit.BackColor = System.Drawing.Color.DimGray;
            this.tmnuExit.Font = new System.Drawing.Font("Consolas", 12F);
            this.tmnuExit.Name = "tmnuExit";
            this.tmnuExit.Size = new System.Drawing.Size(180, 24);
            this.tmnuExit.Text = "Exit";
            this.tmnuExit.Click += new System.EventHandler(this.tmnuExit_Click);
            // 
            // mnuRegister
            // 
            this.mnuRegister.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmnuRemoveUser});
            this.mnuRegister.Name = "mnuRegister";
            this.mnuRegister.Size = new System.Drawing.Size(110, 27);
            this.mnuRegister.Text = "Register";
            // 
            // tmnuRemoveUser
            // 
            this.tmnuRemoveUser.BackColor = System.Drawing.Color.DimGray;
            this.tmnuRemoveUser.Font = new System.Drawing.Font("Consolas", 12F);
            this.tmnuRemoveUser.Name = "tmnuRemoveUser";
            this.tmnuRemoveUser.Size = new System.Drawing.Size(180, 24);
            this.tmnuRemoveUser.Text = "Remove user";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuFrmMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuFrmMain;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.mnuFrmMain.ResumeLayout(false);
            this.mnuFrmMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFrmMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem tmnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuRegister;
        private System.Windows.Forms.ToolStripMenuItem tmnuRemoveUser;
    }
}