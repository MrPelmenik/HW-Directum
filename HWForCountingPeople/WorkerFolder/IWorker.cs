using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWForCountingPeople
{
    internal interface IWorker // Сделаем рабочего и офисника
    {
        string name { get; set; }
        string workPlace { get; }
        int salary { get; set; }
    }
}
