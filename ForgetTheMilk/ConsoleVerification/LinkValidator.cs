using System;
using System.Net;

namespace ConsoleVerification
{
    public class LinkValidator
    {
        public void Validate(string link)
        {
            var request = WebRequest.CreateHttp(link);
            request.Method = "HEAD";
            try
            {
                request.GetResponse();
            }
            catch (WebException exception)
            {
                throw new ApplicationException("Invalid link " + link);
            }
        }
    }
}