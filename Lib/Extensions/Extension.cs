using Microsoft.AspNetCore.Components.WebAssembly.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SaavnLib
{
    public static class Extension
    {
        public static Task<HttpResponseMessage> GetCorsSafe(this HttpClient client, string url)
        {
            if (OperatingSystem.IsBrowser())
            {
                var request = new HttpRequestMessage
                {
                    Method = new HttpMethod("GET"),
                    RequestUri = new Uri(url)
                };
                //request.Headers.Add("Access-Control-Allow-Origin", "*");
                request.SetBrowserRequestMode(BrowserRequestMode.Cors);
                return client.SendAsync(request);
            }
            return client.GetAsync(url);

        }
    }
}
