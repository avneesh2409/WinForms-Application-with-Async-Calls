using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiHelperLibrary
{
    public class WebScrapingApiHelper
    {
        public static List<string> Urls;
        public static void LoadWebUrls() {
            Urls = new List<string>();
            string words = "The quick brown fox jumps over the lazy dog”. My favorite pangram is “Amazingly few discotheques provide jukeboxes";
            foreach (string word in words.Split(' '))
            {
                Urls.Add($"https://www.google.com/search?q={word}");
            }
        }
        public static List<Task<string>> GetWebContent()
        {
            LoadWebUrls();
            List<Task<string>> webContents = new List<Task<string>>();
            foreach (string item in Urls)
            {
                webContents.Add(CommonApiHelper.GetApiResult(item));
            }
            
            return webContents; 
        }
    }
}
