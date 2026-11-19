using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка управления корзинами покупателей, выбора скидок и оформления заказов.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private List<Customer> _customers = new List<Customer>();
        private Customer? _currentCustomer;

        /// <summary>
        /// Возвращает и задает список доступных товаров магазина.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value ?? new List<Item>(); }
        }

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

        private Customer? CurrentCustomer
        {
            get { return _currentCustomer; }
            set
            {
                _currentCustomer = value;
                UpdateDiscountsCheckedListBox();
                UpdateCartListBox();
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CartsTab"/>.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет списки товаров, покупателей и содержимое корзины при переключении на вкладку.
        /// </summary>
        public void RefreshData()
        {
            UpdateItemsListBox();
            UpdateCustomersComboBox();
            CurrentCustomer = null;
        }

        private void UpdateItemsListBox()
        {
            CartItemsListBox.Items.Clear();

            if (_items == null)
            {
                return;
            }

            foreach (Item item in _items)
            {
                CartItemsListBox.Items.Add(item);
            }
        }

        private void UpdateCustomersComboBox()
        {
            CartCustomerComboBox.Items.Clear();
            CartCustomerComboBox.SelectedIndex = -1;

            if (_customers == null)
            {
                return;
            }

            foreach (Customer customer in _customers)
            {
                CartCustomerComboBox.Items.Add(customer);
            }
        }

        private void UpdateDiscountsCheckedListBox()
        {
            DiscountsCheckedListBox.Items.Clear();

            if (CurrentCustomer == null || CurrentCustomer.Discounts == null)
            {
                return;
            }

            foreach (IDiscount discount in CurrentCustomer.Discounts)
            {
                DiscountsCheckedListBox.Items.Add(discount.Info, true);
            }
        }

        private void UpdateCartListBox()
        {
            CartListBox.Items.Clear();

            if (CurrentCustomer == null || CurrentCustomer.Cart == null)
            {
                AmountLabel.Text = 0.0.ToString("N2");
                DiscountAmountLabel.Text = 0.0.ToString("N2");
                TotalLabel.Text = 0.0.ToString("N2");
                return;
            }

            foreach (Item item in CurrentCustomer.Cart.Items)
            {
                CartListBox.Items.Add(item);
            }

            UpdateAmounts();
        }

        private void UpdateAmounts(int changedIndex = -1, CheckState newState = CheckState.Unchecked)
        {
            if (CurrentCustomer == null || CurrentCustomer.Cart == null)
            {
                AmountLabel.Text = 0.0.ToString("N2");
                DiscountAmountLabel.Text = 0.0.ToString("N2");
                TotalLabel.Text = 0.0.ToString("N2");
                return;
            }

            double amount = CurrentCustomer.Cart.Amount;
            double discountAmount = CalculateDiscountAmount(changedIndex, newState);
            double total = amount - discountAmount;
            if (total < 0)
            {
                total = 0.0;
            }

            AmountLabel.Text = amount.ToString("N2");
            DiscountAmountLabel.Text = discountAmount.ToString("N2");
            TotalLabel.Text = total.ToString("N2");
        }

        private double CalculateDiscountAmount(int changedIndex = -1, CheckState newState = CheckState.Unchecked)
        {
            if (CurrentCustomer == null || CurrentCustomer.Cart == null || CurrentCustomer.Discounts == null)
            {
                return 0.0;
            }

            double discountSum = 0.0;
            List<Item> cartItems = CurrentCustomer.Cart.Items;

            for (int i = 0; i < CurrentCustomer.Discounts.Count && i < DiscountsCheckedListBox.Items.Count; i++)
            {
                bool isChecked = (i == changedIndex)
                    ? (newState == CheckState.Checked)
                    : DiscountsCheckedListBox.GetItemChecked(i);

                if (isChecked)
                {
                    discountSum += CurrentCustomer.Discounts[i].Calculate(cartItems);
                }
            }

            return discountSum;
        }

        private void CartCustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentCustomer = CartCustomerComboBox.SelectedItem as Customer;
        }

        private void DiscountsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UpdateAmounts(e.Index, e.NewValue);
        }

        private void CartAddBtn_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer == null)
            {
                MessageBox.Show("Сначала выберите покупателя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CartItemsListBox.SelectedItem is not Item selectedItem)
            {
                MessageBox.Show("Выберите товар для добавления в корзину.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CurrentCustomer.Cart.Items.Add(selectedItem);
            UpdateCartListBox();
        }

        private void RemoveItemBtn_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer == null)
            {
                MessageBox.Show("Сначала выберите покупателя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CartListBox.SelectedItem is not Item selectedItem)
            {
                MessageBox.Show("Выберите товар для удаления из корзины.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CurrentCustomer.Cart.Items.Remove(selectedItem);
            UpdateCartListBox();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer == null)
            {
                MessageBox.Show("Сначала выберите покупателя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CurrentCustomer.Cart.Items.Clear();
            UpdateCartListBox();
        }

        private void CreateOrderBtn_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer == null)
            {
                MessageBox.Show("Сначала выберите покупателя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CurrentCustomer.Cart.Items.Count == 0)
            {
                MessageBox.Show("Корзина пуста.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Item> orderItems = new List<Item>(CurrentCustomer.Cart.Items);
            Address sourceAddress = CurrentCustomer.Address;
            Address deliveryAddress = new Address(
                sourceAddress.Index,
                sourceAddress.Country,
                sourceAddress.City,
                sourceAddress.Street,
                sourceAddress.Building,
                sourceAddress.Apartment);

            double appliedDiscount = 0.0;
            for (int i = 0; i < CurrentCustomer.Discounts.Count && i < DiscountsCheckedListBox.Items.Count; i++)
            {
                if (DiscountsCheckedListBox.GetItemChecked(i))
                {
                    appliedDiscount += CurrentCustomer.Discounts[i].Apply(orderItems);
                }
            }

            foreach (IDiscount discount in CurrentCustomer.Discounts)
            {
                discount.Update(orderItems);
            }

            int id = IdGenerator.GetNextOrderId();
            Order order;

            if (CurrentCustomer.IsPriority)
            {
                order = new PriorityOrder(
                    id,
                    deliveryAddress,
                    orderItems,
                    OrderStatus.New,
                    DateTime.Now.Date,
                    PriorityOrder.AllowedDeliveryTimes[0]);
            }
            else
            {
                order = new Order(
                    id,
                    deliveryAddress,
                    orderItems,
                    OrderStatus.New);
            }

            order.DiscountAmount = appliedDiscount;

            CurrentCustomer.Orders.Add(order);
            CurrentCustomer.Cart.Items.Clear();

            for (int i = 0; i < CurrentCustomer.Discounts.Count && i < DiscountsCheckedListBox.Items.Count; i++)
            {
                DiscountsCheckedListBox.Items[i] = CurrentCustomer.Discounts[i].Info;
            }

            UpdateCartListBox();
        }
    }
}