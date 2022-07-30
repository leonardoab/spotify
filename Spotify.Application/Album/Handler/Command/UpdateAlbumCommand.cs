using MediatR;
using Spotify.Application.Album.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Album.Handler.Command
{
    public class UpdateAlbumCommand : IRequest<UpdateAlbumCommandResponse>
    {
        public AlbumInputUpdateDto Album { get; set; }

        public UpdateAlbumCommand(AlbumInputUpdateDto album)
        {
            Album = album;

        }
    }

    public class UpdateAlbumCommandResponse
    {
        public AlbumOutputUpdateDeleteDto Album { get; set; }       

        public UpdateAlbumCommandResponse(AlbumOutputUpdateDeleteDto album)
        {
            Album = album;
            
        }
    }
}
