using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMiniConsoleApp
{
    internal class Baku : ICity
    {
        private List<Human> humansList = new List<Human>();

        public List<Human> Humans => humansList;

        public void AddHuman(Human human)
        {
            humansList.Add(human);
        }

        public Employee[] GetEmployees() => humansList.OfType<Employee>().ToArray();


        public Student[] GetStudents() => humansList.OfType<Student>().ToArray();


        public Human[] SearchHumans(string fullName)
        {
            return humansList.Where(h => (h.Name + " " + h.Surname).Contains(fullName)).ToArray();
        }
    }
}
