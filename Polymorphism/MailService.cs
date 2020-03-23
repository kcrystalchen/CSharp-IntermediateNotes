using System;

namespace Polymorphism
{
    public class MailService
    {
        public void Send(Mail mail)
        {
            Console.WriteLine("Sending email from MailServer Send method");
        }
    }
}