using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_authentication
{
    public partial class FrmMain : Form
    {
        #region Singleton in the window
        private static FrmMain _instance;
        public static FrmMain GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmMain();
            }

            return _instance;
        }
        #endregion
        private FrmMain()
        {
            InitializeComponent();
        }

        //-- FrmMain
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmLogin.GetInstance().Show();
        }
        //--//

        //-- tmnuExit
        private void tmnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-//
    }
}
