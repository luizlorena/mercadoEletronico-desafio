using NUnit.Framework;

namespace ME.WebApi.Tests
{
    public class StatusPedidoTest
    {
        private const string url = "api/status";
        private dynamic _factory;

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void MudarStatus_PedidoPadrao()
        {
            dynamic _formContent = "";

            var client = _factory.CreateClient();
            

            var response =  client.PostAsync(url, _formContent);

            // Assert
            response.EnsureSuccesStatusCode();

            Assert.Pass();
        }


        [Test]
        public void MudarStatus_PedidoInexistente()
        {
            dynamic _formContent = "";

            var client = _factory.CreateClient();

            var response = client.PostAsync(url, _formContent);

            // Assert
            response.EnsureErrorStatusCode();

            Assert.Pass();
        }

    }
}