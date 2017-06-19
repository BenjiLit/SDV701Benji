using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BenjisBicyclesWinForm
{
    public partial class frmCustomerOrder : Form
    {
        public frmCustomerOrder()
        {
            InitializeComponent();
        }

        private static Dictionary<string, frmCustomerOrder> _OrderFormList = new Dictionary<string, frmCustomerOrder>();       

        private clsOrder _Order;

        public static void Run(string prOrder)
        {
            frmCustomerOrder lcOrderForm;
            if (string.IsNullOrEmpty(prOrder) ||
            !_OrderFormList.TryGetValue(prOrder, out lcOrderForm))
            {
                lcOrderForm = new frmCustomerOrder();
                if (string.IsNullOrEmpty(prOrder))
                    lcOrderForm.SetDetails(new clsOrder());
                else
                {
                    _OrderFormList.Add(prOrder, lcOrderForm);
                    lcOrderForm.refreshFormFromDB(prOrder);
                }
            }
            else
            {
                lcOrderForm.Show();
                lcOrderForm.Activate();
            }
        }

        public void SetDetails(clsOrder prOrder)
        {
            _Order = prOrder;                        
            UpdateForm();           
            Show();
        }
        
        public void UpdateForm()
        {
            txtOrderersName.Text = _Order.CustomerName;
            txtOrderesPhone.Text = _Order.CustomerPhone;
            txtItemOrdered.Text = _Order.BicycleID.ToString();
            txtOrderedQuantity.Text = _Order.ItemQuantity.ToString();
            txtOrderDate.Text = _Order.OrderDate.ToShortDateString();
            txtTotalPrice.Text = _Order.TotalPrice.ToString();
        }        

        private async void refreshFormFromDB(string prOrder)
        {
            SetDetails(await ServiceClient.GetOrderAsync(prOrder));
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
