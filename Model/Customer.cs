using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс покупателя.
    /// </summary>
    public class Customer
    {
        private readonly int _id;
        private string _fullname;
        private Address _address;

        private Cart _cart;

        private List<Order> _orders;

        /// <summary>
        /// Возвращает уникальный идентификатор покупателя.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Возвращает и задает ФИО покупателя.
        /// </summary>
        public string Fullname 
        { 
            get { return _fullname; } 
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname));

                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес покупателя.
        /// </summary>
        public Address Address
        {
            get { return _address; }
        }

        /// <summary>
        /// Возвращает и задает корзину покупателя.
        /// </summary>
        public Cart Cart
        {
            get { return _cart; }
            set { _cart = value; }
        }

        /// <summary>
        /// Возвращает и задает списко заказов покупателя.
        /// </summary>
        public List<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        /// <summary>
        /// Возвращает строковое представление покупателя.
        /// </summary>
        /// <returns>ФИО покупателя..</returns>
        public override string ToString()
        {
            return $"{Id}. {Fullname}";
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">ФИО покупателя.</param>
        public Customer(string fullname)
        {
            Fullname = fullname;
            _address = new Address();

            _id = IdGenerator.GetNextId();

            _cart = new Cart();
            _orders = new List<Order>();
        }
    }
} 

