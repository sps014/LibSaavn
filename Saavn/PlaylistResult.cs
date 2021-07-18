using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Saavn
{
    public class Song
    {
        public Song(string id, string type, string songName, string album, string year, string music, string musicId, string primaryArtists, string primaryArtistsId, string featuredArtists, string featuredArtistsId, string singers, string starring, string image, string label, string albumid, string language, string origin, string playCount, string copyrightText, string _320kbps, bool isDolbyContent, int explicitContent, string hasLyrics, string lyricsSnippet, string encryptedMediaUrl, string encryptedMediaPath, string mediaPreviewUrl, string permaUrl, string albumUrl, string duration, Rights rights, string cacheState, string starred, Dictionary<string, object> artistMap, string releaseDate, string vcode, string vlink, bool trillerAvailable, string labelUrl)
        {
            Id = id;
            Type = type;
            SongName = songName;
            Album = album;
            Year = year;
            Music = music;
            MusicId = musicId;
            PrimaryArtists = primaryArtists;
            PrimaryArtistsId = primaryArtistsId;
            FeaturedArtists = featuredArtists;
            FeaturedArtistsId = featuredArtistsId;
            Singers = singers;
            Starring = starring;
            Image = image;
            Label = label;
            Albumid = albumid;
            Language = language;
            Origin = origin;
            PlayCount = playCount;
            CopyrightText = copyrightText;
            this._320kbps = _320kbps;
            IsDolbyContent = isDolbyContent;
            ExplicitContent = explicitContent;
            HasLyrics = hasLyrics;
            LyricsSnippet = lyricsSnippet;
            EncryptedMediaUrl = encryptedMediaUrl;
            EncryptedMediaPath = encryptedMediaPath;
            MediaPreviewUrl = mediaPreviewUrl;
            PermaUrl = permaUrl;
            AlbumUrl = albumUrl;
            Duration = duration;
            Rights = rights;
            CacheState = cacheState;
            Starred = starred;
            ArtistMap = artistMap;
            ReleaseDate = releaseDate;
            Vcode = vcode;
            Vlink = vlink;
            TrillerAvailable = trillerAvailable;
            LabelUrl = labelUrl;
        }

        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("type")]
        public string Type { get; }

        [JsonPropertyName("song")]
        public string SongName { get; }

        [JsonPropertyName("album")]
        public string Album { get; }

        [JsonPropertyName("year")]
        public string Year { get; }

        [JsonPropertyName("music")]
        public string Music { get; }

        [JsonPropertyName("music_id")]
        public string MusicId { get; }

        [JsonPropertyName("primary_artists")]
        public string PrimaryArtists { get; }

        [JsonPropertyName("primary_artists_id")]
        public string PrimaryArtistsId { get; }

        [JsonPropertyName("featured_artists")]
        public string FeaturedArtists { get; }

        [JsonPropertyName("featured_artists_id")]
        public string FeaturedArtistsId { get; }

        [JsonPropertyName("singers")]
        public string Singers { get; }

        [JsonPropertyName("starring")]
        public string Starring { get; }

        [JsonPropertyName("image")]
        public string Image { get; }

        [JsonPropertyName("label")]
        public string Label { get; }

        [JsonPropertyName("albumid")]
        public string Albumid { get; }

        [JsonPropertyName("language")]
        public string Language { get; }

        [JsonPropertyName("origin")]
        public string Origin { get; }

        [JsonPropertyName("play_count")]
        public string PlayCount { get; }

        [JsonPropertyName("copyright_text")]
        public string CopyrightText { get; }

        [JsonPropertyName("320kbps")]
        public string _320kbps { get; }

        [JsonPropertyName("is_dolby_content")]
        public bool IsDolbyContent { get; }

        [JsonPropertyName("explicit_content")]
        public int ExplicitContent { get; }

        [JsonPropertyName("has_lyrics")]
        public string HasLyrics { get; }

        [JsonPropertyName("lyrics_snippet")]
        public string LyricsSnippet { get; }

        [JsonPropertyName("encrypted_media_url")]
        public string EncryptedMediaUrl { get; }
        public ValueTask<string> DecryptedMediaUrl => DesDecryption.DecryptString(EncryptedMediaUrl);

        [JsonPropertyName("encrypted_media_path")]
        public string EncryptedMediaPath { get; }
        public ValueTask<string> DecryptedMediaPath => DesDecryption.DecryptString(EncryptedMediaPath);

        [JsonPropertyName("media_preview_url")]
        public string MediaPreviewUrl { get; }

        [JsonPropertyName("perma_url")]
        public string PermaUrl { get; }

        [JsonPropertyName("album_url")]
        public string AlbumUrl { get; }

        [JsonPropertyName("duration")]
        public string Duration { get; }

        [JsonPropertyName("rights")]
        public Rights Rights { get; }

        [JsonPropertyName("cache_state")]
        public string CacheState { get; }

        [JsonPropertyName("starred")]
        public string Starred { get; }

        [JsonPropertyName("artistMap")]
        public Dictionary<string, object> ArtistMap { get; }

        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; }

        [JsonPropertyName("vcode")]
        public string Vcode { get; }

        [JsonPropertyName("vlink")]
        public string Vlink { get; }

        [JsonPropertyName("triller_available")]
        public bool TrillerAvailable { get; }

        [JsonPropertyName("label_url")]
        public string LabelUrl { get; }
    }

    public class PlaylistResult
    {
        [JsonPropertyName("listid")]
        public string Listid { get; }

        [JsonPropertyName("listname")]
        public string Listname { get; }

        [JsonPropertyName("perma_url")]
        public string PermaUrl { get; }

        [JsonPropertyName("follower_count")]
        public string FollowerCount { get; }

        [JsonPropertyName("uid")]
        public string Uid { get; }

        [JsonPropertyName("last_updated")]
        public string LastUpdated { get; }

        [JsonPropertyName("username")]
        public string Username { get; }

        [JsonPropertyName("firstname")]
        public string Firstname { get; }

        [JsonPropertyName("lastname")]
        public string Lastname { get; }

        [JsonPropertyName("is_followed")]
        public object IsFollowed { get; }

        [JsonPropertyName("isFY")]
        public bool IsFY { get; }

        [JsonPropertyName("image")]
        public string Image { get; }

        [JsonPropertyName("share")]
        public string Share { get; }

        [JsonPropertyName("songs")]
        public List<Song> Songs { get; }

        [JsonPropertyName("type")]
        public string Type { get; }

        [JsonPropertyName("list_count")]
        public string ListCount { get; }

        [JsonPropertyName("fan_count")]
        public int FanCount { get; }

        [JsonPropertyName("H2")]
        public object H2 { get; }

        [JsonPropertyName("is_dolby_playlist")]
        public bool IsDolbyPlaylist { get; }

        [JsonPropertyName("subheading")]
        public object Subheading { get; }

        [JsonPropertyName("sub_types")]
        public List<object> SubTypes { get; }

        [JsonPropertyName("images")]
        public List<object> Images { get; }

        [JsonPropertyName("video_available")]
        public bool VideoAvailable { get; }

        [JsonPropertyName("video_count")]
        public int VideoCount { get; }
    }


}