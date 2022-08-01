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

        public async Task<AlbumOutputDto> Criar(AlbumInputCreateDto dto)
        {
            var album = this.mapper.Map<Spotify.Domain.Album.Album>(dto);

            //album.Musicas = this.mapper.Map<List<MusicaInputCreateDto>>(Musica);
            //album.Musicas = (IList<Domain.Album.Musica>)dto.MusicasNovas;
            //album.Musicas = this.mapper.Map<List<MusicaOutputDto>>(dto.MusicasNovas);



            //album.Musicas.Add((Domain.Album.Musica)(IList<Domain.Album.Musica>)dto.MusicasExistentes);

            await this.albumRepository.Save(album);

            return this.mapper.Map<AlbumOutputDto>(album);

        }

        public async Task<AlbumOutputDto> Deletar(AlbumInputDeleteDto dto)
        {
            var album = this.mapper.Map<Spotify.Domain.Album.Album>(dto);

            await this.albumRepository.Delete(album);

            return this.mapper.Map<AlbumOutputDto>(album);

        }        

        public async Task<AlbumOutputDto> Atualizar(AlbumInputUpdateDto dto)
        {
            var album = this.mapper.Map<Spotify.Domain.Album.Album>(dto);

            await this.albumRepository.Update(album);
            

            return this.mapper.Map<AlbumOutputDto>(album);

        }


        public async Task<List<AlbumOutputDto>> ObterTodos()
        {
            var album = await this.albumRepository.ObterTodosAlbuns();

            return this.mapper.Map<List<AlbumOutputDto>>(album);
        }
    }
}
