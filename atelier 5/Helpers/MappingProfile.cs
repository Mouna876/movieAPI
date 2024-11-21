using AutoMapper;
using Dto;
using Models;

namespace atelier_5.Helpers
{
    public class MappingProfile: Profile
    {
        public MappingProfile() {
            CreateMap<Movie, MovieDetailsDto>();
            CreateMap<MovieDto, Movie>().ForMember(src => src.Poster,opt => opt.Ignore());
        }
    }
}
