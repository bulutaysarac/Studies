namespace Studies.SOLID.InterfaceSegretion
{
    public interface IPushNotificationSender
    {
        void SendPushNotification(string recipient, string message);
    }
}