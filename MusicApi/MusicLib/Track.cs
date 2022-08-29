using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApi
{
    public class Track : Entity 
    {
        public int DurationMs { get; set; }
        public string Title { get; set; }
        public string FormattedDuration 
        {
            get {
                var ts = TimeSpan.FromMilliseconds(DurationMs);
                return ts.ToString(@"hh\:mm\:ss");
            }
        }
    }
}
