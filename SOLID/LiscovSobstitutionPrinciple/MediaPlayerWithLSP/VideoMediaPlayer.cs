using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiscovSobstitutionPrinciple.MediaPlayerWithLSP
{
    public class VideoMediaPlayer: MediaPlayer
    {
        public virtual void PlayVideo()
        {
            Console.WriteLine("Playing video...");
        }
    }
}
