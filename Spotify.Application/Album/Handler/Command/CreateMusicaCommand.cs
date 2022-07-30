using MediatR;
using Spotify.Application.Album.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Album.Handler.Command
{
    public class CreateMusicaCommand : IRequest<CreateMusicaCommandResponse>
    {
        public MusicaInputCreateDto Musica { get; set; }

        //public Guid IdMusica { get; set; }

        public CreateMusicaCommand(MusicaInputCreateDto musica)
        {
            Musica = musica;

        }
    }

    public class CreateMusicaCommandResponse
    {
        public MusicaOutputDto Musica { get; set; }

        public CreateMusicaCommandResponse(MusicaOutputDto musica)
        {
            Musica = musica;
        }
    }
}
