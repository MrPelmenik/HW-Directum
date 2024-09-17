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
                            team.AddWorker();
                            break;
                        }
                    case (2):
                        {
                            team.RemoveWorker();
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
                            team.ChangeName();
                            break;
                        }
                    case (6):
                        {
                            team.ChangeSalary();
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
