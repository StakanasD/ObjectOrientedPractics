using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Сервисный класс для фильтрации и сортировки коллекций товаров с использованием делегатов.
    /// </summary>
    public static class DataTools
    {
        /// <summary>
        /// Фильтрует список товаров по заданному критерию без использования LINQ.
        /// </summary>
        /// <param name="items">Исходный список товаров.</param>
        /// <param name="criterion">Делегат-предикат, определяющий условие отбора товара.</param>
        /// <returns>Новый список товаров, удовлетворяющих критерию.</returns>
        public static List<Item> Filter(List<Item> items, Func<Item, bool> criterion)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            if (criterion == null)
            {
                throw new ArgumentNullException(nameof(criterion));
            }

            List<Item> filteredItems = new List<Item>();

            foreach (Item item in items)
            {
                if (criterion(item))
                {
                    filteredItems.Add(item);
                }
            }

            return filteredItems;
        }

        /// <summary>
        /// Проверяет, превышает ли стоимость товара 5000.
        /// </summary>
        /// <param name="item">Проверяемый товар.</param>
        /// <returns><c>true</c>, если стоимость товара больше 5000; иначе <c>false</c>.</returns>
        public static bool IsCostAbove5000(Item item)
        {
            return item != null && item.Cost > 5000.0;
        }

        /// <summary>
        /// Проверяет, относится ли товар к первой категории перечисления <see cref="Category"/>.
        /// </summary>
        /// <param name="item">Проверяемый товар.</param>
        /// <returns><c>true</c>, если товар относится к первой категории; иначе <c>false</c>.</returns>
        public static bool IsFirstCategory(Item item)
        {
            Category[] categories = Enum.GetValues<Category>();
            return item != null && categories.Length > 0 && item.Category == categories[0];
        }

        /// <summary>
        /// Сортирует список товаров по заданному правилу сравнения и возвращает новый упорядоченный список.
        /// </summary>
        /// <param name="items">Исходный список товаров.</param>
        /// <param name="compare">Делегат сравнения двух товаров, возвращающий <c>true</c>, если первый товар должен идти раньше второго.</param>
        /// <returns>Новый отсортированный список товаров.</returns>
        public static List<Item> Sort(List<Item> items, Func<Item, Item, bool> compare)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            if (compare == null)
            {
                throw new ArgumentNullException(nameof(compare));
            }

            List<Item> sortedItems = new List<Item>(items);

            for (int i = 0; i < sortedItems.Count; i++)
            {
                for (int j = 1; j < sortedItems.Count; j++)
                {
                    if (compare(sortedItems[j], sortedItems[j - 1]))
                    {
                        Item temp = sortedItems[j];
                        sortedItems[j] = sortedItems[j - 1];
                        sortedItems[j - 1] = temp;
                    }
                }
            }

            return sortedItems;
        }

        /// <summary>
        /// Сортирует список товаров с помощью внешнего делегата сортировки.
        /// </summary>
        /// <param name="items">Исходный список товаров.</param>
        /// <param name="sorter">Делегат, принимающий список товаров и возвращающий новый упорядоченный список.</param>
        /// <returns>Новый отсортированный список товаров.</returns>
        public static List<Item> Sort(List<Item> items, Func<List<Item>, List<Item>> sorter)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            if (sorter == null)
            {
                throw new ArgumentNullException(nameof(sorter));
            }

            return sorter(new List<Item>(items));
        }

        /// <summary>
        /// Сравнивает два товара по названию в алфавитном порядке.
        /// </summary>
        /// <param name="item1">Первый товар.</param>
        /// <param name="item2">Второй товар.</param>
        /// <returns><c>true</c>, если первый товар должен располагаться перед вторым.</returns>
        public static bool CompareByName(Item item1, Item item2)
        {
            return string.Compare(item1.Name, item2.Name, StringComparison.OrdinalIgnoreCase) < 0;
        }

        /// <summary>
        /// Сравнивает два товара по возрастанию стоимости.
        /// </summary>
        /// <param name="item1">Первый товар.</param>
        /// <param name="item2">Второй товар.</param>
        /// <returns><c>true</c>, если стоимость первого товара меньше стоимости второго.</returns>
        public static bool CompareByCostAscending(Item item1, Item item2)
        {
            return item1.Cost < item2.Cost;
        }

        /// <summary>
        /// Сравнивает два товара по убыванию стоимости.
        /// </summary>
        /// <param name="item1">Первый товар.</param>
        /// <param name="item2">Второй товар.</param>
        /// <returns><c>true</c>, если стоимость первого товара больше стоимости второго.</returns>
        public static bool CompareByCostDescending(Item item1, Item item2)
        {
            return item1.Cost > item2.Cost;
        }
    }
}