using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMiniConsoleApp
{
    internal class Student : Human
    {
        public byte Grade { get; set; }
        public string GroupNo { get; set; }
        public Student(string name, string surname, int age, byte grade, string groupNo) : base(name, surname, age)
        {
            Grade = grade;
            GroupNo = groupNo;
        }



        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Bal: {Grade},\nQrup nomresi: {GroupNo}");
            Console.WriteLine(" = = = = = = = = = ");

        }
    }
}
