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
    public partial class ChangeOrderForm : Form
    {
        private Order CurrentOrder;
        private Order NewOrder;
        private OrderService orderService;
        public ChangeOrderForm(OrderService orderService, Order order)
        {
            InitializeComponent();
            CurrentOrder = order;
            NewOrder = CurrentOrder;
            this.orderService = orderService;
            orderBindingSource.DataSource = NewOrder;
            customerBindingSource.DataSource = NewOrder.Customer;
            detailsBindingSource.DataSource = NewOrder.Details;
            detailsBindingSource.ResetBindings(false);
        }

        public void UpdateDetails()
        {
            detailsBindingSource.DataSource = NewOrder.Details;
            detailsBindingSource.ResetBindings(false);
        }

        private void updateDetailsButton_Click(object sender, EventArgs e)
        {
            UpdateDetails();
        }

        private void addDetailButton_Click(object sender, EventArgs e)
        {
            AddDetailForm addDetailForm = new AddDetailForm(NewOrder);
            addDetailForm.Show();
        }

        private void deleteDetailButton_Click(object sender, EventArgs e)
        {
            OrderDetails detail = detailsBindingSource.Current as OrderDetails;
            if (detail == null)
            {
                MessageBox.Show("请选择要删除的订单明细！");
                return;
            }
            DialogResult result = MessageBox.Show($"确定要删除订单明细{detail.Id}吗？", "删除订单明细", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                NewOrder.Details.Remove(detail);
                UpdateDetails();
                using (var context = new OrderContext())
                {
                    context.Details.Remove(detail);
                    context.SaveChanges();
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                orderService.DeleteOrder(CurrentOrder.Id);
                orderService.AddOrder(NewOrder);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }
    }
}
