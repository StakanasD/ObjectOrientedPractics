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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        public CartsTab()
        {
            InitializeComponent();
        }

        private List<Item> _items;
        private List<Customer> _customers;
        private Customer _currentCustomer;

        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        public void RefreshData()
        {
            UpdateItemsListBox();
            UpdateCustomersComboBox();
            UpdateCartListBox();
        }

        private void UpdateItemsListBox()
        {
            CartItemsListBox.Items.Clear();

            if (_items == null) return;

            foreach (Item item in _items)
                CartItemsListBox.Items.Add(item);
        }

        private void UpdateCustomersComboBox()
        {
            CartCustomerComboBox.Items.Clear();

            if (_customers == null) return;

            foreach (Customer customer in _customers)
                CartCustomerComboBox.Items.Add(customer);
        }

        private void UpdateCartListBox()
        {
            CartListBox.Items.Clear();

            if (_currentCustomer == null || _currentCustomer.Cart == null)
            {
                AmountLabel.Text = "0.0";
                return;
            }

            foreach (Item item in _currentCustomer.Cart.Items)
                CartListBox.Items.Add(item);

            AmountLabel.Text = _currentCustomer.Cart.Amount.ToString();
        }

        private void CartCustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentCustomer = CartCustomerComboBox.SelectedItem as Customer;

            UpdateCartListBox();
        }

        private void CartAddBtn_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                MessageBox.Show("Сначала выберите покупателя.");
                return;
            }

            if (CartItemsListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите товар для добавления в корзину.");
                return;
            }

            Item selectedItem = CartItemsListBox.SelectedItem as Item;

            _currentCustomer.Cart.Items.Add(selectedItem);

            UpdateCartListBox();
        }

        private void RemoveItemBtn_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                MessageBox.Show("Сначала выберите покупателя.");
                return;
            }

            if (CartListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите товар для удаления из корзины.");
                return;
            }

            Item selectedItem = CartListBox.SelectedItem as Item;

            _currentCustomer?.Cart.Items.Remove(selectedItem);

            UpdateCartListBox();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                MessageBox.Show("Сначала выберите покупателя.");
                return;
            }

            _currentCustomer.Cart.Items.Clear();

            UpdateCartListBox();
        }

        private void CreateOrderBtn_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                MessageBox.Show("Сначала выберите покупателя.");
                return;
            }

            if (_currentCustomer.Cart.Items.Count == 0)
            {
                MessageBox.Show("Корзина пуста.");
                return;
            }

            List<Item> orderItem = new List<Item>(_currentCustomer.Cart.Items);

            int id = GenerateOrderId();

            Order order = new Order(id, _currentCustomer.Address, orderItem, Model.Enums.OrderStatus.New);

            _currentCustomer.Orders.Add(order);

            _currentCustomer.Cart.Items.Clear();

            UpdateCartListBox();
        }

        private int GenerateOrderId()
        {
            int maxId = 0;

            if (_customers == null) return 1;

            foreach (Customer customer in _customers)
            {
                foreach (Order order in customer.Orders)
                {
                    if (order.Id >  maxId)
                        maxId = order.Id;
                }
            }

            return maxId + 1;
        }
    }
}
