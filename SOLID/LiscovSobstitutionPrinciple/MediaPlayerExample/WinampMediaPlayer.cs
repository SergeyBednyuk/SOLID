using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiscovSobstitutionPrinciple.MediaPlayerExample
{
    public class WinampMediaPlayer: MediaPlayer
    {
        public override void PlayVideo()
        {
            throw new Exception("WinampMediaPlayer can't play video");
        }
    }
}
