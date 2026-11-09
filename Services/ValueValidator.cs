using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс валидатора значений свойств.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверяет, что длина строки не превышает указанное максимальное значение.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="maxLength">Максимальное значение.</param>
        /// <param name="propertyName">Имя проверяемого свойства.</param>
        /// <exception cref="ArgumentException">Выбрасывает, если длина строки больше максимальной допустимой длины.</exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
                throw new ArgumentException($"{propertyName} не может быть больше {maxLength} символов.");

        }
    }
}
