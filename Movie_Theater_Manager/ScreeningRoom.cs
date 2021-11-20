using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Theater_Manager
{
    public class ScreeningRoom
    {
        public string Code { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }

        public ScreeningRoom()
        {
            Code = "";
            Capacity = 0;
            Description = "";
        }

        public ScreeningRoom(string code, int capacity, string description)
        {
            Code = code;
            Capacity = capacity;
            Description = description;
        }
    }
}
