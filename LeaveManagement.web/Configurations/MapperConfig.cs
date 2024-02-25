using AutoMapper;
using LeaveManagement.web.Data;
using LeaveManagement.web.Models;

namespace LeaveManagement.web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType,LeaveTypeViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ReverseMap();
        }
    }
}
