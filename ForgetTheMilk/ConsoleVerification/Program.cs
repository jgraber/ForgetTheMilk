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
            TestDescriptionAndNoDueDate();

            TestMayDueDate();

            Console.ReadLine();
        }

        private static void TestDescriptionAndNoDueDate()
        {
            var input = "Pickup the groceries";
            Console.WriteLine("Scenario: " + input);
            var task = new Task(input);
            var descriptionShouldBe = input;
            DateTime? dueDateShouldBe = null;
            if (descriptionShouldBe == task.Description
                && dueDateShouldBe == task.DueDate)
            {
                Console.WriteLine("SUCCESS");
            }
            else
            {
                Console.WriteLine("Description: " + task.Description + " should be " + descriptionShouldBe);
                Console.WriteLine("Due date: " + task.DueDate + "should be " + dueDateShouldBe);
                Console.WriteLine("ERROR");
            }
            Console.WriteLine();
        }

        private static void TestMayDueDate()
        {
            var input = "Pickup the groceries may 5";
            Console.WriteLine("Scenario: " + input);
            var task = new Task(input);
            var dueDateShouldBe = new DateTime(DateTime.Today.Year, 5, 5);
            if (dueDateShouldBe == task.DueDate)
            {
                Console.WriteLine("SUCCESS");
            }
            else
            {
                Console.WriteLine("Due date: " + task.DueDate + "should be " + dueDateShouldBe);
                Console.WriteLine("ERROR");
            }
            Console.WriteLine();
        }
    }
}
