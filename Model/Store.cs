using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс магазина, хранящий коллекции товаров и покупателей.
    /// </summary>
    public class Store
    {
        private List<Item> _items = new List<Item>();
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Возвращает и задает список товаров магазина.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value ?? new List<Item>(); }
        }

        /// <summary>
        /// Возвращает и задает список покупателей магазина.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value ?? new List<Customer>(); }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Store"/> с пустыми списками товаров и покупателей.
        /// </summary>
        public Store()
        {
            Items = new List<Item>();
            Customers = new List<Customer>();
        }
    }
}