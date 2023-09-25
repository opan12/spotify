﻿using spotify.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify.servises
{
    internal class NotepadService
    {
        public void WriteToNotpad(Playlist playlist)
        {
            string directory = $@"{ Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName}\Playlist";
            if (!File.Exists(directory))
                Directory.CreateDirectory(directory);
            string saveFile = Path.Combine(directory,$"{playlist.Id}.txt");

            File.WriteAllText(saveFile, playlist.GetSongs());
            Console.WriteLine("Data succesfully loaded ");
        }
    }
}
