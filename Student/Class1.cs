using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Student
    {
        private string name;
        private string surname;
        private string lastname;
        private DateTime age;
        private string HomeAddress;
        private string NumberOfPhone;

        private ArrayList OffSet = new ArrayList();
        private ArrayList Exams = new ArrayList();
        private ArrayList TermPapers = new ArrayList();

        public void AddOffSet(int number)
        {
            this.OffSet.Add(number);
        }

        public void AddExams(int number)
        {
            this.Exams.Add(number);
        }

        public void AddTermPapers(int number)
        {
            this.TermPapers.Add(number);
        }

        public Student()
        {
            SetName("Seriy");
            SetSurname("APARAT");
            SetLastname("Olegovich");
            age = age.AddDays(20 - 1);
            age = age.AddMonths(1 - 1);
            age = age.AddYears(2003 - 1);
            SetHomeAddress("Uspenskaya 100");
            SetNumberOfPhone("+380912939192");
        }

        public Student(string name, string surname, string lastname, DateTime age)
        {
            SetName(name);
            SetSurname(surname);
            SetLastname(lastname);
            SetAge(age);
            SetHomeAddress("Uspenskaya 100");
            SetNumberOfPhone("+380912939192");
        }

        public Student(string name, string surname, string lastname, DateTime age, string HomeAddress,string NumberOfPhone)
        {
            SetName(name);
            SetSurname(surname);
            SetLastname(lastname);
            SetAge(age);
            SetHomeAddress(HomeAddress);
            SetNumberOfPhone(NumberOfPhone);
        }



       public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetSurname(string surname)
        {
            this.surname = surname;
        }

        public string GetSurname()
        {
            return surname;
        }

        public void SetLastname(string lastname)
        {
            this.lastname = lastname;
        }

        public string GetLastname()
        {
            return lastname;
        }

        public void SetAge(DateTime age)
        {
            this.age = age.AddDays(20 - 1);
            this.age = age.AddMonths(1 - 1);
            this.age = age.AddYears(2003 - 1);
        }

        public DateTime GetAge()
        {
            return age;
        }

        public void SetHomeAddress(string HomeAddress)
        {
            this.HomeAddress = HomeAddress;
        }

        public string GetHomeAddress()
        {
            return HomeAddress;
        }

        public void SetNumberOfPhone(string NumberOfPhone)
        {
            this.NumberOfPhone = NumberOfPhone;
        }

        public string GetNumberOfPhone()
        {
            return NumberOfPhone;
        }

        public void Print()
        {
            Console.WriteLine("Name : " + GetName());
            Console.WriteLine("SurName : " + GetSurname());
            Console.WriteLine("LastName : " + GetLastname());
            Console.WriteLine("Date of Birthday : " + GetAge());
            Console.WriteLine("Home Address : " + GetHomeAddress());
            Console.WriteLine("Phone Number : " + GetNumberOfPhone());
            Console.Write("\nЗачёты : ");
            for (int i = 0; i < OffSet.Count; i++)
            {
                Console.Write(OffSet[i] + ", ");
            }
            Console.Write("\nЭкзамены : ");
            for (int i = 0; i < Exams.Count; i++)
            {
                Console.Write(Exams[i] + ", ");
            }
            Console.Write("\nКурсовые работы : ");
            for (int i = 0; i < TermPapers.Count; i++)
            {
                Console.Write(TermPapers[i] + ", ");
            }
        }


    }
}
