using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Employee
    {
       // public string firstName;
       // public string lastName;

        public virtual void printFullName()
        {
            //Console.WriteLine($"{firstName} {lastName}");
            Console.WriteLine("This is a Parent Class");
        }

        public void printFullNameM()
        {
            Console.WriteLine("This is a parent Class Method");
        }

       
    }
}
