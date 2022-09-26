using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student person = new Student();
            person.AddOffSet(12);
            person.AddOffSet(2);
            person.AddOffSet(11);
            person.AddExams(11);
            person.AddExams(11);
            person.AddTermPapers(10);
            person.AddTermPapers(6);
            person.Print();
            Console.ReadLine();
        }
    }
}
