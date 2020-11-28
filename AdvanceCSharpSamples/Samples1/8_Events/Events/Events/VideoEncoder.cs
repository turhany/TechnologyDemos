using System;
using System.Threading;

namespace Events
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }

    }

    public class VideoEncoder
    {
        //1 - Define a delegate
        //2 - Define an event based ýn that delegate
        //3 - Raise the Event

        //public delegate void VideoEncodedEventHandler(Object source, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;

        //Yukarýda ki gibi olan Event handler yapýsýný kolaylaþtýrmak için .net 
        //EventHandler
        //EventHandler<TEventArgs>
        //yapýsýný getirmiþtir

        //yeni hali
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video....");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() {Video = video});//EventArgs.Empty);
            }
        }
    }
}