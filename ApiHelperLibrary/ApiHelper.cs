using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ApiHelperLibrary
{
    public class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        public static void InitializeApi() {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
