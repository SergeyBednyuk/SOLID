using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiscovSobstitutionPrinciple.MediaPlayerExample;
using LiscovSobstitutionPrinciple.MediaPlayerWithLSP;

namespace LiscovSobstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            //    ClassA classA1 = new ClassA();
            //    ClassB classB1 = new ClassB();

            //    classA1.DoSmth();
            //    classB1.DoSmth();
            //    Console.WriteLine("_________________");

            //    ClassA classB2 = new ClassB();
            //    classB2.DoSmth();
            //    Console.WriteLine(classB2.GetType());
            //    object o = new ClassA();

            List<MediaPlayerExample.MediaPlayer> mediaPlayers = new List<MediaPlayerExample.MediaPlayer>();
            mediaPlayers.Add(new MediaPlayerExample.TorMediaPlayer());
            mediaPlayers.Add(new MediaPlayerExample.WinampMediaPlayer());

            mediaPlayers[0].PlayVideo();
            Console.ReadKey();
            //mediaPlayers[1].PlayVideo();

            List<MediaPlayerWithLSP.AudioMediaPlayer> audios = new List<AudioMediaPlayer>() {new MediaPlayerWithLSP.WinampMediaPlayer() };
            audios[0].PlayAudio();

            Console.ReadKey();
        }
    }
}
