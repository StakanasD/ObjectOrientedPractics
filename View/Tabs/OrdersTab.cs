using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка просмотра и управления заказами покупателей.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        private List<Customer> _customers = new List<Customer>();
        private List<Order> _orders = new List<Order>();
        private Order? _selectedOrder;
        private PriorityOrder? _selectedPriorityOrder;

        /// <summary>
        /// Возвращает и задает список покупателей магазина.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value ?? new List<Customer>(); }
        }

        /// <summary>
        /// Возвращает и задает выбранный в таблице заказ.
        /// </summary>
        private Order? SelectedOrder
        {
            get { return _selectedOrder; }
            set
            {
                _selectedOrder = value;

                if (_selectedOrder == null)
                {
                    _selectedPriorityOrder = null;
                    PriorityOptionsPanel.Visible = false;
                    ClearOrderDetails();
                    return;
                }

                OrdersIdTextBox.Text = _selectedOrder.Id.ToString();
                OrdersDateTextBox.Text = _selectedOrder.CreationDate.ToString();
                OrderAmountLabel.Text = _selectedOrder.Amount.ToString("N2");
                addressControl1.Address = _selectedOrder.Address;

                OrdersItemsListBox.Items.Clear();
                if (_selectedOrder.Items != null)
                {
                    foreach (Item item in _selectedOrder.Items)
                    {
                        OrdersItemsListBox.Items.Add(item);
                    }
                }

                OrdersStatusComboBox.SelectedItem = _selectedOrder.Status;

                if (_selectedOrder is PriorityOrder priorityOrder)
                {
                    _selectedPriorityOrder = priorityOrder;
                    PriorityOptionsPanel.Visible = true;
                    DeliveryTimeComboBox.SelectedItem = _selectedPriorityOrder.DeliveryTime;
                }
                else
                {
                    _selectedPriorityOrder = null;
                    PriorityOptionsPanel.Visible = false;
                }
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="OrdersTab"/>.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();

            InitializeOrdersGrid();
            InitializeStatusComboBox();
            InitializeDeliveryTimeComboBox();
        }

        /// <summary>
        /// Обновляет данные таблицы заказов при переходе на вкладку.
        /// </summary>
        public void RefreshData()
        {
            UpdateOrders();
        }

        /// <summary>
        /// Собирает все заказы покупателей и обновляет таблицу заказов.
        /// </summary>
        public void UpdateOrders()
        {
            _orders = new List<Order>();

            if (_customers == null)
            {
                OrdersDataGridView.Rows.Clear();
                SelectedOrder = null;
                return;
            }

            foreach (Customer customer in _customers)
            {
                foreach (Order order in customer.Orders)
                {
                    _orders.Add(order);
                }
            }

            UpdateOrdersGrid();
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
            OrdersDataGridView.Columns.Add("Customer", "ФИО покупателя");
            OrdersDataGridView.Columns.Add("Address", "Адрес доставки");
            OrdersDataGridView.Columns.Add("Amount", "Стоимость");
            OrdersDataGridView.Columns.Add("Status", "Статус заказа");

            foreach (DataGridViewColumn column in OrdersDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void InitializeStatusComboBox()
        {
            OrdersStatusComboBox.Items.Clear();

            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                OrdersStatusComboBox.Items.Add(status);
            }
        }

        private void InitializeDeliveryTimeComboBox()
        {
            DeliveryTimeComboBox.Items.Clear();

            foreach (string time in PriorityOrder.AllowedDeliveryTimes)
            {
                DeliveryTimeComboBox.Items.Add(time);
            }
        }

        private void UpdateOrdersGrid()
        {
            OrdersDataGridView.Rows.Clear();

            foreach (Order order in _orders)
            {
                Customer? customer = GetCustomerByOrder(order);

                OrdersDataGridView.Rows.Add(
                    order.Id,
                    order.CreationDate,
                    customer != null ? customer.Fullname : string.Empty,
                    order.Address,
                    order.Amount.ToString("N2"),
                    order.Status);
            }

            if (_orders.Count == 0)
            {
                SelectedOrder = null;
            }
        }

        private void ClearOrderDetails()
        {
            OrdersIdTextBox.Clear();
            OrdersDateTextBox.Clear();
            OrderAmountLabel.Text = 0.0.ToString("N2");
            addressControl1.Address = new Address();
            OrdersItemsListBox.Items.Clear();
            OrdersStatusComboBox.SelectedIndex = -1;
        }

        private Customer? GetCustomerByOrder(Order order)
        {
            if (_customers == null)
            {
                return null;
            }

            foreach (Customer customer in _customers)
            {
                if (customer.Orders.Contains(order))
                {
                    return customer;
                }
            }

            return null;
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.CurrentRow == null)
            {
                SelectedOrder = null;
                return;
            }

            int index = OrdersDataGridView.CurrentRow.Index;
            if (index < 0 || index >= _orders.Count)
            {
                SelectedOrder = null;
                return;
            }

            SelectedOrder = _orders[index];
        }

        private void OrdersStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedOrder == null || OrdersStatusComboBox.SelectedItem == null)
            {
                return;
            }

            _selectedOrder.Status = (OrderStatus)OrdersStatusComboBox.SelectedItem;

            if (OrdersDataGridView.CurrentRow != null)
            {
                OrdersDataGridView.CurrentRow.Cells["Status"].Value = _selectedOrder.Status;
            }
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedPriorityOrder == null || DeliveryTimeComboBox.SelectedItem == null)
            {
                return;
            }

            string? selectedTime = DeliveryTimeComboBox.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(selectedTime))
            {
                _selectedPriorityOrder.DeliveryTime = selectedTime;
            }
        }
    }
}