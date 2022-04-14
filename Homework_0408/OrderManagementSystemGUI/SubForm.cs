using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagementSystem;

namespace OrderManagementSystemGUI
{
    public partial class SubForm : Form
    {
        private Client client = new Client();
        private Order order;
        private OrderDetail detail = new OrderDetail();
        private List<OrderDetail> details = new List<OrderDetail>();
        public SubForm()
        {
            InitializeComponent();
        }

        private void ShowErrorMessage(string message) => MessageBox.Show(message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

        private void SubForm_Load(object sender, EventArgs e)
        {
            txtClientID.DataBindings.Add("Text", this.client, "ClientId");
            txtClientName.DataBindings.Add("Text", this.client, "Name");
            txtGoodName.DataBindings.Add("Text", detail.Goods, "GoodsName");
            txtSinglePrice.DataBindings.Add("Text", detail.Goods, "GoodsPrice");
            txtAmount.DataBindings.Add("Text", detail, "Count");
            txtDiscount.DataBindings.Add("Text", detail, "Discount");

            detailsBindingSource.DataSource = this.details;

            order = new Order(client);
        }

        private void btnAddDetial_Click(object sender, EventArgs e)
        {
            this.detail.Goods = new Goods(txtGoodName.Text, Double.Parse(txtSinglePrice.Text));
            this.detail.Count = Int32.Parse(txtAmount.Text);
            this.detail.Discount = Double.Parse(txtDiscount.Text);
            this.details.Add(detail);
            this.order.AddDetail(detail);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (this.order.OrderDetails.Count == 0)
                ShowErrorMessage("No order detail!");
            this.order.Client.Name = txtClientName.Text;
            this.order.Client.ClientId = txtClientID.Text;
            try
            {
                OrderService.AddOrder(order);
            }
            catch (Exception exception)
            {
                if (exception.Message.Equals("Order has already existed."))
                    ShowErrorMessage("Order has already existed.");
            }
            finally
            {
                this.Close();
            }

            Console.WriteLine(OrderService.orders.Count);
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "0";
            txtClientID.Text = "";
            txtClientName.Text = "";
            txtDiscount.Text = "1";
            txtGoodName.Text = "";
            txtSinglePrice.Text = "0";
            this.Close();

        }

        
    }
}
