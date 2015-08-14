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
            TestMayDueDateDoesWrapYear();
            TestMayDueDateDoesNotWrapYear();


            Console.ReadLine();
        }

        public static void PrintOutcome(bool success, string failureMessage)
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

        private static void TestMayDueDateDoesWrapYear()
        {
            var input = "Pickup the groceries may 5 - as of 2015-05-31";
            Console.WriteLine("Scenario: " + input);
            var today = new DateTime(2015, 5, 31);

            var task = new Task(input, today);

            var dueDateShouldBe = new DateTime(2016, 5, 5);
            var success = dueDateShouldBe == task.DueDate;
            var failureMessage = "Due date: " + task.DueDate + "should be " + dueDateShouldBe;
            PrintOutcome(success, failureMessage);
        }

        private static void TestMayDueDateDoesNotWrapYear()
        {
            var input = "Pickup the groceries may 5 - as of 2015-05-04";
            Console.WriteLine("Scenario: " + input);
            var today = new DateTime(2015, 5, 4);

            var task = new Task(input, today);

            var dueDateShouldBe = new DateTime(DateTime.Today.Year, 5, 5);
            var success = dueDateShouldBe == task.DueDate;
            var failureMessage = "Due date: " + task.DueDate + " should be " + dueDateShouldBe;
            PrintOutcome(success, failureMessage);
        }
    }
}
