using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskhotel.Models
{
    internal class Otel
    {
        private static int _id = 0;
        public readonly int Id;
        public string Name;
        public Room[] Rooms=new Room[0];
        public Otel() 
        {
            _id++;
            Id= _id;    
        }
    }
}
