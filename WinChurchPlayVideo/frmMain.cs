using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinChurchPlayVideo
{
    public partial class frmMain : Form
    {
        public frmMain(string[] args)
        {
            InitializeComponent();



      
            if (args.Length > 0)
                if (Convert.ToInt32( args[0]) == 1)
                {
                    openPlayForm();
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openPlayForm();
        }



        /// <summary>
        /// 開啟播放系統
        /// </summary>
        private void openPlayForm()
        {
            var playform = new frmPlayForm();
            playform.FormBorderStyle = FormBorderStyle.None;
            playform.WindowState = FormWindowState.Maximized;
            playform.ShowDialog();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();

            frm.ShowDialog();
        }

 
    }
}
