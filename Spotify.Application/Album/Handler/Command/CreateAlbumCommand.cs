using MediatR;
using Spotify.Application.Album.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Album.Handler.Command
{
    public class CreateAlbumCommand : IRequest<CreateAlbumCommandResponse>
    {
        public AlbumInputCreateDto Album { get; set; }

        public Guid IdBanda { get; set; }

        public CreateAlbumCommand(AlbumInputCreateDto album)
        {
            Album = album;
            
        }
    }

    public class CreateAlbumCommandResponse
    {
        public AlbumOutputCreateDto Album { get; set; }

        public CreateAlbumCommandResponse(AlbumOutputCreateDto album)
        {
            Album = album;
        }
    }
}
