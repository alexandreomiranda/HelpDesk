using System;
using Xunit;
using Bogus;
using HelpDesk.Domain.Chamados;

namespace HelpDesk.Domain.Tests
{
    public class ChamadoTest
    {
        [Fact]
        public void CriarChamadoValido()
        {
            //Arrange
            var faker = new Faker<Chamado>()
             .CustomInstantiator(f => 
             Chamado.Factory.NovoChamado(
                 f.Lorem.Paragraph(1), 
                 new Usuario(), new Assunto(), 
                 new Pessoa()
                 ));


            var chamado = faker.Generate();

            //Act      
            var chamadoValido =  chamado.IsValid();

            //Assert
            Assert.True(chamadoValido);
        }
    }
}
