using MediatR;
using Spotify.Application.Account.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Account.Handler.Command
{
    public class DeleteUsuarioCommand : IRequest<DeleteUsuarioCommandResponse>
    {
        public UsuarioInputDeleteDto Usuario { get; set; }

        public DeleteUsuarioCommand(UsuarioInputDeleteDto usuario)
        {
            Usuario = usuario;

        }
    }

    public class DeleteUsuarioCommandResponse
    {
        public string Resultado;

        public DeleteUsuarioCommandResponse(string resultado)
        {
            Resultado = resultado;
        }
    }
}
