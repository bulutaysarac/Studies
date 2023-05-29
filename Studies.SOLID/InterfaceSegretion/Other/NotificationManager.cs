namespace Studies.SOLID.InterfaceSegretion
{
    public class NotificationManager : IEmailSender, ISMSNotifier, IPushNotificationSender
    {
        private readonly IEmailSender emailSender;
        private readonly ISMSNotifier smsNotifier;
        private readonly IPushNotificationSender pushNotificationSender;

        public NotificationManager(IEmailSender emailSender, ISMSNotifier smsNotifier, IPushNotificationSender pushNotificationSender)
        {
            this.emailSender = emailSender;
            this.smsNotifier = smsNotifier;
            this.pushNotificationSender = pushNotificationSender;
        }

        public void SendEmail(string recipient, string message)
        {
            emailSender.SendEmail(recipient, message);
        }

        public void SendSMS(string recipient, string message)
        {
            smsNotifier.SendSMS(recipient, message);
        }

        public void SendPushNotification(string recipient, string message)
        {
            pushNotificationSender.SendPushNotification(recipient, message);
        }
    }
}