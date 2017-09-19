using AutoMapper;
using EZ.MvcDotNet.Application.ViewModels;
using EZ.MvcDotNet.Domain.Entities;

namespace EZ.MvcDotNet.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        /*public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }*/

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ClienteEnderecoViewModel, Cliente>();
            CreateMap<EnderecoViewModel, Endereco>();
            CreateMap<ClienteEnderecoViewModel, Endereco>();
        }
    }
}