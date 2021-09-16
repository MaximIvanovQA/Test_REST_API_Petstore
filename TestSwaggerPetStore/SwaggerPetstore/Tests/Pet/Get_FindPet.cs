using Test_Framework.BaseTest;
using NUnit.Framework;

namespace TestSwaggerPetStore.SwaggerPetstore.Tests.Pet
{
    [TestFixture]
    class Get_FindPet : SwaggerPetstoreBaseTest
    {
        [Test]
        public void NegativeSmoke()
        {
            var id = 37162363;

            FindPet(id);

            Assert.IsNotNull(GetTest.SwaggerPetstore.FindPetResponse.id);
           
        }
    }
}
