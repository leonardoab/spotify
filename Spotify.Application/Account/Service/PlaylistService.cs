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
        private readonly IPlaylistRepository playlistRepository;
        private readonly IMapper mapper;

        public PlaylistService(IPlaylistRepository PlaylistRepository, IMapper mapper)
        {
            this.playlistRepository = PlaylistRepository;
            this.mapper = mapper;
        }

        public async Task<PlaylistOutputDto> Criar(PlaylistInputCreateDto dto)
        {
            var Playlist = this.mapper.Map<Spotify.Domain.Account.Playlist>(dto);

            await this.playlistRepository.Save(Playlist);

            return this.mapper.Map<PlaylistOutputDto>(Playlist);

        }

        public async Task<PlaylistOutputDto> Deletar(PlaylistInputDeleteDto dto)
        {
            var Playlist = this.mapper.Map<Spotify.Domain.Account.Playlist>(dto);

            await this.playlistRepository.Delete(Playlist);

            return this.mapper.Map<PlaylistOutputDto>(Playlist);

        }

        public async Task<PlaylistOutputDto> Atualizar(PlaylistInputUpdateDto dto)
        {
            var Playlist = this.mapper.Map<Spotify.Domain.Account.Playlist>(dto);

            await this.playlistRepository.Update(Playlist);

            return this.mapper.Map<PlaylistOutputDto>(Playlist);

        }


        public async Task<List<PlaylistOutputDto>> ObterTodos()
        {
            var Playlist = await this.playlistRepository.ObterTodasPlaylists();

            return this.mapper.Map<List<PlaylistOutputDto>>(Playlist);
        }
    }
}
