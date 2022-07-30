using MediatR;
using Spotify.Application.Album.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Album.Handler.Command
{
    public class UpdateMusicaCommand : IRequest<UpdateMusicaCommandResponse>
    {
        public MusicaInputUpdateDto Musica { get; set; }

        public UpdateMusicaCommand(MusicaInputUpdateDto musica)
        {
            Musica = musica;

        }
    }

    public class UpdateMusicaCommandResponse
    {
        public MusicaOutputDto Musica { get; set; }

        public UpdateMusicaCommandResponse(MusicaOutputDto musica)
        {
            Musica = musica;

        }
    }
}
