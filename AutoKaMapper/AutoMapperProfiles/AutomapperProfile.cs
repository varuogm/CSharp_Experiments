using AutoKaMapper.Models;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace AutoKaMapper.AutoMapperProfiles
{ 
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<PuranaModel, NewModel>();
            CreateMap<PuranaModel, FutureModel>().ForMember(dest => (dest.Address), opt => opt.MapFrom(src => src.City));
            //CreateMap<List<printerProduct>, fleet>();
            CreateMap<List<printerProduct>, fleet>()
         .ForMember(dest => dest.PmoId, o => o.MapFrom(src => src.AsEnumerable()))
            .ForMember(dest => dest.SKU, opt => opt.MapFrom(src => src.AsEnumerable()))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.AsEnumerable()))
            ;
        }
    } 
}
