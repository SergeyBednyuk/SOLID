using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiscovSobstitutionPrinciple.MediaPlayerWithLSP
{
    public class MediaPlayer
    {
        public virtual void PlayAudio()
        {
            Console.WriteLine("Playing audio...");
        }
    }
}
