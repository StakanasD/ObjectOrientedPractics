using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Класс заказа приоритетного обслуживания.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Допустимые диапазоны времени доставки.
        /// </summary>
        public static readonly string[] AllowedDeliveryTimes =
        {
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"
        };

        private DateTime _deliveryDate;
        private string _deliveryTime = AllowedDeliveryTimes[0];

        /// <summary>
        /// Возвращает и задает желаемую дату доставки.
        /// </summary>
        public DateTime DeliveryDate
        {
            get { return _deliveryDate; }
            set { _deliveryDate = value; }
        }

        /// <summary>
        /// Возвращает и задает желаемый диапазон времени доставки.
        /// </summary>
        public string DeliveryTime
        {
            get { return _deliveryTime; }
            set
            {
                if (!AllowedDeliveryTimes.Contains(value))
                {
                    throw new ArgumentException("Указан недопустимый диапазон времени доставки.");
                }

                _deliveryTime = value;
            }
        }

        /// <summary>
        /// Создает пустой приоритетный заказ со значениями по умолчанию.
        /// </summary>
        public PriorityOrder() : base()
        {
            DeliveryDate = DateTime.Now.Date;
            DeliveryTime = AllowedDeliveryTimes[0];
        }

        /// <summary>
        /// Создает приоритетный заказ с заданными параметрами.
        /// </summary>
        /// <param name="id">Уникальный идентификатор заказа.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров заказа.</param>
        /// <param name="status">Статус заказа.</param>
        /// <param name="deliveryDate">Желаемая дата доставки.</param>
        /// <param name="deliveryTime">Желаемое время доставки.</param>
        public PriorityOrder(
            int id,
            Address address,
            List<Item> items,
            OrderStatus status,
            DateTime deliveryDate,
            string deliveryTime)
            : base(id, address, items, status)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }
    }
}