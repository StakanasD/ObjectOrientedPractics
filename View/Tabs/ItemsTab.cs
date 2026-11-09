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
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
        }

        /// <summary>
        /// Хранит список товаров.
        /// </summary>
        private List<Item> _items = new();

        public List<Item> Items
        {
            get { return _items; }
            set
            {
                if (value == null)
                    _items = new List<Item>();
                else
                    _items = value;

                    ItemsListBox.Items.Clear();

                foreach (Item item in _items)
                    ItemsListBox.Items.Add(item);
            }
        }

        /// <summary>
        /// Создает новый товар, добавляет его в список и выделяет его в списке товаров.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ItemsAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Item item = new Item("Новый товар", "Описание товара", 0, Category.Electronics);

                _items.Add(item);
                ItemsListBox.Items.Add(item);

                ItemsListBox.SelectedItem = item;
            }
            catch (FormatException)
            {
                MessageBox.Show("Стоимость должна быть числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Отображает данные выбранного товара в полях редактирования.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is not Item item)
                return;

            IDTextBox.Text = item.Id.ToString();
            NameTextBox.Text = item.Name;
            InfoTextBox.Text = item.Info;
            CostTextBox.Text = item.Cost.ToString();

            CategoryComboBox.SelectedItem = item.Category;
        }

        /// <summary>
        /// Сохраняет новое название выбранного товара.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is not Item item)
                return;

            try
            {
                item.Name = NameTextBox.Text;

                RefreshSelectedItem();
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                NameTextBox.Text = item.Name;
            }
        }

        /// <summary>
        /// Обновляет отображение выбранного товара в списке.
        /// </summary>
        private void RefreshSelectedItem()
        {
            int selectedIndex = ItemsListBox.SelectedIndex;

            if (selectedIndex < 0)
                return;

            ItemsListBox.Items.RemoveAt(selectedIndex);
            ItemsListBox.Items.Insert(selectedIndex, _items[selectedIndex]);
            ItemsListBox.SelectedIndex = selectedIndex;
        }

        /// <summary>
        /// Сохраняет новое описание выбранного товара.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void InfoTextBox_Leave(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is not Item item)
                return;

            try
            {
                item.Info = InfoTextBox.Text;

                RefreshSelectedItem();
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                InfoTextBox.Text = item.Info;
            }
        }

        /// <summary>
        /// Сохраняет новую стоимость выбранного товара.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CostTextBox_Leave(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is not Item item)
                return;
            try
            {
                double cost = double.Parse(CostTextBox.Text);

                item.Cost = cost;

                RefreshSelectedItem();
            }
            catch (FormatException)
            {
                MessageBox.Show("Стоимость должна быть числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                CostTextBox.Text = item.Cost.ToString();
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                CostTextBox.Text = item.Cost.ToString();
            }
        }

        /// <summary>
        /// Удаляет выбранный товар из списка товаров и очищает поля редактирования.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ItemsRemoveBtn_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is not Item item)
            {
                MessageBox.Show("Выберите товар для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _items.Remove(item);
            ItemsListBox.Items.Remove(item);

            IDTextBox.Clear();
            NameTextBox.Clear();
            InfoTextBox.Clear();
            CostTextBox.Clear();
        }

        /// <summary>
        /// Проверяет корректность названия товара и подсвечивает поле при некорректном значении.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text) || (NameTextBox.Text.Length > 200))
            {
                NameTextBox.BackColor = Color.LightPink;
            }
            else
            {
                NameTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Проверяет корректность описания товара и подсвечивает поле при некорректном значении.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void InfoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(InfoTextBox.Text) || (InfoTextBox.Text.Length > 1000))
            {
                InfoTextBox.BackColor = Color.LightPink;
            }
            else
            {
                InfoTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Проверяет корректность стоимости товара и подсвечивает поле при некорректном значении.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(CostTextBox.Text, out double cost) || cost < 0 || cost > 100000)
            {
                CostTextBox.BackColor = Color.LightPink;
            }
            else
            {
                CostTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Обрабатывает выбор новой категории товара.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ItemsListBox.SelectedItem is Item item &&
                CategoryComboBox.SelectedItem is Category category)
                item.Category = category;
        }
    }
}