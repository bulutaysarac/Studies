namespace Studies.SOLID.InterfaceSegretion
{
    public class EmailService : IEmailSender
    {
        public void SendEmail(string recipient, string message)
        {
            Console.WriteLine($"Sending email to {recipient}: {message}");
        }
    }
}