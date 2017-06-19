using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BenjisBicycleUniversal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public partial class pgBrandDetails : Page
    {
        public pgBrandDetails()
        {
            InitializeComponent();
        }        

        private static Dictionary<string, pgBrandDetails> _BicyclePageList = new Dictionary<string, pgBrandDetails>();

        private clsBrand _Brand;    

        public void SetDetails(clsBrand prBrand)
        {
            _Brand = prBrand;
            UpdateForm();
            UpdateDisplay();            
        }

        private void UpdateDisplay()
        {
            try
            {
                _Brand.BrandName = tbBrandName.Text;
                _Brand.BrandContactPhone = tbBrandContactPh.Text;
                _Brand.WarrantyPeriod = tbBrandWarranty.Text;

                lstBicycles.ItemsSource = null;
                if (_Brand.BicycleList != null)
                    lstBicycles.ItemsSource = _Brand.BicycleList;
            }
            catch (Exception lcEx)
            {
                tbMessages.Text = lcEx.Message.ToString();
            }
        }

        public void UpdateForm()
        {
            try
            {
                tbBrandName.Text = _Brand.BrandName;
                tbBrandContactPh.Text = _Brand.BrandContactPhone;
                tbBrandWarranty.Text = _Brand.WarrantyPeriod;
            }
            catch (Exception lcEx)
            {
                tbMessages.Text = lcEx.Message.ToString();
            }           
        }

        private async void refreshFormFromDB(string prBrandName)
        {
            SetDetails(await ServiceClient.GetBrandAsync(prBrandName));
        }
                      

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter != null)
            {
                string lcBrandName = e.Parameter.ToString();
                
                try
                {
                    _Brand = await ServiceClient.GetBrandAsync(lcBrandName);
                }
                catch (Exception lcEx)
                {
                    tbMessages.Text = lcEx.Message.ToString();
                }                   
               
                UpdateForm();
                UpdateDisplay();               
            }
            else 
                _Brand = new clsBrand();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(pgMain), null);
        }
    }
}
