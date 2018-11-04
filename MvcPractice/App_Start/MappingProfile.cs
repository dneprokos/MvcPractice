using AutoMapper;
using MvcPractice.DTO;
using MvcPractice.Models;

namespace MvcPractice.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            //Domain to DTO
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();

            //DTO to Domain
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());            
            Mapper.CreateMap<MovieDto, Movie>().ForMember(m => m.Id, opt => opt.Ignore()); ;
        }
    }
}