using AutoMapper;
using BAL.ViewModel;
using DAL;

namespace BAL.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<DashboardVM, Dashboard>().ReverseMap();
        }
    }
}
