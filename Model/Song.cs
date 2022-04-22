using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Song
    {
        private int _duration;

        public Song()
        {

        }
        public Song(string title, string singer, int duration)
        {
            Title = title;
            Singer = singer;
            Duration = duration;
        }
        public string Title { get; set; }
        public string Singer { get; set; }

        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Длительность песни должна быть больше нуля");
                }
                _duration = value;
            }
        }
    }
}
