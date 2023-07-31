using AutoMapper;
using Usuarios.API.Data.Dtos;
using Usuarios.API.Models;

namespace Usuarios.API.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
        }
    }
}
