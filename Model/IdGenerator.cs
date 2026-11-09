using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс генератора уникального идентификатора.
    /// </summary>
    public class IdGenerator
    {
        private static int _nextId = 1;
        
        /// <summary>
        /// Возвращает следующий уникальный идентификатор.
        /// </summary>
        /// <returns>Следующий уникальный идентификатор. </returns>
        public static int GetNextId()
        {
            return _nextId++;
        }
    }
}
