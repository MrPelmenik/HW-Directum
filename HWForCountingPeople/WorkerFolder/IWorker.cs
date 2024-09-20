using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWForCountingPeople
{
    /// <summary>
    /// Интерфейс работяга
    /// </summary>
    internal interface IWorker // Сделаем рабочего и офисника
    {
        /// <summary>
        /// Имя
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Рабочее место
        /// </summary>
        string WorkPlace { get; }

        /// <summary>
        /// Зарплата
        /// </summary>
        int Salary { get; set; }
    }
}
