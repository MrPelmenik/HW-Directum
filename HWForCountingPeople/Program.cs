using HWForCountingPeople.WorkerFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWForCountingPeople
{
    internal class Program
    {
        public static void ShowMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Menu:");
            sb.AppendLine("1. Add new person");
            sb.AppendLine("2. Delete person by ID");
            sb.AppendLine("3. Show team info(ID,name,salary,workPlace)");
            sb.AppendLine("4. Show requared salary");
            sb.AppendLine("5. Change person name by ID");
            sb.AppendLine("6. Change person salary by ID");
            sb.AppendLine("0. Exit");
            sb.Append("Input: ");
            Console.Write(sb);
        }
        static void Main()
        {
            Console.WriteLine("Programm begin");

            TeamOperation team = new TeamOperation();
            while (true) 
            {
                ShowMenu();
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case (1):
                        {
                            Console.Write("Input name: ");
                            string name = Console.ReadLine();

                            Console.Write("Input salary: ");
                            int salary = int.Parse(Console.ReadLine());

                            Console.Write("Chose work place: 1 - Office, 2 - Product: ");
                            string inputWorkPlace = Console.ReadLine();

                            Console.WriteLine(team.AddWorker(name, salary, inputWorkPlace));

                            break;
                        }
                    case (2):
                        {
                            Console.WriteLine("Input person id");
                            int id = int.Parse(Console.ReadLine());

                            if (team.CheckWorker(id))
                            {
                                Console.WriteLine(team.RemoveWorker(id));
                            }

                            break;
                        }
                    case (3):
                        {
                            team.ShowTeamInfo();
                            break;
                        }
                    case (4):
                        {
                            Console.WriteLine($"Requared salary is: {team.GetTeamSalary()}, for paying {team.GetPersonCount()} worker");
                            break;
                        }
                    case (5):
                        {
                            Console.WriteLine("Input person id");
                            int id = int.Parse(Console.ReadLine());
                            if (team.CheckWorker(id))
                            {
                                Console.Write("Input new name: ");
                                string name = Console.ReadLine();

                                Console.WriteLine (team.ChangeName(id, name));
                            }
                            break;
                        }
                    case (6):
                        {
                            Console.WriteLine("Input person id");
                            int id = int.Parse(Console.ReadLine());
                            if (team.CheckWorker(id))
                            {
                                Console.Write("Input new salary: ");
                                int salary = int.Parse(Console.ReadLine());

                                Console.WriteLine(team.ChangeSalary(id, salary));
                            }
                            break;
                        }
                    case (0):
                        {
                            Console.WriteLine("Programm end");
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid menu chosing");
                            break;
                        }
                }
            }
        }
    }
}
