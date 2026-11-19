using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка для работы с единичным заказом приоритетного обслуживания.
    /// </summary>
    public partial class PriorityOrdersTab : UserControl
    {
        private PriorityOrder _currentOrder;
        private List<Item> _items = new List<Item>();
        private readonly Random _random = new Random();

        /// <summary>
        /// Возвращает и задает коллекцию доступных товаров магазина.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value ?? new List<Item>(); }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PriorityOrdersTab"/>.
        /// </summary>
        public PriorityOrdersTab()
        {
            InitializeComponent();

            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                OrdersStatusComboBox.Items.Add(status);
            }

            foreach (string time in PriorityOrder.AllowedDeliveryTimes)
            {
                DeliveryTimeComboBox.Items.Add(time);
            }

            _currentOrder = new PriorityOrder();
            UpdateOrderInfo();
        }

        private void UpdateOrderInfo()
        {
            if (_currentOrder == null)
            {
                return;
            }

            OrdersIdTextBox.Text = _currentOrder.Id.ToString();
            OrdersDateTextBox.Text = _currentOrder.CreationDate.ToString();
            OrdersStatusComboBox.SelectedItem = _currentOrder.Status;
            DeliveryTimeComboBox.SelectedItem = _currentOrder.DeliveryTime;
            addressControl1.Address = _currentOrder.Address;

            UpdateItemsList();
        }

        private void UpdateItemsList()
        {
            OrdersItemsListBox.Items.Clear();

            if (_currentOrder?.Items != null)
            {
                foreach (Item item in _currentOrder.Items)
                {
                    OrdersItemsListBox.Items.Add(item);
                }
            }

            OrderAmountLabel.Text = _currentOrder != null
                ? _currentOrder.Amount.ToString("N2")
                : 0.0.ToString("N2");
        }

        private void OrdersStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentOrder == null || OrdersStatusComboBox.SelectedItem == null)
            {
                return;
            }

            _currentOrder.Status = (OrderStatus)OrdersStatusComboBox.SelectedItem;
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentOrder == null || DeliveryTimeComboBox.SelectedItem == null)
            {
                return;
            }

            string? selectedTime = DeliveryTimeComboBox.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(selectedTime))
            {
                _currentOrder.DeliveryTime = selectedTime;
            }
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            if (_currentOrder == null)
            {
                return;
            }

            Item newItem;
            if (_items != null && _items.Count > 0)
            {
                newItem = _items[_random.Next(_items.Count)];
            }
            else
            {
                Category[] categories = Enum.GetValues<Category>();
                Category category = categories[_random.Next(categories.Length)];
                double cost = Math.Round(_random.NextDouble() * 5000 + 100, 2);
                newItem = new Item(
                    $"Товар #{_random.Next(100, 999)}",
                    "Случайно сгенерированный товар",
                    cost,
                    category);
            }

            _currentOrder.Items.Add(newItem);
            UpdateItemsList();
        }

        private void RemoveItemBtn_Click(object sender, EventArgs e)
        {
            if (_currentOrder == null || OrdersItemsListBox.SelectedIndex < 0)
            {
                return;
            }

            int selectedIndex = OrdersItemsListBox.SelectedIndex;
            _currentOrder.Items.RemoveAt(selectedIndex);
            UpdateItemsList();

            if (OrdersItemsListBox.Items.Count > 0)
            {
                OrdersItemsListBox.SelectedIndex = selectedIndex < OrdersItemsListBox.Items.Count
                    ? selectedIndex
                    : OrdersItemsListBox.Items.Count - 1;
            }
        }

        private void ClearOrderBtn_Click(object sender, EventArgs e)
        {
            _currentOrder = new PriorityOrder();
            UpdateOrderInfo();
        }
    }
}