using MediatR;
using Spotify.Application.Album.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Album.Handler.Query
{
    public class GetAllAlbumQuery : IRequest<GetAllAlbumQueryResponse>
    {

    }

    public class GetAllAlbumQueryResponse
    {
        public IList<AlbumOutputCreateDto> Albums { get; set; }

        public GetAllAlbumQueryResponse(IList<AlbumOutputCreateDto> albums)
        {
            Albums = albums;
        }
    }
}
