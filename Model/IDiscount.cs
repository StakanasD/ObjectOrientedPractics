using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Интерфейс скидки на товары.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Возвращает текстовую информацию о скидке.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Рассчитывает размер скидки для переданного списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер доступной скидки.</returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Применяет скидку к списку товаров и возвращает размер предоставленной скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер примененной скидки.</returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Обновляет накопленные параметры скидки на основе совершенной покупки.
        /// </summary>
        /// <param name="items">Список купленных товаров.</param>
        void Update(List<Item> items);
    }
}