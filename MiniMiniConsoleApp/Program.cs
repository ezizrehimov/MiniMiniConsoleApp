using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMiniConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Baku baku = new Baku();


            while (true)
            {
                Console.WriteLine("1. Employee elave et\r\n2. Student elave et\r\n3. Employeelerin sayini goster\r\n4. Studentlerin sayini goster\r\n5. Employeelere bax\r\n6. Studentlere bax\r\n7. Insanlar uzere axtaris et\r\n0. Menudan cix");


                Console.WriteLine(" = = = = = = = = = = = ");
                string chooseStr;
                int choose;

                do
                {
                    Console.Write("Secim edin: ");
                    chooseStr = Console.ReadLine();

                } while (!int.TryParse(chooseStr, out choose) || !(choose >= 0 && choose <= 7));

                switch (choose)
                {
                    case 1:
                        addEmp(baku);
                        break;
                    case 2:
                        addStu(baku);
                        break;
                    case 3:
                        Console.WriteLine($"Employeeler: {baku.GetEmployees().Length}");
                        break;

                    case 4:
                        Console.WriteLine($"Studentler: {baku.GetStudents().Length}");
                        break;

                    case 5:
                        allEmp(baku);
                        break;

                    case 6:
                        allStu(baku);
                        break;

                    case 7:
                        searchHuman(baku);
                        break;

                    case 0:
                        return;
                }
            }
        }


        // 1. Employee elave et:
        public static void addEmp(Baku baku)
        {
            Console.Write("Ad: ");
            string name = Console.ReadLine();
            Console.Write("Soyad: ");
            string surName = Console.ReadLine();

            string ageStr;
            int age;

            do
            {
                Console.Write("Yash: ");
                ageStr = Console.ReadLine();

            } while (!int.TryParse(ageStr, out age) || !(age > 0 && age < 120));

            Console.Write("Pozisiya: ");
            string position = Console.ReadLine();
            Employee emp = new Employee(name, surName, age, position);
            baku.AddHuman(emp);

        }

        // 2. Student elave et:
        public static void addStu(Baku baku)
        {

            Console.Write("Ad: ");
            string name = Console.ReadLine();
            Console.Write("Soyad: ");
            string surName = Console.ReadLine();

            string ageStr;
            int age;

            do
            {
                Console.Write("Yash: ");
                ageStr = Console.ReadLine();

            } while (!int.TryParse(ageStr, out age) || !(age > 0 && age < 120));

            string gradeStr;
            byte grade;

            do
            {
                Console.Write("Bal: ");
                gradeStr = Console.ReadLine();

            } while (!byte.TryParse(gradeStr, out grade) || !(grade >= 0 && grade <= 100));

            Console.Write("Group nomresi: ");
            string groupNo = Console.ReadLine();
            Student stu = new Student(name, surName, age, grade, groupNo);
            baku.AddHuman(stu);


        }

        // 5. Employee-lere bax:
        public static void allEmp(Baku baku)
        {
            Console.WriteLine("Ischiler: ");

            foreach (var emp in baku.GetEmployees())
            {
                emp.ShowInfo();
            }

        }

        // 6. Student-lere bax:
        public static void allStu(Baku baku)
        {
            Console.WriteLine("Telebeler: ");

            foreach (var stu in baku.GetStudents())
            {
                stu.ShowInfo();
            }
        }

        // 7. searchHuman -lar uchun:
        public static void searchHuman(Baku baku)
        {
            Console.Write("Filter ucun sozu daxil edin: ");
            string word = Console.ReadLine();

            Human[] search = baku.SearchHumans(word);

            Console.WriteLine("Filter edilen insanlar: ");
            foreach (var filter in search)
            {
                filter.ShowInfo();

            }

        }
    }
}
