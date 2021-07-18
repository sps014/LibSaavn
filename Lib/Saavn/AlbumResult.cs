using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Saavn
{

    public class AlbumResult
    {
        public AlbumResult(string title, string name, string year, string releaseDate, string primaryArtists, string primaryArtistsId, string albumid, string permaUrl, string image, List<Song> songs)
        {
            Title = title;
            Name = name;
            Year = year;
            ReleaseDate = releaseDate;
            PrimaryArtists = primaryArtists;
            PrimaryArtistsId = primaryArtistsId;
            Albumid = albumid;
            PermaUrl = permaUrl;
            Image = image;
            Songs = songs;
        }

        [JsonPropertyName("title")]
        public string Title { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("year")]
        public string Year { get; }

        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; }

        [JsonPropertyName("primary_artists")]
        public string PrimaryArtists { get; }

        [JsonPropertyName("primary_artists_id")]
        public string PrimaryArtistsId { get; }

        [JsonPropertyName("albumid")]
        public string Albumid { get; }

        [JsonPropertyName("perma_url")]
        public string PermaUrl { get; }

        [JsonPropertyName("image")]
        public string Image { get; }

        [JsonPropertyName("songs")]
        public List<Song> Songs { get; }
    }
}