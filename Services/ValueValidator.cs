using System;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Сервисный класс валидации значений свойств.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверяет, что длина строки не превышает указанное максимальное значение.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="maxLength">Максимальная допустимая длина строки.</param>
        /// <param name="propertyName">Имя проверяемого свойства.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если длина строки больше максимальной допустимой длины.</exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value != null && value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов.");
            }
        }
    }
}