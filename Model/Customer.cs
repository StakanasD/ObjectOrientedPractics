using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс покупателя.
    /// </summary>
    public class Customer
    {
        private readonly int _id;
        private string _fullname = string.Empty;
        private Address _address = new Address();
        private Cart _cart = new Cart();
        private List<Order> _orders = new List<Order>();
        private List<IDiscount> _discounts = new List<IDiscount>();
        private bool _isPriority;

        /// <summary>
        /// Возвращает уникальный идентификатор покупателя.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает и задает полное имя покупателя (до 200 символов).
        /// </summary>
        public string Fullname
        {
            get { return _fullname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("ФИО покупателя не может быть пустым.");
                }

                ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес доставки покупателя.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value ?? new Address(); }
        }

        /// <summary>
        /// Возвращает и задает корзину товаров покупателя.
        /// </summary>
        public Cart Cart
        {
            get { return _cart; }
            set { _cart = value; }
        }

        /// <summary>
        /// Возвращает и задает список заказов покупателя.
        /// </summary>
        public List<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        /// <summary>
        /// Возвращает и задает список скидок покупателя.
        /// </summary>
        public List<IDiscount> Discounts
        {
            get { return _discounts; }
            set { _discounts = value ?? new List<IDiscount>(); }
        }

        /// <summary>
        /// Возвращает и задает признак приоритетного обслуживания покупателя.
        /// </summary>
        public bool IsPriority
        {
            get { return _isPriority; }
            set { _isPriority = value; }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя.</param>
        public Customer(string fullname)
        {
            Fullname = fullname;
            Address = new Address();
            Cart = new Cart();
            Orders = new List<Order>();
            Discounts = new List<IDiscount>
            {
                new PointsDiscount()
            };
            IsPriority = false;

            _id = IdGenerator.GetNextCustomerId();
        }

        /// <summary>
        /// Возвращает строковое представление покупателя.
        /// </summary>
        /// <returns>Идентификатор и полное имя покупателя.</returns>
        public override string ToString()
        {
            return $"{Id}. {Fullname}";
        }
    }
}