using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskhotel.Models;

namespace taskhotel.Services.Interfaces
{
    internal interface IRoomService
    {
        public void create();
        public void ShowAllRooms();
        public void Reserve();

    }
}
