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
            var success = descriptionShouldBe == task.Description
                && dueDateShouldBe == task.DueDate;
            var failureMessage = "Description: " + task.Description + " should be " + descriptionShouldBe
                                 + Environment.NewLine
                                 + "Due date: " + task.DueDate + "should be " + dueDateShouldBe;
            PrintOutcome(success, failureMessage);
        }

        private static void PrintOutcome(bool success, string failureMessage)
        {
            if (success)
            {
                Console.WriteLine("SUCCESS");
            }
            else
            {
                Console.WriteLine("ERROR: ");
                Console.WriteLine(failureMessage);
            }
            Console.WriteLine();
        }

        private static void TestMayDueDate()
        {
            var input = "Pickup the groceries may 5";
            Console.WriteLine("Scenario: " + input);

            var task = new Task(input);

            var dueDateShouldBe = new DateTime(DateTime.Today.Year, 5, 5);
            var success = dueDateShouldBe == task.DueDate;
            var failureMessage = "Due date: " + task.DueDate + "should be " + dueDateShouldBe;
            PrintOutcome(success, failureMessage);
        }
    }
}
