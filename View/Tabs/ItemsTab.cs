using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка управления товарами магазина с поддержкой поиска и сортировки через делегаты.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private List<Item> _displayedItems = new List<Item>();
        private bool _isUpdatingControls;

        /// <summary>
        /// Возвращает и задает общий список товаров магазина.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value ?? new List<Item>();
                UpdateDisplayedItems();
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));

            OrderByComboBox.Items.Add("Name");
            OrderByComboBox.Items.Add("Cost (Ascending)");
            OrderByComboBox.Items.Add("Cost (Descending)");
            OrderByComboBox.SelectedIndex = 0;
        }

        private void UpdateDisplayedItems()
        {
            Item? previouslySelectedItem = ItemsListBox.SelectedItem as Item;

            string searchText = FindTextBox.Text;
            List<Item> result;

            if (!string.IsNullOrEmpty(searchText))
            {
                result = DataTools.Filter(
                    _items,
                    item => item.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                result = new List<Item>(_items);
            }

            switch (OrderByComboBox.SelectedIndex)
            {
                case 1:
                    result = DataTools.Sort(result, DataTools.CompareByCostAscending);
                    break;
                case 2:
                    result = DataTools.Sort(result, DataTools.CompareByCostDescending);
                    break;
                default:
                    result = DataTools.Sort(result, DataTools.CompareByName);
                    break;
            }

            _displayedItems = result;

            _isUpdatingControls = true;
            try
            {
                ItemsListBox.Items.Clear();
                foreach (Item item in _displayedItems)
                {
                    ItemsListBox.Items.Add(item);
                }

                if (previouslySelectedItem != null)
                {
                    int index = _displayedItems.IndexOf(previouslySelectedItem);
                    if (index >= 0)
                    {
                        ItemsListBox.SelectedIndex = index;
                    }
                    else
                    {
                        ClearSelectedItemFields();
                    }
                }
                else
                {
                    ClearSelectedItemFields();
                }
            }
            finally
            {
                _isUpdatingControls = false;
            }
        }

        private void ClearSelectedItemFields()
        {
            IDItemTextBox.Clear();
            CostItemTextBox.Clear();
            CostItemTextBox.BackColor = Color.White;
            NameItemTextBox.Clear();
            NameItemTextBox.BackColor = Color.White;
            DescriptionItemTextBox.Clear();
            DescriptionItemTextBox.BackColor = Color.White;

            if (CategoryComboBox.Items.Count > 0)
            {
                CategoryComboBox.SelectedIndex = 0;
            }
        }

        private void FillSelectedItemFields(Item item)
        {
            _isUpdatingControls = true;
            try
            {
                IDItemTextBox.Text = item.Id.ToString();
                CostItemTextBox.Text = item.Cost.ToString();
                CostItemTextBox.BackColor = Color.White;
                CategoryComboBox.SelectedItem = item.Category;
                NameItemTextBox.Text = item.Name;
                NameItemTextBox.BackColor = Color.White;
                DescriptionItemTextBox.Text = item.Info;
                DescriptionItemTextBox.BackColor = Color.White;
            }
            finally
            {
                _isUpdatingControls = false;
            }
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateDisplayedItems();
        }

        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDisplayedItems();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdatingControls)
            {
                return;
            }

            if (ItemsListBox.SelectedItem is not Item selectedItem)
            {
                ClearSelectedItemFields();
                return;
            }

            FillSelectedItemFields(selectedItem);
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Item newItem = new Item("Новый товар", "Описание товара", 100.0, Category.Electronics);
                _items.Add(newItem);

                UpdateDisplayedItems();

                int newIndex = _displayedItems.IndexOf(newItem);
                if (newIndex >= 0)
                {
                    ItemsListBox.SelectedIndex = newIndex;
                }
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveItemBtn_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is not Item selectedItem)
            {
                MessageBox.Show("Выберите товар для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _items.Remove(selectedItem);
            UpdateDisplayedItems();
        }

        private void CostItemTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdatingControls || ItemsListBox.SelectedItem == null)
            {
                CostItemTextBox.BackColor = Color.White;
                return;
            }

            if (!double.TryParse(CostItemTextBox.Text, out double cost) || cost < 0 || cost > 100000)
            {
                CostItemTextBox.BackColor = Color.LightPink;
            }
            else
            {
                CostItemTextBox.BackColor = Color.White;
            }
        }

        private void CostItemTextBox_Leave(object sender, EventArgs e)
        {
            if (_isUpdatingControls || ItemsListBox.SelectedItem is not Item selectedItem)
            {
                return;
            }

            try
            {
                if (!double.TryParse(CostItemTextBox.Text, out double cost))
                {
                    throw new ArgumentException("Введите корректную стоимость товара.");
                }

                selectedItem.Cost = cost;
                UpdateDisplayedItems();
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CostItemTextBox.Text = selectedItem.Cost.ToString();
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdatingControls || ItemsListBox.SelectedItem is not Item selectedItem)
            {
                return;
            }

            if (CategoryComboBox.SelectedItem is Category category)
            {
                selectedItem.Category = category;
            }
        }

        private void NameItemTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdatingControls || ItemsListBox.SelectedItem == null)
            {
                NameItemTextBox.BackColor = Color.White;
                return;
            }

            if (string.IsNullOrWhiteSpace(NameItemTextBox.Text) || NameItemTextBox.Text.Length > 200)
            {
                NameItemTextBox.BackColor = Color.LightPink;
            }
            else
            {
                NameItemTextBox.BackColor = Color.White;
            }
        }

        private void NameItemTextBox_Leave(object sender, EventArgs e)
        {
            if (_isUpdatingControls || ItemsListBox.SelectedItem is not Item selectedItem)
            {
                return;
            }

            try
            {
                selectedItem.Name = NameItemTextBox.Text;
                UpdateDisplayedItems();
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NameItemTextBox.Text = selectedItem.Name;
            }
        }

        private void DescriptionItemTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdatingControls || ItemsListBox.SelectedItem == null)
            {
                DescriptionItemTextBox.BackColor = Color.White;
                return;
            }

            if (DescriptionItemTextBox.Text.Length > 1000)
            {
                DescriptionItemTextBox.BackColor = Color.LightPink;
            }
            else
            {
                DescriptionItemTextBox.BackColor = Color.White;
            }
        }

        private void DescriptionItemTextBox_Leave(object sender, EventArgs e)
        {
            if (_isUpdatingControls || ItemsListBox.SelectedItem is not Item selectedItem)
            {
                return;
            }

            try
            {
                selectedItem.Info = DescriptionItemTextBox.Text;
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DescriptionItemTextBox.Text = selectedItem.Info;
            }
        }
    }
}