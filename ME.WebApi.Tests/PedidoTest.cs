using NUnit.Framework;

namespace ME.WebApi.Tests
{
    public class PedidoTest
    {
        private dynamic _factory;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SalvarNovoPedidoPadrao()
        {
            dynamic _formContent = "";

            var client = _factory.CreateClient();
            var url = "api/paths";

            var response =  client.PostAsync(url, _formContent);

            // Assert
            response.EnsureSuccesStatusCode();

            Assert.Pass();
        }


        [Test]
        public void SalvarNovoPedidoSemItem()
        {
            dynamic _formContent = "";

            var client = _factory.CreateClient();
            var url = "api/paths";

            var response = client.PostAsync(url, _formContent);

            // Assert
            response.EnsureErrorStatusCode();

            Assert.Pass();
        }

    }
}