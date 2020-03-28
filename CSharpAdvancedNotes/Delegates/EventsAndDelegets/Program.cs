using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegets
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video() { Title = "Video 1"};


            VideoEncoder videoEncoder = new VideoEncoder(); // publisher

            MailService mailService = new MailService(); // subscriber
            MessageServer messageServer = new MessageServer(); // another subscriber



            // before called the Encode method in the VideoEncoder class 
            // we need to setup the subscription from the Event - VideoEncoded Event (it was define from delegate VideoEncodedEventHandler)
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageServer.OnVideoEncoder; // this is not a method call, it is a reference or the pointer



            // then call the encode method, otherwise subscriber wont be notified the event
            videoEncoder.Encode(video);



        }
    }
}
