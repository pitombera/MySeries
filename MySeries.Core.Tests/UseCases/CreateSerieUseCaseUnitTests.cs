using System.Threading.Tasks;
using Moq;
using MySeries.Core.Dto.GatewayResponses.Repositories;
using MySeries.Core.Dto.UseCaseRequests;
using MySeries.Core.Entities;
using MySeries.Core.Interfaces;
using MySeries.Core.Interfaces.Repositories;
using MySeries.Core.UseCases;
using Xunit;

namespace MySeries.Core.Tests.UseCases
{
    public class CreateSerieUseCaseUnitTests
    {
        [Fact]
        public async void Can_Create_Serie()
        {
            // arrange

            // 1. We need to store the user data somehow
            var mockUserRepository = new Mock<ISerieRepository>();
            mockUserRepository
                .Setup(repo => repo.Create(It.IsAny<Serie>()))
                .Returns(Task.FromResult(new CreateSerieResponse(1, true)));

            // 2. The use case and star of this test
            var useCase = new CreateSerieUseCase(mockUserRepository.Object);

            // 3. The output port is the mechanism to pass response data from the use case to a Presenter 
            // for final preparation to deliver back to the UI/web page/api response etc.
            var mockOutputPort = new Mock<IOutputPort<CreateSerieResponse>>();
            mockOutputPort.Setup(outputPort => outputPort.Handle(It.IsAny<CreateSerieResponse>()));

            // act

            // 4. We need a request model to carry data into the use case from the upper layer (UI, Controller etc.)
            var response = await useCase.Handle(new CreateSerieRequest("See", "See, série original da Apple TV+ estrelada por Jason Mamoa, acompanha um mundo distópico onde mais da metade da população mundial foi exterminada por um vírus e os poucos sobreviventes perderam completamente a visão. Séculos depois, a perda do sentido foi passada de forma hereditária e a raça humana teve de encontrar novos modos de sobrevivência e interação para resconstruir a sociedade. Mas toda a estrutura desse novo mundo passa a ser desafiada quando um par de gêmeos nasce capaz de enxergar.", 2019), mockOutputPort.Object);

            // assert
            Assert.True(response);
        }
    }
}