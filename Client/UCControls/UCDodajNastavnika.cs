using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UCControls
{
    public partial class UCDodajNastavnika : UserControl
    {
        public UCDodajNastavnika()
        {
            InitializeComponent();
            cmbPol.DataSource=Enum.GetValues(typeof(Pol));

        }
        private void promenateksta(object sender, EventArgs args)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

       
    }
}
