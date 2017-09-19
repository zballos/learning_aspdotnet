using AutoMapper;
using EZ.MvcDotNet.Application.ViewModels;
using EZ.MvcDotNet.Domain.Entities;

namespace EZ.MvcDotNet.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        /*public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }*/

        public DomainToViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Cliente, ClienteEnderecoViewModel>();
            CreateMap<Endereco, ClienteEnderecoViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();
        }


        // Obsoleto in v4.x
        /*protected override void Configure()
        {
            CreateMap<Cliente, ClienteViewModel>();
        }*/
    }
}