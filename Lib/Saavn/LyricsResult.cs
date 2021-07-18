using System.Text.Json.Serialization;

namespace Saavn
{

    public class LyricsResult
    {
        [JsonPropertyName("lyrics")]
        public string Lyrics { get; set; }

        [JsonPropertyName("script_tracking_url")]
        public string ScriptTrackingUrl { get; set; }

        [JsonPropertyName("lyrics_copyright")]
        public string LyricsCopyright { get; set; }

        [JsonPropertyName("snippet")]
        public string Snippet { get; set; }
    }

}