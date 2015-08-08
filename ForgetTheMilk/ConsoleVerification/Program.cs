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
            while (true)
            {
                Console.WriteLine("Add a task:");
                var input = Console.ReadLine();
                var task = new Task(input);
                Console.WriteLine("Description: " + task.Description);
                Console.WriteLine("Due date: " + task.DueDate);
                Console.WriteLine();
            }
        }
    }
}
