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
    public partial class MainForm : Form
    {
        OrderService orderService = new OrderService();
        public string keyWords { get; set; }

        public MainForm()
        {
            InitializeComponent();
            InitOrders();
            orderBindingSource.DataSource = orderService.Orders;
            queryComboBox.SelectedIndex = 0;
            queryTextBox.DataBindings.Add("Text", this, "keyWords");
        }

        public void InitOrders()
        {
            Order order1 = new Order(1, new Customer("张三"));
            order1.Details.Add(new OrderDetails(1, new Goods("egg", 2.5), 50));
            order1.Details.Add(new OrderDetails(2, new Goods("milk", 5.5), 20));
            Order order2 = new Order(2, new Customer("李四"));
            order2.Details.Add(new OrderDetails(1, new Goods("meat", 15.5), 12));
            order2.Details.Add(new OrderDetails(2, new Goods("fish", 10.5), 15));
            order2.Details.Add(new OrderDetails(3, new Goods("tomato", 4.5), 22));
            orderService.Orders.Add(order1);
            orderService.Orders.Add(order2);
        }

        public void UpdataOrders()
        {
            orderBindingSource.DataSource = orderService.Orders;
            orderBindingSource.ResetBindings(false);
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (queryComboBox.SelectedIndex)
                {
                    case 0:
                        orderBindingSource.DataSource = orderService.Orders;
                        break;
                    case 1:
                        orderBindingSource.DataSource = orderService.SearchOrderById(Convert.ToInt32(keyWords));
                        break;
                    case 2:
                        orderBindingSource.DataSource = orderService.SearchOrdersByCustomerName(keyWords);
                        break;
                    case 3:
                        orderBindingSource.DataSource = orderService.SearchOrdersByGoodsName(keyWords);
                        break;
                    case 4:
                        orderBindingSource.DataSource = orderService.SearchOrdersByTotalPrice(Convert.ToDouble(keyWords));
                        break;
                }
                orderBindingSource.ResetBindings(false);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                string fileName = saveFileDialog.FileName;
                orderService.Export(fileName);
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                string fileName = openFileDialog.FileName;
                orderService.Import(fileName);
                UpdataOrders();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Order order = orderBindingSource.Current as Order;
            if(order == null)
            {
                MessageBox.Show("请选择要删除的订单！");
                return;
            }
            DialogResult result = MessageBox.Show($"确定要删除订单{order.Id}吗？", "删除订单", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                orderService.DeleteOrder(order.Id);
                UpdataOrders();
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            CreateOrderForm createOrderForm = new CreateOrderForm(orderService, order);
            createOrderForm.Show();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            Order order = orderBindingSource.Current as Order;
            ChangeOrderForm changeOrderForm = new ChangeOrderForm(orderService, order);
            changeOrderForm.Show();
        }
    }
}
