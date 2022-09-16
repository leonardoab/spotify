using Spotify.Application.Account.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Application.Account.Profile
{
    public class AccountProfile : AutoMapper.Profile
    {
        public AccountProfile()
        {
            CreateMap<UsuarioInputCreateDto, Spotify.Domain.Account.Usuario>()
               .ForPath(x => x.Password.Valor, f => f.MapFrom(m => m.Password))
               .ForPath(x => x.Email.Valor, f => f.MapFrom(m => m.Email));

            CreateMap<UsuarioInputUpdateDto, Spotify.Domain.Account.Usuario>()
                .ForPath(x => x.Password.Valor, f => f.MapFrom(m => m.Password))
                .ForPath(x => x.Email.Valor, f => f.MapFrom(m => m.Email));

            CreateMap<UsuarioInputDeleteDto, Spotify.Domain.Account.Usuario>();

            CreateMap<Spotify.Domain.Account.Usuario, UsuarioOutputDto>()
                .ForPath(x => x.Password, f => f.MapFrom(m => m.Password.Valor))
                .ForPath(x => x.Email, f => f.MapFrom(m => m.Email.Valor));

            CreateMap<UsuarioInputAutenticacaoDto, Spotify.Domain.Account.Usuario>()
                .ForPath(x => x.Password.Valor, f => f.MapFrom(m => m.Password))
                .ForPath(x => x.Email.Valor, f => f.MapFrom(m => m.Email));



            CreateMap<PlaylistInputCreateDto, Spotify.Domain.Account.Playlist>();

            CreateMap<PlaylistInputCreateSemMusicasDto, Spotify.Domain.Account.Playlist>();

            CreateMap<PlaylistInputUpdateSemMusicaDto, Spotify.Domain.Account.Playlist>();

            




            CreateMap<PlaylistInputUpdateDto, Spotify.Domain.Account.Playlist>();
               
            CreateMap<PlaylistInputDeleteDto, Spotify.Domain.Account.Playlist>();

            CreateMap<Spotify.Domain.Account.Playlist, PlaylistOutputDto>();
              
        }
    }
}
