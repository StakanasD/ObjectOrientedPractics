using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Класс накопительной балльной скидки.
    /// </summary>
    public class PointsDiscount : IDiscount, IComparable<PointsDiscount>
    {
        private int _points;

        /// <summary>
        /// Возвращает количество накопленных баллов.
        /// </summary>
        public int Points
        {
            get { return _points; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Количество баллов не может быть отрицательным.");
                }

                _points = value;
            }
        }

        /// <summary>
        /// Возвращает текстовую информацию о накопительной скидке.
        /// </summary>
        public string Info
        {
            get { return $"Накопительная - {Points} баллов"; }
        }

        /// <summary>
        /// Создает экземпляр накопительной скидки с нулевым балансом баллов.
        /// </summary>
        public PointsDiscount()
        {
            Points = 0;
        }

        /// <summary>
        /// Создает экземпляр накопительной скидки с заданным количеством баллов.
        /// </summary>
        /// <param name="points">Начальное количество баллов.</param>
        public PointsDiscount(int points)
        {
            Points = points;
        }

        /// <summary>
        /// Рассчитывает доступную скидку в баллах (не более 30% от общей стоимости товаров).
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер доступной скидки.</returns>
        public double Calculate(List<Item> items)
        {
            if (items == null || items.Count == 0 || Points == 0)
            {
                return 0.0;
            }

            double totalAmount = GetTotalAmount(items);
            int maxDiscount = (int)Math.Floor(totalAmount * 0.3);

            return Points <= maxDiscount ? Points : maxDiscount;
        }

        /// <summary>
        /// Применяет накопительную скидку, списывая использованные баллы.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер примененной скидки.</returns>
        public double Apply(List<Item> items)
        {
            int discount = (int)Calculate(items);
            Points -= discount;
            return discount;
        }

        /// <summary>
        /// Начисляет баллы в размере 10% от общей стоимости товаров с округлением вверх.
        /// </summary>
        /// <param name="items">Список купленных товаров.</param>
        public void Update(List<Item> items)
        {
            if (items == null || items.Count == 0)
            {
                return;
            }

            double totalAmount = GetTotalAmount(items);
            int addedPoints = (int)Math.Ceiling(totalAmount * 0.1);
            Points += addedPoints;
        }

        /// <summary>
        /// Вычисляет общую стоимость списка товаров.
        /// </summary>
        private static double GetTotalAmount(List<Item> items)
        {
            double amount = 0.0;
            foreach (Item item in items)
            {
                amount += item.Cost;
            }

            return amount;
        }

        /// <inheritdoc />
        public int CompareTo(PointsDiscount? other)
        {
            if (other is null)
            {
                return 1;
            }

            return Points.CompareTo(other.Points);
        }
    }
}