using MediatR;
using Spotify.Application.Account.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Account.Handler.Command
{
    public class UpdateUsuarioCommand : IRequest<UpdateUsuarioCommandResponse>
    {
        public UsuarioInputUpdateDto Usuario { get; set; }

        public UpdateUsuarioCommand(UsuarioInputUpdateDto usuario)
        {
            Usuario = usuario;

        }
    }

    public class UpdateUsuarioCommandResponse
    {
        public UsuarioOutputDto Usuario { get; set; }

        public UpdateUsuarioCommandResponse(UsuarioOutputDto usuario)
        {
            Usuario = usuario;

        }
    }
}
