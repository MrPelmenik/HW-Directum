using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWForCountingPeople.Worker
{
    /// <summary>
    /// Офисник
    /// </summary>
    public class OfficeWorker : IWorker
    {
        #region Свойства

        public string Name { get; set; }

        public string WorkPlace { get; }

        public int Salary { get; set; }

        #endregion

        #region Конструктор

        public OfficeWorker (string name, int salary) 
        { 
            this.Name = name;
            WorkPlace = "Office";
            this.Salary = salary;
        }

        #endregion
    }
}
