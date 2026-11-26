using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Класс накопительной процентной скидки на определенную категорию товаров.
    /// </summary>
    public class PercentDiscount : IDiscount, IComparable<PercentDiscount>
    {
        private int _percent = 1;
        private double _totalSpent;

        /// <summary>
        /// Возвращает текущий процент скидки (от 1% до 10%).
        /// </summary>
        public int Percent
        {
            get { return _percent; }
            private set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentException("Процент скидки должен находиться в диапазоне от 1 до 10.");
                }

                _percent = value;
            }
        }

        /// <summary>
        /// Возвращает категорию товаров, на которую распространяется скидка.
        /// </summary>
        public Category Category { get; }

        /// <summary>
        /// Возвращает общую сумму покупок товаров данной категории.
        /// </summary>
        public double TotalSpent
        {
            get { return _totalSpent; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Сумма покупок не может быть отрицательной.");
                }

                _totalSpent = value;
            }
        }

        /// <summary>
        /// Возвращает текстовую информацию о процентной скидке.
        /// </summary>
        public string Info
        {
            get { return $"Процентная \"{Category}\" - {Percent}%"; }
        }

        /// <summary>
        /// Создает экземпляр процентной скидки для указанной категории товаров.
        /// </summary>
        /// <param name="category">Категория товаров.</param>
        public PercentDiscount(Category category)
        {
            Category = category;
            Percent = 1;
            TotalSpent = 0.0;
        }

        /// <summary>
        /// Рассчитывает размер скидки для товаров соответствующей категории.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки.</returns>
        public double Calculate(List<Item> items)
        {
            if (items == null || items.Count == 0)
            {
                return 0.0;
            }

            double categoryAmount = GetCategoryAmount(items);
            return Math.Round(categoryAmount * Percent / 100.0, 2);
        }

        /// <summary>
        /// Применяет процентную скидку к списку товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер примененной скидки.</returns>
        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

        /// <summary>
        /// Увеличивает сумму покупок по категории и повышает процент скидки на 1% за каждую 1000 рублей (до 10%).
        /// </summary>
        /// <param name="items">Список купленных товаров.</param>
        public void Update(List<Item> items)
        {
            if (items == null || items.Count == 0)
            {
                return;
            }

            double categoryAmount = GetCategoryAmount(items);
            TotalSpent += categoryAmount;

            int calculatedPercent = 1 + (int)(TotalSpent / 1000);
            Percent = Math.Min(10, calculatedPercent);
        }

        /// <summary>
        /// Вычисляет суммарную стоимость товаров, относящихся к категории скидки.
        /// </summary>
        private double GetCategoryAmount(List<Item> items)
        {
            double amount = 0.0;
            foreach (Item item in items)
            {
                if (item.Category == Category)
                {
                    amount += item.Cost;
                }
            }

            return amount;
        }

        /// <inheritdoc />
        public int CompareTo(PercentDiscount? other)
        {
            if (other is null)
            {
                return 1;
            }

            return Percent.CompareTo(other.Percent);
        }
    }
}