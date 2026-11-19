using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вспомогательная вкладка для тестирования расчетной механики скидок.
    /// </summary>
    public partial class DiscountsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private readonly IDiscount _discount = new PointsDiscount();

        /// <summary>
        /// Возвращает и задает список товаров для расчета тестовой скидки.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value ?? new List<Item>();
                UpdateLabels(0.0);
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="DiscountsTab"/>.
        /// </summary>
        public DiscountsTab()
        {
            InitializeComponent();
            UpdateLabels(0.0);
        }

        private void UpdateLabels(double discountAmount)
        {
            InfoLabel.Text = $"Info: {_discount.Info}";

            double total = 0.0;
            foreach (Item item in _items)
            {
                total += item.Cost;
            }

            ProductsAmountLabel.Text = total.ToString("N2");
            DiscountAmountLabel.Text = discountAmount.ToString("N2");
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            double discount = _discount.Calculate(_items);
            UpdateLabels(discount);
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            double discount = _discount.Apply(_items);
            UpdateLabels(discount);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            _discount.Update(_items);
            UpdateLabels(0.0);
        }
    }
}