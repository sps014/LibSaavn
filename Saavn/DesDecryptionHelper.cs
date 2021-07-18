using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Saavn
{
    internal class DesDecryption
    {
        private const string Key = "38346591";

        static HttpClient httpClient;
        public static async ValueTask<string> WasmDecryptAsync(string chipher)
        {
            httpClient ??= new HttpClient();

            var formContent = new Dictionary<string, string>
            {
                ["action"] = "ajax_decrypt",
                ["key"] = Key,
                ["text"] = chipher,
                ["algo"] = "des",
                ["mode"] = "ecb",
                ["decode"] = "checked",
                ["decode_method"] = "1"
            };
            var formData = new FormUrlEncodedContent(formContent);

            var res = await httpClient.PostAsync("https://www.tools4noobs.com/", formData);
            var response = await res.Content.ReadAsStringAsync();
            response = response.Replace("", " ");
            var match = Regex.Match(response, @"https?:\/(\/[a-z0-9_.%~=&-]*)*");
            if (match.Success)
                return match.Value;
            return string.Empty;
        }
        public static async ValueTask<string> DecryptString(string pToDecrypt)
        {
            if (OperatingSystem.IsBrowser())
            {
                return await WasmDecryptAsync(pToDecrypt);
            }

            var des = new DESCryptoServiceProvider();
            des.Padding = PaddingMode.PKCS7;
            var inputByteArray = Convert.FromBase64String(pToDecrypt);
            des.Key = Encoding.UTF8.GetBytes(Key);
            des.BlockSize = 64;
            des.Mode = CipherMode.ECB;
            var ms = new MemoryStream();
            var cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Encoding.Default.GetString(ms.ToArray());
        }
    }
}
