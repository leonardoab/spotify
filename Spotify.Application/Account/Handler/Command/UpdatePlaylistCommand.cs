using MediatR;
using Spotify.Application.Account.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Account.Handler.Command
{
    public class UpdatePlaylistCommand : IRequest<UpdatePlaylistCommandResponse>
    {
        public PlaylistInputUpdateDto Playlist { get; set; }

        public UpdatePlaylistCommand(PlaylistInputUpdateDto playlist)
        {
            Playlist = playlist;

        }
    }

    public class UpdatePlaylistCommandResponse
    {
        public PlaylistOutputDto Playlist { get; set; }

        public UpdatePlaylistCommandResponse(PlaylistOutputDto playlist)
        {
            Playlist = playlist;

        }
    }
}
