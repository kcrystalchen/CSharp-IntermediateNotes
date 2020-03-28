using System;

namespace EventsAndDelegets
{
    public class MessageServer
    {
        public void OnVideoEncoder(object source, VideoEventArgs args) //to pass the data from Video when the event happens
        {
            Console.WriteLine("From MessageServer class... " + args.Video.Title);
        }
    }
}
