using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс корзины товаров покупателя.
    /// </summary>
    public class Cart
    {
        private List<Item> _items; // Агрегация, корзина хранит ссылки на существующие товары 

        /// <summary>
        /// Возвращает и задает список товаров в корзине.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Возвращает общую стоимость всех товаров в корзине.
        /// </summary>
        public double Amount
        {
            get
            {
                if (_items == null || _items.Count == 0)
                {
                    return 0.0;
                }

                double amount = 0.0;

                foreach (Item item in _items)
                {
                    amount += item.Cost;
                }

                return amount;
            }
        }

        /// <summary>
        /// Создает пустую корзину товаров.
        /// </summary>
        public Cart()
        {
            _items = new List<Item>();
        }
    }
}