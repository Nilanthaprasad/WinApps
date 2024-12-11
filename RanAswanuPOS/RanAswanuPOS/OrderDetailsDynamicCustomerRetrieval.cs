using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RanAswanuPOS.Entity;

namespace RanAswanuPOS
{
    public partial class OrderDetailsDynamicCustomerRetrieval : Form
    {
        public OrderDetailsDynamicCustomerRetrieval(int orderId, String customerFirstName, String customerLastName, double total, Customer customer)
        {
            InitializeComponent();
            loadGrid(orderId, customer);
            lblCustomerName.Text = customerFirstName + " " + customerLastName;
            lblTotalPrice.Text = total.ToString();
            loadCustomerData(customer);
        }
        public void loadCustomerData(Customer customer)
        {
            lblBillingFN.Text = customer.Billing_first_name;
            lblBillingLN.Text = customer.Billing_last_name;
            lblBillingPhone.Text = customer.Billing_phone;
            lblBillingCity.Text = customer.Billing_city;
            lblBillingPostCode.Text = customer.Billing_postcode;
            lblBillingEmail.Text = customer.Billing_email;
            lblBillingAddress.Text = customer.Billing_address_1 + "\n" + customer.Billing_address_2;

            lblShippingFN.Text = customer.Shipping_first_name;
            lblShippingLN.Text = customer.Shipping_last_name;
            lblShippingCity.Text = customer.Shipping_city;
            lblShippingPostCode.Text = customer.Shipping_post;
            lblShippingAddress.Text = customer.Shipping_address_1 + "\n" + customer.Shipping_address_2;
        }

        public void loadGrid(int orderId, Customer customer)
        {
            List<OrderItem> orderItems = OrderItem.getOrderItemsWithCustomerObject(orderId, customer);
            int total = 0;
            int totalItemCount = 0;
            if (orderItems.Count > 0)
            {
                int i = 0;
                OrderItem orderItem;
                while (i < orderItems.Count)
                {
                    orderItem = (OrderItem)orderItems[i];

                    dgvOrderDetails.Rows.Add(++i, orderItem.Product.ProductId, orderItem.Product.ProductName, orderItem.LineTotal / orderItem.Quantity, orderItem.Quantity, orderItem.LineTotal);
                    total = total + Convert.ToInt32(orderItem.LineTotal);
                    totalItemCount += Convert.ToInt32(orderItem.Quantity);
                }
                dgvOrderDetails.Rows.Add(++i, "", "Transport Cost", 250, "", 250);
                total += 250;
                dgvOrderDetails.Rows.Add(++i, "", "", "Total", totalItemCount, total);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
