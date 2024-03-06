using Module18.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary;

namespace Module18.Receivers
{
    internal class YouTubeVideo : IReceiver
    {
        public string Uri { get; set; }
        internal YouTubeVideo(string uri)
        {
            Uri = uri;
        }
        public void Operation()
        {
            Console.WriteLine("Видео загружается");
            Console.WriteLine();
            
            //string uri = "https://www.youtube.com/shorts/k32u3ntp1e8";
            var youTube = YouTube.Default;
            var video = youTube.GetVideo(Uri);

            byte[] bytes = video.GetBytes();
            var stream = video.Stream();


            File.WriteAllBytes(video.FullName, bytes);

            Console.WriteLine("Видео загружено и сохранено");
        }
    }
}
