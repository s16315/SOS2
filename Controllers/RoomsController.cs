using System;
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
    [Route("/api/rooms")]
    public class RoomsController : Controller
    {
        private readonly SosDBContext _context;
        private readonly IMapper _mapper;

        public RoomsController(SosDBContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
        [HttpGet]
        public async Task<IEnumerable<RoomResource>> GetRooms()
        {
            var rooms = await _context.Rooms.ToListAsync();
            return _mapper.Map<List<Room>, List<RoomResource>>(rooms);
        }
        [HttpPost]
        public async Task<IActionResult> CreateRoom([FromBody] RoomResource roomResource)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var room = _mapper.Map<RoomResource, Room>(roomResource);
            room.LastUpdate = DateTime.Now;
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();
            var result = _mapper.Map<Room, RoomResource>(room);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRoom(int id, [FromBody] RoomResource roomResource)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var room = await _context.Rooms.SingleOrDefaultAsync(v => v.Id == id);
            if (room == null) return NotFound();
            _mapper.Map<RoomResource, Room>(roomResource, room); 
            room.LastUpdate = DateTime.Now;
            await _context.SaveChangesAsync();
            var result = _mapper.Map<Room, RoomResource>(room);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoomById(int id)
        {
            var room = await _context.Rooms.SingleOrDefaultAsync(v => v.Id == id);
            if (room == null) return NotFound();
            var roomResource = _mapper.Map<Room, RoomResource>(room); 
            return Ok(roomResource);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteRoomById(int id)
        {
            var room = await _context.Rooms.FindAsync(id);
            if (room == null) return NotFound();
            _context.Remove(room);
            await _context.SaveChangesAsync();
            return Ok(id);
        }
    }
}