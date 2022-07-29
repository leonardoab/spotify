using MediatR;
using Spotify.Application.Album.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Album.Handler.Command
{
    public class DeleteAlbumCommand :IRequest<DeleteAlbumCommandResponse>
    {
        public AlbumInputDeleteDto Album { get; set; }        

        public DeleteAlbumCommand(AlbumInputDeleteDto album)
        {
            Album = album;

        }
    }

    public class DeleteAlbumCommandResponse
    {
        public string Resultado;

        public DeleteAlbumCommandResponse(string resultado)
        {
            Resultado = resultado;
        }
    }
}
