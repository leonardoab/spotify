using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Spotify.Application.Album.Dto;
using Spotify.Application.Banda.Handler.Command;
using Spotify.Application.Banda.Handler.Query;


namespace Spotify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BandaController : ControllerBase
    {

        private readonly IMediator mediator;

        public BandaController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        //private readonly IBandaService bandaService;



        /*public BandaController(IBandaService bandaService)
        {
            this.bandaService = bandaService;
        }*/

        /*[HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            return Ok(await this.bandaService.ObterTodos());
        }

        [HttpPost]
        public async Task<IActionResult> Criar(BandaInputDto dto)
        {
            if (ModelState.IsValid == false)
                return BadRequest(ModelState);

            var result = await this.bandaService.Criar(dto);

            return Created($"/{result.Id}", result);
        }*/

        [HttpGet]
        public async Task<IActionResult> ListarTodos()
        {
            return Ok(await this.mediator.Send(new GetAllBandaQuery()));
        }

        //[HttpPost("{idBanda}")]
        [HttpPost]
        public async Task<IActionResult> Criar(BandaInputCreateDto dto)
        {
            var result = await this.mediator.Send(new CreateBandaCommand(dto));
            return Created($"{result.Banda.Id}", result.Banda);
        }

        [HttpDelete]
        public async Task<IActionResult> Deletar(BandaInputDeleteDto dto)
        {
            var result = await this.mediator.Send(new DeleteBandaCommand(dto));
            //if (result.Resultado == "Deleted") 
            return Ok(result.Resultado);
            //else return NotFound(result.Resultado);

        }

        [HttpPatch]
        public async Task<IActionResult> Atualizar(BandaInputUpdateDto dto)
        {
            var result = await this.mediator.Send(new UpdateBandaCommand(dto));
            return Ok(result.Banda);

        }


    }
}
