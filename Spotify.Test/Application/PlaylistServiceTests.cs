using AutoMapper;
using Moq;
using Spotify.Application.Account.Dto;
using Spotify.Application.Account.Service;
using Spotify.Domain.Account;
using Spotify.Domain.Account.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Test.Application
{
    public class PlaylistServiceTests
    {
        [Fact]
        public async Task DeveCriarPlaylistComSucesso()
        {
            PlaylistInputCreateDto dtoInput = new PlaylistInputCreateDto("XTPO");
            PlaylistOutputDto dtoOutput = new PlaylistOutputDto(Guid.NewGuid(), "XTPO");


            Mock<IPlaylistRepository> mockRepository = new Mock<IPlaylistRepository>();
            Mock<IMapper> mockMapper = new Mock<IMapper>();

            Playlist playlist = new Playlist()
            {                
                Nome = "Xpto"
            };

            mockMapper.Setup(x => x.Map<Playlist>(dtoInput)).Returns(playlist);
            mockMapper.Setup(x => x.Map<PlaylistOutputDto>(playlist)).Returns(dtoOutput);

            mockRepository.Setup(x => x.Save(It.IsAny<Playlist>())).Returns(Task.FromResult(playlist));

            var service = new PlaylistService(mockRepository.Object, mockMapper.Object);
            var result = await service.Criar(dtoInput);

            Assert.NotNull(result);


        }

        [Fact]
        public async Task DeveExcluirPlaylistComSucesso()
        {
            PlaylistInputDeleteDto dtoInput = new PlaylistInputDeleteDto(Guid.NewGuid());
            PlaylistOutputDto dtoOutput = new PlaylistOutputDto(Guid.NewGuid(), "XTPO");


            Mock<IPlaylistRepository> mockRepository = new Mock<IPlaylistRepository>();
            Mock<IMapper> mockMapper = new Mock<IMapper>();

            Playlist playlist = new Playlist()
            {               
                Nome = "Xpto"
            };

            mockMapper.Setup(x => x.Map<Playlist>(dtoInput)).Returns(playlist);
            mockMapper.Setup(x => x.Map<PlaylistOutputDto>(playlist)).Returns(dtoOutput);

            mockRepository.Setup(x => x.Delete(It.IsAny<Playlist>())).Returns(Task.FromResult(playlist));

            var service = new PlaylistService(mockRepository.Object, mockMapper.Object);
            var result = await service.Deletar(dtoInput);

            Assert.NotNull(result);


        }

        [Fact]
        public async Task DeveAtualizarPlaylistComSucesso()
        {
            PlaylistInputUpdateDto dtoInput = new PlaylistInputUpdateDto(Guid.NewGuid(), "XTPO");
            PlaylistOutputDto dtoOutput = new PlaylistOutputDto(Guid.NewGuid(), "XTPO");


            Mock<IPlaylistRepository> mockRepository = new Mock<IPlaylistRepository>();
            Mock<IMapper> mockMapper = new Mock<IMapper>();

            Playlist playlist = new Playlist()
            {              
                Nome = "Xpto"
            };

            mockMapper.Setup(x => x.Map<Playlist>(dtoInput)).Returns(playlist);
            mockMapper.Setup(x => x.Map<PlaylistOutputDto>(playlist)).Returns(dtoOutput);

            mockRepository.Setup(x => x.Update(It.IsAny<Playlist>())).Returns(Task.FromResult(playlist));

            var service = new PlaylistService(mockRepository.Object, mockMapper.Object);
            var result = await service.Atualizar(dtoInput);

            Assert.NotNull(result);


        }
    }
}
