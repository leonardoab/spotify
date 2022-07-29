using Spotify.Application.Album.Dto;

namespace Spotify.Application.Album.Service
{
    public interface IAlbumService
    {
        Task<AlbumOutputCreateDto> Criar(AlbumInputCreateDto dto);
        Task<AlbumOutputDeleteDto> Deletar(AlbumInputDeleteDto dto);
        Task<AlbumOutputUpdateDto> Atualizar(AlbumInputUpdateDto dto);        
        Task<List<AlbumOutputCreateDto>> ObterTodos();
        Task<AlbumOutputDeleteDto> BuscarPorId(Guid id);


    }
}