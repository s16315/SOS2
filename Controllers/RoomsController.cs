using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SOS.Models;
using SOS.Persistance;
using AutoMapper;
using SOS.Controllers.Resources;

namespace SOS.Controllers
{
    public class RoomsController : Controller
    {
        private readonly SosDBContext context;
        private readonly IMapper mapper;

        public RoomsController(SosDBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet("/api/rooms")]
        public async Task<IEnumerable<RoomResource>> GetRooms()
        {
            var rooms = await context.Rooms.ToListAsync();
            return mapper.Map<List<Room>, List<RoomResource>>(rooms);
        }
    }
}