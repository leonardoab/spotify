using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Spotify.Application.Account.Dto;
using Spotify.Application.Account.Handler.Command;
using Spotify.Application.Account.Handler.Query;
using Spotify.Domain.Account.Repository;

namespace Spotify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        /*public IUsuarioRepository UsuarioRepository { get; }

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            UsuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await this.UsuarioRepository.GetAll());
        }*/

        private readonly IMediator mediator;

        public UsuarioController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("ListarTodos")]
        public async Task<IActionResult> ListarTodos()
        {
            return Ok(await this.mediator.Send(new GetAllUsuarioQuery()));
        }

        //[HttpPost("{idBanda}")]
        [HttpPost]
        [Route("Criar")]
        public async Task<IActionResult> Criar(UsuarioInputCreateDto dto)
        {
            var result = await this.mediator.Send(new CreateUsuarioCommand(dto));
            return Created($"{result.Usuario.Id}", result.Usuario);
        }

        [HttpDelete]
        [Route("Deletar")]
        public async Task<IActionResult> Deletar(UsuarioInputDeleteDto dto)
        {
            var result = await this.mediator.Send(new DeleteUsuarioCommand(dto));
            //if (result.Resultado == "Deleted") 
            return Ok(result.Resultado);
            //else return NotFound(result.Resultado);

        }

        [HttpPatch]
        [Route("Atualizar")]
        public async Task<IActionResult> Atualizar(UsuarioInputUpdateDto dto)
        {
            var result = await this.mediator.Send(new UpdateUsuarioCommand(dto));
            return Ok(result.Usuario);

        }


    }
}
