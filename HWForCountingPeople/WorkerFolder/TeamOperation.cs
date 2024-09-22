using HWForCountingPeople.Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HWForCountingPeople.WorkerFolder
{
    /// <summary>
    /// Операции с классом Team.
    /// </summary>
    public class TeamOperation
    {
        List<IWorker> workers;

        public TeamOperation()
        {
            workers = new List<IWorker>();
        }

        /// <summary>
        /// Добавление работника.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="salary">Зарплата.</param>
        /// <param name="input">Место работы. 1-офис, 2-завод.</param>
        /// <returns>Результат добавления работника.</returns>
        public string AddWorker(string name, int salary, string input)
        {
            if (input == "1")
            {
                IWorker worker = new OfficeWorker(name, salary);
                workers.Add(worker);
            }
            else if (input == "2")
            {
                IWorker worker = new ProductWorker(name, salary);
                workers.Add(worker);
            }
            else
            {
                return "Invalid choice, person didn't added";
            }
            return "Input complete";
        }

        /// <summary>
        /// Проверить наличие работника.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns>True-существует, false-не найден.</returns>
        public bool CheckWorker (int id)
        {
            if (workers.Count < id)
            {
                Console.WriteLine("Not found");
                return false;
            }
            var worker = workers[id-1];
            Console.WriteLine($"Name:{worker.Name}; Salary:{worker.Salary}; WorkPlace{worker.WorkPlace}");
            return true;
        }

        /// <summary>
        /// Удаление сотрудника.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Удаление успешно.</returns>
        public string RemoveWorker(int id)
        {
            workers.RemoveAt(id);
            return "Worker is deleted";
        }

        /// <summary>
        /// Смена имени работяги.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <param name="name">Новое имя.</param>
        /// <returns>Смена имени успешна.</returns>
        public string ChangeName(int id, string name)
        {
            workers[id-1].Name = name;
            return "Change complete";
        }

        /// <summary>
        /// Смена зарплаты работяги.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <param name="salary">Новая ЗП.</param>
        /// <returns>Смена ЗП успешна.</returns>
        public string ChangeSalary(int id, int salary)
        {
            workers[id-1].Salary = salary;
            return "Change complete";
        }

        /// <summary>
        /// Показ в консоли данных по пользователям.
        /// </summary>
        public void ShowTeamInfo()
        {
            StringBuilder sb = new StringBuilder();
            int count = 1;
            foreach (var worker in workers)
            {
                sb.AppendLine($"{count}: Name:{worker.Name}, Salary:{worker.Salary}, WorkPlace:{worker.WorkPlace};");
                count++;
            }
            Console.WriteLine(sb.ToString());
        }

        /// <summary>
        /// Возвращает инфорамции по зарплатам всех работяг.
        /// </summary>
        /// <returns>ЗП всех работяг.</returns>
        public int GetTeamSalary()
        {
            int AllSalary = workers.Sum(x => x.Salary);
            return AllSalary;
        }

        /// <summary>
        /// Возвращает информацию сколько всего работяг.
        /// </summary>
        /// <returns>Количество работяг.</returns>
        public int GetPersonCount()
        {
            return workers.Count;
        }
    }
}
