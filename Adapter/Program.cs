using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioPlayer audioPlayer = new AudioPlayer();
            audioPlayer.Play("mp4","hakkı bulut ben köylüyüm");
            audioPlayer.Play("vcl","cendere");
            audioPlayer.Play("mp3","tivorlu ismail");

        }
    }

    public interface IMediaPlayer
    {
        void Play(string audioType, string fileName);
    }

    public interface IAdvancedMediaPlayer
    {
        void PlayVCL(string fileName);
        void PlayMP4(string fileName);
    }

    public class VCLPlayer : IAdvancedMediaPlayer
    {
        public void PlayVCL(string fileName)
        {
            Console.WriteLine("playin vcl file" + fileName);
        }

        public void PlayMP4(string fileName){}
    }

    public class MP4Player :IAdvancedMediaPlayer
    {
        public void PlayVCL(string fileName)
        {
            
        }
        public void PlayMP4(string fileName)
        {
            Console.WriteLine("Playing mp4 file." + fileName);
        }
    }

    public class MediaAdapter : IMediaPlayer
    {
        IAdvancedMediaPlayer advancedMediaPlayer;

        public MediaAdapter(string audioType)
        {
            if(audioType == "vcl"){
                advancedMediaPlayer = new VCLPlayer(); 
            }
            else if(audioType == "mp4")
            {
                advancedMediaPlayer = new MP4Player();
            }
        }

        public void Play(string audioType, string fileName){
            if(audioType == "vcl")
            {
                advancedMediaPlayer.PlayVCL(fileName);
            }else if(audioType=="mp4")
            {
                advancedMediaPlayer.PlayMP4(fileName);
            }
        }
    }

    public class AudioPlayer : IMediaPlayer
    {
        MediaAdapter mediaAdapter;

        public void Play(string audioType,string fileName)
        {
            if(audioType == "mp3"){
                Console.WriteLine("playing mp3 "+ fileName);
            }

            else if(audioType == "vcl" || audioType == "mp4"){
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.Play(audioType,fileName);
            }else
            {
                Console.WriteLine("Invalid media type " + audioType);
            }
        }
    }
}
