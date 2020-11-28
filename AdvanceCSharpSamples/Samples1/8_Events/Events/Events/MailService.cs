using System;

namespace Events
{
    public class MailService
    {
        public void OnVideoEncoded(Object source, VideoEventArgs e)//EventArgs e)
        {
            Console.WriteLine("MailService:  Sending an email...." + e.Video.Title);
        }
    }
}