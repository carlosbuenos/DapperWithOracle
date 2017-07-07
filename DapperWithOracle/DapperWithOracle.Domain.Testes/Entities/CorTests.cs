using DapperWithOracle.Domain.Entities;
using System;
using Xunit;

namespace DapperWithOracle.Domain.Testes.Entities
{
    public class CorTests
    {
        // testar cor com dados válidos
        [Fact]
        public void CorTests_ValidarDados_DadosValidos()
        {
            // Arrange
            var cor = new Cor();
            cor.Descricao = "azul";
            cor.Usuario = "victor";
            var dt = cor.DataAlteracao = DateTime.Now;

            // Act
            var isValid = cor.IsValid();

            // Assert
            Assert.NotNull(cor);
            Assert.True(isValid);
            Assert.True(!string.IsNullOrEmpty(cor.Descricao.Trim()));
            Assert.True(!string.IsNullOrEmpty(cor.Usuario.Trim()));
            Assert.Equal(dt, cor.DataAlteracao);
        }

        // testar cor com dados inválidos
        [Fact]
        public void CorTests_ValidarDados_DadosInvalidos()
        {
            // Arrange
            var cor = new Cor();
            cor.Descricao = " ";
            cor.Usuario = "";
            var dt = new DateTime(2017, 03, 15);
            cor.DataAlteracao = DateTime.Now;

            // Act
            var isValid = cor.IsValid();

            // Assert
            Assert.NotNull(cor);
            Assert.True(!isValid);
            Assert.True(string.IsNullOrEmpty(cor.Descricao.Trim()));
            Assert.True(string.IsNullOrEmpty(cor.Usuario.Trim()));
            Assert.NotEqual(dt, cor.DataAlteracao);
        }

        // testar validação disparando uma NullReferenceException
        [Fact]
        public void CorTests_ValidarDados_DispararNullReferenceException()
        {
            // Arrange
            var cor = new Cor();

            // Act & Assert
            var ex = Assert.Throws<NullReferenceException>(() => cor.IsValid());
            Assert.NotNull(ex);
            Assert.Null(cor.Descricao);
        }
    }
}