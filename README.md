# LibSaavn
Unofficial wrapper for Saavn Music Streaming platform, written entirely in C#. 

### Features:
Extract anything Top Trending songs or custom Query a song , recieve everything about the song with easy to use API.

### Usage

Install lib from [nuget](https://www.nuget.org/packages/LibSaavn/) or dotnet CLI
```
dotnet add package LibSaavn 
```

Create Saavn Client
```cs
using Saavn;
using static System.Console;

SaavnClient client = new();
```


1. Search
```cs
var searchresult = await client.SearchAsync("Dua Lipa Songs");
foreach (var s in searchresult.Songs.Data)
{
    WriteLine($"Id: {s.Id}");
    WriteLine($"Title: {s.Title}");
    WriteLine($"Singers: {s.MoreInfo.Singers}");
    //get more info
}

```

2. Fetch info about Song
```cs
var songDetails = await client.GetSongInfoAsync("-5JOWX7I"); //parameter is song id
//playable stream url
WriteLine(songDetails.DecryptedMediaUrl);
WriteLine(songDetails.HasLyrics);
WriteLine(songDetails.LyricsSnippet);
//and more
```

3. Top Trending Songs
```cs
var top = await client.GetTopChartsAsync();
foreach (var s in top.List)
{
    WriteLine($"Id: {s.Id}");
    WriteLine($"Title: {s.Title}");
    ForegroundColor = ConsoleColor.Cyan;
    WriteLine($"URL: {s.MoreInfo.DecryptedMediaUrl}");
}
```

4. Get Lyrics
```cs
var lyrics = await client.GetLyricsAsync("-5JOWX7I"); //parameter is song id
WriteLine(lyrics.Lyrics);
```

5. Get Album Details
```cs
var album = await client.GetAlbumAsync("22765589");
WriteLine(album.Title);
```

6. Get Playlist
```cs

WriteLine(searchresult.Playlists.Data[0].Id);
//155225861 get playlist id
var playlist = await client.GetPlayListAsync("155225861");
WriteLine(playlist.Listname);
```
* most of the API are ported from [Unofficial Saavn API](https://github.com/cyberboysumanjay/JioSaavnAPI)
