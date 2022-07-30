using AutoMapper;
using Spotify.Application.Album.Dto;
using Spotify.Domain.Album.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Spotify.Application.Musica.Service
{
    public class MusicaService : IMusicaService
    {
        private readonly IMusicaRepository musicaRepository;
        private readonly IMapper mapper;

        public MusicaService(IMusicaRepository MusicaRepository, IMapper mapper)
        {
            this.musicaRepository = MusicaRepository;
            this.mapper = mapper;
        }

        public async Task<MusicaOutputDto> Criar(MusicaInputCreateDto dto)
        {
            var Musica = this.mapper.Map<Spotify.Domain.Album.Musica>(dto);

            await this.musicaRepository.Save(Musica);

            return this.mapper.Map<MusicaOutputDto>(Musica);

        }

        public async Task<MusicaOutputDto> Deletar(MusicaInputDeleteDto dto)
        {
            var Musica = this.mapper.Map<Spotify.Domain.Album.Musica>(dto);

            await this.musicaRepository.Delete(Musica);

            return this.mapper.Map<MusicaOutputDto>(Musica);

        }

        public async Task<MusicaOutputDto> Atualizar(MusicaInputUpdateDto dto)
        {
            var Musica = this.mapper.Map<Spotify.Domain.Album.Musica>(dto);

            await this.musicaRepository.Update(Musica);

            return this.mapper.Map<MusicaOutputDto>(Musica);

        }


        public async Task<List<MusicaOutputDto>> ObterTodos()
        {
            var Musica = await this.musicaRepository.GetAll();

            return this.mapper.Map<List<MusicaOutputDto>>(Musica);
        }
    }
}
