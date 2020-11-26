using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9
{
    class Song : IComparable<Song>
    {
        public string Title { get; set; }

        public string Artist { get; set; }

        public double Duration { get; set; }

        public Genre Genre { get; set; }

        //still not entirely sure how to imlement the linked constructors

        public Song()
        {
            Title = "Unknown";
            Artist = "Unknown";
            Duration = 0.0;
            Genre = 0;
        }

        public Song(string title, string artist, double duration, Genre genre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            Genre = genre;
        }

        public override string ToString()
        {
            return String.Format("{0,-20}{1,-20}{2,-10}{3,-10}" ,Artist ,Title ,Duration ,Genre);
        }

        public int CompareTo(Song obj)
        {
            int result = Artist.CompareTo(obj.Artist);
            if (result == 0)
                result = Title.CompareTo(obj.Title);
            return result;
        }
    }

    enum Genre
    {
        Rock = 0,
        Pop = 1,
        Dance = 2,
        Other =3
    }


}
