using System;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Forms
{
    /// <summary>
    /// Диалоговое окно добавления процентной скидки на выбранную категорию товаров.
    /// </summary>
    public partial class AddDiscountForm : Form
    {
        /// <summary>
        /// Возвращает выбранную категорию товаров для новой скидки.
        /// </summary>
        public Category SelectedCategory { get; private set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AddDiscountForm"/>.
        /// </summary>
        public AddDiscountForm()
        {
            InitializeComponent();

            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            if (CategoryComboBox.Items.Count > 0)
            {
                CategoryComboBox.SelectedIndex = 0;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedItem is Category category)
            {
                SelectedCategory = category;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}