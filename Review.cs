using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp
{
    public class Review
    {
        public string Author { get; set; }
        public string Content { get; set; }
        public bool IsPositive {  get; set; }
        public string PostDate { get; set; }

        public Review(string author, string content, bool isPositive, string postDate)
        {
            Author = author;
            Content = content;
            IsPositive = isPositive;
            PostDate = postDate;
        }
    }
}
