using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tweetcool
{
    public class Tweet
    {
        public string UserName { get; set; }
        public string Comment { get; set; }
        public DateTime TweetingTime { get; set; }



        public Tweet(string username, string comment)
        {
            UserName = username;
            Comment = comment;
            TweetingTime = DateTime.Now;
        }
    }
}