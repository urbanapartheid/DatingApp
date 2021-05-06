using API.DTOs;
using API.Entities;
using API.Extensions;
using AutoMapper;
using System.Linq;

namespace API.Helper
{
    public class AutoMapperProfiles : Profile
    {
        #region CTOR
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>()
                .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src =>
                    src.Photos.FirstOrDefault(u => u.IsMain).Url))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CaluculateAge()));
            CreateMap<Photo, PhotoDto>();
        } 
        #endregion
    }
}
