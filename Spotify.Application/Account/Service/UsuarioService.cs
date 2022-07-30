using AutoMapper;
using Spotify.Application.Account.Dto;
using Spotify.Domain.Account.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Account.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository musicaRepository;
        private readonly IMapper mapper;

        public UsuarioService(IUsuarioRepository UsuarioRepository, IMapper mapper)
        {
            this.musicaRepository = UsuarioRepository;
            this.mapper = mapper;
        }

        public async Task<UsuarioOutputDto> Criar(UsuarioInputCreateDto dto)
        {
            var Usuario = this.mapper.Map<Spotify.Domain.Account.Usuario>(dto);

            Usuario.Validate();
            Usuario.SetPassword();            

            return this.mapper.Map<UsuarioOutputDto>(Usuario);

        }

        public async Task<UsuarioOutputDto> Deletar(UsuarioInputDeleteDto dto)
        {
            var Usuario = this.mapper.Map<Spotify.Domain.Account.Usuario>(dto);

            await this.musicaRepository.Delete(Usuario);

            return this.mapper.Map<UsuarioOutputDto>(Usuario);

        }

        public async Task<UsuarioOutputDto> Atualizar(UsuarioInputUpdateDto dto)
        {
            var Usuario = this.mapper.Map<Spotify.Domain.Account.Usuario>(dto);

            Usuario.Validate();

            await this.musicaRepository.Update(Usuario);

            return this.mapper.Map<UsuarioOutputDto>(Usuario);

        }


        public async Task<List<UsuarioOutputDto>> ObterTodos()
        {
            var Usuario = await this.musicaRepository.GetAll();

            return this.mapper.Map<List<UsuarioOutputDto>>(Usuario);
        }
    }
}
