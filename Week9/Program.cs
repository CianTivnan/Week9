using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("Breaking the Law", "Judas Priest", 2.33, Genre.Rock);
            Song song2 = new Song("The Coffin Ships", "Primordial", 9.58, Genre.Rock);
            Song song3 = new Song("DEJA VU", "Dave Rodgers", 4.20, Genre.Dance);
            Song song4 = new Song("Chemical Love", "KEVIN&CHERRY", 5.45, Genre.Dance);
            Song song5 = new Song("Lightning & Snow", "Woods Of Ypres", 4.40, Genre.Rock);

            List<Song> PlayList = new List<Song>();
            PlayList.Add(song1);
            PlayList.Add(song2);
            PlayList.Add(song3);
            PlayList.Add(song4);
            PlayList.Add(song5);

            DisplayPlaylist(PlayList);


        }

        static void DisplayPlaylist(List<Song> Playlist)
        {
            Console.WriteLine("{0,-20}{1,-20}{2,-10}{3,-10}" ,"Artist" ,"Song" ,"Duration" ,"Genre");

            foreach (Song song in Playlist)
            {
                Console.WriteLine(song.ToString());
            }
        }
    }
}
