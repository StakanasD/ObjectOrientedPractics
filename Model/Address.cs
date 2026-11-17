using ObjectOrientedPractics.Services;
using System;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс адреса доставки.
    /// </summary>
    public class Address
    {
        private int _index = 100000;
        private string _country = string.Empty;
        private string _city = string.Empty;
        private string _street = string.Empty;
        private string _building = string.Empty;
        private string _apartment = string.Empty;

        /// <summary>
        /// Возвращает и задает почтовый индекс (целое шестизначное число).
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                if (value < 100000 || value > 999999)
                {
                    throw new ArgumentException("Почтовый индекс должен быть шестизначным числом.");
                }

                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и задает страну или регион (не более 50 символов).
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _country = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Возвращает и задает город (не более 50 символов).
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                _city = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Возвращает и задает улицу (не более 100 символов).
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Возвращает и задает номер дома (не более 10 символов).
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                _building = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Возвращает и задает номер квартиры или помещения (не более 10 символов).
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Создает пустой адрес со значениями по умолчанию.
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = string.Empty;
            City = string.Empty;
            Street = string.Empty;
            Building = string.Empty;
            Apartment = string.Empty;
        }

        /// <summary>
        /// Создает адрес с заданными данными.
        /// </summary>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна или регион.</param>
        /// <param name="city">Город.</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Номер дома.</param>
        /// <param name="apartment">Номер квартиры.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Возвращает строковое представление адреса.
        /// </summary>
        /// <returns>Строка с полным адресом доставки.</returns>
        public override string ToString()
        {
            return $"{Index}, {Country}, {City}, {Street}, {Building}, {Apartment}";
        }
    }
}