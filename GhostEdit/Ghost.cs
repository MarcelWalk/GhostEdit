using Jose;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace GhostEdit
{
    class Ghost
    {

        public string TokenId { get; set; }
        public string TokenSecret { get; set; }
        public string AuthToken { get; set; }

        public Ghost(string adminToken)
        {
            string tokenStr = "5f5e8c5f9a3f6219000f7528:4d8b084e3269cb06b6570608522c48471c21822eda298e8044b38da0e8955db3";

            TokenId = tokenStr.Split(":")[0];
            TokenSecret = tokenStr.Split(":")[1];

            var extraHead = new Dictionary<string, object>()
            {
                { "als", "HS256"},
                { "typ", "JWT"},
                {"kid", TokenId }
            };
            long iat = DateTime.Now.Ticks;
            var payload = new Dictionary<string, object>()
            {
                { "iat", iat},
                { "exp", iat + 5 * 60},
                {"aud", "/v3/admin/" }
            };
            var secretKey = ConvertHexStringToByteArray(TokenSecret);

            AuthToken = Jose.JWT.Encode(payload, secretKey, JwsAlgorithm.HS256, extraHead);
        }

        public bool CreatePostFromHtml(string htmlText)
        {
            HttpClient clientTest = new HttpClient();

            HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Post, "https://nyasaki.dev/ghost/api/v3/admin/posts/");

            httpRequest.Content = new StringContent(htmlText, Encoding.UTF8, "application/json");
            httpRequest.Headers.Authorization = new AuthenticationHeaderValue("Ghost", AuthToken);

            var response = clientTest.SendAsync(httpRequest).Result;

            return response.IsSuccessStatusCode;
        }

        public static byte[] ConvertHexStringToByteArray(string hexString)
        {
            if (hexString.Length % 2 != 0)
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", hexString));
            }

            byte[] data = new byte[hexString.Length / 2];
            for (int index = 0; index < data.Length; index++)
            {
                string byteValue = hexString.Substring(index * 2, 2);
                data[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }

            return data;
        }
    }

}
