using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static Form1 instance;
        private Form1()
        {
            InitializeComponent();
        }

        public static Form1 GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Form1();
            }
            
            return instance;
        }

        private void btnDark_Click(object sender, EventArgs e)
        {
            pnlBackground.BackColor = Color.Black;
            lblTitle.ForeColor = Color.White;
            btnDark.BackColor = Color.FromArgb(70, 70, 70);
            btnSky.BackColor = Color.FromArgb(70, 70, 70);
            btnForest.BackColor = Color.FromArgb(70, 70, 70);
            btnFire.BackColor = Color.FromArgb(70, 70, 70);
            btnDefault.BackColor = Color.FromArgb(70, 70, 70);
            btnDark.ForeColor = Color.White;
            btnSky.ForeColor = Color.White;
            btnForest.ForeColor = Color.White;
            btnFire.ForeColor = Color.White;
            btnDefault.ForeColor = Color.White;
        }

        private void btnSky_Click(object sender, EventArgs e)
        {
            pnlBackground.BackColor = btnDark.BackColor = Color.FromArgb(170, 211, 247);
            lblTitle.ForeColor = Color.FromArgb(255, 255, 250);
            btnDark.BackColor = Color.FromArgb(95, 175, 245);
            btnSky.BackColor = Color.FromArgb(95, 175, 245);
            btnForest.BackColor = Color.FromArgb(95, 175, 245); 
            btnFire.BackColor = Color.FromArgb(95, 175, 245);
            btnDefault.BackColor = Color.FromArgb(95, 175, 245);
            btnDark.ForeColor = Color.White;
            btnSky.ForeColor = Color.White;
            btnForest.ForeColor = Color.White;
            btnFire.ForeColor = Color.White;
            btnDefault.ForeColor = Color.White;
        }

        private void btnForest_Click(object sender, EventArgs e)
        {
            pnlBackground.BackColor = Color.FromArgb(8, 78, 0);
            lblTitle.ForeColor = Color.FromArgb(255, 255, 250);
            btnDark.BackColor = Color.FromArgb(91, 247, 74);
            btnSky.BackColor = Color.FromArgb(91, 247, 74);
            btnForest.BackColor = Color.FromArgb(91, 247, 74);
            btnFire.BackColor = Color.FromArgb(91, 247, 74);
            btnDefault.BackColor = Color.FromArgb(91, 247, 74);
            btnDark.ForeColor = Color.White;
            btnSky.ForeColor = Color.White;
            btnForest.ForeColor = Color.White;
            btnFire.ForeColor = Color.White;
            btnDefault.ForeColor = Color.White;
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            pnlBackground.BackColor = Color.FromArgb(64, 6, 0);
            lblTitle.ForeColor = Color.FromArgb(255, 255, 250);
            btnDark.BackColor = Color.FromArgb(230, 23, 0);
            btnSky.BackColor = Color.FromArgb(230, 23, 0);
            btnForest.BackColor = Color.FromArgb(230, 23, 0);
            btnFire.BackColor = Color.FromArgb(230, 23, 0);
            btnDefault.BackColor = Color.FromArgb(230, 23, 0);
            btnDark.ForeColor = Color.White;
            btnSky.ForeColor = Color.White;
            btnForest.ForeColor = Color.White;
            btnFire.ForeColor = Color.White;
            btnDefault.ForeColor = Color.White;
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            pnlBackground.BackColor = Color.White;
            lblTitle.ForeColor = Color.Black;
            btnDark.BackColor = Color.White;
            btnSky.BackColor = Color.White;
            btnForest.BackColor = Color.White;
            btnFire.BackColor = Color.White;
            btnDefault.BackColor = Color.White;
            btnDark.ForeColor = Color.Black;
            btnSky.ForeColor = Color.Black;
            btnForest.ForeColor = Color.Black;
            btnFire.ForeColor = Color.Black;
            btnDefault.ForeColor = Color.Black;
        }
    }
}
