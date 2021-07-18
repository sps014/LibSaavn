using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Saavn.TopCharts
{
    public class Rights
    {
        public Rights(string code, string cacheable, string deleteCachedObject, string reason)
        {
            Code = code;
            Cacheable = cacheable;
            DeleteCachedObject = deleteCachedObject;
            Reason = reason;
        }

        [JsonPropertyName("code")]
        public string Code { get; }

        [JsonPropertyName("cacheable")]
        public string Cacheable { get; }

        [JsonPropertyName("delete_cached_object")]
        public string DeleteCachedObject { get; }

        [JsonPropertyName("reason")]
        public string Reason { get; }
    }

    public class PrimaryArtist
    {
        public PrimaryArtist(string id, string name, string role, string image, string type, string permaUrl)
        {
            Id = id;
            Name = name;
            Role = role;
            Image = image;
            Type = type;
            PermaUrl = permaUrl;
        }

        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("role")]
        public string Role { get; }

        [JsonPropertyName("image")]
        public string Image { get; }

        [JsonPropertyName("type")]
        public string Type { get; }

        [JsonPropertyName("perma_url")]
        public string PermaUrl { get; }
    }

    public class FeaturedArtist
    {
        public FeaturedArtist(string id, string name, string role, string image, string type, string permaUrl)
        {
            Id = id;
            Name = name;
            Role = role;
            Image = image;
            Type = type;
            PermaUrl = permaUrl;
        }

        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("role")]
        public string Role { get; }

        [JsonPropertyName("image")]
        public string Image { get; }

        [JsonPropertyName("type")]
        public string Type { get; }

        [JsonPropertyName("perma_url")]
        public string PermaUrl { get; }
    }

    public class Artist
    {
        public Artist(string id, string name, string role, string image, string type, string permaUrl)
        {
            Id = id;
            Name = name;
            Role = role;
            Image = image;
            Type = type;
            PermaUrl = permaUrl;
        }

        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("role")]
        public string Role { get; }

        [JsonPropertyName("image")]
        public string Image { get; }

        [JsonPropertyName("type")]
        public string Type { get; }

        [JsonPropertyName("perma_url")]
        public string PermaUrl { get; }
    }

    public class ArtistMap
    {
        public ArtistMap(List<PrimaryArtist> primaryArtists, List<FeaturedArtist> featuredArtists, List<Artist> artists)
        {
            PrimaryArtists = primaryArtists;
            FeaturedArtists = featuredArtists;
            Artists = artists;
        }

        [JsonPropertyName("primary_artists")]
        public List<PrimaryArtist> PrimaryArtists { get; }

        [JsonPropertyName("featured_artists")]
        public List<FeaturedArtist> FeaturedArtists { get; }

        [JsonPropertyName("artists")]
        public List<Artist> Artists { get; }
    }

    public class MoreInfo
    {
        public MoreInfo(string music, string albumId, string album, string label, string origin, bool isDolbyContent, string _320kbps, string encryptedMediaUrl, string encryptedCacheUrl, string albumUrl, string duration, Rights rights, string cacheState, string hasLyrics, string lyricsSnippet, string starred, string copyrightText, ArtistMap artistMap, string releaseDate, string labelUrl, string vcode, string vlink, bool trillerAvailable, string lyricsId, string uid, List<object> subtype, string lastUpdated, string username, string firstname, string lastname, string isFollowed, bool isFY, string followerCount, string fanCount, string playlistType, string share, List<object> subTypes, List<object> images, string h2, object subheading, string videoCount)
        {
            Music = music;
            AlbumId = albumId;
            Album = album;
            Label = label;
            Origin = origin;
            IsDolbyContent = isDolbyContent;
            this._320kbps = _320kbps;
            EncryptedMediaUrl = encryptedMediaUrl;
            EncryptedCacheUrl = encryptedCacheUrl;
            AlbumUrl = albumUrl;
            Duration = duration;
            Rights = rights;
            CacheState = cacheState;
            HasLyrics = hasLyrics;
            LyricsSnippet = lyricsSnippet;
            Starred = starred;
            CopyrightText = copyrightText;
            ArtistMap = artistMap;
            ReleaseDate = releaseDate;
            LabelUrl = labelUrl;
            Vcode = vcode;
            Vlink = vlink;
            TrillerAvailable = trillerAvailable;
            LyricsId = lyricsId;
            Uid = uid;
            Subtype = subtype;
            LastUpdated = lastUpdated;
            Username = username;
            Firstname = firstname;
            Lastname = lastname;
            IsFollowed = isFollowed;
            IsFY = isFY;
            FollowerCount = followerCount;
            FanCount = fanCount;
            PlaylistType = playlistType;
            Share = share;
            SubTypes = subTypes;
            Images = images;
            H2 = h2;
            Subheading = subheading;
            VideoCount = videoCount;
        }

        [JsonPropertyName("music")]
        public string Music { get; }

        [JsonPropertyName("album_id")]
        public string AlbumId { get; }

        [JsonPropertyName("album")]
        public string Album { get; }

        [JsonPropertyName("label")]
        public string Label { get; }

        [JsonPropertyName("origin")]
        public string Origin { get; }

        [JsonPropertyName("is_dolby_content")]
        public bool IsDolbyContent { get; }

        [JsonPropertyName("320kbps")]
        public string _320kbps { get; }

        [JsonPropertyName("encrypted_media_url")]
        public string EncryptedMediaUrl { get; }
        public ValueTask<string> DecryptedMediaUrl => DesDecryption.DecryptString(EncryptedMediaUrl);

        [JsonPropertyName("encrypted_cache_url")]
        public string EncryptedCacheUrl { get; }
        public ValueTask<string> DecryptedCacheUrl => DesDecryption.DecryptString(EncryptedCacheUrl);


        [JsonPropertyName("album_url")]
        public string AlbumUrl { get; }

        [JsonPropertyName("duration")]
        public string Duration { get; }

        [JsonPropertyName("rights")]
        public Rights Rights { get; }

        [JsonPropertyName("cache_state")]
        public string CacheState { get; }

        [JsonPropertyName("has_lyrics")]
        public string HasLyrics { get; }

        [JsonPropertyName("lyrics_snippet")]
        public string LyricsSnippet { get; }

        [JsonPropertyName("starred")]
        public string Starred { get; }

        [JsonPropertyName("copyright_text")]
        public string CopyrightText { get; }

        [JsonPropertyName("artistMap")]
        public ArtistMap ArtistMap { get; }

        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; }

        [JsonPropertyName("label_url")]
        public string LabelUrl { get; }

        [JsonPropertyName("vcode")]
        public string Vcode { get; }

        [JsonPropertyName("vlink")]
        public string Vlink { get; }

        [JsonPropertyName("triller_available")]
        public bool TrillerAvailable { get; }

        [JsonPropertyName("lyrics_id")]
        public string LyricsId { get; }

        [JsonPropertyName("uid")]
        public string Uid { get; }

        [JsonPropertyName("subtype")]
        public List<object> Subtype { get; }

        [JsonPropertyName("last_updated")]
        public string LastUpdated { get; }

        [JsonPropertyName("username")]
        public string Username { get; }

        [JsonPropertyName("firstname")]
        public string Firstname { get; }

        [JsonPropertyName("lastname")]
        public string Lastname { get; }

        [JsonPropertyName("is_followed")]
        public string IsFollowed { get; }

        [JsonPropertyName("isFY")]
        public bool IsFY { get; }

        [JsonPropertyName("follower_count")]
        public string FollowerCount { get; }

        [JsonPropertyName("fan_count")]
        public string FanCount { get; }

        [JsonPropertyName("playlist_type")]
        public string PlaylistType { get; }

        [JsonPropertyName("share")]
        public string Share { get; }

        [JsonPropertyName("sub_types")]
        public List<object> SubTypes { get; }

        [JsonPropertyName("images")]
        public List<object> Images { get; }

        [JsonPropertyName("H2")]
        public string H2 { get; }

        [JsonPropertyName("subheading")]
        public object Subheading { get; }

        [JsonPropertyName("video_count")]
        public string VideoCount { get; }
    }

    public class List
    {
        public List(string id, string title, string subtitle, string headerDesc, string type, string permaUrl, string image, string language, string year, string playCount, string explicitContent, string listCount, string listType, string lists, MoreInfo moreInfo, string source, int position, string scrollType, string highlight, bool simpleHeader, bool noHeader, List<object> viewMore)
        {
            Id = id;
            Title = title;
            Subtitle = subtitle;
            HeaderDesc = headerDesc;
            Type = type;
            PermaUrl = permaUrl;
            Image = image;
            Language = language;
            Year = year;
            PlayCount = playCount;
            ExplicitContent = explicitContent;
            ListCount = listCount;
            ListType = listType;
            Lists = lists;
            MoreInfo = moreInfo;
            Source = source;
            Position = position;
            ScrollType = scrollType;
            Highlight = highlight;
            SimpleHeader = simpleHeader;
            NoHeader = noHeader;
            ViewMore = viewMore;
        }

        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("title")]
        public string Title { get; }

        [JsonPropertyName("subtitle")]
        public string Subtitle { get; }

        [JsonPropertyName("header_desc")]
        public string HeaderDesc { get; }

        [JsonPropertyName("type")]
        public string Type { get; }

        [JsonPropertyName("perma_url")]
        public string PermaUrl { get; }

        [JsonPropertyName("image")]
        public string Image { get; }

        [JsonPropertyName("language")]
        public string Language { get; }

        [JsonPropertyName("year")]
        public string Year { get; }

        [JsonPropertyName("play_count")]
        public string PlayCount { get; }

        [JsonPropertyName("explicit_content")]
        public string ExplicitContent { get; }

        [JsonPropertyName("list_count")]
        public string ListCount { get; }

        [JsonPropertyName("list_type")]
        public string ListType { get; }

        [JsonPropertyName("list")]
        public string Lists { get; }

        [JsonPropertyName("more_info")]
        public MoreInfo MoreInfo { get; }

        [JsonPropertyName("source")]
        public string Source { get; }

        [JsonPropertyName("position")]
        public int Position { get; }

        [JsonPropertyName("scroll_type")]
        public string ScrollType { get; }

        [JsonPropertyName("highlight")]
        public string Highlight { get; }

        [JsonPropertyName("simpleHeader")]
        public bool SimpleHeader { get; }

        [JsonPropertyName("noHeader")]
        public bool NoHeader { get; }

        [JsonPropertyName("view_more")]
        public List<object> ViewMore { get; }
    }

    public class Modules
    {
        public Modules(List list)
        {
            List = list;
        }

        [JsonPropertyName("list")]
        public List List { get; }
    }

    public class TopSearchResult
    {
        public TopSearchResult(string id, string title, string subtitle, string headerDesc, string type, string permaUrl, string image, string language, string year, string playCount, string explicitContent, string listCount, string listType, List<List> list, MoreInfo moreInfo, Modules modules)
        {
            Id = id;
            Title = title;
            Subtitle = subtitle;
            HeaderDesc = headerDesc;
            Type = type;
            PermaUrl = permaUrl;
            Image = image;
            Language = language;
            Year = year;
            PlayCount = playCount;
            ExplicitContent = explicitContent;
            ListCount = listCount;
            ListType = listType;
            List = list;
            MoreInfo = moreInfo;
            Modules = modules;
        }

        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("title")]
        public string Title { get; }

        [JsonPropertyName("subtitle")]
        public string Subtitle { get; }

        [JsonPropertyName("header_desc")]
        public string HeaderDesc { get; }

        [JsonPropertyName("type")]
        public string Type { get; }

        [JsonPropertyName("perma_url")]
        public string PermaUrl { get; }

        [JsonPropertyName("image")]
        public string Image { get; }

        [JsonPropertyName("language")]
        public string Language { get; }

        [JsonPropertyName("year")]
        public string Year { get; }

        [JsonPropertyName("play_count")]
        public string PlayCount { get; }

        [JsonPropertyName("explicit_content")]
        public string ExplicitContent { get; }

        [JsonPropertyName("list_count")]
        public string ListCount { get; }

        [JsonPropertyName("list_type")]
        public string ListType { get; }

        [JsonPropertyName("list")]
        public List<List> List { get; }

        [JsonPropertyName("more_info")]
        public MoreInfo MoreInfo { get; }

        [JsonPropertyName("modules")]
        public Modules Modules { get; }
    }


}