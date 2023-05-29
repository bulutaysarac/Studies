namespace Studies.SOLID.InterfaceSegretion
{
    public interface IEmailSender
    {
        void SendEmail(string recipient, string message);
    }
}