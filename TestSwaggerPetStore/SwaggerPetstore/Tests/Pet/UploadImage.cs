using Test_Framework.BaseTest;
using NUnit.Framework;

namespace Test_Petstore.SwaggerPetstore.Tests.Pet
{
    [TestFixture]
    class UploadImage : SwaggerPetstoreBaseTest
    {
        [Test]
        public void NegativeSmoke()
        {
            var id = 12;
            var additionalMetadata = "1255";

            UploadImage(id, additionalMetadata);

            Assert.IsTrue(GetTest.SwaggerPetstore.UploadImageResponse.code == "405");
            Assert.IsTrue(GetTest.SwaggerPetstore.UploadImageResponse.type == "unknown");
        }
    }
}
