﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.Data.OleDb;
using System.Configuration;
using System.Data;

namespace WinChurchPlayVideo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain(args));
        }
}
}
