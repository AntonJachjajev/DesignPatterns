using System;
using System.Globalization;

namespace DesignPatterns.Adaptor
{
    public class AudioPlayer : IMediaPlayer
    {
        MediaAdapter _mediaAdapter;

        public void Play(string audioType, string fileName)
        {

            switch (audioType.ToLower(CultureInfo.InvariantCulture))
            {
                case "mp3":
                    Console.WriteLine("Playing mp3 file. Name: " + fileName);
                    break;
                case "vlc":
                case "mp4":
                    _mediaAdapter = new MediaAdapter(audioType);
                    _mediaAdapter.Play(audioType, fileName);
                    break;
                default:
                    Console.WriteLine("Invalid media. " + audioType + " format not supported");
                    break;
            }
        }
    }
}