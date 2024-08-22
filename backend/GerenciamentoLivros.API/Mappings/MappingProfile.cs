using AutoMapper;
using GerenciamentoLivros.API.DTOs;
using GerenciamentoLivros.API.Models;

namespace GerenciamentoLivros.API.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LivroDTO, Livro>();
            CreateMap<Livro, LivroDTO>();
        }
    }
}
