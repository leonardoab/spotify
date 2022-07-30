using Spotify.Application.Album.Dto;

namespace Spotify.Application.Album.Service
{
    public interface IBandaService
    {
        Task<BandaOutputDto> Criar(BandaInputCreateDto dto);
        Task<BandaOutputDto> Deletar(BandaInputDeleteDto dto);
        Task<BandaOutputDto> Atualizar(BandaInputUpdateDto dto);
        Task<List<BandaOutputDto>> ObterTodos();
    }
}