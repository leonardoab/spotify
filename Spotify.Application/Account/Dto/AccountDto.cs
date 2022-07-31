using Spotify.Application.Album.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Account.Dto
{
    

    public record UsuarioInputCreateDto(
        [Required(ErrorMessage = "Nome é obrigatório")] string Nome,
        [Required(ErrorMessage = "Email é obrigatório")] string Email,
        [Required(ErrorMessage = "Password é obrigatório")] string Password
        );

    public record UsuarioInputUpdateDto(
                [Required(ErrorMessage = "ID é obrigatório")] Guid Id,
                [Required(ErrorMessage = "Nome é obrigatório")] string Nome,
                [Required(ErrorMessage = "Email é obrigatório")] string Email,
                [Required(ErrorMessage = "Password é obrigatório")] string Password);

    public record UsuarioInputDeleteDto(
                [Required(ErrorMessage = "ID é obrigatório")] Guid Id);


    public record UsuarioOutputDto(Guid Id, string Nome, string Email, string Password, List<PlaylistOutputDto> Playlists);




    public record PlaylistInputCreateDto(
            [Required(ErrorMessage = "Nome é obrigatório")] string Nome  );

    public record PlaylistInputUpdateDto(
                [Required(ErrorMessage = "ID é obrigatório")] Guid Id,
                [Required(ErrorMessage = "Nome é obrigatório")] string Nome );

    public record PlaylistInputDeleteDto(
                [Required(ErrorMessage = "ID é obrigatório")] Guid Id);

    public record PlaylistOutputDto(Guid Id, string Nome, List<MusicaOutputDto> Musicas);


}
