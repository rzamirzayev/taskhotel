using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskhotel.Models
{
    internal class Room
    {
        private static int _id = 0;
        public readonly int Id;
        public static int No;
        public double Price { get; set; }
        public bool IsReserved { get; set; }=false;
        
        public Room()
        {
            _id++;
            Id= _id;
            No = Id;
        }
         
            
    }
}
