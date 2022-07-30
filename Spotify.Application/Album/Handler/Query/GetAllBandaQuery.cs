using MediatR;
using Spotify.Application.Album.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Banda.Handler.Query
{
    public class GetAllBandaQuery : IRequest<GetAllBandaQueryResponse>
    {

    }

    public class GetAllBandaQueryResponse
    {
        public IList<BandaOutputDto> Bandas { get; set; }

        public GetAllBandaQueryResponse(IList<BandaOutputDto> bandas)
        {
            Bandas = bandas;
        }
    }
}
