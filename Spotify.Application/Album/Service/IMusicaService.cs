using Spotify.Application.Album.Dto;

namespace Spotify.Application.Musica.Service
{
    public interface IMusicaService
    {
        Task<MusicaOutputDto> Atualizar(MusicaInputUpdateDto dto);
        Task<MusicaOutputDto> Criar(MusicaInputCreateDto dto);
        Task<MusicaOutputDto> Deletar(MusicaInputDeleteDto dto);
        Task<List<MusicaOutputDto>> ObterTodos();
    }
}