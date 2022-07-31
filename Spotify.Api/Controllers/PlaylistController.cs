using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Spotify.Application.Account.Dto;
using Spotify.Application.Account.Handler.Command;
using Spotify.Application.Account.Handler.Query;

namespace Spotify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistController : ControllerBase
    {
        private readonly IMediator mediator;

        public PlaylistController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("ListarTodos")]
        public async Task<IActionResult> ListarTodos()
        {
            return Ok(await this.mediator.Send(new GetAllPlaylistQuery()));
        }

        //[HttpPost("{idBanda}")]
        [HttpPost]
        [Route("Criar")]
        public async Task<IActionResult> Criar(PlaylistInputCreateDto dto)
        {
            var result = await this.mediator.Send(new CreatePlaylistCommand(dto));
            return Created($"{result.Playlist.Id}", result.Playlist);
        }

        [HttpDelete]
        [Route("Deletar")]
        public async Task<IActionResult> Deletar(PlaylistInputDeleteDto dto)
        {
            var result = await this.mediator.Send(new DeletePlaylistCommand(dto));
            //if (result.Resultado == "Deleted") 
            return Ok(result.Resultado);
            //else return NotFound(result.Resultado);

        }

        [HttpPatch]
        [Route("Atualizar")]
        public async Task<IActionResult> Atualizar(PlaylistInputUpdateDto dto)
        {
            var result = await this.mediator.Send(new UpdatePlaylistCommand(dto));
            return Ok(result.Playlist);

        }
    }
}
