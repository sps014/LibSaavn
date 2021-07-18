using System;
using static System.Console;
using Saavn;

SaavnClient client = new();

ForegroundColor = ConsoleColor.Blue;

var searchresult = await client.SearchAsync("Dua Lipa");
ForegroundColor = ConsoleColor.Gray;

WriteLine("found songs:");
//22765589
foreach (var s in searchresult.Songs.Data)
{
    ForegroundColor = ConsoleColor.Magenta;
    WriteLine($"Id: {s.Id}");
    ForegroundColor = ConsoleColor.Green;
    WriteLine($"Title: {s.Title}");
    ForegroundColor = ConsoleColor.Cyan;
    WriteLine($"Singers: {s.MoreInfo.Singers}");
    WriteLine();
}

WriteLine();

var songDetails = await client.GetSongInfoAsync("-5JOWX7I");
WriteLine("encrypted :" + songDetails.EncryptedMediaUrl);

WriteLine(songDetails.DecryptedMediaUrl);
WriteLine(songDetails.HasLyrics);
WriteLine(songDetails.LyricsSnippet);
var lyrics = await client.GetLyricsAsync("-5JOWX7I");
Console.WriteLine(lyrics.Lyrics);
WriteLine();
var top = await client.GetTopChartsAsync();
foreach (var s in top.List)
{
    ForegroundColor = ConsoleColor.Magenta;
    WriteLine($"Id: {s.Id}");
    ForegroundColor = ConsoleColor.Green;
    WriteLine($"Title: {s.Title}");
    ForegroundColor = ConsoleColor.Cyan;
    WriteLine($"URL: {s.MoreInfo.DecryptedMediaUrl}");
    WriteLine();
}

WriteLine();
var album = await client.GetAlbumAsync("22765589");
WriteLine(album.Title);

WriteLine(searchresult.Playlists.Data[0].Id);

var playlist = await client.GetPlayListAsync("155225861");
WriteLine(playlist.Listname);
ResetColor();
