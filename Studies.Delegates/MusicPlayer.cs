using static Studies.Delegates.Program;

namespace Studies.Delegates
{
    public class MusicPlayer
    {
        public event CustomEventHandler SongStarted;
        public event CustomEventHandler SongStopped;

        public void StartSong(string songName)
        {
            //Song start code.

            //Trigger the event that the song has started.
            SongStarted?.Invoke("Song started: " + songName);
        }

        public void StopSong(string songName)
        {
            //Song stop code.

            //Trigger the event that the song has stopped.
            SongStopped?.Invoke("Song stopped: " + songName);
        }
    }
}