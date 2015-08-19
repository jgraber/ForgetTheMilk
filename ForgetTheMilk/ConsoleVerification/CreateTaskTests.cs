using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ForgetTheMilk.Controllers;
using NUnit.Framework;

namespace ConsoleVerification
{
    public class CreateTaskTests : AssertionHelper
    {
        [Test]
        public void TestDescriptionAndNoDueDate()
        {
            var input = "Pickup the groceries";
            
            var task = new Task(input, default(DateTime));
            
            Expect(task.Description, Is.EqualTo(input));
            Assert.AreEqual(null, task.DueDate);
        }

        [Test]
        public void TestMayDueDateDoesWrapYear()
        {
            var input = "Pickup the groceries may 5 - as of 2015-05-31";
            var today = new DateTime(2015, 5, 31);

            var task = new Task(input, today);

            Expect(task.DueDate, Is.EqualTo(new DateTime(2016, 5, 5)));
        }

        [Test]
        public void TestMayDueDateDoesNotWrapYear()
        {
            var input = "Pickup the groceries may 5 - as of 2015-05-04";
            var today = new DateTime(2015, 5, 4);

            var task = new Task(input, today);

            Expect(task.DueDate, Is.EqualTo(new DateTime(DateTime.Today.Year, 5, 5)));
        }
    }
}
