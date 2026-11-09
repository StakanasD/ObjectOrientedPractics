using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Заказ покупателя.
    /// </summary>
    public class Order
    {
        private readonly int _id;
        private readonly DateTime _creationDate;
        private Address _address;
        private List<Item> _items;
        private OrderStatus _status;

        /// <summary>
        /// Возвращает уникальный идентификатор заказа.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public DateTime CreationDate { get { return _creationDate; } }

        /// <summary>
        /// Возвращает и задает адрес доставки.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// Возвращает и задает товары, входящие в заказ.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Возвращает и задает статус заказа.
        /// </summary>
        public OrderStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        /// Возвращает стоимость заказа.
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
        /// Создает заказ.
        /// </summary>
        /// <param name="id">Уникальный номер заказа.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Товары заказа.</param>
        /// <param name="status">Статус заказа.</param>
        public Order(int id, Address address, List<Item> items, OrderStatus status)
        {
            _id = id;
            _creationDate = DateTime.Now;
            _address = address;
            _items = items;
            _status = status;
        }
    }
}
