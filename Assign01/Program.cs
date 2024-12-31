using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Emit;
using System.Security.Claims;
using System.Security.Cryptography;

namespace Assign01
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region 1.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
        //Console.WriteLine("Enter Two Point X,Y");
        //int.TryParse(Console.ReadLine(), out int X);
        //int.TryParse(Console.ReadLine(), out int Y);

        //Point P01 = new Point(X, Y);

        //int result = P01.Distance();
        //Console.WriteLine($"(X-Y) = {result}"); 
        #endregion

        #region 2.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

        //Person[] person = new Person[3];

        //for (int i = 0; i < person.Length; i++)
        //{
        //    Console.WriteLine($"Enter Data Of Person {i + 1} (Name and Age):");
        //    person[i].Name = Console.ReadLine();
        //    int.TryParse(Console.ReadLine(), out int age);
        //    person[i].Age = age;
        //}


        //Person oldest = person[0];
        //foreach (var p in person)
        //{
        //    if (p.Age > oldest.Age)
        //    {
        //        oldest = p;
        //    }
        //}


        //Console.WriteLine($"The oldest person is {oldest.Name}, Age = {oldest.Age}");

        #endregion

        #region Design and implement a Class for the employees in a company:Notes: Employee is identified by an ID, Name, security level, salary, hire date and Gender.

            //try
            //{

            //    Employee[] empArr = new Employee[3];


            //    empArr[0] = new Employee(
            //        1, "Ahmed Ali", Gender.Male, 7000.00, new HiringDate(15, 6, 2015), SecurityPrivilege.DBA
            //    );


            //    empArr[1] = new Employee(
            //        2, "Rana Mohamed", Gender.Female, 3000.00, new HiringDate(20, 8, 2018), SecurityPrivilege.Guest
            //    );


            //    empArr[2] = new Employee(
            //        3, "Tamer Mohsen", Gender.Male, 8000.00, new HiringDate(5, 3, 2017), SecurityPrivilege.Developer
            //    );


            //    Console.WriteLine("Before Sorting:");
            //    foreach (var emp in empArr)
            //    {
            //        Console.WriteLine(emp);
            //    }


            //    var sortedEmpArr = empArr.OrderBy(e => e.HireDate.Year).ThenBy(e => e.HireDate.Month).ThenBy(e => e.HireDate.Day).ToArray();

            //    Console.WriteLine("After Sorting:");
            //    foreach (var emp in sortedEmpArr)
            //    {
            //        Console.WriteLine(emp);
            //    }


            //    int boxingCount = 0;
            //    int unboxingCount = 0;


            //    var sortedEmpArrForCounting = empArr.OrderBy(e =>
            //    {
            //        boxingCount++;
            //        return e.HireDate.Year;
            //    }).ThenBy(e =>
            //    {
            //        boxingCount++;
            //        return e.HireDate.Month;
            //    }).ThenBy(e =>
            //    {
            //        boxingCount++;
            //        return e.HireDate.Day;
            //    }).ToArray();


            //    foreach (var emp in sortedEmpArrForCounting)
            //    {
            //        unboxingCount++;
            //    }


            //    Console.WriteLine($"Boxing: {boxingCount}");
            //    Console.WriteLine($"Unboxing: {unboxingCount}");
            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    Console.WriteLine("error: " + ex.Message);
            //} 
            #endregion
        }










}
    
}
