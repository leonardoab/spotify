using MediatR;
using Spotify.Application.Album.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Banda.Handler.Command
{
    public class UpdateBandaCommand : IRequest<UpdateBandaCommandResponse>
    {
        public BandaInputUpdateDto Banda { get; set; }

        public UpdateBandaCommand(BandaInputUpdateDto banda)
        {
            Banda = banda;

        }
    }

    public class UpdateBandaCommandResponse
    {
        public BandaOutputDto Banda { get; set; }

        public UpdateBandaCommandResponse(BandaOutputDto banda)
        {
            Banda = banda;

        }
    }
}
