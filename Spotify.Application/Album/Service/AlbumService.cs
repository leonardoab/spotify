using AutoMapper;
using Spotify.Application.Album.Dto;
using Spotify.Domain.Album.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Album.Service
{
    public class AlbumService : IAlbumService
    {

        private readonly IAlbumRepository albumRepository;
        private readonly IMapper mapper;

        public AlbumService(IAlbumRepository albumRepository, IMapper mapper)
        {
            this.albumRepository = albumRepository;
            this.mapper = mapper;
        }

        public async Task<AlbumOutputCreateDto> Criar(AlbumInputCreateDto dto)
        {
            var album = this.mapper.Map<Spotify.Domain.Album.Album>(dto);

            await this.albumRepository.Save(album);

            return this.mapper.Map<AlbumOutputCreateDto>(album);

        }

        public async Task<AlbumOutputUpdateDeleteDto> Deletar(AlbumInputDeleteDto dto)
        {
            var album = this.mapper.Map<Spotify.Domain.Album.Album>(dto);

            await this.albumRepository.Delete(album);

            return this.mapper.Map<AlbumOutputUpdateDeleteDto>(album);

        }        

        public async Task<AlbumOutputUpdateDeleteDto> Atualizar(AlbumInputUpdateDto dto)
        {
            var album = this.mapper.Map<Spotify.Domain.Album.Album>(dto);

            await this.albumRepository.Update(album);

            return this.mapper.Map<AlbumOutputUpdateDeleteDto>(album);

        }


        public async Task<List<AlbumOutputCreateDto>> ObterTodos()
        {
            var album = await this.albumRepository.ObterTodosAlbuns();

            return this.mapper.Map<List<AlbumOutputCreateDto>>(album);
        }
    }
}
