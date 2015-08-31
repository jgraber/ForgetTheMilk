using System;

namespace ConsoleVerification
{
    public class LinkValidator
    {
        public void Validate(string link)
        {
            throw new ApplicationException("Invalid link " + link);
        }
    }
}