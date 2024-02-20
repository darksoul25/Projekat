using Client.Exceptions;
using Domain.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GUIController
{
    public class LoginController
    {
        private static LoginController instance;
        public static LoginController Instance
        {
            get
            {
                if(instance == null)
                    instance=new LoginController();
                return instance;
            }
        }
        private LoginController() { }
        public Administrator PrijavljeniAdmin { get; private set; }

        private FrmLogin frmLogin;
        public DialogResult ShowFrmLogin()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            frmLogin = new FrmLogin();
            frmLogin.AutoSize = true;
            //Application.Run(frmLogin); ovo je inicijalno

            DialogResult result = frmLogin.ShowDialog();

            return result;
        }
        public void Login(object sender,EventArgs args)
        {
            try
            {
                if (Communication.Instance.Connect())
                {
                    if (Validacija())
                    {
                        Administrator a = new Administrator()
                        {
                            KoricnikoIme = frmLogin.TxtUsername.Text,
                            Lozinka = frmLogin.TxtPassword.Text,
                        };
                        PrijavljeniAdmin = Communication.Instance.Login(a);
                        frmLogin.DialogResult = DialogResult.OK;
                        
                    }
                }
                else
                {
                    MessageBox.Show("Greska prilikom povezivanja sa serverom!");
                }
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool Validacija()
        {
            bool valid = true;
            if (string.IsNullOrEmpty(frmLogin.TxtUsername.Text))
            {
                frmLogin.TxtUsername.BackColor = Color.Salmon;
                valid = false;
            }
            if (string.IsNullOrEmpty(frmLogin.TxtPassword.Text))
            {
                frmLogin.TxtPassword.BackColor = Color.Salmon;
                valid = false;
            }
            return valid;
        }
        private void PromenaTeksta(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }
    }
}
