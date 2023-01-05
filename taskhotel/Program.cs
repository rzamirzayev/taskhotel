

using taskhotel.Models;
using taskhotel.Services.Implementations;
using taskhotel.Services.Interfaces;

int secim;
IRoomService service=new RoomService();
do
{
    Console.WriteLine("1.Create\n2.Show rooms\n3.Reserved\n4.Exit");
    secim=Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    if (secim == 1)
    {
        service.create();
    }
    else if (secim == 2)
    {
        service.ShowAllRooms();
    }
    else if (secim == 3)
    {
        service.Reserve();
    }

}while(secim!=4);