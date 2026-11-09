using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Корзина товаров покупателя.
    /// </summary>
    public class Cart
    {
        private List<Item> _items;

        /// <summary>
        /// Список товаров в корзине.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Общая стоимость всех товаров корзины.
        /// </summary>
        public double Amount
        {
            get
            {
                if (_items == null || _items.Count == 0)
                    return 0.0;

                double amount = 0.0;

                foreach (Item item in _items)
                    amount += item.Cost;

                return amount;
            }
        }

        /// <summary>
        /// Создает пустую корзину.
        /// </summary>
        public Cart()
        {
            _items = new List<Item>();
        }
    }
}
