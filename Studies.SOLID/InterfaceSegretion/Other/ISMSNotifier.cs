namespace Studies.SOLID.InterfaceSegretion
{
    public interface ISMSNotifier
    {
        void SendSMS(string recipient, string message);
    }
}