namespace WindowsFormsApp1
{
    partial class Form1
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
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.btnDefault = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnForest = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.btnSky = new System.Windows.Forms.Button();
            this.btnDark = new System.Windows.Forms.Button();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.White;
            this.pnlBackground.Controls.Add(this.btnDefault);
            this.pnlBackground.Controls.Add(this.lblTitle);
            this.pnlBackground.Controls.Add(this.btnForest);
            this.pnlBackground.Controls.Add(this.btnFire);
            this.pnlBackground.Controls.Add(this.btnSky);
            this.pnlBackground.Controls.Add(this.btnDark);
            this.pnlBackground.Location = new System.Drawing.Point(-2, -3);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(305, 282);
            this.pnlBackground.TabIndex = 0;
            // 
            // btnDefault
            // 
            this.btnDefault.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnDefault.Location = new System.Drawing.Point(109, 209);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(83, 47);
            this.btnDefault.TabIndex = 4;
            this.btnDefault.Text = "DEFAULT";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(48, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(205, 28);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "SELECT THE THEME";
            // 
            // btnForest
            // 
            this.btnForest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForest.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForest.Location = new System.Drawing.Point(53, 144);
            this.btnForest.Margin = new System.Windows.Forms.Padding(0);
            this.btnForest.Name = "btnForest";
            this.btnForest.Size = new System.Drawing.Size(83, 47);
            this.btnForest.TabIndex = 2;
            this.btnForest.Text = "FOREST";
            this.btnForest.UseVisualStyleBackColor = true;
            this.btnForest.Click += new System.EventHandler(this.btnForest_Click);
            // 
            // btnFire
            // 
            this.btnFire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFire.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.Location = new System.Drawing.Point(168, 144);
            this.btnFire.Margin = new System.Windows.Forms.Padding(0);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(83, 47);
            this.btnFire.TabIndex = 3;
            this.btnFire.Text = "FIRE";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnSky
            // 
            this.btnSky.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSky.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSky.Location = new System.Drawing.Point(168, 74);
            this.btnSky.Margin = new System.Windows.Forms.Padding(0);
            this.btnSky.Name = "btnSky";
            this.btnSky.Size = new System.Drawing.Size(83, 47);
            this.btnSky.TabIndex = 1;
            this.btnSky.Text = "SKY";
            this.btnSky.UseVisualStyleBackColor = true;
            this.btnSky.Click += new System.EventHandler(this.btnSky_Click);
            // 
            // btnDark
            // 
            this.btnDark.BackColor = System.Drawing.Color.White;
            this.btnDark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDark.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDark.Location = new System.Drawing.Point(53, 74);
            this.btnDark.Margin = new System.Windows.Forms.Padding(0);
            this.btnDark.Name = "btnDark";
            this.btnDark.Size = new System.Drawing.Size(83, 47);
            this.btnDark.TabIndex = 0;
            this.btnDark.Text = "DARK";
            this.btnDark.UseVisualStyleBackColor = false;
            this.btnDark.Click += new System.EventHandler(this.btnDark_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(299, 276);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Themes";
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnForest;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnSky;
        private System.Windows.Forms.Button btnDark;
        private System.Windows.Forms.Button btnDefault;
    }
}

