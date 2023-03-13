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
    public partial class Usuarios : Form
    {
        private static Usuarios instance;
        private Usuarios()
        {
            InitializeComponent();
        }

        public static Usuarios GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Usuarios();
            }
            return instance;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
