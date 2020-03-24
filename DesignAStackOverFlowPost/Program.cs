using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignAStackOverFlowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post();
            post.title = "levelUp";
            post.description = "Stack-over Flow post";
            post.DateTime = DateTime.Now;


            for(var x = 0; x < 10; x += 1)
            {
                post.UpVote();
               
            }

             post.downVote();
             post.TotalVote();



             Console.WriteLine("The total Vote is " + post.TotalVote());
        }
    }
}
