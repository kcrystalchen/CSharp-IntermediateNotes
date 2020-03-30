using System;
using System.Collections.Generic;

namespace ExceptionHandling
{

    public class YouTubeException : Exception // YoutubeException derive System Exception
    {
        public YouTubeException(string message, Exception innerException)
            : base(message, innerException) // call the base method from the Exception class and pass the message and innerException
        {

        }
    }

    public class YouTubeApi
    {

        public List<Video> GetVideos(string user) // get the user information from the user, then display the list of videos 
        {
            try
            {
                // Access YouTube web service
                // Read date
                // Create a list of Video objects
                throw new Exception("opps some low level YouTube error."); // innerExcept 
            }
            catch(Exception ex) // create a custom YouTube exception (create a custom YouTube exception class)
            {
                // if the try block have an error, then it run the catch block
                // first is setup the exception LOG
                // LOG
                // then throw the exceptions from the custom YouTube exception class 
                // ex is for troubleshooting to know what is the exactly problem happened 
                throw new YouTubeException("Could not fetch the videos from YouTube.", ex);
            }
            return new List<Video>();
        }
    }
}
