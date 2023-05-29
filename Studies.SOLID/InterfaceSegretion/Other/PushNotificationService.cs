namespace Studies.SOLID.InterfaceSegretion
{
    public class PushNotificationService : IPushNotificationSender
    {
        public void SendPushNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending push notification to {recipient}: {message}");
        }
    }
}