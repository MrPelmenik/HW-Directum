namespace HWForCountingPeople.Worker
{
    /// <summary>
    /// Заводчанин.
    /// </summary>
    public class ProductWorker : IWorker
    {
        #region IWorker

        public string Name { get; set; }

        public string WorkPlace { get;}

        public int Salary { get; set; }

        #endregion

        #region Конструктор

        public ProductWorker(string name, int salary)
        { 
            this.Name = name;
            WorkPlace = "Product";
            this.Salary = salary;
        }

        #endregion
    }
}
