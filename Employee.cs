using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8___OOP_Generic_Collections
{
    //Employee klass
    public class Employee
    {
        public int Id { get; set; }
        public int Salary { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        //Konstruktor för employee, underlättar för att skapa en ny, och gör koden "renare" i main.
        public Employee(int id, string name, string gender, int salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;

        }

    }
}
