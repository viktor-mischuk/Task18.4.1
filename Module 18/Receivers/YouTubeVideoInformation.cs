using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module18.Interfaces;
using VideoLibrary;
namespace Module18.Receivers
{
    internal class YouTubeVideoInformation : IReceiver
    {

        public string Uri { get; set; }
        internal YouTubeVideoInformation(string uri)
        {
            Uri = uri;
        }

       

        public void Operation()
        {
            //string uri = "https://www.youtube.com/watch?v=SRSfAjA00jI";
            var youTube = YouTube.Default;
            var video = youTube.GetVideo(Uri);

            string title = video.Title;
            VideoInfo info = video.Info; // (Title,Author,LengthSeconds)
            string fileExtension = video.FileExtension;
            string fullName = video.FullName; // same thing as title + fileExtension
            int resolution = video.Resolution;

            Console.WriteLine($"Видео: {title}");
            Console.WriteLine();
            
        }


    }
}
