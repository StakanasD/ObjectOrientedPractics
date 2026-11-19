using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.View.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка управления списком покупателей и их скидками.
    /// </summary>
    public partial class CustomerTab : UserControl
    {
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Возвращает и задает список отображаемых покупателей.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value ?? new List<Customer>();

                CustomersListBox.Items.Clear();
                foreach (Customer customer in _customers)
                {
                    CustomersListBox.Items.Add(customer);
                }
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CustomerTab"/>.
        /// </summary>
        public CustomerTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет отображение скидок выбранного покупателя.
        /// </summary>
        public void RefreshDiscounts()
        {
            if (CustomersListBox.SelectedItem is Customer customer)
            {
                UpdateDiscountsListBox(customer);
            }
        }

        private void UpdateDiscountsListBox(Customer? customer)
        {
            DiscountsListBox.Items.Clear();

            if (customer == null || customer.Discounts == null)
            {
                return;
            }

            foreach (IDiscount discount in customer.Discounts)
            {
                DiscountsListBox.Items.Add(discount.Info);
            }
        }

        private void RefreshSelectedCustomer()
        {
            int selectedIndex = CustomersListBox.SelectedIndex;
            if (selectedIndex < 0)
            {
                return;
            }

            CustomersListBox.Items.RemoveAt(selectedIndex);
            CustomersListBox.Items.Insert(selectedIndex, _customers[selectedIndex]);
            CustomersListBox.SelectedIndex = selectedIndex;
        }

        private void CustomersAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer("Новый покупатель");

                _customers.Add(customer);
                CustomersListBox.Items.Add(customer);
                CustomersListBox.SelectedItem = customer;
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem is not Customer customer)
            {
                return;
            }

            IDCustomerTextBox.Text = customer.Id.ToString();
            NameCustomerTextBox.Text = customer.Fullname;
            IsPriorityCheckBox.Checked = customer.IsPriority;
            addressControl1.Address = customer.Address;
            UpdateDiscountsListBox(customer);
        }

        private void NameCustomerTextBox_Leave(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem is not Customer customer)
            {
                return;
            }

            try
            {
                customer.Fullname = NameCustomerTextBox.Text;
                RefreshSelectedCustomer();
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NameCustomerTextBox.Text = customer.Fullname;
            }
        }

        private void CustomersRemoveBtn_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem is not Customer customer)
            {
                MessageBox.Show("Выберите покупателя для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _customers.Remove(customer);
            CustomersListBox.Items.Remove(customer);

            IDCustomerTextBox.Clear();
            NameCustomerTextBox.Clear();
            NameCustomerTextBox.BackColor = Color.White;
            IsPriorityCheckBox.Checked = false;
            addressControl1.Address = new Address();
            UpdateDiscountsListBox(null);
        }

        private void NameCustomerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem == null)
            {
                NameCustomerTextBox.BackColor = Color.White;
                return;
            }

            if (string.IsNullOrWhiteSpace(NameCustomerTextBox.Text) || NameCustomerTextBox.Text.Length > 200)
            {
                NameCustomerTextBox.BackColor = Color.LightPink;
            }
            else
            {
                NameCustomerTextBox.BackColor = Color.White;
            }
        }

        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem is Customer customer)
            {
                customer.IsPriority = IsPriorityCheckBox.Checked;
            }
        }

        private void AddDiscountBtn_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem is not Customer customer)
            {
                MessageBox.Show("Сначала выберите покупателя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using AddDiscountForm form = new AddDiscountForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                PercentDiscount discount = new PercentDiscount(form.SelectedCategory);
                customer.Discounts.Add(discount);
                UpdateDiscountsListBox(customer);
            }
        }

        private void RemoveDiscountBtn_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem is not Customer customer)
            {
                MessageBox.Show("Сначала выберите покупателя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = DiscountsListBox.SelectedIndex;
            if (selectedIndex < 0)
            {
                MessageBox.Show("Выберите скидку для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedIndex == 0 || customer.Discounts[selectedIndex] is PointsDiscount)
            {
                MessageBox.Show("Накопительную скидку удалить нельзя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            customer.Discounts.RemoveAt(selectedIndex);
            UpdateDiscountsListBox(customer);
        }
    }
}