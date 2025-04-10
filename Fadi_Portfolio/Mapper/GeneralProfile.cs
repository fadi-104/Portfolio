using AutoMapper;
using Fadi_Portfolio.Entities;
using Fadi_Portfolio.Models;

namespace Fadi_Portfolio.Mapper
{
    public class GeneralProfile : Profile
    {

        public GeneralProfile()
        {
            CreateMap<CertificateModel, Certificate>()
                .ReverseMap();

            CreateMap<ServiceModel,Service>()
                .ReverseMap();
        }

    }
}
