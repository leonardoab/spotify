using AutoMapper;
using Moq;
using Spotify.Application.Album.Dto;
using Spotify.Application.Album.Service;
using Spotify.Domain.Album;
using Spotify.Domain.Album.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Test.Application
{
    public class BandaServiceTests
    {
        

        [Fact]
        public async Task DeveCriarBandaComSucesso()
        {
            BandaInputCreateDto dtoInput = new BandaInputCreateDto("XTPO", "https://xpto.com/foto.png", "Lorem ipsum da banda");
            BandaOutputDto dtoOutput = new BandaOutputDto(Guid.NewGuid(), "XTPO", "https://xpto.com/foto.png", "Lorem ipsum da banda");   
            

            Mock<IBandaRepository> mockRepository = new Mock<IBandaRepository>();
            Mock<IMapper> mockMapper = new Mock<IMapper>();

            Banda banda = new Banda()
            {
                Descricao = "Lorem Ipsom",
                Foto = "lorem ipsum",
                Nome = "Xpto"
            };

            mockMapper.Setup(x => x.Map<Banda>(dtoInput)).Returns(banda);
            mockMapper.Setup(x => x.Map<BandaOutputDto>(banda)).Returns(dtoOutput);

            mockRepository.Setup(x => x.Save(It.IsAny<Banda>())).Returns(Task.FromResult(banda));

            var service = new BandaService(mockRepository.Object, mockMapper.Object);
            var result = await service.Criar(dtoInput);

            Assert.NotNull(result);


        }

        [Fact]
        public async Task DeveExcluirBandaComSucesso()
        {
            BandaInputDeleteDto dtoInput = new BandaInputDeleteDto(Guid.NewGuid());
            BandaOutputDto dtoOutput = new BandaOutputDto(Guid.NewGuid(), "XTPO", "https://xpto.com/foto.png", "Lorem ipsum da banda");


            Mock<IBandaRepository> mockRepository = new Mock<IBandaRepository>();
            Mock<IMapper> mockMapper = new Mock<IMapper>();

            Banda banda = new Banda()
            {
                Descricao = "Lorem Ipsom",
                Foto = "lorem ipsum",
                Nome = "Xpto"
            };

            mockMapper.Setup(x => x.Map<Banda>(dtoInput)).Returns(banda);
            mockMapper.Setup(x => x.Map<BandaOutputDto>(banda)).Returns(dtoOutput);

            mockRepository.Setup(x => x.Save(It.IsAny<Banda>())).Returns(Task.FromResult(banda));

            var service = new BandaService(mockRepository.Object, mockMapper.Object);
            var result = await service.Deletar(dtoInput);

            Assert.NotNull(result);


        }

        [Fact]
        public async Task DeveAtualizarBandaComSucesso()
        {
            BandaInputUpdateDto dtoInput = new BandaInputUpdateDto(Guid.NewGuid(), "XTPO", "https://xpto.com/foto.png", "Lorem ipsum da banda");
            BandaOutputDto dtoOutput = new BandaOutputDto(Guid.NewGuid(), "XTPO", "https://xpto.com/foto.png", "Lorem ipsum da banda");


            Mock<IBandaRepository> mockRepository = new Mock<IBandaRepository>();
            Mock<IMapper> mockMapper = new Mock<IMapper>();

            Banda banda = new Banda()
            {
                Descricao = "Lorem Ipsom",
                Foto = "lorem ipsum",
                Nome = "Xpto"
            };

            mockMapper.Setup(x => x.Map<Banda>(dtoInput)).Returns(banda);
            mockMapper.Setup(x => x.Map<BandaOutputDto>(banda)).Returns(dtoOutput);

            mockRepository.Setup(x => x.Save(It.IsAny<Banda>())).Returns(Task.FromResult(banda));

            var service = new BandaService(mockRepository.Object, mockMapper.Object);
            var result = await service.Atualizar(dtoInput);

            Assert.NotNull(result);


        }

        [Fact]
        public async Task DeveBuscarTodosComSucesso()
        {
            Mock<IBandaRepository> mockRepository = new Mock<IBandaRepository>();
            Mock<IMapper> mockMapper = new Mock<IMapper>();

            Banda banda = new Banda()
            {
                Descricao = "Lorem Ipsom",
                Foto = "lorem ipsum",
                Nome = "Xpto"
            };

            mockMapper.Setup(x => x.Map<Banda>(dtoInput)).Returns(banda);
            mockMapper.Setup(x => x.Map<BandaOutputDto>(banda)).Returns(dtoOutput);

            mockRepository.Setup(x => x.Save(It.IsAny<Banda>())).Returns(Task.FromResult(banda));

            var service = new BandaService(mockRepository.Object, mockMapper.Object);
            var result = await service.Atualizar(dtoInput);

            Assert.NotNull(result);


        }

    }
}
