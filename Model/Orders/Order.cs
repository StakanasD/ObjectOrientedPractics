using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Класс заказа покупателя.
    /// </summary>
    public class Order // родительский 
    {
        private readonly int _id;
        private readonly DateTime _creationDate;
        private Address _address;
        private List<Item> _items;
        private OrderStatus _status;
        private double _discountAmount;

        /// <summary>
        /// Возвращает уникальный идентификатор заказа.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает дату и время создания заказа.
        /// </summary>
        public DateTime CreationDate
        {
            get { return _creationDate; }
        }

        /// <summary>
        /// Возвращает и задает адрес доставки.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// Возвращает и задает список товаров заказа.
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
        /// Возвращает общую стоимость товаров заказа без учета скидки.
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
        /// Возвращает и задает размер примененной скидки.
        /// </summary>
        public double DiscountAmount
        {
            get { return _discountAmount; }
            set { _discountAmount = value; }
        }

        /// <summary>
        /// Возвращает конечную стоимость заказа с учетом примененной скидки.
        /// </summary>
        public double Total
        {
            get
            {
                double total = Amount - DiscountAmount;
                return total < 0 ? 0.0 : total;
            }
        }

        /// <summary>
        /// Создает пустой заказ со значениями по умолчанию.
        /// </summary>
        public Order()
        {
            _id = IdGenerator.GetNextOrderId();
            _creationDate = DateTime.Now;
            _address = new Address();
            _items = new List<Item>();
            _status = OrderStatus.New;
            _discountAmount = 0.0;
        }

        /// <summary>
        /// Создает заказ с заданными параметрами.
        /// </summary>
        /// <param name="id">Уникальный идентификатор заказа.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров заказа.</param>
        /// <param name="status">Статус заказа.</param>
        public Order(int id, Address address, List<Item> items, OrderStatus status)
        {
            _id = id;
            _creationDate = DateTime.Now;
            _address = address;
            _items = items;
            _status = status;
            _discountAmount = 0.0;
        }
    }
}