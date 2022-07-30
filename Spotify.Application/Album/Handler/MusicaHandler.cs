using MediatR;
using Spotify.Application.Album.Handler.Command;
using Spotify.Application.Album.Handler.Query;
using Spotify.Application.Musica.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Album.Handler
{
    public class MusicaHandler : IRequestHandler<CreateMusicaCommand, CreateMusicaCommandResponse>,
                                IRequestHandler<GetAllMusicaQuery, GetAllMusicaQueryResponse>,
                                IRequestHandler<DeleteMusicaCommand, DeleteMusicaCommandResponse>,
                                IRequestHandler<UpdateMusicaCommand, UpdateMusicaCommandResponse>



    {
        private readonly IMusicaService _MusicaService;

        public MusicaHandler(IMusicaService MusicaService)
        {
            _MusicaService = MusicaService;
        }

        public async Task<CreateMusicaCommandResponse> Handle(CreateMusicaCommand request, CancellationToken cancellationToken)
        {
            var result = await this._MusicaService.Criar(request.Musica);
            return new CreateMusicaCommandResponse(result);
        }

        public async Task<DeleteMusicaCommandResponse> Handle(DeleteMusicaCommand request, CancellationToken cancellationToken)
        {
            //var result = await this._MusicaService.BuscarPorIdExclusao(request.Musica);
            //if (result == null) return new DeleteMusicaCommandResponse("ID não Encontrado");
            //else
            // {
            var result = await this._MusicaService.Deletar(request.Musica);
            return new DeleteMusicaCommandResponse("Deleted");
            //}
        }

        public async Task<UpdateMusicaCommandResponse> Handle(UpdateMusicaCommand request, CancellationToken cancellationToken)
        {
            var result = await this._MusicaService.Atualizar(request.Musica);
            return new UpdateMusicaCommandResponse(result);
        }


        public async Task<GetAllMusicaQueryResponse> Handle(GetAllMusicaQuery request, CancellationToken cancellationToken)
        {
            var result = await this._MusicaService.ObterTodos();
            return new GetAllMusicaQueryResponse(result);
        }


    }
}
