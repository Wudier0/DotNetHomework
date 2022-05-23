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
    public partial class AddDetailForm : Form
    {
        private Order order;
        public AddDetailForm(Order order)
        {
            InitializeComponent();
            this.order = order;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                OrderDetails detail = new OrderDetails();
                detail.Id = Convert.ToInt32(idTextBox.Text);
                detail.Goods = new Goods(Convert.ToString(goodsNameTextBox.Text), Convert.ToDouble(priceTextBox.Text));
                detail.Amount = Convert.ToInt32(amountTextBox.Text);
                order.Details.Add(detail);
                using (var context = new OrderContext())
                {
                    context.Details.Add(detail);
                    context.SaveChanges();
                }
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
    }
}
