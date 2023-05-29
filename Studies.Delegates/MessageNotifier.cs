namespace Studies.Delegates
{
    public class MessageNotifier
    {
        public void OnSongStarted(string message)
        {
            Console.WriteLine("Notification: " + message);
        }

        public void OnSongStopped(string message)
        {
            Console.WriteLine("Notification: " + message);
        }
    }
}