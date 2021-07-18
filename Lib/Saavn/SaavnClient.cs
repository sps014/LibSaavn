using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using Saavn.Search;
using Saavn.TopCharts;
using SaavnLib;

namespace Saavn
{
    public class SaavnClient
    {
        private readonly HttpClient _httpClient;
        public HttpClient Http => _httpClient;
        public SaavnClient()
        {
            _httpClient = new HttpClient();
            //_httpClient.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
        }
        public SaavnClient([NotNull] HttpClient client)
        {
            _httpClient = client;
        }


        public async ValueTask<SearchResult> SearchAsync(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                throw new ArgumentNullException($"parameter query is null or whitespace {query}");

            var encodedQuery = HttpUtility.UrlEncode(query);

            var response = await _httpClient.GetCorsSafe(Endpoints.SearchBaseUrl + encodedQuery);
            var json = await response.Content.ReadAsStringAsync();
            try
            {
                return JsonSerializer.Deserialize<SearchResult>(json);
            }
            catch
            {
                throw new Exception($"failed to process search json response for query {query}");
            }
        }
        public async ValueTask<TopSearchResult> GetTopChartsAsync()
        {


            var response = await _httpClient.GetCorsSafe(Endpoints.TopChartsUrl);
            var json = await response.Content.ReadAsStringAsync();
            try
            {
                return JsonSerializer.Deserialize<TopSearchResult>(json);
            }
            catch
            {
                throw new Exception("failed to process top chart's json response for query");
            }
        }


        public async ValueTask<SongInfoResult> GetSongInfoAsync(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentNullException($"parameter id is null or whitespace {id}");


            var response = await _httpClient.GetCorsSafe(Endpoints.SongDetailUrl + id);
            var json = await response.Content.ReadAsStringAsync();
            try
            {
                var jsonDoc = JsonSerializer.Deserialize<Dictionary<string, object>>(json);
                if (jsonDoc == null || !jsonDoc.ContainsKey(id))
                {
                    throw new Exception($"invalid response , missing id:{id} in body");
                }
                var songJson = JsonSerializer.Serialize(jsonDoc[id]);
                return JsonSerializer.Deserialize<SongInfoResult>(songJson);
            }
            catch
            {
                throw new Exception($"failed to process song's json response for id {id}");
            }
        }

        public async ValueTask<LyricsResult> GetLyricsAsync(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentNullException($"parameter id is null or whitespace {id}");


            var response = await _httpClient.GetCorsSafe(Endpoints.LyricsUrl + id);
            var json = await response.Content.ReadAsStringAsync();
            try
            {
                var res = JsonSerializer.Deserialize<LyricsResult>(json);
                if (res is { Lyrics: { } })
                    res.Lyrics = res.Lyrics.Replace("<br>", "\n");
                return res;
            }
            catch
            {
                throw new Exception($"failed to process lyrics json response for id {id}");
            }
        }

        public async ValueTask<AlbumResult> GetAlbumAsync(string albumid)
        {
            if (string.IsNullOrWhiteSpace(albumid))
                throw new ArgumentNullException($"parameter id is null or whitespace {albumid}");


            var response = await _httpClient.GetCorsSafe(Endpoints.AlbumDetailUrl + albumid);
            var json = await response.Content.ReadAsStringAsync();
            try
            {
                var res = JsonSerializer.Deserialize<AlbumResult>(json);
                return res;
            }
            catch
            {
                throw new Exception($"failed to process album's json response for id {albumid}");
            }
        }

        public async ValueTask<PlaylistResult> GetPlayListAsync(string playlistId)
        {
            if (string.IsNullOrWhiteSpace(playlistId))
                throw new ArgumentNullException($"parameter id is null or whitespace {playlistId}");


            var response = await _httpClient.GetCorsSafe(Endpoints.PlaylistDetailUrl + playlistId);
            var json = await response.Content.ReadAsStringAsync();
            try
            {
                var res = JsonSerializer.Deserialize<PlaylistResult>(json);
                return res;
            }
            catch
            {
                throw new Exception($"failed to process album's json response for id {playlistId}");
            }
        }
    }
}