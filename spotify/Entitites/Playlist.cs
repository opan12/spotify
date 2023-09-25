using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace spotify.Entitites
{
    internal class Playlist
    {
        public Guid Id { get; set; }
        private List<Song> Songs { get; set; }

        private Random random;
        public Playlist(Song firstSong)
        {

            Id = Guid.NewGuid();
            Songs = new List<Song>();
            random = new();
            AddSong(firstSong);
        }
        public void AddSong(Song song)
        {
            if (song != null)
                Songs.Add(song);
        }
        public string GetSongs()
        {

            return string.Join("\n", Songs.Select(song => $"{song.Title}-{song.Composer}"));
        }
        public void SfuffleSongs()
        {
            int songcount = Songs.Count;


            while (songcount > 0)
            {
                songcount--;
                Song song = Songs[songcount];

                int randomIndex = random.Next(songcount);
                Songs[songcount] = Songs[randomIndex];
                Songs[randomIndex] = song;
            }
        }


    }
}
