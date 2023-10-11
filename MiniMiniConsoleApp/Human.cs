using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMiniConsoleApp
{
    internal class Human
    {

        private string _name;
        private string _surName;
        public string Name
        {
            get { return _name; }
            set
            {
                if (CheckOnlyChar(value)) _name = value;
                else Console.WriteLine("Ad yalniz herflerden ibaret olmalidir.");
            }
        }
        public string Surname
        {
            get { return _surName; }
            set
            {
                if (CheckOnlyChar(value)) _surName = value;
                else Console.WriteLine("Ad yalniz herflerden ibaret olmalidir.");
            }
        }
        public int Age { get; set; }

        public Human(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public Human(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }



        public virtual void ShowInfo()
        {
            Console.WriteLine($"Ad: {Name},\nSoyad: {Surname},\nYash: {Age}");

        }


        public bool CheckOnlyChar(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {

                if (!Char.IsLetter(value[i]))
                {
                    return false;
                }

            }
            return true;
        }
    }
}
