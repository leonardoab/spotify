using MediatR;
using Spotify.Application.Account.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Account.Handler.Command
{
    public class DeletePlaylistCommand : IRequest<DeletePlaylistCommandResponse>
    {
        public PlaylistInputDeleteDto Playlist { get; set; }

        public DeletePlaylistCommand(PlaylistInputDeleteDto playlist)
        {
            Playlist = playlist;

        }
    }

    public class DeletePlaylistCommandResponse
    {
        public string Resultado;

        public DeletePlaylistCommandResponse(string resultado)
        {
            Resultado = resultado;
        }
    }
}
