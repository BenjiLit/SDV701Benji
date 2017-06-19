using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BenjisBicycleUniversal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class pgMain : Page
    {
        public pgMain()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateDisplay();
        }

        public async void UpdateDisplay()
        {
            try
            {
                lstBicycleBrands.ItemsSource = null;
                lstBicycleBrands.ItemsSource = await ServiceClient.GetBrandNamesAsync();
            }
            catch (Exception lcEx)
            {
                tbMessages.Text = lcEx.ToString();
            }
        }

        private void ViewBrand()
        {
            if (lstBicycleBrands.SelectedItem != null)
                Frame.Navigate(typeof(pgBrandDetails), lstBicycleBrands.SelectedItem);
        }

        private void lstBicycleBrands_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            try
            {
                ViewBrand();
            }
            catch (Exception lcEx)
            {
                tbMessages.Text = lcEx.ToString();
            }
        }
    }
}
