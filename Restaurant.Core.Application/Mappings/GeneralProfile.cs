using AutoMapper;
using Restaurant.Core.Application.Dtos.Account;
using Restaurant.Core.Application.ViewModels.Ingredientes;
using Restaurant.Core.Application.ViewModels.Mesa;
using Restaurant.Core.Application.ViewModels.Orden;
using Restaurant.Core.Application.ViewModels.Plato;
using Restaurant.Core.Application.ViewModels.Users;
using Restaurant.Core.Domain.Entities;

namespace Restaurant.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {

            CreateMap<Plato, PlatoViewModel>()
                .ForMember(dest => dest.Ingredientes, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreateBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Plato, SavePlatoViewModel>()
                .ForMember(dest => dest.Ingredientes, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreateBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<PlatoViewModel, SavePlatoViewModel>()
                .ReverseMap();









            CreateMap<Mesa, MesaViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreateBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Mesa, SaveMesaViewModel>()
                    .ReverseMap()
                    .ForMember(dest => dest.Created, opt => opt.Ignore())
                    .ForMember(dest => dest.CreateBy, opt => opt.Ignore())
                    .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                    .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<SaveMesaViewModel, MesaViewModel>()
                    .ReverseMap();









            CreateMap<Ingredientes, IngredientesViewModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nombre))
                .ReverseMap()
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreateBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());


            CreateMap<Ingredientes, SaveIngredientesViewModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nombre))
                .ReverseMap()
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Platos, opt => opt.Ignore())
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreateBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<SaveIngredientesViewModel, IngredientesViewModel>()
                .ReverseMap();








            CreateMap<Orden, OrdenViewModel>()
                .ForMember(dest => dest.Platos, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreateBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Orden, SaveOrdenViewModel>()
                .ForMember(dest => dest.Platos, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreateBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<SaveOrdenViewModel, OrdenViewModel>()
                .ReverseMap();






            CreateMap<AuthenticationRequest, LoginDTO>()
                .ForMember(dest => dest.HasError, opt => opt.Ignore())
                .ForMember(dest => dest.Error, opt => opt.Ignore())
                .ReverseMap();




            CreateMap<RegisterRequest, SaveUserDTO>()
                .ForMember(x => x.HasError, opt => opt.Ignore())
                .ForMember(x => x.Error, opt => opt.Ignore())
                .ReverseMap();




        }
    }
}
