using System;
using System.Windows.Forms;

namespace BenjisBicyclesWinForm
{
    public sealed partial class frmOrders : Form
    {

        public static readonly frmOrders _Instance = new frmOrders();

        private frmOrders()
        {
            InitializeComponent();
            UpdateDisplay();
        }

        private clsOrder _Order;        

        public async void UpdateDisplay()
        {
            try
            {
                lstOrders.DataSource = null;
                lstOrders.DataSource = await ServiceClient.GetOrdersAsync();
                lblTotalValue.Text = null;
                var lcTotalOrdersValue = string.Join(",", await ServiceClient.GetTotalOrderValueAsync()); //converts list into string
                lblTotalValue.Text = lcTotalOrdersValue;
            }
            catch (Exception lcEx)
            {
                MessageBox.Show(lcEx.Message, "Error updating list");
            }
        }

        public void SetDetails(clsOrder prOrder)
        {
            _Order = prOrder;
            UpdateDisplay();
            Show();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void lstOrders_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                frmCustomerOrder.Run(lstOrders.SelectedItem as string);
            }
            catch (Exception lcEx)
            {
                MessageBox.Show(lcEx.Message, "Error");
            }
        }

        private async void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int lcIndex = lstOrders.SelectedIndex;

                if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await ServiceClient.DeleteOrderAsync(lstOrders.SelectedItem as clsOrder);                    
                }
            }
            catch (Exception lcEx)
            {
                MessageBox.Show(lcEx.Message.ToString());
            }
        }       
    }
}