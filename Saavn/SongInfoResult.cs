//Auto generated class from JsonToC# website 
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Saavn
{
    public class Rights
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        [JsonPropertyName("cacheable")]
        public bool Cacheable { get; set; }

        [JsonPropertyName("delete_cached_object")]
        public bool DeleteCachedObject { get; set; }
    }


    public class SongInfoResult
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("song")]
        public string Song { get; set; }

        [JsonPropertyName("album")]
        public string Album { get; set; }

        [JsonPropertyName("year")]
        public string Year { get; set; }

        [JsonPropertyName("music")]
        public string Music { get; set; }

        [JsonPropertyName("music_id")]
        public string MusicId { get; set; }

        [JsonPropertyName("primary_artists")]
        public string PrimaryArtists { get; set; }

        [JsonPropertyName("primary_artists_id")]
        public string PrimaryArtistsId { get; set; }

        [JsonPropertyName("featured_artists")]
        public string FeaturedArtists { get; set; }

        [JsonPropertyName("featured_artists_id")]
        public string FeaturedArtistsId { get; set; }

        [JsonPropertyName("singers")]
        public string Singers { get; set; }

        [JsonPropertyName("starring")]
        public string Starring { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("albumid")]
        public string Albumid { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("origin")]
        public string Origin { get; set; }

        [JsonPropertyName("play_count")]
        public int PlayCount { get; set; }

        [JsonPropertyName("copyright_text")]
        public string CopyrightText { get; set; }

        [JsonPropertyName("320kbps")]
        public string _320kbps { get; set; }

        [JsonPropertyName("is_dolby_content")]
        public bool IsDolbyContent { get; set; }

        [JsonPropertyName("explicit_content")]
        public int ExplicitContent { get; set; }

        [JsonPropertyName("has_lyrics")]
        public string HasLyrics { get; set; }

        [JsonPropertyName("lyrics_snippet")]
        public string LyricsSnippet { get; set; }

        [JsonPropertyName("encrypted_media_url")]
        public string EncryptedMediaUrl { get; set; }
        public ValueTask<string> DecryptedMediaUrl => DesDecryption.DecryptString(EncryptedMediaUrl);


        [JsonPropertyName("encrypted_media_path")]
        public string EncryptedMediaPath { get; set; }
        public ValueTask<string> DecryptedMediaPath => DesDecryption.DecryptString(EncryptedMediaPath);


        [JsonPropertyName("media_preview_url")]
        public string MediaPreviewUrl { get; set; }

        [JsonPropertyName("perma_url")]
        public string PermaUrl { get; set; }

        [JsonPropertyName("album_url")]
        public string AlbumUrl { get; set; }

        [JsonPropertyName("duration")]
        public string Duration { get; set; }

        [JsonPropertyName("rights")]
        public Rights Rights { get; set; }

        [JsonPropertyName("cache_state")]
        public string CacheState { get; set; }

        [JsonPropertyName("starred")]
        public string Starred { get; set; }

        [JsonPropertyName("artistMap")]
        public Dictionary<string,object> ArtistMap { get; set; }

        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; }

        [JsonPropertyName("triller_available")]
        public bool TrillerAvailable { get; set; }

        [JsonPropertyName("label_url")]
        public string LabelUrl { get; set; }
    }

}