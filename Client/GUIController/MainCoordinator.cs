using Client.UCControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Client.GUIController
{
    internal class MainCoordinator
    {
        private static MainCoordinator instance;
        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainCoordinator();
                }
                return instance;
            }
        }
        
        private MainCoordinator()
        {
            nastavnikGuiController = new NastavnikGuiController();
            predmetGuiController = new PredmetGuiController();
            rasporedNastaveController = new RasporedNastaveController();
            predavanjeGuiController = new PredavanjeGuiController();
        }

        private FrmMain frmMain;
        private NastavnikGuiController nastavnikGuiController;
        private PredmetGuiController predmetGuiController;
        private RasporedNastaveController rasporedNastaveController;
        private PredavanjeGuiController predavanjeGuiController;
        

        internal void ShowFrmMain()
        {
            frmMain = new FrmMain();
            frmMain.AutoSize = true;
            frmMain.ShowDialog();
            
        }

       public void ShowDodajNastavnika()
        {
            frmMain.ChangePanel(nastavnikGuiController.PrikaziDodajNastavnika());
        }
        public void ShowPretraziNastavnika()
        {
            frmMain.ChangePanel(nastavnikGuiController.PrikaziPretraziNastavnika());
        }
        public void ShowKreirajPredmet()
        {
            frmMain.ChangePanel(predmetGuiController.PrikaziKreirajPredmet());
        }
        public void ShowKreirajRaspored()
        {
            frmMain.ChangePanel(rasporedNastaveController.PrikaziRasporedNastave());
        }
        public void ShowPredavanje()
        {
            frmMain.ChangePanel(predavanjeGuiController.PrikaziPredavanje());

        }
        public void ShowIzmeniRaspored()
        {
            frmMain.ChangePanel(rasporedNastaveController.PrikaziIzmeniRaspored());

        }

    }
}
