using System.Collections.Generic;

namespace Polymorphism
{
    public class VideoEncoder  
    {
        private readonly IList<INotificationChannel> _notificationChannel;

        public VideoEncoder()
        {
            _notificationChannel = new List<INotificationChannel>();
        }

        
        public void Encode(Video video)
            //get video object method
            // once video encoded, we send the email  to the person who upload the video on the website 
        {
            // video encoding logic
            foreach (var channel in _notificationChannel)
            {
                channel.Send(new Message());
            }
           

        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannel.Add(channel);
        }


    }
}