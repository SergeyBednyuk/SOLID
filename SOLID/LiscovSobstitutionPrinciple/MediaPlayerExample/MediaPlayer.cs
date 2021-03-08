using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiscovSobstitutionPrinciple.MediaPlayerExample
{
    public class MediaPlayer
    {
        public virtual void PlayAudio()
        {
            Console.WriteLine("Playing audio...");
        }
        public virtual void PlayVideo()
        {
            Console.WriteLine("Playing video...");
        }
    }
}
