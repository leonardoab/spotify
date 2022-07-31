using AutoMapper;
using Spotify.Application.Album.Dto;
using Spotify.Domain.Album;
using Spotify.Domain.Album.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Album.Service
{
    public class BandaService : IBandaService
    {
        private readonly IBandaRepository bandaRepository;
        private readonly IMapper mapper;


        public BandaService(IBandaRepository bandaRepository, IMapper mapper)
        {
            this.bandaRepository = bandaRepository;
            this.mapper = mapper;
        }

        public async Task<BandaOutputDto> Criar(BandaInputCreateDto dto)
        {
            var banda = this.mapper.Map<Spotify.Domain.Album.Banda>(dto);

            await this.bandaRepository.Save(banda);

            return this.mapper.Map<BandaOutputDto>(banda);
        }

        public async Task<BandaOutputDto> Deletar(BandaInputDeleteDto dto)
        {
            var banda = this.mapper.Map<Spotify.Domain.Album.Banda>(dto);

            await this.bandaRepository.Delete(banda);

            return this.mapper.Map<BandaOutputDto>(banda);

        }

        public async Task<BandaOutputDto> Atualizar(BandaInputUpdateDto dto)
        {
            var banda = this.mapper.Map<Spotify.Domain.Album.Banda>(dto);

            await this.bandaRepository.Update(banda);

            return this.mapper.Map<BandaOutputDto>(banda);

        }

        public async Task<List<BandaOutputDto>> ObterTodos()
        {
            var result = await this.bandaRepository.ObterTodasBandas();

            return this.mapper.Map<List<BandaOutputDto>>(result);
        }

    }
}
