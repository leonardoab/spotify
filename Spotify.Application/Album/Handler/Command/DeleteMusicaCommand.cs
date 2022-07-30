using MediatR;
using Spotify.Application.Album.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Album.Handler.Command
{
    public class DeleteMusicaCommand : IRequest<DeleteMusicaCommandResponse>
    {
        public MusicaInputDeleteDto Musica { get; set; }

        public DeleteMusicaCommand(MusicaInputDeleteDto musica)
        {
            Musica = musica;

        }
    }

    public class DeleteMusicaCommandResponse
    {
        public string Resultado;

        public DeleteMusicaCommandResponse(string resultado)
        {
            Resultado = resultado;
        }
    }
}
