using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApi
{
    public class Album : Entity
    {
        public Artist Artist { get; set; }
        public string Name { get; set; }
        public string ReleaseDate { get; set; }
        public List<Track> Tracks { get; set; }

        public Album()
        {
            Tracks = new List<Track>();
        }
    }
}
