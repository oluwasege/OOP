using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class PartTimeEmployee : Employee
    {
        public override void printFullName()
        {
            //Console.WriteLine($"{firstName} {lastName} , Part Time Employee");
            Console.WriteLine("This is a child class");
            //base.printFullName();
        }

        

       
    }
}
