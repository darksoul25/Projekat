using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        private Server server;
        public FrmServer()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            server = new Server();
            server.Start();
            Thread nit = new Thread(server.Listen);
            nit.IsBackground = true;
            nit.Start();
            btnPokreni.Enabled = false;
            btnZaustavi.Enabled = true;
            lblPoruka.Text = "Server je pokrenut.";
            lblPoruka.ForeColor = Color.Green;

        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            server.Stop();
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
            lblPoruka.Text = "Server je zaustavljen.";
            lblPoruka.ForeColor = Color.Red;


        }
    }
}
