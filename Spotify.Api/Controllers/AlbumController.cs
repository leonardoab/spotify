using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Spotify.Application.Album.Dto;
using Spotify.Application.Album.Handler.Command;
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

        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    return Ok(await this.mediator.Send(new GetAllAlbumQuery()));
        // }

        [HttpPost("{idBanda}")]
        public async Task<IActionResult> Criar(AlbumInputDto dto, Guid idBanda)
        {
            var result = await this.mediator.Send(new CreateAlbumCommand(dto, idBanda));
            return Created($"{result.Album.Id}", result.Album);
        }


    }
}
