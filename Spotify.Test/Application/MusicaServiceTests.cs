using AutoMapper;
using Moq;
using Spotify.Application.Album.Dto;
using Spotify.Application.Musica.Service;
using Spotify.Domain.Album;
using Spotify.Domain.Album.Repository;
using Spotify.Domain.Album.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Test.Application
{
    public class MusicaServiceTests
    {

        [Fact]
        public async Task DeveCriarMusicaComSucesso()
        {
            MusicaInputCreateDto dtoInput = new MusicaInputCreateDto("XTPO", 300);
            MusicaOutputDto dtoOutput = new MusicaOutputDto(Guid.NewGuid(), "XTPO", "00:00:00");


            Mock<IMusicaRepository> mockRepository = new Mock<IMusicaRepository>();
            Mock<IMapper> mockMapper = new Mock<IMapper>();

            Musica musica = new Musica()
            {
              
                Nome = "Xpto",
                Duracao = new Duracao(200)
            };

            mockMapper.Setup(x => x.Map<Musica>(dtoInput)).Returns(musica);
            mockMapper.Setup(x => x.Map<MusicaOutputDto>(musica)).Returns(dtoOutput);

            mockRepository.Setup(x => x.Save(It.IsAny<Musica>())).Returns(Task.FromResult(musica));

            var service = new MusicaService(mockRepository.Object, mockMapper.Object);
            var result = await service.Criar(dtoInput);

            Assert.NotNull(result);


        }

        [Fact]
        public async Task DeveExcluirMusicaComSucesso()
        {
            MusicaInputDeleteDto dtoInput = new MusicaInputDeleteDto(Guid.NewGuid());
            MusicaOutputDto dtoOutput = new MusicaOutputDto(Guid.NewGuid(), "XTPO", "00:00:00");


            Mock<IMusicaRepository> mockRepository = new Mock<IMusicaRepository>();
            Mock<IMapper> mockMapper = new Mock<IMapper>();


            Musica musica = new Musica()
            {

                Nome = "Xpto",
                Duracao = new Duracao(200)
            };

            mockMapper.Setup(x => x.Map<Musica>(dtoInput)).Returns(musica);
            mockMapper.Setup(x => x.Map<MusicaOutputDto>(musica)).Returns(dtoOutput);

            mockRepository.Setup(x => x.Delete(It.IsAny<Musica>())).Returns(Task.FromResult(musica));

            var service = new MusicaService(mockRepository.Object, mockMapper.Object);
            var result = await service.Deletar(dtoInput);

            Assert.NotNull(result);


        }

        [Fact]
        public async Task DeveAtualizarMusicaComSucesso()
        {
            MusicaInputUpdateDto dtoInput = new MusicaInputUpdateDto(Guid.NewGuid(), "XTPO", 300);
            MusicaOutputDto dtoOutput = new MusicaOutputDto(Guid.NewGuid(), "XTPO", "00:00:00");


            Mock<IMusicaRepository> mockRepository = new Mock<IMusicaRepository>();
            Mock<IMapper> mockMapper = new Mock<IMapper>();

            Musica musica = new Musica()
            {

                Nome = "Xpto",
                Duracao = new Duracao(200)
            };

            mockMapper.Setup(x => x.Map<Musica>(dtoInput)).Returns(musica);
            mockMapper.Setup(x => x.Map<MusicaOutputDto>(musica)).Returns(dtoOutput);

            mockRepository.Setup(x => x.Update(It.IsAny<Musica>())).Returns(Task.FromResult(musica));

            var service = new MusicaService(mockRepository.Object, mockMapper.Object);
            var result = await service.Atualizar(dtoInput);

            Assert.NotNull(result);


        }
    }
}
