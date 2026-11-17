using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка управления списком товаров.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Возвращает и задает список отображаемых товаров.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value ?? new List<Item>();

                ItemsListBox.Items.Clear();
                foreach (Item item in _items)
                {
                    ItemsListBox.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            CategoryComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Обновляет отображение выбранного товара в списке.
        /// </summary>
        private void RefreshSelectedItem()
        {
            int selectedIndex = ItemsListBox.SelectedIndex;
            if (selectedIndex < 0)
            {
                return;
            }

            ItemsListBox.Items.RemoveAt(selectedIndex);
            ItemsListBox.Items.Insert(selectedIndex, _items[selectedIndex]);
            ItemsListBox.SelectedIndex = selectedIndex;
        }

        private void ItemsAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Item item = new Item("Новый товар", "Описание товара", 0, Category.Electronics);

                _items.Add(item);
                ItemsListBox.Items.Add(item);
                ItemsListBox.SelectedItem = item;
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is not Item item)
            {
                return;
            }

            IDTextBox.Text = item.Id.ToString();
            NameTextBox.Text = item.Name;
            InfoTextBox.Text = item.Info;
            CostTextBox.Text = item.Cost.ToString();
            CategoryComboBox.SelectedItem = item.Category;
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is not Item item)
            {
                return;
            }

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

        private void InfoTextBox_Leave(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is not Item item)
            {
                return;
            }

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

        private void CostTextBox_Leave(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is not Item item)
            {
                return;
            }

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

        private void ItemsRemoveBtn_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is not Item item)
            {
                MessageBox.Show("Выберите товар для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _items.Remove(item);
            ItemsListBox.Items.Remove(item);

            IDTextBox.Clear();
            NameTextBox.Clear();
            InfoTextBox.Clear();
            CostTextBox.Clear();
            CategoryComboBox.SelectedIndex = -1;

            NameTextBox.BackColor = Color.White;
            InfoTextBox.BackColor = Color.White;
            CostTextBox.BackColor = Color.White;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null)
            {
                NameTextBox.BackColor = Color.White;
                return;
            }

            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || NameTextBox.Text.Length > 200)
            {
                NameTextBox.BackColor = Color.LightPink;
            }
            else
            {
                NameTextBox.BackColor = Color.White;
            }
        }

        private void InfoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null)
            {
                InfoTextBox.BackColor = Color.White;
                return;
            }

            if (string.IsNullOrWhiteSpace(InfoTextBox.Text) || InfoTextBox.Text.Length > 1000)
            {
                InfoTextBox.BackColor = Color.LightPink;
            }
            else
            {
                InfoTextBox.BackColor = Color.White;
            }
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null)
            {
                CostTextBox.BackColor = Color.White;
                return;
            }

            if (!double.TryParse(CostTextBox.Text, out double cost) || cost < 0 || cost > 100000)
            {
                CostTextBox.BackColor = Color.LightPink;
            }
            else
            {
                CostTextBox.BackColor = Color.White;
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is Item item &&
                CategoryComboBox.SelectedItem is Category category)
            {
                item.Category = category;
            }
        }
    }
}