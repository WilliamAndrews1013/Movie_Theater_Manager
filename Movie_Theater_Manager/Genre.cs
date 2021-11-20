using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Theater_Manager
{
    public class Genre
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Genre()
        {
            Code = "";
            Name = "";
            Description = "";
        }

        public Genre(string code, string name, string description)
        {
            Code = code;
            Name = name;
            Description = description;
        }
    }
}
