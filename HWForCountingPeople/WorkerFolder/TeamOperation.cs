using HWForCountingPeople.Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HWForCountingPeople.WorkerFolder
{
    public class TeamOperation
    {
        List<IWorker> workers;
        public TeamOperation()
        {
            workers = new List<IWorker>();
        }
        public void AddWorker()
        {
            Console.Write("Input name: ");
            string name = Console.ReadLine();
            Console.Write("Input salary: ");
            int salary = int.Parse(Console.ReadLine());
            Console.Write("Chose work place: 1 - Office, 2 - Product: ");
            string input = Console.ReadLine();
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
                Console.WriteLine("Invalid choice, person didn't added");
            }
        }
        public void RemoveWorker()
        {
            Console.WriteLine("Input id, to delete person");
            int id = int.Parse(Console.ReadLine())-1;
            if (workers.Count < id)
            {
                Console.WriteLine("Out of bound");
                return;
            }
            workers.RemoveAt(id);
        }
        public void ChangeName()
        {
            Console.WriteLine("Input person id");
            int id = int.Parse(Console.ReadLine());
            if (workers.Count < id)
            { 
                Console.WriteLine("Out of bound");
                return;
            }
            Console.WriteLine($"Old name {workers[id-1].name}");
            Console.Write("Input new name: ");
            string name = Console.ReadLine();
            workers[id-1].name = name;
            Console.WriteLine("Change complete");
        }
        public void ChangeSalary()
        {
            Console.WriteLine("Input person id");
            int id = int.Parse(Console.ReadLine());
            if (workers.Count < id)
            {
                Console.WriteLine("Out of bound");
                return;
            }
            Console.WriteLine($"Old salary {workers[id - 1].salary}");
            Console.Write("Input new salary: ");
            int salary = int.Parse(Console.ReadLine());
            workers[id-1].salary = salary;
            Console.WriteLine("Change complete");
        }

        public void ShowTeamInfo()
        {
            StringBuilder sb = new StringBuilder();
            int count = 1;
            foreach (var worker in workers)
            {
                sb.AppendLine($"{count}: Name:{worker.name}, Salary:{worker.salary}, WorkPlace:{worker.workPlace};");
                count++;
            }
            Console.WriteLine(sb.ToString());
        }
        public int GetTeamSalary()
        {
            int AllSalary = workers.Sum(x => x.salary);
            return AllSalary;
        }
        public int GetPersonCount()
        {
            return workers.Count;
        }
    }

}
