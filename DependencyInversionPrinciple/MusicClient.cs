using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class MusicClient : MusicApi
    {
        private MusicApi _client;
        public MusicClient(MusicApi client)
        {
            _client = client;
        }

        public void GetTracks()
        {
            _client.GetTracks();
        }
    }
}
