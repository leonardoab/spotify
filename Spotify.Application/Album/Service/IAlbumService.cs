using Spotify.Application.Album.Dto;

namespace Spotify.Application.Album.Service
{
    public interface IAlbumService
    {
        Task<AlbumOutputDto> Criar(AlbumInputCreateDto dto);
        Task<AlbumOutputDto> Deletar(AlbumInputDeleteDto dto);
        Task<AlbumOutputDto> Atualizar(AlbumInputUpdateDto dto);        
        Task<List<AlbumOutputDto>> ObterTodos();

    }
}