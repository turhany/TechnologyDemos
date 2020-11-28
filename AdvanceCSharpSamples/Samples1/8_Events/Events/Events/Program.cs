using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() {Title = "Video 1"};
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var messageService = new MessageService(); //subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideEncoded;
            videoEncoder.Encode(video);

            Console.WriteLine("Encoded");
            Console.ReadLine();
        }

        public class MessageService
        {
            public void OnVideEncoded(object source, VideoEventArgs e) //EventArgs e)
            {
                Console.WriteLine("MessageService: Sending a text message...." + e.Video.Title);
            }
        }
    }
}
