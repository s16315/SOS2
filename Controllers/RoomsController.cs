using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SOS.Models;
using SOS.Persistance;

namespace SOS.Controllers
{
    public class RoomsController : Controller
    {
        private readonly SosDBContext context;

        public RoomsController(SosDBContext context)
        {
            this.context = context;
        }
        [HttpGet("/api/rooms")]
        public IEnumerable<Room> GetRooms()
        {
            return context.Rooms;
        }
    }
}