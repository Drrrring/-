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
    public partial class MainForm : Form
    {
        public string KeyWord { get; set; }
        //private OpenFileDialog = new OpenFileDialog();

        public MainForm()
        {
            InitializeComponent();            
            CreateOrders();
            orderBindingSource.DataSource = OrderService.orders;
            //orderDetailsBindingSource.DataSource = ((Order)orderBindingSource.Current);
            //orderDetailsBindingSource.DataMember = "OrderDetails";


            txtQueryInput.DataBindings.Add("Text", this, "KeyWord");
        }

        private void CreateOrders()
        {
            
            var order1 = new Order(new Client("Alice", "1"), new OrderDetail(new Goods("Apple", 21.3), 2));
            var order2 = new Order(new Client("Felix", "2"), new OrderDetail(new Goods("Banana", 22.3), 2));
            var order3 = new Order(new Client("Alice", "1"), new OrderDetail(new Goods("Pear", 23.3), 2));
            var order4 = new Order(new Client("Tom", "3"), new OrderDetail(new Goods("Grape", 24.3), 1),
                new OrderDetail(new Goods("Apple", 21.3), 1));
            OrderService.AddOrder(order1);
            OrderService.AddOrder(order2);
            OrderService.AddOrder(order3);
            OrderService.AddOrder(order4);
        }

       private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Order currentOrder = orderBindingSource.Current as Order;

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (txtQueryInput.Text == "" || txtQueryInput.Text == null)
            {
                orderBindingSource.DataSource = OrderService.orders;
            }
            else
            {
                orderBindingSource.DataSource = OrderService.FindOrder(Int32.Parse(txtQueryInput.Text));
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            new SubForm().ShowDialog();
            
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            Order currentOrder = orderBindingSource.Current as Order;
            OrderService.DeleteOrder(currentOrder.Id);
        }

        private void btnExportOrder_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OrderService.Export(saveFileDialog1.FileName);
                MessageBox.Show("导出成功", "好耶耶", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnImportOrder_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OrderService.Import(openFileDialog1.FileName);
                MessageBox.Show("导入成功", "好耶耶", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
