using System;
using AbstractionExample;

namespace AbstractionExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            INotification[] notifications =
            {
                new EmailNotification(),
                new SmsNotification(),
                new WhatsappNotification()
            };

            foreach (var notification in notifications)
            {
                notification.Send("Hello");
            }
        }
    }
}
