using Spotify.Application.Album.Dto;
using Spotify.Domain.Album;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Album.Profile
{
    public class AlbumProfile : AutoMapper.Profile
    {

        public AlbumProfile()
        {

            CreateMap<Spotify.Domain.Album.Album, AlbumOutputCreateDto>();

            CreateMap<Spotify.Domain.Album.Album, AlbumOutputUpdateDeleteDto>();

            CreateMap<AlbumInputCreateDto, Spotify.Domain.Album.Album>();            

            CreateMap<AlbumInputUpdateDto, Spotify.Domain.Album.Album>();

            CreateMap<AlbumInputDeleteDto, Spotify.Domain.Album.Album>();

            CreateMap<BandaInputCreateDto, Spotify.Domain.Album.Banda>();

            CreateMap<BandaInputUpdateDto, Spotify.Domain.Album.Banda>();

            CreateMap<BandaInputDeleteDto, Spotify.Domain.Album.Banda>();

            CreateMap<Spotify.Domain.Album.Banda, BandaOutputDto>();

            CreateMap<Spotify.Domain.Album.Banda, BandaOutputDto>();

            CreateMap<MusicaInputCreateDto, Spotify.Domain.Album.Musica>()
                .ForPath(x => x.Duracao.Valor, f => f.MapFrom(m => m.Duracao)); 

            CreateMap<MusicaInputUpdateDto, Spotify.Domain.Album.Musica>()
                .ForPath(x => x.Duracao.Valor, f => f.MapFrom(m => m.Duracao));

            CreateMap<MusicaInputDeleteDto, Spotify.Domain.Album.Musica>();

            CreateMap<Spotify.Domain.Album.Musica, MusicaOutputDto>()
                .ForMember(x => x.Duracao, f => f.MapFrom(m => m.Duracao.ValorFormatado()));   

            

        }

    }
}
