using DapperWithOracle.Infra.Context;
using Xunit;

namespace DapperWithOracle.Infra.Testes.Context
{
    public class OracleContextTestes
    {
        // testar conexão válida com o oracle
        [Fact]
        public void OracleContext_TestarConexao_ConexaoOk()
        {
            // Arrange & Act
            var conn = OracleContext.GetConnection();

            // Assert
            Assert.NotNull(conn);
        }
    }
}