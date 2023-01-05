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
        Otel otel = new Otel();
      
        public void create()
        {
            int id;
           
            Room room = new Room();

            Array.Resize(ref otel.Rooms, otel.Rooms.Length + 1);
            otel.Rooms[otel.Rooms.Length-1]=room;
            
            
         
        }

        public void Reserve()
        {
            int no;
      
            
            Console.WriteLine("Hansi No-li otagi rezerv etmek istiyirsiniz:");
            no=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<otel.Rooms.Length;i++)
            {

                if (otel.Rooms[i].Id == no)
                {
                    if (otel.Rooms[i].IsReserved == false)
                    {
                        Console.WriteLine("Otaq rezerv olundu");
                        otel.Rooms[i].IsReserved = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Rezerv olunmus otaqdir");
                        break;
                    }
                    
                }
                


            }
  

        }

        public void ShowAllRooms()
        {
           for(int i = 0; i < otel.Rooms.Length; i++)
            {
                Console.Write(otel.Rooms[i].Id+".Idli otaq movcuddur.");
                if (otel.Rooms[i].IsReserved == false)
                {
                    Console.WriteLine("Otaq rezerv olunmuyub.");
                }
                else
                {
                    Console.WriteLine("Otaq rezerv olunub");
                }
                
            }
        }
    }
}
