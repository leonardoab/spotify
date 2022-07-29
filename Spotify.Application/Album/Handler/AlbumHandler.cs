using MediatR;
using Spotify.Application.Album.Handler.Command;
using Spotify.Application.Album.Handler.Query;
using Spotify.Application.Album.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Album.Handler
{
    public class AlbumHandler : IRequestHandler<CreateAlbumCommand, CreateAlbumCommandResponse>,
                                IRequestHandler<GetAllAlbumQuery, GetAllAlbumQueryResponse>,
                                IRequestHandler<DeleteAlbumCommand, DeleteAlbumCommandResponse>,
                                IRequestHandler<UpdateAlbumCommand, UpdateAlbumCommandResponse>
                                


    {
        private readonly IAlbumService _albumService;

        public AlbumHandler(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public async Task<CreateAlbumCommandResponse> Handle(CreateAlbumCommand request, CancellationToken cancellationToken)
        {
            var result = await this._albumService.Criar(request.Album);
            return new CreateAlbumCommandResponse(result);
        }

        public async Task<DeleteAlbumCommandResponse> Handle(DeleteAlbumCommand request, CancellationToken cancellationToken)
        {
            var result = await this._albumService.Deletar(request.Album);
            return new DeleteAlbumCommandResponse(result);
        }

        public async Task<UpdateAlbumCommandResponse> Handle(UpdateAlbumCommand request, CancellationToken cancellationToken)
        {
            var result = await this._albumService.Atualizar(request.Album);
            return new UpdateAlbumCommandResponse(result);
        }





        public async Task<GetAllAlbumQueryResponse> Handle(GetAllAlbumQuery request, CancellationToken cancellationToken)
        {
            var result = await this._albumService.ObterTodos();
            return new GetAllAlbumQueryResponse(result);
        }


    }
}
