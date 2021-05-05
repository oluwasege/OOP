using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //PartTimeEmployee PTE = new PartTimeEmployee();
            //PTE.firstName = "Muiz";
            //PTE.lastName = "Atolagbe";
            //PTE.printFullName();

            //Contract CTE = new Contract();
            //CTE.firstName="Muiz";
            //CTE.lastName = "Atolagbe";
            //CTE.printFullName();

            //Employee naem = new PartTimeEmployee();
            // multiple class inheritance is not possible in c#, multiple interface inheritance is possible

            // Polymorphism(many forms)in c# is a concept by which we can perform a single action in different ways.
            //We can perform polymorphism in c# by method overloading and method overriding. 
            //If you overload a method in c#, it is the example of compile time(static) polymorphism
            //If you override a method in c#, it is the example of run time(dynamic) polymorphism

            Employee em = new Employee();
            em.printFullName();
            PartTimeEmployee pt = new PartTimeEmployee();
            pt.printFullName();
            pt.printFullNameM();
        }
    }
}
