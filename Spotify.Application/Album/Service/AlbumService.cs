using AutoMapper;
using Spotify.Application.Album.Dto;
using Spotify.Domain.Album.Repository;
using Spotify.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Album.Service
{
    public class AlbumService : IAlbumService
    {

        private readonly IAlbumRepository albumRepository;        
        private readonly IMapper mapper;

        private IHttpClientFactory httpClientFactory;

        private AzureBlobStorage storage;


        public AlbumService(IAlbumRepository albumRepository, IHttpClientFactory httpClientFactory, AzureBlobStorage storage, IMapper mapper)
        {
            this.albumRepository = albumRepository;
            this.httpClientFactory = httpClientFactory;
            this.storage = storage;
            this.mapper = mapper;
        }

        public async Task<AlbumOutputDto> Criar(AlbumInputCreateDto dto)
        {
            var album = this.mapper.Map<Spotify.Domain.Album.Album>(dto);


            HttpClient httpClient = this.httpClientFactory.CreateClient();

            using var response = await httpClient.GetAsync(album.Backdrop);


            if (response.IsSuccessStatusCode)
            {
                using var stream = await response.Content.ReadAsStreamAsync();

                var fileName = $"{Guid.NewGuid()}.jpg";

                var pathStorage = await this.storage.UploadFile(fileName, stream);

                album.Backdrop = pathStorage;

            }

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
