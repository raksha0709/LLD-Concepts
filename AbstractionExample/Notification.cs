using System;

namespace AbstractionExample
{
    public interface INotification
    {
        void Send(string message);
    }

    // Simple abstract base that captures the common sending behavior
    public abstract class NotificationBase : INotification
    {
        protected abstract string ChannelName { get; }

        public void Send(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                Console.WriteLine("Cannot send empty message.");
                return;
            }

            Console.WriteLine($"Sending {ChannelName} notification: {message}");
        }
    }

    public class EmailNotification : NotificationBase
    {
        protected override string ChannelName => "email";
    }

    public class SmsNotification : NotificationBase
    {
        protected override string ChannelName => "sms";
    }

    public class WhatsappNotification : NotificationBase
    {
        protected override string ChannelName => "whatsapp";
    }
}
