using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMiniConsoleApp
{
    internal interface ICity
    {

        List<Human> Humans { get; }
        void AddHuman(Human human);
        Human[] SearchHumans(string fullName);
        Employee[] GetEmployees();
        Student[] GetStudents();
    }
}
