using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BenjisBicyclesWinForm
{
    public sealed partial class frmElectricBike : frmBicycle
    {
        public static readonly frmElectricBike _Instance = new frmElectricBike();

        private frmElectricBike()
        {
            InitializeComponent();
        }
    }
}
