using System;

namespace DesignAStackOverFlowPost
{
    // 1. design a class called "Post" - property title, description and the date/time
    // 2. up-vote or down-vote a post (up-vote and down-vote methods)
    // 3. displaying current vote value (console.writeline current vote value)
    // 4. Should not give ability to set the Vote property from the outside (vote are private)
    public class Post
    {
        public string title { get; set; }
        public string description { get; set; }
        public DateTime DateTime { get; set; }
        private int CurrentVote { get; set; }


        public int TotalVote()
        {
            Console.WriteLine("Total Vote Value " + CurrentVote);
            return CurrentVote;
        }

        public int UpVote()
        {
            CurrentVote += 1;
            return CurrentVote;
        }
        
        public int downVote()
        {
            CurrentVote -= 1;
            return CurrentVote;
        }
    } 
}
