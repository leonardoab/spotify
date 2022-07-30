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
    public class PlaylistService : IPlaylistService
    {
        private readonly IPlaylistRepository musicaRepository;
        private readonly IMapper mapper;

        public PlaylistService(IPlaylistRepository PlaylistRepository, IMapper mapper)
        {
            this.musicaRepository = PlaylistRepository;
            this.mapper = mapper;
        }

        public async Task<PlaylistOutputDto> Criar(PlaylistInputCreateDto dto)
        {
            var Playlist = this.mapper.Map<Spotify.Domain.Account.Playlist>(dto);

            await this.musicaRepository.Save(Playlist);

            return this.mapper.Map<PlaylistOutputDto>(Playlist);

        }

        public async Task<PlaylistOutputDto> Deletar(PlaylistInputDeleteDto dto)
        {
            var Playlist = this.mapper.Map<Spotify.Domain.Account.Playlist>(dto);

            await this.musicaRepository.Delete(Playlist);

            return this.mapper.Map<PlaylistOutputDto>(Playlist);

        }

        public async Task<PlaylistOutputDto> Atualizar(PlaylistInputUpdateDto dto)
        {
            var Playlist = this.mapper.Map<Spotify.Domain.Account.Playlist>(dto);

            await this.musicaRepository.Update(Playlist);

            return this.mapper.Map<PlaylistOutputDto>(Playlist);

        }


        public async Task<List<PlaylistOutputDto>> ObterTodos()
        {
            var Playlist = await this.musicaRepository.GetAll();

            return this.mapper.Map<List<PlaylistOutputDto>>(Playlist);
        }
    }
}
