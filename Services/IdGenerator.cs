namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Сервисный класс генератора уникальных идентификаторов.
    /// </summary>
    public static class IdGenerator
    {
        private static int _nextItemId = 1;
        private static int _nextCustomerId = 1;
        private static int _nextOrderId = 1;

        /// <summary>
        /// Возвращает следующий уникальный идентификатор товара.
        /// </summary>
        /// <returns>Уникальный идентификатор товара.</returns>
        public static int GetNextItemId()
        {
            return _nextItemId++;
        }

        /// <summary>
        /// Возвращает следующий уникальный идентификатор покупателя.
        /// </summary>
        /// <returns>Уникальный идентификатор покупателя.</returns>
        public static int GetNextCustomerId()
        {
            return _nextCustomerId++;
        }

        /// <summary>
        /// Возвращает следующий уникальный идентификатор заказа.
        /// </summary>
        /// <returns>Уникальный идентификатор заказа.</returns>
        public static int GetNextOrderId()
        {
            return _nextOrderId++;
        }
    }
}