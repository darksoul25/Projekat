using Client.Exceptions;
using Client.GUIController;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //FrmLogin fmrLogin = new FrmLogin();
            //DialogResult result = fmrLogin.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    Application.Run(new FrmMain());
            //}
            while (true)
            {
                try
                {
                    DialogResult result = LoginController.Instance.ShowFrmLogin();

                    if (result == DialogResult.OK)
                    {
                        MainCoordinator.Instance.ShowFrmMain();
                    }
                    if (result == DialogResult.Cancel)
                    {
                        break;
                    }

                }
                catch (ServerCommunicationException ex)
                {
                    Debug.WriteLine(">>>>" + ex.Message);
                    MessageBox.Show("Server je pao.");
                }
            }
        }
    }
}
