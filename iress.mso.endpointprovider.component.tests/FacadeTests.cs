using iress.mso.endpointprovider.components;
using NUnit.Framework;

namespace iress.mso.endpointprovider.component.tests
{
    [TestFixture]
    public class Tests
    {
        private readonly IEndPointProviderFacade _facade;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CanRetrieveAnEndpointFromARepository()
        {
            var result = _facade.GetEndPointAsync("Account-Servicing");

            Assert.Pass();
        }
    }
}