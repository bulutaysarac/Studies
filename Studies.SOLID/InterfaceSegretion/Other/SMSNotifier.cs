namespace Studies.SOLID.InterfaceSegretion.Other
{
    public class SMSNotifier : ISMSNotifier
    {
        public void SendSMS(string recipient, string message)
        {
            Console.WriteLine($"Sending SMS to {recipient}: {message}");
        }
    }
}