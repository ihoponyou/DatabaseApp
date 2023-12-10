using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp
{
    public class Tag
    {
        public int ID { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }

        public Tag(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }

        
    }
}
