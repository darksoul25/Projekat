using Client.Exceptions;
using Client.GUIController;
using Domain.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            btnPrijavi.Click+= LoginController.Instance.Login;

        }

        //private void btnPrijavi_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (Communication.Instance.Connect())
        //        {
        //            if (Validacija())
        //            {
        //                Administrator a = new Administrator()
        //                {
        //                    KoricnikoIme = txtUsername.Text,
        //                    Lozinka = txtPassword.Text,
        //                };
        //                a = Communication.Instance.Login(a);
        //                DialogResult = DialogResult.OK;
        //                MessageBox.Show($"Dobro dosao {a.Ime} {a.Prezime}");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Greska prilikom povezivanja sa serverom!");
        //        }
        //    }
        //    catch (SystemOperationException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}

        //private bool Validacija()
        //{
        //    bool valid = true;
        //    if (string.IsNullOrEmpty(txtUsername.Text))
        //    {
        //        txtUsername.BackColor = Color.Salmon;
        //        valid = false;
        //    }
        //    if (string.IsNullOrEmpty(txtPassword.Text))
        //    {
        //        txtPassword.BackColor = Color.Salmon;
        //        valid = false;
        //    }
        //    return valid;
        //}

        private void promenateksta(object sender,EventArgs args)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        
    }
}
