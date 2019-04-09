using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Audioplayer
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Playlist mainPlaylist = new Playlist();
            Playlist secondPlayList = new Playlist();
            Song song1 = new Song
            {
                duration = 300,
                title = "Cvet nastroenia sinii",
                songGenre = "Metal",
                lyrics = "lalala",
                artist = new Artist
                {
                    name = "Kirkorov"
                },
                
            };

            song1.playlists[0] = mainPlaylist;
            song1.playlists[1] = secondPlayList;


            Song song2 = new Song();

            song2.duration = 300;
            song2.title = "Anaconda";
            song2.songGenre = "Pop";
            song2.lyrics = "lalala";
            song2.artist = new Artist { name = "Minaj" };
            song2.album = new Album
            {
                name = "MinajAlbum", path = "pathAlbum"
            };
            song2.playlists[0] = mainPlaylist;
            song2.playlists[1] = secondPlayList;

            

            mainPlaylist.title = "Main";
            mainPlaylist.path = "Path1";
            mainPlaylist.Songs[0] = song1;
            mainPlaylist.Songs[1] = song2;

            mainPlaylist.title = "Second";
            mainPlaylist.path = "Path2";
            secondPlayList.Songs[0] = song1;
            secondPlayList.Songs[1] = song2;

            WriteLine(mainPlaylist.title);
            WriteLine(mainPlaylist.Songs[1].title);
            WriteLine(song1.title);
            WriteLine(song1.playlists[0].title);
            WriteLine(song2.lyrics);
            WriteLine(song2.playlists[1].title);

            Player player = new Player();
            player.songs = new[] { song1, song2 };

            player.VolumeChange(25, "+");
            player.VolumeChange(5, "-");

            while (true)
            {
                switch (ReadLine())
                {
                    case "a":
                        {
                            player.VolumeUp();
                            break;
                        }
                    case "s":
                        {
                            player.VolumeDown();
                            break;
                        }
                    case "d": 
                        {
                            player.Play();
                            break;
                        }
                    case "q":
                        {
                            player.Lock();
                            break;
                        }
                    case "w":
                        {
                            player.UnLock();
                            break;
                        }
                    case "e":
                        {
                            player.Start();
                            break;
                        }
                    case "r":
                        {
                            player.Stop();
                            break;
                        }

                }
            }

            

            ReadLine();
        }
    }
}
