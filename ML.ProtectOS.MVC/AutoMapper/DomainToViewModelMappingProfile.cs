using AutoMapper;
using ML.ProtectOS.Domain.Entities;
using ML.ProtectOS.MVC.ViewModels;


namespace ML.ProtectOS.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ProdutoViewModel, Produto>();
        }

    }
}