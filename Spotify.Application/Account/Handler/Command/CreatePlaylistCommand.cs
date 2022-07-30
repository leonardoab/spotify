using MediatR;
using Spotify.Application.Account.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Account.Handler.Command
{
    public class CreatePlaylistCommand : IRequest<CreatePlaylistCommandResponse>
    {
        public PlaylistInputCreateDto Playlist { get; set; }

        //public Guid IdBanda { get; set; }

        public CreatePlaylistCommand(PlaylistInputCreateDto playlist)
        {
            Playlist = playlist;

        }
    }

    public class CreatePlaylistCommandResponse
    {
        public PlaylistOutputDto Playlist { get; set; }

        public CreatePlaylistCommandResponse(PlaylistOutputDto playlist)
        {
            Playlist = playlist;
        }
    }
}
