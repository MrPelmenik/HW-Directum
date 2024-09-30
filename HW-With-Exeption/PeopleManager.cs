using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_With_Exeption
{
    /// <summary>
    /// Менеджер людей.
    /// </summary>
    public class PeopleManager
    {
        /// <summary>
        /// Колекция людей.
        /// </summary>
        private List<Person> persons;

        /// <summary>
        /// Добавление человека.
        /// </summary>
        /// <param name="name">Имя.</param>
        public void AddPerson(string name)
        {
            try
            {
                if (persons.Any(p => p.Name == name))
                    throw new Exception ("Человек с таким именем существует");
                persons.Add(new Person { Name = name });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        /// <summary>
        /// Удаление сотрудника.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        public void RemovePerson(int id)
        {
            try
            {
                persons.RemoveAt(id);
            }
            catch 
            {
                Console.WriteLine($"Error: OutOfBound");
            }
        }

        /// <summary>
        /// Показать информацию о сотрудниках.
        /// </summary>
        public string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            int id = 1;
            foreach (var person in persons)
            {
                sb.AppendLine($"{id}: Name:{person.Name};");
                id++;
            }
            return sb.ToString();
        }

        /// <summary>
        /// Конструктор для создания листа Person в переменную persons
        /// </summary>
        #region Конструктор
        public PeopleManager()
        {
            persons = new List<Person>();
        }
        #endregion
    }
}
