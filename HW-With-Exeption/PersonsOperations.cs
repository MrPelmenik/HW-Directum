using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_With_Exeption
{
    /// <summary>
    /// Операции с классом Person.
    /// </summary>
    internal class PersonsOperations
    {
        List<Person> persons;

        public PersonsOperations ()
        { 
            persons = new List<Person>(); 
        }

        /// <summary>
        /// Добавление человека.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <returns>Результат добавление сотрудника.</returns>
        public string AddPerson(string name)
        {
            persons.Add(new Person { Name = name });

            return "Adding complete";
        }

        /// <summary>
        /// Удаление сотрудника.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Результат удаление сотрудника.</returns>
        public string RemovePerson(int id)
        {
            try
            {
                persons.RemoveAt(id);
            }
            catch 
            {
                return($"Error: OutOfBound");
            }
            return "Deleting complete";
        }

        /// <summary>
        /// Показать информацию о сотрудниках
        /// </summary>
        public void ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            int id = 1;
            foreach (var person in persons)
            {
                sb.AppendLine($"{id}: Name:{person.Name};");
                id++;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
