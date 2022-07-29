using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Spotify.Application.Album.Dto;
using Spotify.Application.Album.Handler.Command;
using Spotify.Application.Album.Handler.Query;
using Spotify.Domain.Album.Repository;

namespace Spotify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IMediator mediator;

        public AlbumController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ListarTodos()
        {
            return Ok(await this.mediator.Send(new GetAllAlbumQuery()));
        }

        //[HttpPost("{idBanda}")]
        [HttpPost]
        public async Task<IActionResult> Criar(AlbumInputCreateDto dto)
        {
            var result = await this.mediator.Send(new CreateAlbumCommand(dto));
            return Created($"{result.Album.Id}", result.Album);
        }

        [HttpDelete]
        public async Task<IActionResult> Deletar(AlbumInputDeleteDto dto)
        {
            var result = await this.mediator.Send(new DeleteAlbumCommand(dto));
            //if (result.Resultado == "Deleted") 
            return Ok(result.Resultado);
            //else return NotFound(result.Resultado);
            
        }

        [HttpPatch]
        public async Task<IActionResult> Atualizar(AlbumInputUpdateDto dto)
        {
            var result = await this.mediator.Send(new UpdateAlbumCommand(dto));
            return Ok(result.Album);
            
        }

       


    }
}
