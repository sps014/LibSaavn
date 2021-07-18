namespace Saavn
{
    internal static class Endpoints
    {
        public const string SearchBaseUrl = "https://www.jiosaavn.com/api.php?__call=autocomplete.get&_format=json&_marker=0&cc=in&includeMetaTags=1&query=";
        public const string SongDetailUrl = "https://www.jiosaavn.com/api.php?__call=song.getDetails&cc=in&_marker=0%3F_marker%3D0&_format=json&pids=";
        public const string AlbumDetailUrl = "https://www.jiosaavn.com/api.php?__call=content.getAlbumDetails&_format=json&cc=in&_marker=0%3F_marker%3D0&albumid=";
        public const string PlaylistDetailUrl = "https://www.jiosaavn.com/api.php?__call=playlist.getDetails&_format=json&cc=in&_marker=0%3F_marker%3D0&listid=";
        public const string LyricsUrl = "https://www.jiosaavn.com/api.php?__call=lyrics.getLyrics&ctx=web6dot0&api_version=4&_format=json&_marker=0%3F_marker%3D0&lyrics_id=";
        public const string TopChartsUrl = "https://www.jiosaavn.com/api.php?__call=webapi.get&token=8MT-LQlP35c_&type=playlist&p=1&n=20&includeMetaTags=0&ctx=web6dot0&api_version=4&_format=json&_marker=0";
    }
}