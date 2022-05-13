using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderSystem;

namespace OrderSystemWinForm
{
    public partial class CreateOrderForm : Form
    {
        private OrderService orderService;
        private Order order;
        public CreateOrderForm(OrderService orderService, Order order)
        {
            InitializeComponent();
            this.orderService = orderService;
            this.order = order;
        }

        public void UpdateDetails()
        {
            detailsBindingSource.DataSource = order.Details;
            detailsBindingSource.ResetBindings(false);
        }

        private void addDetailsButton_Click(object sender, EventArgs e)
        {
            AddDetailForm addDetailForm = new AddDetailForm(order);
            addDetailForm.Show();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                order.Id = Convert.ToInt32(orderIdTextBox.Text);
                order.Customer = new Customer(customerNameTextBox.Text);
                orderService.AddOrder(order);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateDetailsButton_Click(object sender, EventArgs e)
        {
            UpdateDetails();
        }

        private void deleteDetailsButton_Click(object sender, EventArgs e)
        {
            detailsBindingSource.DataSource = order.Details;
            OrderDetails detail = detailsBindingSource.Current as OrderDetails;
            if (detail == null)
            {
                MessageBox.Show("请选择要删除的订单明细！");
                return;
            }
            DialogResult result = MessageBox.Show($"确定要删除订单明细{detail.Id}吗？", "删除订单明细", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                order.Details.Remove(detail);
                UpdateDetails();
            }
        }

        private void changeDetailsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
