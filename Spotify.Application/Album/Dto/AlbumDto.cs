using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Album.Dto
{

    public record AlbumInputCreateDto(
        [Required(ErrorMessage = "Nome é obrigatório")] string Nome,
        [Required(ErrorMessage = "Data Lançamento é obrigatório")] DateTime DataLancamento,
        string Backdrop, 
        List<MusicaInputCreateDto> Musicas);

    public record AlbumInputDeleteDto(
        [Required(ErrorMessage = "ID é obrigatório")] Guid Id);

    public record AlbumInputUpdateDto(
       [Required(ErrorMessage = "ID é obrigatório")] Guid Id,
       [Required(ErrorMessage = "Nome é obrigatório")] string Nome,
       [Required(ErrorMessage = "Data Lançamento é obrigatório")] DateTime DataLancamento,
       string Backdrop);

    public record AlbumOutputCreateDto(Guid Id, string Nome, DateTime DataLancamento, string Backdrop, List<MusicaOutputDto> Musicas);

    public record AlbumOutputUpdateDeleteDto(Guid Id, string Nome, DateTime DataLancamento, string Backdrop); 

    public record MusicaInputCreateDto(
        [Required(ErrorMessage = "Nome é obrigatório")] string Nome,
        [Required(ErrorMessage = "Duração é obrigatório")] int Duracao);

    public record MusicaInputUpdateDto(
        [Required(ErrorMessage = "ID é obrigatório")] Guid Id,
        [Required(ErrorMessage = "Nome é obrigatório")] string Nome,
        [Required(ErrorMessage = "Duração é obrigatório")] int Duracao);

    public record MusicaInputDeleteDto(
    [Required(ErrorMessage = "ID é obrigatório")] Guid Id);

    public record MusicaOutputDto(Guid Id, string Nome, string Duracao);

    public record BandaInputCreateDto(
                [Required(ErrorMessage = "Nome é obrigatório")] string Nome,
                [Required(ErrorMessage = "Foto é obrigatório")] string Foto,
                [Required(ErrorMessage = "Descrição é obrigatório")] string Descricao,
                List<AlbumInputCreateDto> Albuns);

    public record BandaInputUpdateDto(
                [Required(ErrorMessage = "ID é obrigatório")] Guid Id,
                [Required(ErrorMessage = "Nome é obrigatório")] string Nome,
                [Required(ErrorMessage = "Foto é obrigatório")] string Foto,
                [Required(ErrorMessage = "Descrição é obrigatório")] string Descricao);

    public record BandaInputDeleteDto(
                [Required(ErrorMessage = "ID é obrigatório")] Guid Id);

    public record BandaOutputCreateDto(Guid Id, string Nome, string Foto, string Descricao, List<AlbumInputCreateDto> Albuns);

    public record BandaOutputUpdateDeleteDto(Guid Id, string Nome, string Foto, string Descricao);

    

    



}
