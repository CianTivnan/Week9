using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9
{
    static class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("Breaking the Law", "Judas Priest", 2.33, Genre.Rock);
            Song song2 = new Song("The Coffin Ships", "Primordial", 9.58, Genre.Rock);
            Song song3 = new Song("DEJA VU", "Dave Rodgers", 4.20, Genre.Dance);
            Song song4 = new Song("Empire Falls", "Primordial", 8.03, Genre.Rock);
            Song song5 = new Song("Lightning & Snow", "Woods Of Ypres", 4.40, Genre.Rock);

            List<Song> PlayList = new List<Song>();
            PlayList.Add(song1);
            PlayList.Add(song2);
            PlayList.Add(song3);
            PlayList.Add(song4);
            PlayList.Add(song5);

            DisplayPlaylist(PlayList);

            Console.WriteLine("Sorting playlist by artist, and then by song..");

            PlayList.Sort();

            DisplayPlaylist(PlayList);

            Console.WriteLine("Shuffling playlist..");

            Shuffle(PlayList);

            DisplayPlaylist(PlayList);
        }

        public static void Shuffle<T>(this IList<T> Playlist)
        {
            Random rng = new Random();

            int n = Playlist.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = Playlist[k];
                Playlist[k] = Playlist[n];
                Playlist[n] = value;
            }
        }

        static void DisplayPlaylist(List<Song> Playlist)
        {
            Console.WriteLine("\n{0,-20}{1,-20}{2,-10}{3,-10}" ,"Artist" ,"Song" ,"Duration" ,"Genre");

            foreach (Song song in Playlist)
            {
                Console.WriteLine(song.ToString());
            }
        }
    }
}
