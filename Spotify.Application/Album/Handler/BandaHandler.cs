using MediatR;
using Spotify.Application.Album.Service;
using Spotify.Application.Banda.Handler.Command;
using Spotify.Application.Banda.Handler.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Banda.Handler
{
    public class BandaHandler : IRequestHandler<CreateBandaCommand, CreateBandaCommandResponse>,
                                IRequestHandler<GetAllBandaQuery, GetAllBandaQueryResponse>,
                                IRequestHandler<DeleteBandaCommand, DeleteBandaCommandResponse>,
                                IRequestHandler<UpdateBandaCommand, UpdateBandaCommandResponse>



    {
        private readonly IBandaService _BandaService;

        public BandaHandler(IBandaService BandaService)
        {
            _BandaService = BandaService;
        }

        public async Task<CreateBandaCommandResponse> Handle(CreateBandaCommand request, CancellationToken cancellationToken)
        {
            var result = await this._BandaService.Criar(request.Banda);
            return new CreateBandaCommandResponse(result);
        }

        public async Task<DeleteBandaCommandResponse> Handle(DeleteBandaCommand request, CancellationToken cancellationToken)
        {
            //var result = await this._BandaService.BuscarPorIdExclusao(request.Banda);
            //if (result == null) return new DeleteBandaCommandResponse("ID não Encontrado");
            //else
            // {
            var result = await this._BandaService.Deletar(request.Banda);
            return new DeleteBandaCommandResponse("Deleted");
            //}
        }

        public async Task<UpdateBandaCommandResponse> Handle(UpdateBandaCommand request, CancellationToken cancellationToken)
        {
            var result = await this._BandaService.Atualizar(request.Banda);
            return new UpdateBandaCommandResponse(result);
        }


        public async Task<GetAllBandaQueryResponse> Handle(GetAllBandaQuery request, CancellationToken cancellationToken)
        {
            var result = await this._BandaService.ObterTodos();
            return new GetAllBandaQueryResponse(result);
        }


    }
}
