using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ForgetTheMilk.Controllers;
using NUnit.Framework;

namespace ConsoleVerification
{
    public class TaskLinkTest : AssertionHelper
    {
        [Test]
        public void CreateTask_DescriptionWithALink_SetLink()
        {
            var input = "test http://www.google.com";

            var task = new Task(input, default(DateTime));

            Expect(task.Link, Is.EqualTo("http://www.google.com"));
        }

        [Test]
        public void Validate_InvalidUrl_ThrowsException()
        {
            var input = "http://www.doesnotexistdotcom.com";

            Expect(() => new Task(input, default(DateTime), new LinkValidator()),
                Throws.Exception.With.Message.EqualTo("Invalid link " + input));
        }
    }
}
