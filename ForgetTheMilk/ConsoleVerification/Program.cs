using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ForgetTheMilk.Controllers;

namespace ConsoleVerification
{
    class Program
    {
        private static void Main(string[] args)
        {
            var input = "Pickup the groceries";
            var task = new Task(input);
            Console.WriteLine("Description: " + task.Description);
            Console.WriteLine("Due date: " + task.DueDate);
            Console.WriteLine();

            input = "Pickup the groceries may 5";
            task = new Task(input);
            Console.WriteLine("Description: " + task.Description);
            Console.WriteLine("Due date: " + task.DueDate);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
