using ModelLibrary;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiHelperLibrary
{
    public class ComicApiHelper
    {
        public static async Task<ComicModel> GetComic(string url) {
            string response = await CommonApiHelper.GetApiResult(url);
            ComicModel comic = JsonSerializer.Deserialize<ComicModel>(response);
            return comic;
        }
    }
}
