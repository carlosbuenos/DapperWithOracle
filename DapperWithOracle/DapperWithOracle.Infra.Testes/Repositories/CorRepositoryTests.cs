using DapperWithOracle.Infra.Repositories;
using Xunit;

namespace DapperWithOracle.Infra.Testes.Repositories
{
    public class CorRepositoryTests
    {
        // testar consulta válida de todas as cores
        [Fact]
        public void CorRepositoryTests_BuscarTudo_RetornoValido()
        {
            // Arrange
            var rep = new CorRepository();

            // Act
            var list = rep.BuscarTudo();
            
            // Assert
            Assert.NotNull(list);
            Assert.True(list.Count > 0);
        }
    }
}