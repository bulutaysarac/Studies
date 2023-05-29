namespace Studies.Delegates
{
    public class Program
    {
        public delegate void CustomEventHandler(string message);

        static void Main(string[] args)
        {
            MusicPlayer player = new MusicPlayer();
            MessageNotifier notifier = new MessageNotifier();

            //Subscribe notifications to events.
            player.SongStarted += notifier.OnSongStarted;
            player.SongStopped += notifier.OnSongStopped;

            player.StartSong("Lose Yourself");
            player.StopSong("Lose Yourself");
        }
    }
}