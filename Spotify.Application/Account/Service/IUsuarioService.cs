using Spotify.Application.Account.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Account.Service
{
    public interface IUsuarioService
    {
        Task<UsuarioOutputDto> Atualizar(UsuarioInputUpdateDto dto);
        Task<bool> AuthenticateUser(UsuarioInputAutenticacaoDto dto);
        Task<UsuarioOutputDto> Criar(UsuarioInputCreateDto dto);
        Task<UsuarioOutputDto> Deletar(UsuarioInputDeleteDto dto);
        Task<string> GenerateToken();
        Task<List<UsuarioOutputDto>> ObterTodos();
    }
}
