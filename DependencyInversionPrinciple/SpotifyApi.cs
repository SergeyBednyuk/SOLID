using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class SpotifyApi : MusicApi
    {
        public void FindAll()
        {
            Console.WriteLine("SpotifyApi -> FindAll()");
        }

        public void GetTracks()
        {
            Console.WriteLine("SpotifyApi -> GetTracks()");
        }
    }
}
