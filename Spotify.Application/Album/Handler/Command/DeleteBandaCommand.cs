using MediatR;
using Spotify.Application.Album.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Banda.Handler.Command
{
    public class DeleteBandaCommand : IRequest<DeleteBandaCommandResponse>
    {
        public BandaInputDeleteDto Banda { get; set; }

        public DeleteBandaCommand(BandaInputDeleteDto banda)
        {
            Banda = banda;

        }
    }

    public class DeleteBandaCommandResponse
    {
        public string Resultado;

        public DeleteBandaCommandResponse(string resultado)
        {
            Resultado = resultado;
        }
    }
}
