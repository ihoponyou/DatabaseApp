using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp
{
    public class Review
    {
        public int ID { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public bool IsPositive {  get; set; }
        public string PostDate { get; set; }

        public Review(int id, string author, string content, bool isPositive, string postDate)
        {
            ID = id;
            Author = author;
            Content = content;
            IsPositive = isPositive;
            PostDate = postDate;
        }
    }
}
