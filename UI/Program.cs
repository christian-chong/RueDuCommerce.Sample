using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Services;

namespace UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainForm();

            ServiceLocator.Instance().MainForm = mainForm;
            ServiceLocator.Instance().DealService = new DealService();
            ServiceLocator.Instance().DealService.Init();


            Application.Run(mainForm);
        }
    }
}
