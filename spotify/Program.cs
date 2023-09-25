// See https://aka.ms/new-console-template for more information
using spotify;
using spotify.Entitites;
using spotify.servises;

string currenDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName;

Console.WriteLine();

//Console.WriteLine("spotify");
var song1 = new Song("Paint The Town Red","Doja Cat","Freenjoy","doja cat");
var song2 = new Song("Firuze","Sezen Aksu","Broadcast Music Inc.","Aysel Gürel");
var song3 = new Song("memories", "conan gray", "UMG", "conan gray");
var song4 = new Song("Like my style", "50 cent",  "warner bros","sude opan");
var song5 = new Song("carmen ", "lana del rey", "warner bros","sude opan ");

var playlist1 = new Playlist(song1);
playlist1.AddSong(song2);
playlist1.AddSong(song3);
playlist1.AddSong(song4);
playlist1.AddSong(song5);

Console.WriteLine("before");

Console.WriteLine(playlist1.GetSongs());
playlist1.SfuffleSongs();
Console.WriteLine("after");

Console.WriteLine(playlist1.GetSongs());
NotepadService notepadService = new NotepadService();
notepadService.WriteToNotpad(playlist1   );