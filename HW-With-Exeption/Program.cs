using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_With_Exeption
{
    internal class Program
    {
        public static void ShowMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Menu:");
            sb.AppendLine("1. Add new person");
            sb.AppendLine("2. Delete person by ID");
            sb.AppendLine("3. Show info(ID,name)");
            sb.AppendLine("0. Exit");
            sb.Append("Input: ");
            Console.Write(sb);
        }

        static void Main()
        {
            Console.WriteLine("Programm begin");

            PersonsOperations persons = new PersonsOperations();
            while (true)
            {
                ShowMenu();
                try
                {
                    int input = int.Parse(Console.ReadLine());

                    switch (input)
                    {
                        case (1):
                            {
                                Console.Write("Input name: ");
                                string name = Console.ReadLine();

                                Console.WriteLine(persons.AddPerson(name));
                                break;
                            }
                        case (2):
                            {
                                Console.WriteLine("Input person id");
                                int id = int.Parse(Console.ReadLine());

                                Console.WriteLine(persons.RemovePerson(id - 1));
                                break;
                            }
                        case (3):
                            {
                                persons.ShowInfo();
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
                catch
                {
                    Console.WriteLine("Invalid format");
                }

            }
        }
    }
}
