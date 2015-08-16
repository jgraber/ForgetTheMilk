using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ForgetTheMilk.Controllers;
using NUnit.Framework;

namespace ConsoleVerification
{
    public class CreateTaskTests
    {
        [Test]
        public void TestDescriptionAndNoDueDate()
        {
            var input = "Pickup the groceries";
            
            var task = new Task(input, default(DateTime));
            
            Assert.AreEqual(input, task.Description);
            Assert.AreEqual(null, task.DueDate);
        }
    }
}
