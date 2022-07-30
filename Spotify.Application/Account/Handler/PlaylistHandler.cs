using MediatR;
using Spotify.Application.Account.Handler.Command;
using Spotify.Application.Account.Handler.Query;
using Spotify.Application.Account.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Account.Handler
{
    public class PlaylistHandler : IRequestHandler<CreatePlaylistCommand, CreatePlaylistCommandResponse>,
                                IRequestHandler<GetAllPlaylistQuery, GetAllPlaylistQueryResponse>,
                                IRequestHandler<DeletePlaylistCommand, DeletePlaylistCommandResponse>,
                                IRequestHandler<UpdatePlaylistCommand, UpdatePlaylistCommandResponse>



    {
        private readonly IPlaylistService _PlaylistService;

        public PlaylistHandler(IPlaylistService PlaylistService)
        {
            _PlaylistService = PlaylistService;
        }

        public async Task<CreatePlaylistCommandResponse> Handle(CreatePlaylistCommand request, CancellationToken cancellationToken)
        {
            var result = await this._PlaylistService.Criar(request.Playlist);
            return new CreatePlaylistCommandResponse(result);
        }

        public async Task<DeletePlaylistCommandResponse> Handle(DeletePlaylistCommand request, CancellationToken cancellationToken)
        {
            //var result = await this._PlaylistService.BuscarPorIdExclusao(request.Playlist);
            //if (result == null) return new DeletePlaylistCommandResponse("ID não Encontrado");
            //else
            // {
            var result = await this._PlaylistService.Deletar(request.Playlist);
            return new DeletePlaylistCommandResponse("Deleted");
            //}
        }

        public async Task<UpdatePlaylistCommandResponse> Handle(UpdatePlaylistCommand request, CancellationToken cancellationToken)
        {
            var result = await this._PlaylistService.Atualizar(request.Playlist);
            return new UpdatePlaylistCommandResponse(result);
        }


        public async Task<GetAllPlaylistQueryResponse> Handle(GetAllPlaylistQuery request, CancellationToken cancellationToken)
        {
            var result = await this._PlaylistService.ObterTodos();
            return new GetAllPlaylistQueryResponse(result);
        }


    }
}
