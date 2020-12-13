using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;

namespace WindowsFormsApp1.Common
{
    public class HtmlParser
    {
        public static string HtmlDomParser(string data) {
                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(data);
                var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//html");
            if (htmlBody != null)
            {
                return htmlBody.InnerText;
            }
            else {
                return "anchor not found";
            }
        }
    }
}
