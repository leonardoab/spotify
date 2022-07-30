using Spotify.Application.Album.Dto;

namespace Spotify.Application.Album.Service
{
    public interface IBandaService
    {
        Task<BandaOutputCreateDto> Criar(BandaInputCreateDto dto);
        Task<BandaOutputUpdateDeleteDto> Deletar(BandaInputDeleteDto dto);
        Task<BandaOutputUpdateDeleteDto> Atualizar(BandaInputUpdateDto dto);
        Task<List<BandaOutputCreateDto>> ObterTodos();
    }
}