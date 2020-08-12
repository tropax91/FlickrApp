using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace FlickrApp.Requests
{
    public class FlickrAPI
    {
        public List<string> GetFeed()
        {
            string content = string.Empty;
            string url = @"https://www.flickr.com/services/feeds/photos_public.gne";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            XmlNodeList NodeList;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            //using (StreamReader reader = new StreamReader(stream))
            {
                //content = reader.ReadToEnd();
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(stream);
                NodeList = xDoc.GetElementsByTagName("link");
                
               

            }
            return NodeList.Cast<XmlNode>()/*.Where(node => node.Attributes["type"].Value == "image/jpeg")*/.Select(node => node.Attributes["href"].Value).ToList();
        }
    }
}
