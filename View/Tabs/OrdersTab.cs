using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        public OrdersTab()
        {
            InitializeComponent();

            InitializeOrdersGrid();
            InitializeStatusComboBox();
        }

        private List<Customer> _customers;
        private List<Order> _orders;
        private Order _currentOrder;

        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        private void InitializeOrdersGrid()
        {
            OrdersDataGridView.MultiSelect = false;
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToResizeRows = false;
            OrdersDataGridView.AllowUserToOrderColumns = false;
            OrdersDataGridView.ReadOnly = true;
            OrdersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            OrdersDataGridView.Columns.Clear();

            OrdersDataGridView.Columns.Add("Id", "Id");
            OrdersDataGridView.Columns.Add("CreationDate", "Дата создания");
            OrdersDataGridView.Columns.Add("Customer", "ФОИ покупателя");
            OrdersDataGridView.Columns.Add("Address", "Адрес доставки");
            OrdersDataGridView.Columns.Add("Amount", "Стоимость");
            OrdersDataGridView.Columns.Add("Status", "Статус заказа");
        }

        private void InitializeStatusComboBox()
        {
            OrdersStatusComboBox.Items.Clear();

            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
                OrdersStatusComboBox.Items.Add(status);
        }

        public void UpdateOrders()
        {
            _orders = new List<Order>();

            if (_customers == null)
            {
                OrdersDataGridView.Rows.Clear();
                return;
            }

            foreach (Customer customer in _customers)
            {
                foreach (Order order in customer.Orders)
                    _orders.Add(order);
            }

            UpdateOrdersGrid();
        }

        private void UpdateOrdersGrid()
        {
            OrdersDataGridView.Rows.Clear();

            foreach (Order order in _orders)
            {

                OrdersDataGridView.Rows.Add(
                    order.Id,
                    order.CreationDate,
                    GetCustomerByOrder(order).Fullname,
                    order.Address,
                    order.Amount,
                    order.Status);
            }
        }

        private Customer GetCustomerByOrder(Order order)
        {
            foreach (Customer customer in _customers)
            {
                if (customer.Orders.Contains(order))
                    return customer;
            }

            return null;
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.CurrentCell == null) return;

            int index = OrdersDataGridView.CurrentRow.Index;

            if (index < 0 || index >= _orders.Count) return;

            _currentOrder = _orders[index];

            OrdersIdTextBox.Text = _currentOrder.Id.ToString();
            OrdersDateTextBox.Text = _currentOrder.CreationDate.ToString();
            OrderAmountLabel.Text = _currentOrder.Amount.ToString();

            addressControl1.Address = _currentOrder.Address;

            OrdersItemsListBox.Items.Clear();

            foreach (Item item in _currentOrder.Items)
                OrdersItemsListBox.Items.Add(item);

            OrdersStatusComboBox.SelectedItem = _currentOrder.Status;
        }

        private void OrdersStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentOrder == null || OrdersStatusComboBox.SelectedItem == null) return;

            _currentOrder.Status = (OrderStatus)OrdersStatusComboBox.SelectedItem;

            if (OrdersDataGridView.CurrentRow != null)
            {
                OrdersDataGridView.CurrentRow.Cells["Status"].Value = _currentOrder.Status;
            }
        }
    }
}
