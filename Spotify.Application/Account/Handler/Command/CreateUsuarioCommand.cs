using MediatR;
using Spotify.Application.Account.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Account.Handler.Command
{
    public class CreateUsuarioCommand : IRequest<CreateUsuarioCommandResponse>
    {
        public UsuarioInputCreateDto Usuario { get; set; }

        //public Guid IdBanda { get; set; }

        public CreateUsuarioCommand(UsuarioInputCreateDto usuario)
        {
            Usuario = usuario;

        }
    }

    public class CreateUsuarioCommandResponse
    {
        public UsuarioOutputDto Usuario { get; set; }

        public CreateUsuarioCommandResponse(UsuarioOutputDto usuario)
        {
            Usuario = usuario;
        }
    }
}
