//Auto generated class from JsonToC# website 
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Saavn.Search
{
    public class MoreInfo
    {
        public MoreInfo(string year, string isMovie, string language, string songPids, string primaryArtists, string singers, object videoAvailable, bool trillerAvailable, string vcode, string vlink)
        {
            Year = year;
            IsMovie = isMovie;
            Language = language;
            SongPids = songPids;
            PrimaryArtists = primaryArtists;
            Singers = singers;
            VideoAvailable = videoAvailable;
            TrillerAvailable = trillerAvailable;
            Vcode = vcode;
            Vlink = vlink;
        }

        [JsonPropertyName("year")]
        public string Year { get; }

        [JsonPropertyName("is_movie")]
        public string IsMovie { get; }

        [JsonPropertyName("language")]
        public string Language { get; }

        [JsonPropertyName("song_pids")]
        public string SongPids { get; }

        [JsonPropertyName("primary_artists")]
        public string PrimaryArtists { get; }

        [JsonPropertyName("singers")]
        public string Singers { get; }

        [JsonPropertyName("video_available")]
        public object VideoAvailable { get; }

        [JsonPropertyName("triller_available")]
        public bool TrillerAvailable { get; }

        [JsonPropertyName("vcode")]
        public string Vcode { get; }

        [JsonPropertyName("vlink")]
        public string Vlink { get; }
    }

    public class Datum
    {
        public Datum(string id, string title, string image, string music, string url, string type, string description, int ctr, int position, MoreInfo moreInfo, string album, string extra, string language, int entity)
        {
            Id = id;
            Title = title;
            Image = image;
            Music = music;
            Url = url;
            Type = type;
            Description = description;
            Ctr = ctr;
            Position = position;
            MoreInfo = moreInfo;
            Album = album;
            Extra = extra;
            Language = language;
            Entity = entity;
        }

        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("title")]
        public string Title { get; }

        [JsonPropertyName("image")]
        public string Image { get; }

        [JsonPropertyName("music")]
        public string Music { get; }

        [JsonPropertyName("url")]
        public string Url { get; }

        [JsonPropertyName("type")]
        public string Type { get; }

        [JsonPropertyName("description")]
        public string Description { get; }

        [JsonPropertyName("ctr")]
        public int Ctr { get; }

        [JsonPropertyName("position")]
        public int Position { get; }

        [JsonPropertyName("more_info")]
        public MoreInfo MoreInfo { get; }

        [JsonPropertyName("album")]
        public string Album { get; }

        [JsonPropertyName("extra")]
        public string Extra { get; }

        [JsonPropertyName("language")]
        public string Language { get; }

        [JsonPropertyName("entity")]
        public int Entity { get; }
    }

    public class Albums
    {
        public Albums(List<Datum> data, int position)
        {
            Data = data;
            Position = position;
        }

        [JsonPropertyName("data")]
        public List<Datum> Data { get; }

        [JsonPropertyName("position")]
        public int Position { get; }
    }

    public class Songs
    {
        public Songs(List<Datum> data, int position)
        {
            Data = data;
            Position = position;
        }

        [JsonPropertyName("data")]
        public List<Datum> Data { get; }

        [JsonPropertyName("position")]
        public int Position { get; }
    }

    public class Playlists
    {
        public Playlists(List<Datum> data, int position)
        {
            Data = data;
            Position = position;
        }

        [JsonPropertyName("data")]
        public List<Datum> Data { get; }

        [JsonPropertyName("position")]
        public int Position { get; }
    }

    public class Artists
    {
        public Artists(List<Datum> data, int position)
        {
            Data = data;
            Position = position;
        }

        [JsonPropertyName("data")]
        public List<Datum> Data { get; }

        [JsonPropertyName("position")]
        public int Position { get; }
    }

    public class Topquery
    {
        public Topquery(List<Datum> data, int position)
        {
            Data = data;
            Position = position;
        }

        [JsonPropertyName("data")]
        public List<Datum> Data { get; }

        [JsonPropertyName("position")]
        public int Position { get; }
    }

    public class Shows
    {
        public Shows(List<object> data, int position)
        {
            Data = data;
            Position = position;
        }

        [JsonPropertyName("data")]
        public List<object> Data { get; }

        [JsonPropertyName("position")]
        public int Position { get; }
    }

    public class Episodes
    {
        public Episodes(List<object> data, int position)
        {
            Data = data;
            Position = position;
        }

        [JsonPropertyName("data")]
        public List<object> Data { get; }

        [JsonPropertyName("position")]
        public int Position { get; }
    }

    public class SearchResult
    {
        public SearchResult(Albums albums, Songs songs, Playlists playlists, Artists artists, Topquery topquery, Shows shows, Episodes episodes)
        {
            Albums = albums;
            Songs = songs;
            Playlists = playlists;
            Artists = artists;
            Topquery = topquery;
            Shows = shows;
            Episodes = episodes;
        }

        [JsonPropertyName("albums")]
        public Albums Albums { get; }

        [JsonPropertyName("songs")]
        public Songs Songs { get; }

        [JsonPropertyName("playlists")]
        public Playlists Playlists { get; }

        [JsonPropertyName("artists")]
        public Artists Artists { get; }

        [JsonPropertyName("topquery")]
        public Topquery Topquery { get; }

        [JsonPropertyName("shows")]
        public Shows Shows { get; }

        [JsonPropertyName("episodes")]
        public Episodes Episodes { get; }
    }


}