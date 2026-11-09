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
    public partial class CustomerTab : UserControl
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CustomerTab"/>.
        /// </summary>
        public CustomerTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Хранит список покупателей.
        /// </summary>
        private List<Customer> _customers = new();


        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                if (value == null)
                    _customers = new List<Customer>();
                else
                    _customers = value;

                CustomersListBox.Items.Clear();
                foreach (Customer customer in _customers)
                    CustomersListBox.Items.Add(customer);
            }
        }

        /// <summary>
        /// Создает нового покупателя, добавляет его в список и выделяет его в списке покупателей.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">аргументы события.</param>
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

        /// <summary>
        /// Отображает данные выбранного покупателя в полях редактирования.
        /// </summary>
        /// <param name="sender">Источнкик события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem is not Customer customer)
                return;

            IDCustomerTextBox.Text = customer.Id.ToString();
            NameCustomerTextBox.Text = customer.Fullname;
            addressControl1.Address = customer.Address;
        }

        /// <summary>
        /// Созраняет новое полное имя выбранного покупателя.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void NameCustomerTextBox_Leave(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem is not Customer customer)
                return;

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

        /// <summary>
        /// Обновляет отображение выбранного покупателя в списке.
        /// </summary>
        private void RefreshSelectedCustomer()
        {
            int selectedIndex = CustomersListBox.SelectedIndex;

            if (selectedIndex < 0)
                return;

            CustomersListBox.Items.RemoveAt(selectedIndex);
            CustomersListBox.Items.Insert(selectedIndex, _customers[selectedIndex]);
            CustomersListBox.SelectedIndex = selectedIndex;
        }

        /// <summary>
        /// Удаляет выбранного покупателя из списка покупателей и очищает поля редактирования.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CustomersRemoveBtn_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem is not Customer customer)
            {
                MessageBox.Show("Выберите покупателя для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _customers.Remove(customer);
            CustomersListBox.Items.Remove(customer);

            IDCustomerTextBox.Clear();
            NameCustomerTextBox.Clear();
        }

        /// <summary>
        /// Проверяет корректность полного имени покупателя и подсвечивает поле при некорректном значении.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void NameCustomerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameCustomerTextBox.Text) || (NameCustomerTextBox.Text.Length > 200))
            {
                NameCustomerTextBox.BackColor = Color.LightPink;
            }
            else
            {
                NameCustomerTextBox.BackColor = Color.White;
            }
        }

        private void CustomersGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}