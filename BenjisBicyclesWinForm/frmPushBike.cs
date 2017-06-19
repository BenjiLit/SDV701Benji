using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BenjisBicyclesWinForm
{
    public sealed partial class frmPushBike : frmBicycle
    {
        public static readonly frmPushBike _Instance = new frmPushBike();

        private frmPushBike()
        {
            InitializeComponent();
        }
    }
}
