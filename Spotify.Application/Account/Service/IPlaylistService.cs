using Spotify.Application.Account.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Account.Service
{
    public interface IPlaylistService
    {
        Task<PlaylistOutputDto> Atualizar(PlaylistInputUpdateDto dto);
        Task<PlaylistOutputDto> Criar(PlaylistInputCreateDto dto);
        Task<PlaylistOutputDto> Deletar(PlaylistInputDeleteDto dto);
        Task<List<PlaylistOutputDto>> ObterTodos();
    }
}
