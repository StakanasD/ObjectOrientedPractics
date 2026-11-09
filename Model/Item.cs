using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс товара.
    /// </summary>
    public class Item
    {
        private readonly int _id;
        private string _name;
        private string _info;
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
        /// Получает и задает название товара.
        /// </summary>
        public string Name
        {
            get { return _name;}
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Название товара не может быть пустым.");

                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));

                _name = value;
            }
        }

        /// <summary>
        /// Получает и задает описание товара.
        /// </summary>
        public string Info
        {
            get{ return _info;}
            set
            {

                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Описание товара не может быть пустым.");

                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));

                _info = value;
            }
        }

        /// <summary>
        /// Получает и задает стоимость товара.
        /// </summary>
        public double Cost
        {
            get { return _cost;}
            set
            {
                if ((value < 0) || (value > 100000))
                    throw new ArgumentException("Стоимость товара должна быть от 0 до 100 000.");

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
        /// Возвращает строковое представление товара.
        /// </summary>
        /// <returns>Название товара.</returns>
        public override string ToString()
        {
            return $"{Id}. {Name}";
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Описание товара.</param>
        /// <param name="cost">Стоимость товара.</param>
        /// <param name="category">Категория товара.</param>
        public Item( string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;

            _id = IdGenerator.GetNextId();

            Category = category;
        }
    }
}
