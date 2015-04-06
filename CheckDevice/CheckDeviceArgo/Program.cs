using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckDeviceArgo.BL;

namespace CheckDeviceArgo
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            DataTransfer test = new DataTransfer();
            MessageServis message = new MessageServis();

            MainPresenter prezenter = new MainPresenter(form, test, message);

            Application.Run(form);

        }
    }
}
