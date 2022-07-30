using MediatR;
using Spotify.Application.Album.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Banda.Handler.Command
{
    public class CreateBandaCommand : IRequest<CreateBandaCommandResponse>
    {
        public BandaInputCreateDto Banda { get; set; }

        //public Guid IdBanda { get; set; }

        public CreateBandaCommand(BandaInputCreateDto banda)
        {
            Banda = banda;

        }
    }

    public class CreateBandaCommandResponse
    {
        public BandaOutputDto Banda { get; set; }

        public CreateBandaCommandResponse(BandaOutputDto banda)
        {
            Banda = banda;
        }
    }
}
