using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskhotel.Models;
using taskhotel.Services.Interfaces;

namespace taskhotel.Services.Implementations
{
    internal class RoomService : IRoomService
    {
        Otel otel=new Otel();
        public void create()
        {
            
            Room room = new Room();
            Array.Resize(ref otel.Rooms, otel.Rooms.Length + 1);
            otel.Rooms[otel.Rooms.Length-1]=room;
            
            
         
        }

        public void Reserve()
        {
            int id;
            Console.WriteLine("Hansi id-li otagi rezerv etmek istiyirsiniz:");
            id=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<otel.Rooms.Length;i++)
            {
                if (otel.Rooms[i].Id == id)
                {
                    Console.WriteLine("otaq rezerv olunub.");
                    break;
                    
                }
                 else
                {

                    Console.WriteLine("Size" + (Room.No + 1) + " nomreli otagi rezerv ede bilerik.");
                    Console.WriteLine("Rezerv etmek ucun H basin.Etmek istemirsinizse Y basin");
                    string secim;
                    secim = Console.ReadLine();
                    if (secim.ToUpper() == "H")
                    {
                        create();
                    }
                    else if (secim.ToUpper() == "Y")
                    {
                        Console.WriteLine("Geldiyiniz ucun Tesekkurler.");
                    }
                }

                break;  
            }
        }

        public void ShowAllRooms()
        {
           for(int i = 0; i < otel.Rooms.Length; i++)
            {
                Console.WriteLine(otel.Rooms[i].Id+".nomreli otaq");
            }
        }
    }
}
