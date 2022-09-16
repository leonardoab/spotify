using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Spotify.Application.Account.Dto;
using Spotify.Application.Account.Service;
using Spotify.Cross.Utils;
using Spotify.Domain.Account;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Spotify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {

        IUsuarioService usuarioService;

        public TokenController(IUsuarioService usuarioService)
        {
         
            this.usuarioService = usuarioService;
        }

        [HttpPost]
        public async Task<IActionResult> Token(UsuarioInputAutenticacaoDto dto)
        {
            var isLogged = await usuarioService.AuthenticateUser(dto);

            if (isLogged == null ||  isLogged == false)
                return Unauthorized();

            return Ok(usuarioService.GenerateToken());
        }

        

    }
}

