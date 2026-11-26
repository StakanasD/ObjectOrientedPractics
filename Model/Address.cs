using ObjectOrientedPractics.Services;
using System;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс адреса доставки.
    /// </summary>
    public class Address : ICloneable, IEquatable<Address>
    {
        private int _index = 100000;
        private string _country = string.Empty;
        private string _city = string.Empty;
        private string _street = string.Empty;
        private string _building = string.Empty;
        private string _apartment = string.Empty;

        /// <summary>
        /// Событие, возникающее при изменении любого из свойств адреса доставки.
        /// </summary>
        public event EventHandler<EventArgs>? AddressChanged;

        /// <summary>
        /// Возвращает и задает почтовый индекс (шестизначное целое число).
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

                if (_index != value)
                {
                    _index = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает название страны (до 50 символов).
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                string newCountry = value ?? string.Empty;
                ValueValidator.AssertStringOnLength(newCountry, 50, nameof(Country));

                if (_country != newCountry)
                {
                    _country = newCountry;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает название города (до 50 символов).
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                string newCity = value ?? string.Empty;
                ValueValidator.AssertStringOnLength(newCity, 50, nameof(City));

                if (_city != newCity)
                {
                    _city = newCity;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает название улицы (до 100 символов).
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                string newStreet = value ?? string.Empty;
                ValueValidator.AssertStringOnLength(newStreet, 100, nameof(Street));

                if (_street != newStreet)
                {
                    _street = newStreet;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает номер дома (до 10 символов).
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                string newBuilding = value ?? string.Empty;
                ValueValidator.AssertStringOnLength(newBuilding, 10, nameof(Building));

                if (_building != newBuilding)
                {
                    _building = newBuilding;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает номер квартиры или помещения (до 10 символов).
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                string newApartment = value ?? string.Empty;
                ValueValidator.AssertStringOnLength(newApartment, 10, nameof(Apartment));

                if (_apartment != newApartment)
                {
                    _apartment = newApartment;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
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
        /// Создает адрес с заданными параметрами.
        /// </summary>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна.</param>
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
        /// <returns>Форматированная строка адреса.</returns>
        public override string ToString()
        {
            return $"{Index}, {Country}, {City}, {Street}, {Building}, {Apartment}";
        }

        /// <inheritdoc />
        public object Clone()
        {
            return new Address(Index, Country, City, Street, Building, Apartment);
        }

        /// <inheritdoc />
        public bool Equals(Address? other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Index == other.Index
                && Country == other.Country
                && City == other.City
                && Street == other.Street
                && Building == other.Building
                && Apartment == other.Apartment;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is not Address other)
            {
                return false;
            }

            return Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return HashCode.Combine(Index, Country, City, Street, Building, Apartment);
        }
    }
}