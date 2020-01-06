using AutoMapper;
using SOS.Controllers.Resources;
using SOS.Models;

namespace SOS.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Room, RoomResource>();
        }
        
    }
}