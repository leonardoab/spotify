using MediatR;
using Spotify.Application.Album.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Album.Handler.Query
{
    public class GetAllMusicaQuery : IRequest<GetAllMusicaQueryResponse>
    {

    }

    public class GetAllMusicaQueryResponse
    {
        public IList<MusicaOutputDto> Musicas { get; set; }

        public GetAllMusicaQueryResponse(IList<MusicaOutputDto> musicas)
        {
            Musicas = musicas;
        }
    }
}
