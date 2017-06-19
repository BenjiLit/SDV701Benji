using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BenjisBicyclesWinForm
{
    public partial class frmBrandDetails : Form
    {
        public frmBrandDetails()
        {
            InitializeComponent();            
        }

        private static Dictionary<string, frmBrandDetails> _BicycleFormList = new Dictionary<string, frmBrandDetails>();

        private clsBrand _Brand;

        public static void Run(string prBrandName)
        {
            frmBrandDetails lcBrandForm;
            if (string.IsNullOrEmpty(prBrandName) ||
            !_BicycleFormList.TryGetValue(prBrandName, out lcBrandForm))
            {
                lcBrandForm = new frmBrandDetails();
                if (string.IsNullOrEmpty(prBrandName))
                    lcBrandForm.SetDetails(new clsBrand());
                else
                {
                    _BicycleFormList.Add(prBrandName, lcBrandForm);
                    lcBrandForm.refreshFormFromDB(prBrandName);
                }
            }
            else
            {
                lcBrandForm.Show();
                lcBrandForm.Activate();
            }
        }

        public void SetDetails(clsBrand prBrand)
        {
            _Brand = prBrand;            
            UpdateForm();
            UpdateDisplay();           
            Show();
        }

        private void UpdateDisplay()
        {                           
            lstBicycles.DataSource = null;
            if (_Brand.BicycleList != null)
                lstBicycles.DataSource = _Brand.BicycleList;
        }

        public void UpdateForm()
        {
            txtBrandName.Text = _Brand.BrandName;
            txtBrandContact.Text = _Brand.BrandContactPhone;
            txtWarranyPeriod.Text = _Brand.WarrantyPeriod;                 
        }

        private async void refreshFormFromDB(string prBrandName)
        {       
            try
            {
                SetDetails(await ServiceClient.GetBrandAsync(prBrandName));
            }
            catch (Exception lcEx)
            {
                MessageBox.Show(lcEx.Message.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void lstBicycles_DoubleClick(object sender, EventArgs e)
        {
            try
            {
               frmBicycle.Run(lstBicycles.SelectedItem as string);
            }
            catch (Exception lcEx)
            {
                MessageBox.Show(lcEx.Message);
            }
        }

        private async void btnDeleteBike_Click(object sender, EventArgs e)
        {
            try
            {
                int lcIndex = lstBicycles.SelectedIndex;

                if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting Bicycle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show(await ServiceClient.DeleteBicycleAsync(lstBicycles.SelectedItem as clsBicycle));
                    refreshFormFromDB(_Brand.BrandName);
                }
            }
            catch (Exception lcEx)
            {
                MessageBox.Show(lcEx.Message.ToString());
            }
        }
    }
}
