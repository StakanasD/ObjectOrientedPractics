using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс товара магазина.
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {
        private readonly int _id;
        private string _name = string.Empty;
        private string _info = string.Empty;
        private double _cost;
        private Category _category;

        /// <summary>
        /// Возвращает уникальный идентификатор товара.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает и задает название товара (до 200 символов).
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Название товара не может быть пустым.");
                }

                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает описание товара (до 1000 символов).
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                ValueValidator.AssertStringOnLength(value ?? string.Empty, 1000, nameof(Info));
                _info = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Возвращает и задает стоимость товара (от 0 до 100 000).
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set
            {
                if (value < 0 || value > 100000)
                {
                    throw new ArgumentException("Стоимость товара должна находиться в диапазоне от 0 до 100 000.");
                }

                _cost = value;
            }
        }

        /// <summary>
        /// Возвращает и задает категорию товара.
        /// </summary>
        public Category Category
        {
            get { return _category; }
            set { _category = value; }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Описание товара.</param>
        /// <param name="cost">Стоимость товара.</param>
        /// <param name="category">Категория товара.</param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;

            _id = IdGenerator.GetNextItemId();
        }

        /// <summary>
        /// Возвращает строковое представление товара.
        /// </summary>
        /// <returns>Идентификатор, название и стоимость товара.</returns>
        public override string ToString()
        {
            return $"{Id}. {Name} ({Cost:N2})";
        }

        /// <inheritdoc />
        public object Clone()
        {
            return new Item(Name, Info, Cost, Category);
        }

        /// <inheritdoc />
        public bool Equals(Item? other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Name == other.Name
                && Info == other.Info
                && Cost.Equals(other.Cost)
                && Category == other.Category;
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

            if (obj is not Item other)
            {
                return false;
            }

            return Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Info, Cost, Category);
        }

        /// <inheritdoc />
        public int CompareTo(Item? other)
        {
            if (other is null)
            {
                return 1;
            }

            return Cost.CompareTo(other.Cost);
        }
    }
}