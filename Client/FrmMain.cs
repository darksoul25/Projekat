using Client.Exceptions;
using Client.GUIController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            CustomizeDesign();
           
           
        }

        private void CustomizeDesign()
        {
            lblPrijavljen.Text = $"{LoginController.Instance.PrijavljeniAdmin}";
            pnlSubMenuNastavnik.Visible=false;
            pnlSubMenuPredmet.Visible=false;
            pnlSubMenuRaspored.Visible=false;
        }
        private void HideSubMenu()
        {
            if (pnlSubMenuNastavnik.Visible == true)
            {
                pnlSubMenuNastavnik.Visible = false;
            }
            if (pnlSubMenuPredmet.Visible == true)
            {
                pnlSubMenuPredmet.Visible = false;
            }
            if (pnlSubMenuRaspored.Visible == true)
            {
                pnlSubMenuRaspored.Visible = false;
            }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //HideSubMenu(subMenu);
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Communication.Instance.Close();
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (IOException ex)
            {
               Debug.WriteLine(">>>>FormCloes event>>>>"+ex.Message);
            }
        }

        private void btnNastavnik_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuNastavnik);
        }

        private void btnPredmet_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuPredmet);

        }

        private void btnRaspored_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuRaspored);

        }

        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ChangePanel(Control control)
        {
            pnlGlavni.Controls.Clear();
            pnlGlavni.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            pnlGlavni.AutoSize = true;
            pnlGlavni.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            MainCoordinator.Instance.ShowDodajNastavnika();
            HideSubMenu();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlGlavni.Controls.Clear();
            HideSubMenu();  
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            MainCoordinator.Instance.ShowPretraziNastavnika();
            HideSubMenu();

        }

        private void btnKreirajPredmet_Click(object sender, EventArgs e)
        {
            MainCoordinator.Instance.ShowKreirajPredmet();
            HideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainCoordinator.Instance.ShowKreirajRaspored();
            HideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainCoordinator.Instance.ShowIzmeniRaspored();
            HideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainCoordinator.Instance.ShowPredavanje();
            HideSubMenu();  
        }
    }
}
