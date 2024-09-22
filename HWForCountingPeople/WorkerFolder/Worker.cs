using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWForCountingPeople.Worker
{

    public class OfficeWorker : IWorker
    {

        public string name { get; set; }
        public string workPlace { get;}
        public int salary { get; set; }
        public OfficeWorker (string name, int salary) 
        { 
            this.name = name;
            workPlace = "Office";
            this.salary = salary;
        }
    }

    public class ProductWorker : IWorker
    {
        public string name { get; set; }
        public string workPlace { get;}
        public int salary { get; set; }
        public ProductWorker(string name, int salary)
        { 
            this.name = name;
            workPlace = "Product";
            this.salary = salary;
        }
    }

}
