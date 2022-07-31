using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Spotify.Application.Album.Dto;
using Spotify.Application.Album.Handler.Command;
using Spotify.Application.Album.Handler.Query;

namespace Spotify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicaController : ControllerBase
    {
        private readonly IMediator mediator;

        public MusicaController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("ListarTodos")]
        public async Task<IActionResult> ListarTodos()
        {
            return Ok(await this.mediator.Send(new GetAllMusicaQuery()));
        }

        //[HttpPost("{idBanda}")]
        [HttpPost]
        [Route("Criar")]
        public async Task<IActionResult> Criar(MusicaInputCreateDto dto)
        {
            var result = await this.mediator.Send(new CreateMusicaCommand(dto));
            return Created($"{result.Musica.Id}", result.Musica);
        }

        [HttpDelete]
        [Route("Deletar")]
        public async Task<IActionResult> Deletar(MusicaInputDeleteDto dto)
        {
            var result = await this.mediator.Send(new DeleteMusicaCommand(dto));
            //if (result.Resultado == "Deleted") 
            return Ok(result.Resultado);
            //else return NotFound(result.Resultado);

        }

        [HttpPatch]
        [Route("Atualizar")]
        public async Task<IActionResult> Atualizar(MusicaInputUpdateDto dto)
        {
            var result = await this.mediator.Send(new UpdateMusicaCommand(dto));
            return Ok(result.Musica);

        }
    }
}
