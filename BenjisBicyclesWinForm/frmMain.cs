using System;
using System.Windows.Forms;

namespace BenjisBicyclesWinForm
{
    public sealed partial class frmMain : Form
    {
        //Singleton
        private static readonly frmMain _Instance = new frmMain();

        private frmMain()
        {
            InitializeComponent();
            UpdateDisplay();
        }

        public static frmMain Instance
        {
            get { return frmMain._Instance; }
        }

        public async void UpdateDisplay()
        {
            try
            {
                lstBicycleBrands.DataSource = null;
                lstBicycleBrands.DataSource = await ServiceClient.GetBrandNamesAsync();

            }
            catch (Exception lcEx)
            {
                MessageBox.Show(lcEx.Message, "Error updating list");
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {

            try
            {
                frmOrders lcOrderform = frmOrders._Instance;
                lcOrderform.Show();
            }
            catch (Exception lcEx)
            {
                MessageBox.Show(lcEx.Message.ToString());
            }
        }

        private void lstBicycleBrands_DoubleClick(object sender, EventArgs e)
        {
            ViewBrand();
        }

        private void btnViewBrand_Click(object sender, EventArgs e)
        {
            if (lstBicycleBrands.SelectedItem == null)
                MessageBox.Show("Click on a brand to view");
            else
                ViewBrand();
        }

        private void ViewBrand()
        {
            try
            {
                frmBrandDetails.Run(lstBicycleBrands.SelectedItem as string);
            }
            catch (Exception lcEx)
            {
                MessageBox.Show(lcEx.Message, "Error");
            }
        }        
    }
}
