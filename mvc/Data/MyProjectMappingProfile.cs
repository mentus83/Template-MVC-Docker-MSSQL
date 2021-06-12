using AutoMapper;
using mvc.Models.Entities;
using mvc.Models.ViewModels;

namespace mvc.Data
{
    public class MyProjectMappingProfile : Profile
    {
        public MyProjectMappingProfile()
        {
            CreateMap<MyObject, MyObjectViewModel>().ReverseMap();

            CreateMap<MyObjectItem, MyObjectItemViewModel>().ReverseMap();
        }
    }
}