using System;

namespace Polymorphism
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending Mail...from MailNotificationChannel");
        }
    }

    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS ... from SmsNotificationChannel");
        }
    }



    public interface INotificationChannel 
   // notification channel, we want to send a message to this channel
   // One Interface with two implementations - SMS and Mail
    {
        void Send(Message message);
    }
}