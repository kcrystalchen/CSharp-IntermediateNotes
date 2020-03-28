using System;
using System.Threading;

namespace EventsAndDelegets
{

    public class VideoEventArgs : EventArgs // it is class contains the data about the video that is encoded || publisher
    {
        public Video Video { get; set; }

    }
    public class VideoEncoder
    {



        // implement an event from the videoEncoder, when video is encoded, and notify anyone who are interested in the event
        // three steps needs to follow in order to publish the video encoded event
        // 1. Define a Delegates: it is a contractor between the publisher and subscriber 
        // 2. Define an event based on the Delegate
        // 3. Raise the event


        // 1. define a delegate - have reference eventHandler method includes the source of the event and the additional information of the event
        // We want to send a reference to the video, so the subscriber knows which video is encoded, so we need to create a custom class
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // options: instead of creating 1. define delegate
        // EventHandler <- delegate type
        // EventHandler<TEventArgs>  <- delegate type
        // Public event EnevtHandler<VideoEventArgs> VideoEncoded;  // if we are using this event handler, we do not have to create delegate explicitly 
        // "EventHandler<>" is a way to express delegate that same as the way to define the delegate and we do not need "public event VideoEncodedEventHandler VideoEncoded; " as well

        // 2. define an event (VideoEncoded) based on the delegates (VideoEncodedEventHandler), so it is using the delegate eventHandler method name
        public event VideoEncodedEventHandler VideoEncoded;  

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video from Encode method - Video Encoder class" + video.Title);
            Thread.Sleep(3000);

            // the method should notify all of the subscribers 
            OnVideoEncoded(video);

        }

        // 3. Raise the event, so we need the methods that response for the event (VideoEncoded event); event publish method should be protected 
        protected virtual void OnVideoEncoded(Video video) // the name of the event: starting with on + the name of the event
        {
           // how to notify all the subscribers, to check if there is any subscribers to this event
           if(VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video}); // the source of the event is this, the current class to publish the event; if there is no additional data for the event, we can input an emty return
            }
        }

    }
}
