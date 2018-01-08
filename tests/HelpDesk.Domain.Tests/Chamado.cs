using System;
using Xunit;
using Bogus;
using HelpDesk.Domain.Chamados;

namespace HelpDesk.Domain.Tests
{
    public class ChamadoTest
    {

        private static Chamado CriarChamado()
        {
            var faker = new Faker<Chamado>()
             .CustomInstantiator(f =>
             Chamado.Factory.NovoChamado(
                 f.Lorem.Paragraph(1),
                 new Usuario(), new Assunto(),
                 new Pessoa()
                 ));


            var chamado = faker.Generate();
            return chamado;
        }

        [Fact]
        public void CriarChamadoValido()
        {
            //Arrange
            Chamado chamado = CriarChamado();

            //Act      
            var chamadoValido = chamado.IsValid();

            //Assert
            Assert.True(chamadoValido);
        }

     
        [Fact]
        public void ConcluirChamado()
        {

            //arrange...
            Chamado chamado = CriarChamado();




            
        }
    }
}
