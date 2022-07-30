using Spotify.Application.Album.Dto;

namespace Spotify.Application.Album.Service
{
    public interface IAlbumService
    {
        Task<AlbumOutputCreateDto> Criar(AlbumInputCreateDto dto);
        Task<AlbumOutputUpdateDeleteDto> Deletar(AlbumInputDeleteDto dto);
        Task<AlbumOutputUpdateDeleteDto> Atualizar(AlbumInputUpdateDto dto);        
        Task<List<AlbumOutputCreateDto>> ObterTodos();

    }
}