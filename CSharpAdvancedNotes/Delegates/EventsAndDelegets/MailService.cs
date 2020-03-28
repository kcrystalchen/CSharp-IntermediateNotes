using System;

namespace EventsAndDelegets
{
    // this mail server needs to subscribe the videoEncodedEvent's VideoEncoded
    public class MailService
    {
        // onVideoEncoded is the handler in the MailService
        public void OnVideoEncoded(object source, VideoEventArgs e)  //to pass the data from Video when the event happens
        {
            
            Console.WriteLine("From MailService class..." + e.Video.Title);
        }
    }
}
